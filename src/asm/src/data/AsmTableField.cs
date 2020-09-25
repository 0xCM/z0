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

    /// <summary>
    /// Defines the widths of common asm record fields
    /// </summary>
    public enum AsmOpCodeFieldWidths
    {
        Sequence = 10,

        Mnemonic = asci32.Size,

        Instruction = asci64.Size,

        OpCode = asci32.Size,

        OpCodeId = asci32.Size,

        Address64 = 16,

        YeaOrNea = 8,

        CpuId = asci64.Size,
    }

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
