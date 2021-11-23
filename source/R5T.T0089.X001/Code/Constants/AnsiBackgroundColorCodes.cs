using System;


namespace R5T.T0089.X001
{
    // Source: https://github.com/aspnet/Logging/blob/2d2f31968229eddb57b6ba3d34696ef366a6c71b/src/Microsoft.Extensions.Logging.Console/Internal/AnsiLogConsole.cs#L100
    public static class AnsiBackgroundColorCodes
    {
        public static string Default => "\x1B[49m";

        public static string Black => "\x1B[40m";
        public static string Red => "\x1B[41m";
        public static string Green => "\x1B[42m";
        public static string Yellow => "\x1B[43m";
        public static string Blue => "\x1B[44m";
        public static string Magenta => "\x1B[45m";
        public static string Cyan => "\x1B[46m";
        public static string White => "\x1B[47m";
    }
}
