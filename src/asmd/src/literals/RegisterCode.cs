//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    
    /// <summary>
    /// Defines register field codes; See RegisterCodes.csv
    /// </summary>
    public enum RegisterCode : byte
    {
        r0 = 0b000,

        r1 = 0b001,

        r2 = 0b010,

        r3 = 0b011,

        r4 = 0b100,

        r5 = 0b101,

        r6 = 0b110,

        r7 = 0b111
    }
}