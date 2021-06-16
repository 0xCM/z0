//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    public readonly struct AsmRegCodes
    {
        [SymbolSource]
        public enum Gp8 : byte
        {
            [Symbol("al")]
            AL = r0,

            [Symbol("cl")]
            CL = r1,

            [Symbol("dl")]
            DL = r2,

            [Symbol("bl")]
            BL = r3,

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

        [SymbolSource]
        public enum Gp8Hi : byte
        {
            [Symbol("ah")]
            AH = r0  | r16,

            [Symbol("ch")]
            CH = r1  | r16,

            [Symbol("dh")]
            DH = r2  | r16,

            [Symbol("bh")]
            BH = r3  | r16,
        }

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

        [SymbolSource]
        public enum Gp32 : byte
        {
            [Symbol("eax")]
            EAX = r0,

            [Symbol("ecx")]
            ECX = r1,

            [Symbol("edx")]
            EDX = r2,

            [Symbol("ebx")]
            EBX = r3,

            [Symbol("esp")]
            ESP = r4,

            [Symbol("ebp")]
            EBP = r5,

            [Symbol("esi")]
            ESI = r6,

            [Symbol("edi")]
            EDI = r7,

            [Symbol("r8d")]
            R8D = r8,

            [Symbol("r9d")]
            R9D = r9,

            [Symbol("r10d")]
            R10D = r10,

            [Symbol("r11d")]
            R11D = r11,

            [Symbol("r12d")]
            R12D = r12,

            [Symbol("r13d")]
            R13D = r13,

            [Symbol("r14d")]
            R14D = r14,

            [Symbol("r15d")]
            R15D = r15,
        }

        public enum Gp64 : byte
        {
            [Symbol("rax")]
            RAX = r0,

            [Symbol("rcx")]
            RCX = r1,

            [Symbol("rdx")]
            RDX = r2,

            [Symbol("rbx")]
            RBX = r3,

            [Symbol("rsp")]
            RSP = r4,

            [Symbol("rbp")]
            RBP = r5,

            [Symbol("rsi")]
            RSI = r6,

            [Symbol("rdi")]
            RDI = r7,

            [Symbol("r8")]
            R8Q = r8,

            [Symbol("r9")]
            R9Q = r9,

            [Symbol("r10")]
            R10Q = r10,

            [Symbol("r11")]
            R11Q = r11,

            [Symbol("r12")]
            R12Q = r12,

            [Symbol("r13")]
            R13Q = r13,

            [Symbol("r14")]
            R14Q = r14,

            [Symbol("r15")]
            R15Q = r15,
        }

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

        public enum BndReg : byte
        {
            [Symbol("bnd0")]
            BND0 = r0,

            [Symbol("bnd1")]
            BND1 = r1,

            [Symbol("bnd2")]
            BND2 = r2,

            [Symbol("bnd3")]
            BND3 = r3,
        }

        /// <summary>
        /// Defines accessible control register indices
        /// </summary>
        [SymbolSource]
        public enum ControlReg : byte
        {
            [Symbol("CR0")]
            CR0 = r0,

            [Symbol("CR1")]
            CR1 = r1,

            [Symbol("CR2")]
            CR2 = r2,

            [Symbol("CR3")]
            CR3 = r3,

            [Symbol("CR4")]
            CR4 = r4,

            [Symbol("CR5")]
            CR5 = r5,

            [Symbol("CR6")]
            CR6 = r6,

            [Symbol("CR7")]
            CR7 = r7,
        }

        /// <summary>
        /// Defines accessible debug register indices
        /// </summary>
        [SymbolSource]
        public enum DebugReg : uint
        {
            [Symbol("DR0")]
            DR0 = r0,

            [Symbol("DR1")]
            DR1 = r1,

            [Symbol("DR2")]
            DR2 = r2,

            [Symbol("DR3")]
            DR3 = r3,

            [Symbol("DR4")]
            DR4 = r4,

            [Symbol("DR5")]
            DR5 = r5,

            [Symbol("DR6")]
            DR6 = r6,

            [Symbol("DR7")]
            DR7 = r7,
        }

        /// <summary>
        /// Defines mask register indices
        /// </summary>
        [SymbolSource]
        public enum KReg : byte
        {
            [Symbol("k0")]
            K0 = r0,

            [Symbol("k1")]
            K1 = r1,

            [Symbol("k2")]
            K2 = r2,

            [Symbol("k3")]
            K3 = r3,

            [Symbol("k4")]
            K4 = r4,

            [Symbol("k5")]
            K5 = r5,

            [Symbol("k6")]
            K6 = r6,

            [Symbol("k7")]
            K7 = r7
        }

        [SymbolSource]
        public enum TestReg : byte
        {
            [Symbol("TR0")]
            TR0 = r0,

            [Symbol("TR1")]
            TR1 = r1,

            [Symbol("TR2")]
            TR2 = r2,

            [Symbol("TR3")]
            TR3 = r3,

            [Symbol("TR4")]
            TR4 = r4,

            [Symbol("TR5")]
            TR5 = r5,

            [Symbol("TR6")]
            TR6 = r6,

            [Symbol("TR7")]
            TR7 = r7
        }

        [SymbolSource]
        public enum FpuReg : byte
        {
            [Symbol("ST(0)")]
            ST0 = r0,

            [Symbol("ST(1)")]
            ST1 = r1,

            [Symbol("ST(2)")]
            ST2 = r2,

            [Symbol("ST(3)")]
            ST3 = r3,

            [Symbol("ST(4)")]
            ST4 = r4,

            [Symbol("ST(5)")]
            ST5 = r5,

            [Symbol("ST(6)")]
            ST6 = r6,

            [Symbol("ST(7)")]
            ST7 = r7,
        }

        [SymbolSource]
        public enum SegReg : byte
        {
            /// <summary>
            /// Code segment register
            /// </summary>
            [Symbol("cs", "Code segment register")]
            CS = r0,

            /// <summary>
            /// Data segment register
            /// </summary>
            [Symbol("ds", "Data segment register")]
            DS = r1,

            /// <summary>
            /// Stack segment register
            /// </summary>
            [Symbol("ss", "Stack segment register")]
            SS = r2,

            /// <summary>
            /// Extra segment (1)
            /// </summary>
            [Symbol("es", "Extra segment (1)")]
            ES = r3,

            /// <summary>
            /// Extra segment (2)
            /// </summary>
            [Symbol("fs","Extra segment (2)")]
            FS = r4,

            /// <summary>
            /// Extra segment (3)
            /// </summary>
            [Symbol("gs","Extra segment (3)")]
            GS = r5,
        }

        [SymbolSource]
        public enum TableReg : byte
        {
            [Symbol("GDTR","The global descriptor table register")]
            GDTR = r0,

            [Symbol("LDTR","The localal descriptor table register")]
            LDTR = r1,

            [Symbol("IDTR","The interrupt descriptor table register")]
            IDTR = r2,
        }

        /// <summary>
        /// Specifies the MMX registers
        /// </summary>
        [SymbolSource]
        public enum MmxReg : byte
        {
            [Symbol("mmx0")]
            MM0 = r0,

            [Symbol("mmx1")]
            MM1 = r1,

            [Symbol("mmx2")]
            MM2 = r2,

            [Symbol("mmx3")]
            MM3 = r3,

            [Symbol("mmx4")]
            MM4 = r4,

            [Symbol("mmx5")]
            MM5 = r5,

            [Symbol("mmx6")]
            MM6 = r6,

            [Symbol("mmx7")]
            MM7 = r7,
        }
    }
}