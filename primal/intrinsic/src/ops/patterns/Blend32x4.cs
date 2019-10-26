//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using static zfunc;

    /// <summary>
    /// Defines control mask values for blending four 32-bit components from two vectors
    /// </summary>
    [Flags]
    public enum Blend32x4 : byte
    {
        /// <summary>
        /// Selects all components from the left vector
        /// </summary>
        LLLL = 0b0000,

        LLLR = 0b1000,

        RLLL = 0b0001,

        LLRL = 0b0100,

        LLRR = 0b1100,

        LRLL = 0b0010,

        RLRL = 0b0101,

        LRRL = 0b0110,

        RRRL = 0b0111,

        RLLR = 0b1001,

        LRLR = 0b1010,

        RLRR = 0b1011,

        RRLL = 0b1100,

        RRLR = 0b1101,
        
        LRRR = 0b1110,
        
        /// <summary>
        /// Selects all components from the right vector
        /// </summary>
        RRRR = 0b1111
    }


}