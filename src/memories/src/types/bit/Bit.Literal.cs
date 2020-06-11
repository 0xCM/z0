//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines literals that correspond to potential bit states
    /// </summary>
    public enum Bit : byte
    {
        
        /// <summary>
        /// The bit, it is off
        /// </summary>
        b0 = 0,

        /// <summary>
        /// The bit, enabled it is
        /// </summary>
        b1 = 1    
    }
}