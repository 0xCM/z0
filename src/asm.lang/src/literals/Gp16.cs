//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    partial struct AsmLang
    {
        [SymbolSource]
        public enum Gp16 : byte
        {
            [Symbol("ax")]
            AX = r0,

            [Symbol("cx")]
            CX = r1,

            [Symbol("dx")]
            DX = r2,

            [Symbol("bx")]
            BX = r3,

            [Symbol("sp")]
            SP = r4,

            [Symbol("bp")]
            BP = r5,

            [Symbol("si")]
            SI = r6,

            [Symbol("di")]
            DI = r7,

            [Symbol("r8w")]
            R8W = r8,

            [Symbol("r9w")]
            R9W = r9,

            [Symbol("r10w")]
            R10W = r10,

            [Symbol("r11w")]
            R11W = r11,

            [Symbol("r12w")]
            R12W = r12,

            [Symbol("r13w")]
            R13W = r13,

            [Symbol("r14w")]
            R14W = r14,

            [Symbol("r15w")]
            R15W = r15,
        }
    }
}