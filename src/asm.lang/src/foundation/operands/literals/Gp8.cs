//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    [SymbolSource]
    public enum Gp8 : byte
    {
        [Symbol("al")]
        AL = r0,

        [Symbol("ah")]
        AH = r0  | 0b10000,

        [Symbol("cl")]
        CL = r1,

        [Symbol("ch")]
        CH = r1  | 0b10000,

        [Symbol("dl")]
        DL = r2,

        [Symbol("dh")]
        DH = r2  | 0b10000,

        [Symbol("bl")]
        BL = r3,

        [Symbol("bh")]
        BH = r3  | 0b10000,

        [Symbol("spl")]
        SPL = r4,

        [Symbol("bpl")]
        BPL = r5,

        [Symbol("sil")]
        SIL = r6,

        [Symbol("dil")]
        DIL = r7,

        [Symbol("r8b")]
        R8B = r8,

        [Symbol("r9b")]
        R9B = r9,

        [Symbol("r10b")]
        R10B = r10,

        [Symbol("r11b")]
        R11B = r11,

        [Symbol("r12b")]
        R12B = r12,

        [Symbol("r13b")]
        R13B = r13,

        [Symbol("r14b")]
        R14B = r14,

        [Symbol("r15b")]
        R15B = r15,
    }
}