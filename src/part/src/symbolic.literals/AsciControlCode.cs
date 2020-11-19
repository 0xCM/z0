//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Sym = AsciControl;

    /// <summary>
    /// Defines asci control codes
    /// </summary>
    [CodeProvider]
    public enum AsciControlCode : byte
    {
        /// <summary>
        /// The backspace control symbol code
        /// </summary>
        BS = (byte)Sym.BS,

        /// <summary>
        /// The tab control symbol, asci code 9
        /// </summary>
        Tab = (byte)Sym.Tab,

        /// <summary>
        /// The line-feed/new-line control symbol, asci code 10
        /// </summary>
        NL = (byte)Sym.NL,

        /// <summary>
        /// The form-feed control symbol, asci code 12
        /// </summary>
        FF  = (byte)Sym.FF,

        /// <summary>
        /// The carriage return control symbol, asci code 13
        /// </summary>
        CR = (byte)Sym.CR,
    }
}