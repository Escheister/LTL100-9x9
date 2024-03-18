using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.IO.Ports;
using System.Drawing;
using System.Linq;
using System;

using MBus;

namespace LTL100_9x9
{
    public partial class mainForm : Form
    {
        private Socket mbTcp;
        public ModBusClass mbClass { get; set; } = null;
        private Button[,] ltl9x9;
        private Dictionary<int, int> getBit = new Dictionary<int, int>()
        {
            [0] = 0b0000_0000_0001,
            [1] = 0b0000_0000_0010,
            [2] = 0b0000_0000_0100,
            [3] = 0b0000_0000_1000,
            [4] = 0b0000_0001_0000,
            [5] = 0b0000_0010_0000,
            [6] = 0b0000_0100_0000,
            [7] = 0b0000_1000_0000,
            [8] = 0b0001_0000_0000,
        };
        SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);

        public mainForm()
        {
            InitializeComponent();
            this.Text += $" ver{Assembly.GetEntryAssembly().GetName().Version}";
            AddEvents();
        }
        private void AddEvents()
        {
            Load += FormLoad;
            comPort.SelectedIndexChanged += (s, e) => mbRtu.PortName = comPort.SelectedItem.ToString();
            BaudRate.SelectedIndexChanged += (s, e) => BaudRateSelectedIndexChanged();
            RefreshSerial.Click += (s, e) => AddPorts(comPort);
            foreach (ToolStripDropDownItem item in dataBits.DropDownItems) item.Click += DataBitsForSerial;
            foreach (ToolStripDropDownItem item in Parity.DropDownItems) item.Click += ParityForSerial;
            foreach (ToolStripDropDownItem item in stopBits.DropDownItems) item.Click += StopBitsForSerial;
            OpenCom.Click += OpenComClick;
            Connect.Click += ConnectClick;
            manualReadButton.Click += async (s, e) => await Task.Run(() => StartReading());
            RegistersGrid.CellEndEdit += async (s, e) => await Task.Run(() => CellSetRegisterValue(s, e));
            UploadImageButton.Click += async (s, e) => await Task.Run(() => UploadImage());
            checkBlink.CheckedChanged += (s, e) => numericBlinkTimer.Enabled = checkBlink.Checked;
            checkRefreshPic.CheckedChanged += (s, e) =>
                groupBlink.Enabled = 
                groupColor.Enabled = 
                groupTools.Enabled = 
                UploadImageButton.Enabled = !checkRefreshPic.Checked;
            comboMode.SelectedItem = comboMode.Items[0];
            comboIndex.SelectedItem = comboMode.Items[0];
            comboIndex.DropDownClosed += async (s, e) => await Task.Run(() => SendSingleCommand(s, REnum.Image, labelIndex));
            comboMode.DropDownClosed += async (s, e) => await Task.Run(() => SendSingleCommand(s, REnum.CmdReg, labelMode));
        }
        private void FormLoad(object sender, EventArgs e)
        {
            ComDefault();
            AddPorts(comPort);
            FillGrid();
            CreateButtonArray();
        }
        private void ComDefault()
        {
            mbRtu.WriteTimeout =
            mbRtu.ReadTimeout = 500;
            BaudRate.SelectedItem = "38400";
            DataBitsForSerial(dataBits8, null);
            ParityForSerial(ParityNone, null);
            StopBitsForSerial(stopBits1, null);
            BaudRateSelectedIndexChanged();
        }
        private void AddPorts(ComboBox box)
        {
            box.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                box.Items.AddRange(ports);
                box.SelectedItem = box.Items[0];
            }
            OpenCom.Enabled = ports.Length > 0;
        }
        private void DataBitsForSerial(object sender, EventArgs e)
        {
            ToolStripMenuItem databits = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in dataBits.DropDownItems) item.CheckState = CheckState.Unchecked;
            mbRtu.DataBits = Convert.ToInt32(databits.Text);
            databits.CheckState = CheckState.Checked;
            dataBitsInfo.Text = mbRtu.DataBits.ToString();
        }
        private void ParityForSerial(object sender, EventArgs e)
        {
            ToolStripMenuItem parity = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in Parity.DropDownItems) item.CheckState = CheckState.Unchecked;
            switch (parity.Text)
            {
                case "None":
                    mbRtu.Parity = System.IO.Ports.Parity.None;
                    break;
                case "Odd":
                    mbRtu.Parity = System.IO.Ports.Parity.Odd;
                    break;
                case "Even":
                    mbRtu.Parity = System.IO.Ports.Parity.Even;
                    break;
                case "Mark":
                    mbRtu.Parity = System.IO.Ports.Parity.Mark;
                    break;
                case "Space":
                    mbRtu.Parity = System.IO.Ports.Parity.Space;
                    break;
            }
            parity.CheckState = CheckState.Checked;
            ParityInfo.Text = mbRtu.Parity.ToString();
        }
        private void StopBitsForSerial(object sender, EventArgs e)
        {
            ToolStripMenuItem stopbits = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in stopBits.DropDownItems) item.CheckState = CheckState.Unchecked;
            Enum.TryParse(Enum.GetName(typeof(StopBits), Convert.ToInt32(stopbits.Text)), out StopBits bits);
            mbRtu.StopBits = bits;
            stopbits.CheckState = CheckState.Checked;
            StopBitsInfo.Text = stopbits.Text;
        }
        private void BaudRateSelectedIndexChanged()
            => mbRtu.BaudRate = Convert.ToInt32(BaudRate.SelectedItem);
        private void ToInfoStatus(string msg) => BeginInvoke((MethodInvoker)(() => InfoStatus.Text = msg));
        private void AfterComEvent(bool sw)
        {
            comPort.Enabled = 
                RefreshSerial.Enabled = 
                TcpPage.Enabled = !sw;
            mbClass = sw ? new ModBusClass(mbRtu) : null;
        }
        private void AfterTcpEvent(bool sw)
        {
            RtuPage.Enabled = 
                IPaddressBox.Enabled = 
                numericPort.Enabled = !sw;
            mbClass = sw ? new ModBusClass(mbTcp) : null;
        }
        private void AfterAnyInterfaceEvent(bool sw)
            => LTLControlPage.Enabled = 
                SettingsPanel.Enabled = sw;
        private void AfterStartReading(bool sw)
            => manualReadButton.Enabled =
                        OpenCom.Enabled =
                        Connect.Enabled =
                       BaudRate.Enabled =
                toolStripSerial.Enabled = !sw;
        private void OpenComClick(object sender, EventArgs e)
        {
            if (OpenCom.Text == "Open")
            {
                try
                {
                    mbRtu.Open();
                    OpenCom.Text = "Close";
                }
                catch (Exception ex) { ToInfoStatus(ex.Message); }
            }
            else
            {
                mbRtu.Close();
                OpenCom.Text = "Open";
            }
            AfterComEvent(mbRtu.IsOpen);
            AfterAnyInterfaceEvent(mbRtu.IsOpen);
        }
        //* Не тестировалось
        private void ConnectClick(object sender, EventArgs e)
        {
            try
            {
                if (Connect.Text == "Connect")
                {
                    mbTcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    this.Enabled = false;
                    Connect.Text = "Connecting...";
                    if (!mbTcp.ConnectAsync(IPaddressBox.Text, Convert.ToUInt16(numericPort.Value)).Wait(1500))
                        throw new SocketException(10060);
                    this.Enabled = true;
                    Connect.Text = "Close";
                }
                else
                {
                    if (!this.Enabled) this.Enabled = true;
                    mbTcp.Shutdown(SocketShutdown.Both);
                    Connect.Text = "Connect";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (!this.Enabled) this.Enabled = true;
                try { mbTcp.Shutdown(SocketShutdown.Both); } catch { }
                Connect.Text = "Connect";
            }
            AfterTcpEvent(mbTcp.Connected);
            AfterAnyInterfaceEvent(mbTcp.Connected);
        }
        //* Не тестировалось

        //*Just mothods
        private void ButtonColorChange(Button btn)
            => BeginInvoke((MethodInvoker)(() => {
                btn.BackColor = ColorTranslator.FromHtml($"#" +
                $"{(checkRed.Checked ? "FF" : "00")}" +
                $"{(checkGreen.Checked ? "FF" : "00")}" +
                $"{(checkBlue.Checked ? "FF" : "00")}");
            }));
        private void FillGrid() => BeginInvoke((MethodInvoker)(() => {
            RegistersGrid.Rows.Clear();
            string[] readOnly = { "ReadImage", "DI", "TTL", "Version" };
            foreach (string enumName in Enum.GetNames(typeof(REnum)))
            {
                Enum.TryParse(enumName, out REnum index);
                byte size = index == REnum.TTL ? (byte)4 : (byte)2;
                RegistersGrid.Rows[RegistersGrid.Rows.Add((int)index, enumName, size)]
                    .Cells[(int)CEnum.WriteAO].ReadOnly = readOnly.Contains(enumName);
            }
        }));
        private void SetCellValue(int column, int row, int value, byte[] valueHex)
            => BeginInvoke((MethodInvoker)(() => {
                RegistersGrid[column, row].Value = value;
                RegistersGrid[column, row].ToolTipText = BitConverter.ToString(valueHex).Replace("-", "");
            }));
        private ushort GetCellValue(int column, int row)
        {
            if (RegistersGrid[column, row].Value is null) return 0;
            ushort value = ushort.TryParse(RegistersGrid[column, row].Value.ToString(), out value) ? value : (ushort)0;
            return value;
        }
        private void CreateButtonArray()
        {
            ltl9x9 = new Button[9, 9];
            for (int y = 0; y < ltl9x9.GetLength(1); y++)
                for (int x = 0; x < ltl9x9.GetLength(0); x++)
                {
                    if ((x == 0 && y == 0) ||
                        (x == 8 && y == 8) ||
                        (x == 0 && y == 8) ||
                        (x == 8 && y == 0)) { ltl9x9[x, y] = null; continue; }
                    ltl9x9[x, y] = new Button
                    {
                        Width = 19,
                        Height = 19,
                        Location = new Point(x * 20 + 1, y * 20 + 1),
                        Parent = LEDPanel,
                        Tag = y,
                        BackColor = Color.Black,
                        FlatStyle = FlatStyle.Flat,
                    };
                    ltl9x9ToolTip.SetToolTip(ltl9x9[x, y], ltl9x9[x, y].Tag.ToString());
                    ltl9x9[x, y].Click += SetButtonColor;
                }
        }
        private ushort[,] GetMatrixValues()
        {
            ushort[,] rgbArray = new ushort[3, 9];
            //0 - r, 1 - g, 2 - b
            for (int i = 0; i < rgbArray.GetLength(0); i++)
            {
                for (int x = ltl9x9.GetLength(0) - 1; x >= 0; x--)
                {
                    int count = 0;
                    for (int y = ltl9x9.GetLength(1) - 1; y >= 0; y--)
                    {
                        if (ltl9x9[x, y] is null) continue;
                        else if (i == 0 && ltl9x9[x, y].BackColor.R == 0xff)
                            count += getBit[Convert.ToByte(ltl9x9[x, y].Tag)];
                        else if (i == 1 && ltl9x9[x, y].BackColor.G == 0xff)
                            count += getBit[Convert.ToByte(ltl9x9[x, y].Tag)];
                        else if (i == 2 && ltl9x9[x, y].BackColor.B == 0xff)
                            count += getBit[Convert.ToByte(ltl9x9[x, y].Tag)];
                    }
                    rgbArray[i, x] = (ushort)count;
                }
            }
            return rgbArray;
        }
        private ushort GetBlinkTout()
        {
            ushort value = (ushort)numericBlinkTimer.Value;
            return (ushort)((value & getBit[0]) == 0 ? value + getBit[0] : value);
        }
        private void SetButtonColor(object sender, EventArgs e)
        {
            if (!checkFill.Checked) { ButtonColorChange((Button)sender); return; }
            else
                for (int x = 0; x < ltl9x9.GetLength(0); x++)
                    for (int y = 0; y < ltl9x9.GetLength(1); y++)
                        if (ltl9x9[x, y] != null) ButtonColorChange(ltl9x9[x, y]);
        }
        private void SetInfoFromRegs() => BeginInvoke((MethodInvoker)(() => {
            labelMode.Text = RegistersGrid[(int)CEnum.ReadAO, (int)REnum.CmdReg].Value.ToString();
            comboIndex.Enabled = labelMode.Text == "0";
            labelIndex.Text = labelMode.Text == "3"
            ? RegistersGrid[(int)CEnum.ReadAO, (int)REnum.DI].Value.ToString()
            : RegistersGrid[(int)CEnum.ReadAO, (int)REnum.ReadImage].Value.ToString();
            VersionLabel.Text = $"Ver: {RegistersGrid[3, 5].Value}";
            TimeSpan time = TimeSpan.FromSeconds(Convert.ToInt32(RegistersGrid[3, 4].Value));
            WorkTimeLabel.Text = $"TTL: ({time.Days}) " +
                                    $"{time.Hours}" +
                                    $":{time.Minutes}" +
                                    $":{time.Seconds}";
        }));
        private void SetDiscretInput() => BeginInvoke((MethodInvoker)(() => {
            if (byte.TryParse(RegistersGrid[(int)CEnum.ReadAO, (int)REnum.DI].Value.ToString(), out byte DI)) {
                DI_0.BackColor = (DI & 0b0001) != 0 ? Color.LightGreen : Color.White;
                DI_1.BackColor = (DI & 0b0010) != 0 ? Color.LightGreen : Color.White;
                DI_2.BackColor = (DI & 0b0100) != 0 ? Color.LightGreen : Color.White;
                DI_3.BackColor = (DI & 0b1000) != 0 ? Color.LightGreen : Color.White;
            }
        }));
        async private Task<Reply> WriteRegister(REnum register, ushort value)
        {
            byte[] cmdOut = mbClass.FormatModBusCMD((byte)ID.Value, WriteMB.WriteAO, (ushort)register, value);

            Tuple<byte[], Reply> reply = mbClass.Handler(cmdOut);
            ToInfoStatus($"Отправлено на ID: {ID.Value} : {reply.Item2}");
            if (reply.Item2 == Reply.Ok)
            {
                if (register == REnum.CmdReg && value == 8107) FillGrid();
                await Task.Delay(50);
            }
            return reply.Item2;
        }
        async private Task<Reply> MWriteRegisters(REnum startRegister, ushort[] values)
        {
            byte[] cmdOut = mbClass.FormatMultiplyAO((byte)ID.Value, (ushort)startRegister, (ushort)values.Length, values);
            Tuple<byte[], Reply> reply = mbClass.Handler(cmdOut);
            ToInfoStatus($"Отправлено на ID: {ID.Value} : {reply.Item2}");
            await Task.Delay(50);
            return reply.Item2;
        }
        private void DownloadImage()
        {
            /* x = 9 => 0|1|2|3|4|5|6|7|8
             * y = 3 => 0:red | 1:green | 2:blue*/
            int[,] colors = new int[3, 9];
            for (int y = 0, i = (int)REnum.led_ctrl_r_0; y < colors.GetLength(0); y++)
                for (int x = 0; x < colors.GetLength(1); x++, i++)
                    colors[y, x] = Convert.ToUInt16(RegistersGrid[(int)CEnum.ReadAO, i - 1].Value);

            for (int x = 0; x < colors.GetLength(1); x++)
                for (int y = 0; y < ltl9x9.GetLength(0); y++)
                    if (ltl9x9[x, y] != null)  ChangeColorButtons(x, y, $"#" +
                                                                        $"{((colors[0, x] & getBit[y]) != 0 ? "FF" : "00")}" +
                                                                        $"{((colors[1, x] & getBit[y]) != 0 ? "FF" : "00")}" +
                                                                        $"{((colors[2, x] & getBit[y]) != 0 ? "FF" : "00")}");
        }
        private void ChangeColorButtons(int x, int y, string color) => BeginInvoke((MethodInvoker)(() => { 
            ltl9x9[x, y].BackColor = ColorTranslator.FromHtml(color); }));

        //Tasks
        async private Task StartReading()
        {
            AfterStartReading(autoRButton.Checked);
            do
            {
                await semaphoreSlim.WaitAsync();
                try
                {
                    byte[] cmdOut = mbClass.FormatModBusCMD((byte)ID.Value, ReadMB.ReadAO, 0, 35);
                    Tuple<byte[], Reply> reply = mbClass.Handler(cmdOut);
                    ToInfoStatus(reply.Item2.ToString());
                    if (reply.Item2 == Reply.Ok)
                    {
                        byte[] data = new byte[reply.Item1.Length - 3];
                        Array.Copy(reply.Item1, 3, data, 0, reply.Item1.Length - 3);
                        for (int r = 0, i = 0; r < RegistersGrid.Rows.Count; r++)
                        {
                            byte size = Convert.ToByte(RegistersGrid[(int)CEnum.size, r].Value);
                            byte[] dataReg = new byte[size];
                            Array.Copy(data, i, dataReg, 0, size);
                            int dataNum;
                            if (size == 2) dataNum = dataReg[0] << 8 | dataReg[1];
                            else dataNum = dataReg[2] << 24 | dataReg[3] << 16 | dataReg[0] << 8 | dataReg[1];
                            SetCellValue(3, r, dataNum, dataReg);
                            i += size;
                        }
                        SetInfoFromRegs();
                        SetDiscretInput();
                        if (checkRefreshPic.Checked) DownloadImage();
                    }
                }
                catch { ToInfoStatus("Error receive"); }
                finally
                {
                    await Task.Delay(manualRButton.Checked ? 50 : (int)timeoutMB.Value);
                    semaphoreSlim.Release();
                }
            }
            while (autoRButton.Checked);
            AfterStartReading(autoRButton.Checked);
        }
        async private Task CellSetRegisterValue(object sender, DataGridViewCellEventArgs e)
        {
            Enum.TryParse(RegistersGrid[(int)CEnum.field, e.RowIndex].Value.ToString(), out REnum register);
            if (RegistersGrid[(int)CEnum.WriteAO, e.RowIndex].Value is null) return;
            await semaphoreSlim.WaitAsync();
            try {
                if (UInt16.TryParse(RegistersGrid[(int)CEnum.WriteAO, e.RowIndex].Value.ToString(), out ushort value)
                    && await WriteRegister(register, value) == Reply.Ok) return;
                throw new Exception();
            }
            catch { ToInfoStatus("Error transcieve"); RegistersGrid[(int)CEnum.WriteAO, e.RowIndex].Value = ""; }
            finally { semaphoreSlim.Release(); }
        }
        async private Task UploadImage()
        {
            ushort[,] rgbMatrix = GetMatrixValues();
            ushort[] rgbArray = new ushort[(rgbMatrix.GetLength(0) * rgbMatrix.GetLength(1)) + 1];
            for (int x = 0, i = 0; x < 3; x++)
                for (int y = 0; y < 9; y++, i++)
                    rgbArray[i] = rgbMatrix[x, y];
            if (checkBlink.Checked) rgbArray[rgbArray.Length - 1] = GetBlinkTout();
            await semaphoreSlim.WaitAsync();
            try {
                if (GetCellValue((int)CEnum.ReadAO, (int)REnum.CmdReg) != 2)
                    await WriteRegister(REnum.CmdReg, 2);
                await MWriteRegisters(REnum.led_ctrl_r_0, rgbArray);
                await WriteRegister(REnum.CmdReg, 1);
            }
            catch { ToInfoStatus("Error transcieve"); }
            finally { semaphoreSlim.Release(); }
        }
        async private Task SendSingleCommand(object sender, REnum rEnum, Label label)
        {
            if (((ComboBox)sender).SelectedItem.ToString() == label.Text) return;
            await semaphoreSlim.WaitAsync();
            try { await WriteRegister(rEnum, Convert.ToUInt16(((ComboBox)sender).SelectedItem)); }
            catch { ToInfoStatus("Error transcieve"); }
            finally { semaphoreSlim.Release(); }
        }
    }
}
