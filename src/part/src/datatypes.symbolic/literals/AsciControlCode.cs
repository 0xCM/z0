//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using S = AsciControl;

    /// <summary>
    /// Defines asci control codes
    /// </summary>
    [CodeProvider(typeof(S))]
    public enum AsciControlCode : byte
    {
        /// <summary>
        /// The backspace control symbol code
        /// </summary>
        BS = (byte)S.BS,

        /// <summary>
        /// The tab control symbol, asci code 9
        /// </summary>
        Tab = (byte)S.Tab,

        /// <summary>
        /// The line-feed/new-line control symbol, asci code 10
        /// </summary>
        LF = (byte)S.LF,

        /// <summary>
        /// The form-feed control symbol, asci code 12
        /// </summary>
        FF  = (byte)S.FF,

        /// <summary>
        /// The carriage return control symbol, asci code 13
        /// </summary>
        CR = (byte)S.CR,
    }
}