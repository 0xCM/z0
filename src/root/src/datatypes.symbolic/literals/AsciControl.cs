//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines asci control symbols
    /// </summary>
    [SymbolProvider]
    public enum AsciControl : ushort
    {
        /// <summary>
        /// The '\0' control symbol
        /// </summary>
        Null = '\0',

        /// <summary>
        /// Start of heading
        /// </summary>
        SOH = 1,

        /// <summary>
        /// Start of text
        /// </summary>
        SOT = 2,

        /// <summary>
        /// End of text
        /// </summary>
        EOT = 3,

        /// <summary>
        /// End of transmission
        /// </summary>
        EOTR = 4,

        /// <summary>
        /// Enquiry
        /// </summary>
        ENQ = 5,

        /// <summary>
        /// Acknowledgement
        /// </summary>
        ACK = 6,

        /// <summary>
        /// Hell's bells, asci code 7
        /// </summary>
        Bell = '\a',

        /// <summary>
        /// The backspace control symbol '\b', asci code 8
        /// </summary>
        BS = '\b',

        /// <summary>
        /// A horizontal tab
        /// </summary>
        Tab = '\t',

        /// <summary>
        /// The new-line control symbol \n', asci code 10
        /// </summary>
        LF = '\n',

        /// <summary>
        /// The form-feed control symbol '\f', asci code 12
        /// </summary>
        FF  = '\f',

        /// <summary>
        /// The carriage return control symbol '\r', asci code 13
        /// </summary>
        CR = '\r',

        /// <summary>
        /// The delete control symbol
        /// </summary>
        Del = (byte)sbyte.MaxValue
    }
}
