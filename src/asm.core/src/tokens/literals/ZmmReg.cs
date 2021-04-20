//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    partial struct AsmTokens
    {
        /// <summary>
        /// Specifies the ZMM registers
        /// </summary>
        [SymbolSource]
        public enum ZmmReg : byte
        {
            [Symbol("zmm0")]
            ZMM0 = r0,

            [Symbol("zmm1")]
            ZMM1 = r1,

            [Symbol("zmm2")]
            ZMM2 = r2,

            [Symbol("zmm3")]
            ZMM3 = r3,

            [Symbol("zmm4")]
            ZMM4 = r4,

            [Symbol("zmm5")]
            ZMM5 = r5,

            [Symbol("zmm6")]
            ZMM6 = r6,

            [Symbol("zmm7")]
            ZMM7 = r7,

            [Symbol("zmm8")]
            ZMM8 = r8,

            [Symbol("zmm9")]
            ZMM9 = r9,

            [Symbol("zmm10")]
            ZMM10 = r10,

            [Symbol("zmm11")]
            ZMM11 = r11,

            [Symbol("zmm12")]
            ZMM12 = r12,

            [Symbol("zmm13")]
            ZMM13 = r13,

            [Symbol("zmm14")]
            ZMM14 = r14,

            [Symbol("zmm15")]
            ZMM15 = r15,

            [Symbol("zmm16")]
            ZMM16 = r16,

            [Symbol("zmm17")]
            ZMM17 = r17,

            [Symbol("zmm18")]
            ZMM18 = r18,

            [Symbol("zmm19")]
            ZMM19 = r19,

            [Symbol("zmm20")]
            ZMM20 = r20,

            [Symbol("zmm21")]
            ZMM21 = r21,

            [Symbol("zmm22")]
            ZMM22 = r22,

            [Symbol("zmm23")]
            ZMM23 = r23,

            [Symbol("zmm24")]
            ZMM24 = r24,

            [Symbol("zmm25")]
            ZMM25 = r25,

            [Symbol("zmm26")]
            ZMM26 = r26,

            [Symbol("zmm27")]
            ZMM27 = r27,

            [Symbol("zmm28")]
            ZMM28 = r28,

            [Symbol("zmm29")]
            ZMM29 = r29,

            [Symbol("zmm30")]
            ZMM30 = r30,

            [Symbol("zmm31")]
            ZMM31 = r31,
        }
    }
}