//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using Sym = AsciControl;

    /// <summary>
    /// Defines asci control codes
    /// </summary>
    public enum AsciControlCode : byte
    {
        Null = 0,

        /// <summary>
        /// The backspace control symbol code
        /// </summary>
        Back = (byte)Sym.Back,        

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