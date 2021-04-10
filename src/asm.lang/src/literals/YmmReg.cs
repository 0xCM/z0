//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    partial struct AsmX
    {
        /// <summary>
        /// Specifies the YMM registers
        /// </summary>
        [SymbolSource]
        public enum YmmReg : byte
        {
            [Symbol("ymm0")]
            YMM0 = r0,

            [Symbol("ymm1")]
            YMM1 = r1,

            [Symbol("ymm2")]
            YMM2 = r2,

            [Symbol("ymm3")]
            YMM3 = r3,

            [Symbol("ymm4")]
            YMM4 = r4,

            [Symbol("ymm5")]
            YMM5 = r5,

            [Symbol("ymm6")]
            YMM6 = r6,

            [Symbol("ymm7")]
            YMM7 = r7,

            [Symbol("ymm8")]
            YMM8 = r8,

            [Symbol("ymm9")]
            YMM9 = r9,

            [Symbol("ymm10")]
            YMM10 = r10,

            [Symbol("ymm11")]
            YMM11 = r11,

            [Symbol("ymm12")]
            YMM12 = r12,

            [Symbol("ymm13")]
            YMM13 = r13,

            [Symbol("ymm14")]
            YMM14 = r14,

            [Symbol("ymm15")]
            YMM15 = r15,

            [Symbol("ymm16")]
            YMM16 = r16,

            [Symbol("ymm17")]
            YMM17 = r17,

            [Symbol("ymm18")]
            YMM18 = r18,

            [Symbol("ymm19")]
            YMM19 = r19,

            [Symbol("ymm20")]
            YMM20 = r20,

            [Symbol("ymm21")]
            YMM21 = r21,

            [Symbol("ymm22")]
            YMM22 = r22,

            [Symbol("ymm23")]
            YMM23 = r23,

            [Symbol("ymm24")]
            YMM24 = r24,

            [Symbol("ymm25")]
            YMM25 = r25,

            [Symbol("ymm26")]
            YMM26 = r26,

            [Symbol("ymm27")]
            YMM27 = r27,

            [Symbol("ymm28")]
            YMM28 = r28,

            [Symbol("ymm29")]
            YMM29 = r29,

            [Symbol("ymm30")]
            YMM30 = r30,

            [Symbol("ymm31")]
            YMM31 = r31,
        }
    }
}