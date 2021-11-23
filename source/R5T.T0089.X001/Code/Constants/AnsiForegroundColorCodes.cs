using System;


namespace R5T.T0089.X001
{
    // Source: https://github.com/aspnet/Logging/blob/2d2f31968229eddb57b6ba3d34696ef366a6c71b/src/Microsoft.Extensions.Logging.Console/Internal/AnsiLogConsole.cs#L61
    public static class AnsiForegroundColorCodes
    {
        public static string Default => "\x1B[39m\x1B[22m";

        public static string Black => "\x1B[30m";
        public static string DarkRed => "\x1B[31m";
        public static string DarkGreen => "\x1B[32m";
        public static string DarkYellow => "\x1B[33m";
        public static string DarkBlue => "\x1B[34m";
        public static string DarkMagenta => "\x1B[35m";
        public static string DarkCyan => "\x1B[36m";
        public static string Gray => "\x1B[37m";
        public static string Red => "\x1B[1m\x1B[31m";
        public static string Green => "\x1B[1m\x1B[32m";
        public static string Yellow => "\x1B[1m\x1B[33m";
        public static string Blue => "\x1B[1m\x1B[34m";
        public static string Magenta => "\x1B[1m\x1B[35m";
        public static string Cyan => "\x1B[1m\x1B[36m";
        public static string White => "\x1B[1m\x1B[37m";
    }
}
