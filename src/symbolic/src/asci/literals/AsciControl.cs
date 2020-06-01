//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    /// <summary>
    /// Defines asci control symbols
    /// </summary>
    public enum AsciControl : ushort
    {
        /// <summary>
        /// The '\0' control symbol
        /// </summary>
        Null = '\0',

        /// <summary>
        /// The backspace control symbol
        /// </summary>
        Back = '\b',        

        /// <summary>
        /// The tab control symbol
        /// </summary>
        Tab = '\t',

        /// <summary>
        /// The new-line control symbol \n', asci code 10
        /// </summary>
        NL = '\n',

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
        DEL = (byte)sbyte.MaxValue
    }
}
