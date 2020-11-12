//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
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

    public enum AsmOpCodeField : uint
    {
        Sequence = 0 | (W.Sequence << WidthOffset),

        Mnemonic = 1 | (W.Mnemonic << WidthOffset),

        OpCode = 2 | (W.OpCode << WidthOffset),

        Instruction = 3 | (W.Instruction << WidthOffset),

        M16 = 4 | (W.YeaOrNea << WidthOffset),

        M32 = 5 | (W.YeaOrNea << WidthOffset),

        M64 = 6 | (W.YeaOrNea << WidthOffset),

        CpuId = 7 | (W.CpuId << WidthOffset),

        CodeId = 8 | (W.OpCodeId << WidthOffset),
    }
}