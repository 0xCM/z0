//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using static zfunc;

    /// <summary>
    /// Defines control mask values for blending eight 16-bit components from two vectors
    /// </summary>
    [Flags]
    public enum Blend16x8 : byte
    {
        L = 0,        

        R = 1,

        LLLLLLLL = 0,

        RRRRRRRR = 0b11111111,

        LRLRLRLR = 0b10101010,

        RLRLRLRL = 0b01010101,

        LLRRLLRR = 0b11001100,

        RRLLRRLL = 0b00110011,

        LLLLRRRR = 0b11110000,

        RRRRLLLL = 0b00001111
    }
}