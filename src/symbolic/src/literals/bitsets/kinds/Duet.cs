//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    /// <summary>
    /// Defines literals corresponding to the set of unique 2-bit sequences
    /// </summary>
    public enum Duet : byte
    {
        b00 = 0b00,

        b01 = 0b01,

        b10 = 0b10,

        b11 = 0b11,

        Max2 = b11,
    }
}