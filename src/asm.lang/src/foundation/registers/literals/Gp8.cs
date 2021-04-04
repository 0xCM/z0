//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    public enum Gp8 : byte
    {
        AL = r0,

        AH = r0  | 0b10000,

        CL = r1,

        CH = r1  | 0b10000,

        DL = r2,

        DH = r2  | 0b10000,

        BL = r3,

        BH = r3  | 0b10000,

        SPL = r4,

        BPL = r5,

        SIL = r6,

        DIL = r7,

        R8L = r8,

        R9L = r9,

        R10L = r10,

        R11L = r11,

        R12L = r12,

        R13L = r13,

        R14L = r14,

        R15L = r15,
    }
}