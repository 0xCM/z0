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
        /// The new-line control symbol \n'
        /// </summary>
        LF = '\n',

        /// <summary>
        /// The carriage return control symbol '\r'
        /// </summary>
        CR = '\r',

        /// <summary>
        /// The form-feed control symbol '\f'
        /// </summary>
        FF  = '\f',

        /// <summary>
        /// The delete control symbol
        /// </summary>
        DEL = (byte)sbyte.MaxValue
    }
}
