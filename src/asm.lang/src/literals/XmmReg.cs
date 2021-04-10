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
        /// Specifies the XMM registers
        /// </summary>
        [SymbolSource]
        public enum XmmReg : byte
        {
            [Symbol("xmm0")]
            XMM0 = r0,

            [Symbol("xmm1")]
            XMM1 = r1,

            [Symbol("xmm2")]
            XMM2 = r2,

            [Symbol("xmm3")]
            XMM3 = r3,

            [Symbol("xmm4")]
            XMM4 = r4,

            [Symbol("xmm5")]
            XMM5 = r5,

            [Symbol("xmm6")]
            XMM6 = r6,

            [Symbol("xmm7")]
            XMM7 = r7,

            [Symbol("xmm8")]
            XMM8 = r8,

            [Symbol("xmm9")]
            XMM9 = r9,

            [Symbol("xmm10")]
            XMM10 = r10,

            [Symbol("xmm11")]
            XMM11 = r11,

            [Symbol("xmm12")]
            XMM12 = r12,

            [Symbol("xmm13")]
            XMM13 = r13,

            [Symbol("xmm14")]
            XMM14 = r14,

            [Symbol("xmm15")]
            XMM15 = r15,

            [Symbol("xmm16")]
            XMM16 = r16,

            [Symbol("xmm17")]
            XMM17 = r17,

            [Symbol("xmm18")]
            XMM18 = r18,

            [Symbol("xmm19")]
            XMM19 = r19,

            [Symbol("xmm20")]
            XMM20 = r20,

            [Symbol("xmm21")]
            XMM21 = r21,

            [Symbol("xmm22")]
            XMM22 = r22,

            [Symbol("xmm23")]
            XMM23 = r23,

            [Symbol("xmm24")]
            XMM24 = r24,

            [Symbol("xmm25")]
            XMM25 = r25,

            [Symbol("xmm26")]
            XMM26 = r26,

            [Symbol("xmm27")]
            XMM27 = r27,

            [Symbol("xmm28")]
            XMM28 = r28,

            [Symbol("xmm29")]
            XMM29 = r29,

            [Symbol("xmm30")]
            XMM30 = r30,

            [Symbol("xmm31")]
            XMM31 = r31,
        }

    }
}