using MBus;

namespace LTL100_9x9
{
    static class StaticSettings
    {
        public static bool autoRead { get; set; } = true;
        public static ModBusClass mbClass { get; set; } = null;
    }
}
