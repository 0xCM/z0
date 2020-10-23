//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = AsmOpCodeFieldWidths;

    public enum AsmRowField : uint
    {
        Sequence = 0 | (10 << WidthOffset),

        Address = 1 | (16 << WidthOffset),

        GlobalOffset = 2 | (16 << WidthOffset),

        LocalOffset = 3 | (16 << WidthOffset),

        Mnemonic = 4 | (16 << WidthOffset),

        OpCode = 5 | (16 << WidthOffset),

        Instruction = 6 | (64 << WidthOffset),

        SourceCode = 7 | (64 << WidthOffset),

        Encoded = 8 | 32 << WidthOffset,

        CpuId = 9 | (64 << WidthOffset),

        OpCodeId = 10 | (20 << WidthOffset),
    }
}
