using System;


namespace R5T.T0089
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class AnsiColorCodeOperator : IAnsiColorCodeOperator
    {
        #region Static
        
        public static AnsiColorCodeOperator Instance { get; } = new();

        #endregion
    }
}