using System;

using R5T.T0089;
using R5T.T0089.X001;


namespace System
{
    public static class IAnsiColorCodeExtensions
    {
        #region Foreground

        public static string BlackForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.Black;
        }

        public static string DarkRedForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.DarkRed;
        }

        public static string DarkGreenForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.DarkGreen;
        }

        public static string DarkYellowForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.DarkYellow;
        }

        public static string DarkBlueForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.DarkBlue;
        }

        public static string DarkMagentaForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.DarkMagenta;
        }

        public static string DarkCyanForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.DarkCyan;
        }

        public static string GrayForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.Gray;
        }

        public static string RedForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.Red;
        }

        public static string GreenForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.Green;
        }

        public static string YellowForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.Yellow;
        }

        public static string BlueForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.Blue;
        }

        public static string MagentaForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.Magenta;
        }

        public static string CyanForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.Cyan;
        }

        public static string WhiteForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.White;
        }

        public static string DefaultForeground(this IAnsiColorCode _)
        {
            return AnsiForegroundColorCodes.Default;
        }

        #endregion

        #region Background

        public static string BlackBackground(this IAnsiColorCode _)
        {
            return AnsiBackgroundColorCodes.Black;
        }

        public static string RedBackground(this IAnsiColorCode _)
        {
            return AnsiBackgroundColorCodes.Red;
        }

        public static string GreenBackground(this IAnsiColorCode _)
        {
            return AnsiBackgroundColorCodes.Green;
        }

        public static string YellowBackground(this IAnsiColorCode _)
        {
            return AnsiBackgroundColorCodes.Yellow;
        }

        public static string BlueBackground(this IAnsiColorCode _)
        {
            return AnsiBackgroundColorCodes.Blue;
        }

        public static string MagentaBackground(this IAnsiColorCode _)
        {
            return AnsiBackgroundColorCodes.Magenta;
        }

        public static string CyanBackground(this IAnsiColorCode _)
        {
            return AnsiBackgroundColorCodes.Cyan;
        }

        public static string WhiteBackground(this IAnsiColorCode _)
        {
            return AnsiBackgroundColorCodes.White;
        }

        public static string DefaultBackground(this IAnsiColorCode _)
        {
            return AnsiBackgroundColorCodes.Default;
        }

        #endregion
    }
}