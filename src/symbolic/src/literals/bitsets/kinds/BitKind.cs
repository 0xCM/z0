//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines literals corresponding to the potential states of a bit
    /// </summary>
    public enum BitKind : byte
    {    
        /// <summary>
        /// Disabled
        /// </summary>
        b0 = 0b0,

        /// <summary>
        /// Enabled
        /// </summary>
        b1 = 0b1,
    }
}