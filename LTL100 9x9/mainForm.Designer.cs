namespace LTL100_9x9
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripSerial = new System.Windows.Forms.ToolStrip();
            this.dataBits = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataBits7 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBits8 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBitsInfo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Parity = new System.Windows.Forms.ToolStripDropDownButton();
            this.ParityNone = new System.Windows.Forms.ToolStripMenuItem();
            this.ParityOdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ParityEven = new System.Windows.Forms.ToolStripMenuItem();
            this.ParityMark = new System.Windows.Forms.ToolStripMenuItem();
            this.ParitySpace = new System.Windows.Forms.ToolStripMenuItem();
            this.ParityInfo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.stopBits = new System.Windows.Forms.ToolStripDropDownButton();
            this.stopBits1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBits2 = new System.Windows.Forms.ToolStripMenuItem();
            this.StopBitsInfo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.InfoStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.SignaturePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timeoutMB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.NumericUpDown();
            this.manualReadButton = new System.Windows.Forms.Button();
            this.manualRButton = new System.Windows.Forms.RadioButton();
            this.autoRButton = new System.Windows.Forms.RadioButton();
            this.SerUdpPages = new System.Windows.Forms.TabControl();
            this.RtuPage = new System.Windows.Forms.TabPage();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.OpenCom = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RefreshSerial = new System.Windows.Forms.Button();
            this.TcpPage = new System.Windows.Forms.TabPage();
            this.numericPort = new System.Windows.Forms.NumericUpDown();
            this.Connect = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.IPaddressBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mbRtu = new System.IO.Ports.SerialPort(this.components);
            this.LTLControlPage = new System.Windows.Forms.TabControl();
            this.panelPage = new System.Windows.Forms.TabPage();
            this.groupIndex = new System.Windows.Forms.GroupBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.comboIndex = new System.Windows.Forms.ComboBox();
            this.groupMode = new System.Windows.Forms.GroupBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.groupTools = new System.Windows.Forms.GroupBox();
            this.checkFill = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkRefreshPic = new System.Windows.Forms.CheckBox();
            this.UploadImageButton = new System.Windows.Forms.Button();
            this.groupBlink = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericBlinkTimer = new System.Windows.Forms.NumericUpDown();
            this.checkBlink = new System.Windows.Forms.CheckBox();
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.checkRed = new System.Windows.Forms.CheckBox();
            this.checkGreen = new System.Windows.Forms.CheckBox();
            this.checkBlue = new System.Windows.Forms.CheckBox();
            this.LEDPanel = new System.Windows.Forms.Panel();
            this.registersPage = new System.Windows.Forms.TabPage();
            this.RegistersGrid = new System.Windows.Forms.DataGridView();
            this.EnabledColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadFieldColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteFieldColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.WorkTimeLabel = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.DI_3 = new System.Windows.Forms.Label();
            this.DI_2 = new System.Windows.Forms.Label();
            this.DI_1 = new System.Windows.Forms.Label();
            this.DI_0 = new System.Windows.Forms.Label();
            this.ltl9x9ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSerial.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SignaturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            this.SerUdpPages.SuspendLayout();
            this.RtuPage.SuspendLayout();
            this.TcpPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            this.LTLControlPage.SuspendLayout();
            this.panelPage.SuspendLayout();
            this.groupIndex.SuspendLayout();
            this.groupMode.SuspendLayout();
            this.groupTools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBlink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlinkTimer)).BeginInit();
            this.groupColor.SuspendLayout();
            this.registersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistersGrid)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSerial
            // 
            this.toolStripSerial.AllowMerge = false;
            this.toolStripSerial.BackColor = System.Drawing.Color.White;
            this.toolStripSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripSerial.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSerial.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripSerial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBits,
            this.dataBitsInfo,
            this.toolStripSeparator3,
            this.Parity,
            this.ParityInfo,
            this.toolStripSeparator5,
            this.stopBits,
            this.StopBitsInfo,
            this.toolStripSeparator1});
            this.toolStripSerial.Location = new System.Drawing.Point(0, 0);
            this.toolStripSerial.Name = "toolStripSerial";
            this.toolStripSerial.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripSerial.Size = new System.Drawing.Size(484, 25);
            this.toolStripSerial.TabIndex = 23;
            this.toolStripSerial.Text = "toolStrip1";
            // 
            // dataBits
            // 
            this.dataBits.AutoToolTip = false;
            this.dataBits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dataBits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBits7,
            this.dataBits8});
            this.dataBits.Image = ((System.Drawing.Image)(resources.GetObject("dataBits.Image")));
            this.dataBits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dataBits.Name = "dataBits";
            this.dataBits.ShowDropDownArrow = false;
            this.dataBits.Size = new System.Drawing.Size(57, 22);
            this.dataBits.Text = "Data Bits";
            // 
            // dataBits7
            // 
            this.dataBits7.Name = "dataBits7";
            this.dataBits7.Size = new System.Drawing.Size(80, 22);
            this.dataBits7.Text = "7";
            // 
            // dataBits8
            // 
            this.dataBits8.Name = "dataBits8";
            this.dataBits8.Size = new System.Drawing.Size(80, 22);
            this.dataBits8.Text = "8";
            // 
            // dataBitsInfo
            // 
            this.dataBitsInfo.Enabled = false;
            this.dataBitsInfo.Name = "dataBitsInfo";
            this.dataBitsInfo.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Parity
            // 
            this.Parity.AutoToolTip = false;
            this.Parity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Parity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ParityNone,
            this.ParityOdd,
            this.ParityEven,
            this.ParityMark,
            this.ParitySpace});
            this.Parity.Image = ((System.Drawing.Image)(resources.GetObject("Parity.Image")));
            this.Parity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Parity.Name = "Parity";
            this.Parity.ShowDropDownArrow = false;
            this.Parity.Size = new System.Drawing.Size(41, 22);
            this.Parity.Text = "Parity";
            // 
            // ParityNone
            // 
            this.ParityNone.Name = "ParityNone";
            this.ParityNone.Size = new System.Drawing.Size(105, 22);
            this.ParityNone.Text = "None";
            // 
            // ParityOdd
            // 
            this.ParityOdd.Name = "ParityOdd";
            this.ParityOdd.Size = new System.Drawing.Size(105, 22);
            this.ParityOdd.Text = "Odd";
            // 
            // ParityEven
            // 
            this.ParityEven.Name = "ParityEven";
            this.ParityEven.Size = new System.Drawing.Size(105, 22);
            this.ParityEven.Text = "Even";
            // 
            // ParityMark
            // 
            this.ParityMark.Name = "ParityMark";
            this.ParityMark.Size = new System.Drawing.Size(105, 22);
            this.ParityMark.Text = "Mark";
            // 
            // ParitySpace
            // 
            this.ParitySpace.Name = "ParitySpace";
            this.ParitySpace.Size = new System.Drawing.Size(105, 22);
            this.ParitySpace.Text = "Space";
            // 
            // ParityInfo
            // 
            this.ParityInfo.Enabled = false;
            this.ParityInfo.Name = "ParityInfo";
            this.ParityInfo.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // stopBits
            // 
            this.stopBits.AutoToolTip = false;
            this.stopBits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stopBits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopBits1,
            this.stopBits2});
            this.stopBits.Image = ((System.Drawing.Image)(resources.GetObject("stopBits.Image")));
            this.stopBits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopBits.Name = "stopBits";
            this.stopBits.ShowDropDownArrow = false;
            this.stopBits.Size = new System.Drawing.Size(57, 22);
            this.stopBits.Text = "Stop Bits";
            // 
            // stopBits1
            // 
            this.stopBits1.Name = "stopBits1";
            this.stopBits1.Size = new System.Drawing.Size(80, 22);
            this.stopBits1.Text = "1";
            // 
            // stopBits2
            // 
            this.stopBits2.Name = "stopBits2";
            this.stopBits2.Size = new System.Drawing.Size(80, 22);
            this.stopBits2.Text = "2";
            // 
            // StopBitsInfo
            // 
            this.StopBitsInfo.Enabled = false;
            this.StopBitsInfo.Name = "StopBitsInfo";
            this.StopBitsInfo.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.InfoStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel1.Text = "Information:";
            // 
            // InfoStatus
            // 
            this.InfoStatus.Name = "InfoStatus";
            this.InfoStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // SignaturePanel
            // 
            this.SignaturePanel.BackColor = System.Drawing.Color.White;
            this.SignaturePanel.Controls.Add(this.label2);
            this.SignaturePanel.Controls.Add(this.timeoutMB);
            this.SignaturePanel.Controls.Add(this.label1);
            this.SignaturePanel.Controls.Add(this.ID);
            this.SignaturePanel.Location = new System.Drawing.Point(0, 172);
            this.SignaturePanel.Name = "SignaturePanel";
            this.SignaturePanel.Size = new System.Drawing.Size(165, 45);
            this.SignaturePanel.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время опроса (мс):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeoutMB
            // 
            this.timeoutMB.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.timeoutMB.Location = new System.Drawing.Point(118, 24);
            this.timeoutMB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timeoutMB.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.timeoutMB.Name = "timeoutMB";
            this.timeoutMB.Size = new System.Drawing.Size(45, 20);
            this.timeoutMB.TabIndex = 2;
            this.timeoutMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeoutMB.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(118, 2);
            this.ID.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(45, 20);
            this.ID.TabIndex = 0;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // manualReadButton
            // 
            this.manualReadButton.Location = new System.Drawing.Point(117, 0);
            this.manualReadButton.Margin = new System.Windows.Forms.Padding(1);
            this.manualReadButton.Name = "manualReadButton";
            this.manualReadButton.Size = new System.Drawing.Size(47, 23);
            this.manualReadButton.TabIndex = 6;
            this.manualReadButton.Text = "Read";
            this.manualReadButton.UseVisualStyleBackColor = true;
            // 
            // manualRButton
            // 
            this.manualRButton.AutoSize = true;
            this.manualRButton.Checked = true;
            this.manualRButton.Location = new System.Drawing.Point(57, 3);
            this.manualRButton.Name = "manualRButton";
            this.manualRButton.Size = new System.Drawing.Size(60, 17);
            this.manualRButton.TabIndex = 5;
            this.manualRButton.TabStop = true;
            this.manualRButton.Text = "Manual";
            this.manualRButton.UseVisualStyleBackColor = true;
            // 
            // autoRButton
            // 
            this.autoRButton.AutoSize = true;
            this.autoRButton.Location = new System.Drawing.Point(4, 3);
            this.autoRButton.Name = "autoRButton";
            this.autoRButton.Size = new System.Drawing.Size(47, 17);
            this.autoRButton.TabIndex = 4;
            this.autoRButton.Text = "Auto";
            this.autoRButton.UseVisualStyleBackColor = true;
            // 
            // SerUdpPages
            // 
            this.SerUdpPages.Controls.Add(this.RtuPage);
            this.SerUdpPages.Controls.Add(this.TcpPage);
            this.SerUdpPages.Location = new System.Drawing.Point(0, 25);
            this.SerUdpPages.Margin = new System.Windows.Forms.Padding(0);
            this.SerUdpPages.Multiline = true;
            this.SerUdpPages.Name = "SerUdpPages";
            this.SerUdpPages.SelectedIndex = 0;
            this.SerUdpPages.Size = new System.Drawing.Size(165, 148);
            this.SerUdpPages.TabIndex = 26;
            // 
            // RtuPage
            // 
            this.RtuPage.BackColor = System.Drawing.Color.White;
            this.RtuPage.Controls.Add(this.comPort);
            this.RtuPage.Controls.Add(this.BaudRate);
            this.RtuPage.Controls.Add(this.OpenCom);
            this.RtuPage.Controls.Add(this.label10);
            this.RtuPage.Controls.Add(this.label11);
            this.RtuPage.Controls.Add(this.RefreshSerial);
            this.RtuPage.Location = new System.Drawing.Point(4, 22);
            this.RtuPage.Name = "RtuPage";
            this.RtuPage.Padding = new System.Windows.Forms.Padding(3);
            this.RtuPage.Size = new System.Drawing.Size(157, 122);
            this.RtuPage.TabIndex = 0;
            this.RtuPage.Text = "RTU";
            // 
            // comPort
            // 
            this.comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(19, 29);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(121, 21);
            this.comPort.Sorted = true;
            this.comPort.TabIndex = 32;
            // 
            // BaudRate
            // 
            this.BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRate.Location = new System.Drawing.Point(19, 67);
            this.BaudRate.MaxLength = 7;
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(121, 21);
            this.BaudRate.TabIndex = 33;
            // 
            // OpenCom
            // 
            this.OpenCom.BackColor = System.Drawing.Color.Transparent;
            this.OpenCom.Enabled = false;
            this.OpenCom.Location = new System.Drawing.Point(18, 89);
            this.OpenCom.Name = "OpenCom";
            this.OpenCom.Size = new System.Drawing.Size(123, 23);
            this.OpenCom.TabIndex = 42;
            this.OpenCom.Text = "Open";
            this.OpenCom.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "PortName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "BaudRate";
            // 
            // RefreshSerial
            // 
            this.RefreshSerial.Location = new System.Drawing.Point(76, 10);
            this.RefreshSerial.Name = "RefreshSerial";
            this.RefreshSerial.Size = new System.Drawing.Size(65, 21);
            this.RefreshSerial.TabIndex = 43;
            this.RefreshSerial.Text = "Refresh";
            this.RefreshSerial.UseVisualStyleBackColor = true;
            // 
            // TcpPage
            // 
            this.TcpPage.BackColor = System.Drawing.Color.White;
            this.TcpPage.Controls.Add(this.numericPort);
            this.TcpPage.Controls.Add(this.Connect);
            this.TcpPage.Controls.Add(this.label14);
            this.TcpPage.Controls.Add(this.label13);
            this.TcpPage.Controls.Add(this.IPaddressBox);
            this.TcpPage.Controls.Add(this.label16);
            this.TcpPage.Location = new System.Drawing.Point(4, 22);
            this.TcpPage.Name = "TcpPage";
            this.TcpPage.Padding = new System.Windows.Forms.Padding(3);
            this.TcpPage.Size = new System.Drawing.Size(157, 122);
            this.TcpPage.TabIndex = 1;
            this.TcpPage.Text = "TCP";
            // 
            // numericPort
            // 
            this.numericPort.Location = new System.Drawing.Point(102, 47);
            this.numericPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericPort.Name = "numericPort";
            this.numericPort.Size = new System.Drawing.Size(51, 20);
            this.numericPort.TabIndex = 29;
            this.numericPort.Value = new decimal(new int[] {
            502,
            0,
            0,
            0});
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(5, 69);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(149, 23);
            this.Connect.TabIndex = 29;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Port";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "IP address";
            // 
            // IPaddressBox
            // 
            this.IPaddressBox.Location = new System.Drawing.Point(6, 47);
            this.IPaddressBox.MaxLength = 15;
            this.IPaddressBox.Name = "IPaddressBox";
            this.IPaddressBox.Size = new System.Drawing.Size(88, 20);
            this.IPaddressBox.TabIndex = 0;
            this.IPaddressBox.Text = "192.168.1.50";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(94, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = ":";
            // 
            // LTLControlPage
            // 
            this.LTLControlPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTLControlPage.Controls.Add(this.panelPage);
            this.LTLControlPage.Controls.Add(this.registersPage);
            this.LTLControlPage.Enabled = false;
            this.LTLControlPage.Location = new System.Drawing.Point(166, 25);
            this.LTLControlPage.Margin = new System.Windows.Forms.Padding(0);
            this.LTLControlPage.Name = "LTLControlPage";
            this.LTLControlPage.SelectedIndex = 0;
            this.LTLControlPage.Size = new System.Drawing.Size(319, 311);
            this.LTLControlPage.TabIndex = 28;
            // 
            // panelPage
            // 
            this.panelPage.BackColor = System.Drawing.Color.White;
            this.panelPage.Controls.Add(this.groupIndex);
            this.panelPage.Controls.Add(this.groupMode);
            this.panelPage.Controls.Add(this.groupTools);
            this.panelPage.Controls.Add(this.panel1);
            this.panelPage.Controls.Add(this.groupBlink);
            this.panelPage.Controls.Add(this.groupColor);
            this.panelPage.Controls.Add(this.LEDPanel);
            this.panelPage.Location = new System.Drawing.Point(4, 22);
            this.panelPage.Name = "panelPage";
            this.panelPage.Padding = new System.Windows.Forms.Padding(3);
            this.panelPage.Size = new System.Drawing.Size(311, 285);
            this.panelPage.TabIndex = 1;
            this.panelPage.Text = "Panel";
            // 
            // groupIndex
            // 
            this.groupIndex.Controls.Add(this.labelIndex);
            this.groupIndex.Controls.Add(this.comboIndex);
            this.groupIndex.Location = new System.Drawing.Point(186, 47);
            this.groupIndex.Name = "groupIndex";
            this.groupIndex.Size = new System.Drawing.Size(122, 45);
            this.groupIndex.TabIndex = 88;
            this.groupIndex.TabStop = false;
            this.groupIndex.Text = "Index";
            this.ltl9x9ToolTip.SetToolTip(this.groupIndex, "Выбор индекса изображения");
            // 
            // labelIndex
            // 
            this.labelIndex.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIndex.Location = new System.Drawing.Point(86, 16);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(34, 20);
            this.labelIndex.TabIndex = 83;
            this.labelIndex.Text = "0";
            this.labelIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ltl9x9ToolTip.SetToolTip(this.labelIndex, "Значение регистра:\r\n - ReadImage при Mode:0\r\n - DI при Mode:3");
            // 
            // comboIndex
            // 
            this.comboIndex.BackColor = System.Drawing.Color.White;
            this.comboIndex.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIndex.FormattingEnabled = true;
            this.comboIndex.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboIndex.Location = new System.Drawing.Point(3, 16);
            this.comboIndex.Margin = new System.Windows.Forms.Padding(0);
            this.comboIndex.Name = "comboIndex";
            this.comboIndex.Size = new System.Drawing.Size(80, 21);
            this.comboIndex.TabIndex = 0;
            // 
            // groupMode
            // 
            this.groupMode.Controls.Add(this.labelMode);
            this.groupMode.Controls.Add(this.comboMode);
            this.groupMode.Location = new System.Drawing.Point(186, 2);
            this.groupMode.Name = "groupMode";
            this.groupMode.Size = new System.Drawing.Size(122, 45);
            this.groupMode.TabIndex = 87;
            this.groupMode.TabStop = false;
            this.groupMode.Text = "Mode";
            this.ltl9x9ToolTip.SetToolTip(this.groupMode, resources.GetString("groupMode.ToolTip"));
            // 
            // labelMode
            // 
            this.labelMode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMode.Location = new System.Drawing.Point(86, 16);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(34, 20);
            this.labelMode.TabIndex = 83;
            this.labelMode.Text = "0";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ltl9x9ToolTip.SetToolTip(this.labelMode, "Значение регистра CmdReg\r\n");
            // 
            // comboMode
            // 
            this.comboMode.BackColor = System.Drawing.Color.White;
            this.comboMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "1107",
            "8107"});
            this.comboMode.Location = new System.Drawing.Point(3, 16);
            this.comboMode.Margin = new System.Windows.Forms.Padding(0);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(80, 21);
            this.comboMode.TabIndex = 0;
            // 
            // groupTools
            // 
            this.groupTools.Controls.Add(this.checkFill);
            this.groupTools.Location = new System.Drawing.Point(186, 182);
            this.groupTools.Name = "groupTools";
            this.groupTools.Size = new System.Drawing.Size(122, 45);
            this.groupTools.TabIndex = 86;
            this.groupTools.TabStop = false;
            this.groupTools.Text = "Tools";
            // 
            // checkFill
            // 
            this.checkFill.AutoSize = true;
            this.checkFill.Location = new System.Drawing.Point(11, 19);
            this.checkFill.Margin = new System.Windows.Forms.Padding(0);
            this.checkFill.Name = "checkFill";
            this.checkFill.Size = new System.Drawing.Size(38, 17);
            this.checkFill.TabIndex = 83;
            this.checkFill.Text = "Fill";
            this.ltl9x9ToolTip.SetToolTip(this.checkFill, "Заполнить");
            this.checkFill.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkRefreshPic);
            this.panel1.Controls.Add(this.UploadImageButton);
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 103);
            this.panel1.TabIndex = 86;
            // 
            // checkRefreshPic
            // 
            this.checkRefreshPic.AutoSize = true;
            this.checkRefreshPic.Location = new System.Drawing.Point(2, 25);
            this.checkRefreshPic.Name = "checkRefreshPic";
            this.checkRefreshPic.Size = new System.Drawing.Size(98, 17);
            this.checkRefreshPic.TabIndex = 83;
            this.checkRefreshPic.Text = "Refresh picture";
            this.checkRefreshPic.UseVisualStyleBackColor = true;
            // 
            // UploadImageButton
            // 
            this.UploadImageButton.Location = new System.Drawing.Point(1, 1);
            this.UploadImageButton.Margin = new System.Windows.Forms.Padding(0);
            this.UploadImageButton.Name = "UploadImageButton";
            this.UploadImageButton.Size = new System.Drawing.Size(179, 23);
            this.UploadImageButton.TabIndex = 82;
            this.UploadImageButton.Text = "Upload Image";
            this.ltl9x9ToolTip.SetToolTip(this.UploadImageButton, "Передать изображение на устройство");
            this.UploadImageButton.UseVisualStyleBackColor = true;
            // 
            // groupBlink
            // 
            this.groupBlink.Controls.Add(this.label3);
            this.groupBlink.Controls.Add(this.numericBlinkTimer);
            this.groupBlink.Controls.Add(this.checkBlink);
            this.groupBlink.Location = new System.Drawing.Point(186, 92);
            this.groupBlink.Name = "groupBlink";
            this.groupBlink.Size = new System.Drawing.Size(122, 45);
            this.groupBlink.TabIndex = 85;
            this.groupBlink.TabStop = false;
            this.groupBlink.Text = "Blink";
            this.ltl9x9ToolTip.SetToolTip(this.groupBlink, "Частота мигания\r\n0 бит - отключить мигание\r\n2-15 бит - частота мигания");
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(99, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 26);
            this.label3.TabIndex = 82;
            this.label3.Text = "ms";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericBlinkTimer
            // 
            this.numericBlinkTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericBlinkTimer.Enabled = false;
            this.numericBlinkTimer.Location = new System.Drawing.Point(28, 16);
            this.numericBlinkTimer.Margin = new System.Windows.Forms.Padding(0);
            this.numericBlinkTimer.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericBlinkTimer.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericBlinkTimer.Name = "numericBlinkTimer";
            this.numericBlinkTimer.Size = new System.Drawing.Size(69, 20);
            this.numericBlinkTimer.TabIndex = 81;
            this.numericBlinkTimer.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // checkBlink
            // 
            this.checkBlink.AutoSize = true;
            this.checkBlink.Location = new System.Drawing.Point(11, 19);
            this.checkBlink.Margin = new System.Windows.Forms.Padding(0);
            this.checkBlink.Name = "checkBlink";
            this.checkBlink.Size = new System.Drawing.Size(15, 14);
            this.checkBlink.TabIndex = 80;
            this.ltl9x9ToolTip.SetToolTip(this.checkBlink, "Вкл\\Откл режима мигания");
            this.checkBlink.UseVisualStyleBackColor = true;
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.checkRed);
            this.groupColor.Controls.Add(this.checkGreen);
            this.groupColor.Controls.Add(this.checkBlue);
            this.groupColor.Location = new System.Drawing.Point(186, 137);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(122, 45);
            this.groupColor.TabIndex = 84;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "Color";
            this.ltl9x9ToolTip.SetToolTip(this.groupColor, "Выбор цвета");
            // 
            // checkRed
            // 
            this.checkRed.AutoSize = true;
            this.checkRed.Location = new System.Drawing.Point(11, 19);
            this.checkRed.Margin = new System.Windows.Forms.Padding(0);
            this.checkRed.Name = "checkRed";
            this.checkRed.Size = new System.Drawing.Size(34, 17);
            this.checkRed.TabIndex = 79;
            this.checkRed.Text = "R";
            this.ltl9x9ToolTip.SetToolTip(this.checkRed, "Красный");
            this.checkRed.UseVisualStyleBackColor = true;
            // 
            // checkGreen
            // 
            this.checkGreen.AutoSize = true;
            this.checkGreen.Location = new System.Drawing.Point(45, 19);
            this.checkGreen.Margin = new System.Windows.Forms.Padding(0);
            this.checkGreen.Name = "checkGreen";
            this.checkGreen.Size = new System.Drawing.Size(34, 17);
            this.checkGreen.TabIndex = 80;
            this.checkGreen.Text = "G";
            this.ltl9x9ToolTip.SetToolTip(this.checkGreen, "Зелёный");
            this.checkGreen.UseVisualStyleBackColor = true;
            // 
            // checkBlue
            // 
            this.checkBlue.AutoSize = true;
            this.checkBlue.Location = new System.Drawing.Point(79, 19);
            this.checkBlue.Margin = new System.Windows.Forms.Padding(0);
            this.checkBlue.Name = "checkBlue";
            this.checkBlue.Size = new System.Drawing.Size(33, 17);
            this.checkBlue.TabIndex = 81;
            this.checkBlue.Text = "B";
            this.ltl9x9ToolTip.SetToolTip(this.checkBlue, "Синий");
            this.checkBlue.UseVisualStyleBackColor = true;
            // 
            // LEDPanel
            // 
            this.LEDPanel.BackColor = System.Drawing.Color.White;
            this.LEDPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LEDPanel.Location = new System.Drawing.Point(0, 0);
            this.LEDPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LEDPanel.Name = "LEDPanel";
            this.LEDPanel.Size = new System.Drawing.Size(183, 183);
            this.LEDPanel.TabIndex = 78;
            // 
            // registersPage
            // 
            this.registersPage.Controls.Add(this.RegistersGrid);
            this.registersPage.Location = new System.Drawing.Point(4, 22);
            this.registersPage.Name = "registersPage";
            this.registersPage.Size = new System.Drawing.Size(311, 285);
            this.registersPage.TabIndex = 2;
            this.registersPage.Text = "Registers";
            this.registersPage.UseVisualStyleBackColor = true;
            // 
            // RegistersGrid
            // 
            this.RegistersGrid.AllowUserToAddRows = false;
            this.RegistersGrid.AllowUserToDeleteRows = false;
            this.RegistersGrid.AllowUserToResizeColumns = false;
            this.RegistersGrid.AllowUserToResizeRows = false;
            this.RegistersGrid.BackgroundColor = System.Drawing.Color.White;
            this.RegistersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegistersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RegistersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RegistersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnabledColumn,
            this.FieldsColumn,
            this.SizeColumn,
            this.ReadFieldColumn,
            this.WriteFieldColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RegistersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.RegistersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegistersGrid.EnableHeadersVisualStyles = false;
            this.RegistersGrid.GridColor = System.Drawing.Color.Gray;
            this.RegistersGrid.Location = new System.Drawing.Point(0, 0);
            this.RegistersGrid.Margin = new System.Windows.Forms.Padding(0);
            this.RegistersGrid.MultiSelect = false;
            this.RegistersGrid.Name = "RegistersGrid";
            this.RegistersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RegistersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RegistersGrid.RowHeadersVisible = false;
            this.RegistersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.RegistersGrid.RowTemplate.Height = 19;
            this.RegistersGrid.Size = new System.Drawing.Size(311, 285);
            this.RegistersGrid.TabIndex = 27;
            this.RegistersGrid.TabStop = false;
            // 
            // EnabledColumn
            // 
            this.EnabledColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EnabledColumn.FillWeight = 20F;
            this.EnabledColumn.Frozen = true;
            this.EnabledColumn.HeaderText = "#";
            this.EnabledColumn.MaxInputLength = 3;
            this.EnabledColumn.MinimumWidth = 20;
            this.EnabledColumn.Name = "EnabledColumn";
            this.EnabledColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EnabledColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EnabledColumn.Width = 20;
            // 
            // FieldsColumn
            // 
            this.FieldsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FieldsColumn.Frozen = true;
            this.FieldsColumn.HeaderText = "Field";
            this.FieldsColumn.MaxInputLength = 16;
            this.FieldsColumn.MinimumWidth = 80;
            this.FieldsColumn.Name = "FieldsColumn";
            this.FieldsColumn.ReadOnly = true;
            this.FieldsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FieldsColumn.Width = 80;
            // 
            // SizeColumn
            // 
            this.SizeColumn.Frozen = true;
            this.SizeColumn.HeaderText = "Size";
            this.SizeColumn.MaxInputLength = 3;
            this.SizeColumn.MinimumWidth = 30;
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            this.SizeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SizeColumn.Width = 30;
            // 
            // ReadFieldColumn
            // 
            this.ReadFieldColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReadFieldColumn.HeaderText = "Read";
            this.ReadFieldColumn.MaxInputLength = 10;
            this.ReadFieldColumn.MinimumWidth = 50;
            this.ReadFieldColumn.Name = "ReadFieldColumn";
            this.ReadFieldColumn.ReadOnly = true;
            this.ReadFieldColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ReadFieldColumn.Width = 50;
            // 
            // WriteFieldColumn
            // 
            this.WriteFieldColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.WriteFieldColumn.HeaderText = "Write";
            this.WriteFieldColumn.MaxInputLength = 5;
            this.WriteFieldColumn.MinimumWidth = 50;
            this.WriteFieldColumn.Name = "WriteFieldColumn";
            this.WriteFieldColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WriteFieldColumn.Width = 50;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VersionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VersionLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionLabel.Location = new System.Drawing.Point(2, 83);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(161, 15);
            this.VersionLabel.TabIndex = 7;
            this.VersionLabel.Text = "Ver:";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkTimeLabel
            // 
            this.WorkTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WorkTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WorkTimeLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkTimeLabel.Location = new System.Drawing.Point(2, 101);
            this.WorkTimeLabel.Name = "WorkTimeLabel";
            this.WorkTimeLabel.Size = new System.Drawing.Size(161, 15);
            this.WorkTimeLabel.TabIndex = 8;
            this.WorkTimeLabel.Text = "TTL:";
            this.WorkTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ltl9x9ToolTip.SetToolTip(this.WorkTimeLabel, "Время формата \"(d) hh:mm:ss\" где \r\nd - день\r\nhh - часы\r\nmm - минуты\r\nss - секунды" +
        "");
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsPanel.Controls.Add(this.DI_3);
            this.SettingsPanel.Controls.Add(this.DI_2);
            this.SettingsPanel.Controls.Add(this.WorkTimeLabel);
            this.SettingsPanel.Controls.Add(this.DI_1);
            this.SettingsPanel.Controls.Add(this.autoRButton);
            this.SettingsPanel.Controls.Add(this.DI_0);
            this.SettingsPanel.Controls.Add(this.manualReadButton);
            this.SettingsPanel.Controls.Add(this.VersionLabel);
            this.SettingsPanel.Controls.Add(this.manualRButton);
            this.SettingsPanel.Enabled = false;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 217);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(165, 118);
            this.SettingsPanel.TabIndex = 29;
            // 
            // DI_3
            // 
            this.DI_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DI_3.BackColor = System.Drawing.Color.White;
            this.DI_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DI_3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DI_3.Location = new System.Drawing.Point(122, 66);
            this.DI_3.Margin = new System.Windows.Forms.Padding(0);
            this.DI_3.Name = "DI_3";
            this.DI_3.Size = new System.Drawing.Size(40, 17);
            this.DI_3.TabIndex = 3;
            this.DI_3.Text = "DI.3";
            this.DI_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DI_2
            // 
            this.DI_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DI_2.BackColor = System.Drawing.Color.White;
            this.DI_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DI_2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DI_2.Location = new System.Drawing.Point(82, 66);
            this.DI_2.Margin = new System.Windows.Forms.Padding(0);
            this.DI_2.Name = "DI_2";
            this.DI_2.Size = new System.Drawing.Size(40, 17);
            this.DI_2.TabIndex = 2;
            this.DI_2.Text = "DI.2";
            this.DI_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DI_1
            // 
            this.DI_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DI_1.BackColor = System.Drawing.Color.White;
            this.DI_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DI_1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DI_1.Location = new System.Drawing.Point(42, 66);
            this.DI_1.Margin = new System.Windows.Forms.Padding(0);
            this.DI_1.Name = "DI_1";
            this.DI_1.Size = new System.Drawing.Size(40, 17);
            this.DI_1.TabIndex = 1;
            this.DI_1.Text = "DI.1";
            this.DI_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DI_0
            // 
            this.DI_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DI_0.BackColor = System.Drawing.Color.White;
            this.DI_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DI_0.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DI_0.Location = new System.Drawing.Point(2, 66);
            this.DI_0.Margin = new System.Windows.Forms.Padding(0);
            this.DI_0.Name = "DI_0";
            this.DI_0.Size = new System.Drawing.Size(40, 17);
            this.DI_0.TabIndex = 0;
            this.DI_0.Text = "DI.0";
            this.DI_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.LTLControlPage);
            this.Controls.Add(this.SignaturePanel);
            this.Controls.Add(this.SerUdpPages);
            this.Controls.Add(this.toolStripSerial);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LTL100 9x9";
            this.toolStripSerial.ResumeLayout(false);
            this.toolStripSerial.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.SignaturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeoutMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            this.SerUdpPages.ResumeLayout(false);
            this.RtuPage.ResumeLayout(false);
            this.RtuPage.PerformLayout();
            this.TcpPage.ResumeLayout(false);
            this.TcpPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).EndInit();
            this.LTLControlPage.ResumeLayout(false);
            this.panelPage.ResumeLayout(false);
            this.groupIndex.ResumeLayout(false);
            this.groupMode.ResumeLayout(false);
            this.groupTools.ResumeLayout(false);
            this.groupTools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBlink.ResumeLayout(false);
            this.groupBlink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlinkTimer)).EndInit();
            this.groupColor.ResumeLayout(false);
            this.groupColor.PerformLayout();
            this.registersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegistersGrid)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripSerial;
        private System.Windows.Forms.ToolStripDropDownButton dataBits;
        private System.Windows.Forms.ToolStripMenuItem dataBits7;
        private System.Windows.Forms.ToolStripMenuItem dataBits8;
        private System.Windows.Forms.ToolStripLabel dataBitsInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton Parity;
        private System.Windows.Forms.ToolStripMenuItem ParityNone;
        private System.Windows.Forms.ToolStripMenuItem ParityOdd;
        private System.Windows.Forms.ToolStripMenuItem ParityEven;
        private System.Windows.Forms.ToolStripMenuItem ParityMark;
        private System.Windows.Forms.ToolStripMenuItem ParitySpace;
        private System.Windows.Forms.ToolStripLabel ParityInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton stopBits;
        private System.Windows.Forms.ToolStripMenuItem stopBits1;
        private System.Windows.Forms.ToolStripMenuItem stopBits2;
        private System.Windows.Forms.ToolStripLabel StopBitsInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel InfoStatus;
        private System.Windows.Forms.Panel SignaturePanel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown timeoutMB;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown ID;
        public System.Windows.Forms.TabControl SerUdpPages;
        private System.Windows.Forms.TabPage RtuPage;
        private System.Windows.Forms.Button RefreshSerial;
        private System.Windows.Forms.Button OpenCom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage TcpPage;
        public System.Windows.Forms.NumericUpDown numericPort;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox IPaddressBox;
        private System.Windows.Forms.Label label16;
        private System.IO.Ports.SerialPort mbRtu;
        private System.Windows.Forms.RadioButton manualRButton;
        private System.Windows.Forms.RadioButton autoRButton;
        private System.Windows.Forms.Button manualReadButton;
        private System.Windows.Forms.ComboBox comPort;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.TabControl LTLControlPage;
        private System.Windows.Forms.TabPage panelPage;
        private System.Windows.Forms.Label WorkTimeLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.TabPage registersPage;
        private System.Windows.Forms.DataGridView RegistersGrid;
        private System.Windows.Forms.Panel LEDPanel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.ToolTip ltl9x9ToolTip;
        private System.Windows.Forms.CheckBox checkRed;
        private System.Windows.Forms.CheckBox checkBlue;
        private System.Windows.Forms.CheckBox checkGreen;
        private System.Windows.Forms.Button UploadImageButton;
        private System.Windows.Forms.CheckBox checkFill;
        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.GroupBox groupBlink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupTools;
        private System.Windows.Forms.CheckBox checkBlink;
        private System.Windows.Forms.GroupBox groupMode;
        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.Label DI_0;
        private System.Windows.Forms.Label DI_3;
        private System.Windows.Forms.Label DI_2;
        private System.Windows.Forms.Label DI_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnabledColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadFieldColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteFieldColumn;
        private System.Windows.Forms.NumericUpDown numericBlinkTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.GroupBox groupIndex;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.ComboBox comboIndex;
        private System.Windows.Forms.CheckBox checkRefreshPic;
    }
}

