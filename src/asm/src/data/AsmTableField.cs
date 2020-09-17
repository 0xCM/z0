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

    public enum AsmTableField : uint
    {
        Sequence = 0 | (W.Sequence << WidthOffset),

        Address = 1 | (W.Address64 << WidthOffset),

        GlobalOffset = 2 | (16 << WidthOffset),

        LocalOffset = 3 | (16 << WidthOffset),

        Mnemonic = 4 | (16 << WidthOffset),

        OpCode = 5 | (16 << WidthOffset),

        Instruction = 6 | (W.Instruction << WidthOffset),

        SourceCode = 7 | (W.Instruction << WidthOffset),

        Encoded = 8 | 32 << WidthOffset,

        CpuId = 9 | (W.CpuId << WidthOffset),

        OpCodeId = 10 | (20 << WidthOffset),
    }

}
