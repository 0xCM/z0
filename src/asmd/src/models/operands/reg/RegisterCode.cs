//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    
    [FieldWidth(3)]
    public enum RegisterCode : byte
    {
        r0 = 0b00000,

        r1 = 0b00001,

        r2 = 0b00010,

        r3 = 0b00011,

        r4 = 0b00100,

        r5 = 0b00101,

        r6 = 0b00110,

        r7 = 0b00111,
    }
}