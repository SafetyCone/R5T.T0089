using System;


namespace R5T.T0089
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class AnsiColorCode : IAnsiColorCode
    {
        #region Static
        
        public static AnsiColorCode Instance { get; } = new();

        #endregion
    }
}