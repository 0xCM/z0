//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using CSym = AsciControl;

    /// <summary>
    /// Defines asci control codes
    /// </summary>
    public enum AsciControlCode : byte
    {
        Null = 0,

        /// <summary>
        /// The backspace control symbol code
        /// </summary>
        Back = (byte)CSym.Back,        

        /// <summary>
        /// The tab control symbol
        /// </summary>
        Tab = (byte)CSym.Tab,
        
        /// <summary>
        /// The line-feed/new-line control symbol code 10
        /// </summary>
        LF = (byte)CSym.LF,

        /// <summary>
        /// The form-feed control symbol code 12
        /// </summary>
        FF  = (byte)CSym.FF,

        /// <summary>
        /// The carriage return control symbol code 13
        /// </summary>
        CR = (byte)CSym.CR,
    }
}