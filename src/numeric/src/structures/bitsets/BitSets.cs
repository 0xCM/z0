//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using B = BitState;

    /// <summary>
    /// Defines literals corresponding to the potential states of a bit
    /// </summary>
    public enum BitState : byte
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

    public partial class BitSets
    {
        public const B b0 = B.b0;
                
        public const B b1 = B.b1;
    }
}