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
            al = r0,

            [Symbol("cl")]
            cl = r1,

            [Symbol("dl")]
            dl = r2,

            [Symbol("bl")]
            bl = r3,

            [Symbol("spl")]
            spl = r4,

            [Symbol("bpl")]
            bpl = r5,

            [Symbol("sil")]
            sil = r6,

            [Symbol("dil")]
            dil = r7,

            [Symbol("r8b")]
            r8b = r8,

            [Symbol("r9b")]
            r9b = r9,

            [Symbol("r10b")]
            r10b = r10,

            [Symbol("r11b")]
            r11b = r11,

            [Symbol("r12b")]
            r12b = r12,

            [Symbol("r13b")]
            r13b = r13,

            [Symbol("r14b")]
            r14b = r14,

            [Symbol("r15b")]
            r15b = r15,
        }

        [SymbolSource]
        public enum Gp8Hi : byte
        {
            [Symbol("ah")]
            ah = r0  | r16,

            [Symbol("ch")]
            ch = r1  | r16,

            [Symbol("dh")]
            dh = r2  | r16,

            [Symbol("bh")]
            bh = r3  | r16,
        }

        [SymbolSource]
        public enum Gp16 : byte
        {
            [Symbol("ax")]
            ax = r0,

            [Symbol("cx")]
            cx = r1,

            [Symbol("dx")]
            dx = r2,

            [Symbol("bx")]
            bx = r3,

            [Symbol("sp")]
            sp = r4,

            [Symbol("bp")]
            bp = r5,

            [Symbol("si")]
            si = r6,

            [Symbol("di")]
            di = r7,

            [Symbol("r8w")]
            r8w = r8,

            [Symbol("r9w")]
            r9w = r9,

            [Symbol("r10w")]
            r10w = r10,

            [Symbol("r11w")]
            r11w = r11,

            [Symbol("r12w")]
            r12w = r12,

            [Symbol("r13w")]
            r13w = r13,

            [Symbol("r14w")]
            r14w = r14,

            [Symbol("r15w")]
            r15w = r15,
        }

        [SymbolSource]
        public enum Gp32 : byte
        {
            [Symbol("eax")]
            eax = r0,

            [Symbol("ecx")]
            ecx = r1,

            [Symbol("edx")]
            edx = r2,

            [Symbol("ebx")]
            ebx = r3,

            [Symbol("esp")]
            esp = r4,

            [Symbol("ebp")]
            ebp = r5,

            [Symbol("esi")]
            esi = r6,

            [Symbol("edi")]
            edi = r7,

            [Symbol("r8d")]
            r8d = r8,

            [Symbol("r9d")]
            r9d = r9,

            [Symbol("r10d")]
            r10d = r10,

            [Symbol("r11d")]
            r11d = r11,

            [Symbol("r12d")]
            r12d = r12,

            [Symbol("r13d")]
            r13d = r13,

            [Symbol("r14d")]
            r14d = r14,

            [Symbol("r15d")]
            r15d = r15,
        }

        public enum Gp64 : byte
        {
            [Symbol("rax")]
            rax = r0,

            [Symbol("rcx")]
            rcx = r1,

            [Symbol("rdx")]
            rdx = r2,

            [Symbol("rbx")]
            rbx = r3,

            [Symbol("rsp")]
            rsp = r4,

            [Symbol("rbp")]
            rbp = r5,

            [Symbol("rsi")]
            rsi = r6,

            [Symbol("rdi")]
            rdi = r7,

            [Symbol("r8")]
            r8q = r8,

            [Symbol("r9")]
            r9q = r9,

            [Symbol("r10")]
            r10q = r10,

            [Symbol("r11")]
            r11q = r11,

            [Symbol("r12")]
            r12q = r12,

            [Symbol("r13")]
            r13q = r13,

            [Symbol("r14")]
            r14q = r14,

            [Symbol("r15")]
            r15q = r15,
        }

        /// <summary>
        /// Specifies the XMM registers
        /// </summary>
        [SymbolSource]
        public enum XmmReg : byte
        {
            [Symbol("xmm0")]
            xmm0 = r0,

            [Symbol("xmm1")]
            XMM1 = r1,

            [Symbol("xmm2")]
            xmm2 = r2,

            [Symbol("xmm3")]
            xmm3 = r3,

            [Symbol("xmm4")]
            xmm4 = r4,

            [Symbol("xmm5")]
            xmm5 = r5,

            [Symbol("xmm6")]
            xmm6 = r6,

            [Symbol("xmm7")]
            xmm7 = r7,

            [Symbol("xmm8")]
            xmm8 = r8,

            [Symbol("xmm9")]
            xmm9 = r9,

            [Symbol("xmm10")]
            xmm10 = r10,

            [Symbol("xmm11")]
            xmm11 = r11,

            [Symbol("xmm12")]
            xmm12 = r12,

            [Symbol("xmm13")]
            xmm13 = r13,

            [Symbol("xmm14")]
            xmm14 = r14,

            [Symbol("xmm15")]
            xmm15 = r15,

            [Symbol("xmm16")]
            xmm16 = r16,

            [Symbol("xmm17")]
            xmm17 = r17,

            [Symbol("xmm18")]
            xmm18 = r18,

            [Symbol("xmm19")]
            xmm19 = r19,

            [Symbol("xmm20")]
            xmm20 = r20,

            [Symbol("xmm21")]
            xmm21 = r21,

            [Symbol("xmm22")]
            xmm22 = r22,

            [Symbol("xmm23")]
            xmm23 = r23,

            [Symbol("xmm24")]
            xmm24 = r24,

            [Symbol("xmm25")]
            xmm25 = r25,

            [Symbol("xmm26")]
            xmm26 = r26,

            [Symbol("xmm27")]
            xmm27 = r27,

            [Symbol("xmm28")]
            xmm28 = r28,

            [Symbol("xmm29")]
            xmm29 = r29,

            [Symbol("xmm30")]
            xmm30 = r30,

            [Symbol("xmm31")]
            xmm31 = r31,
        }

        /// <summary>
        /// Specifies the YMM registers
        /// </summary>
        [SymbolSource]
        public enum YmmReg : byte
        {
            [Symbol("ymm0")]
            ymm0 = r0,

            [Symbol("ymm1")]
            ymm1 = r1,

            [Symbol("ymm2")]
            ymm2 = r2,

            [Symbol("ymm3")]
            ymm3 = r3,

            [Symbol("ymm4")]
            ymm4 = r4,

            [Symbol("ymm5")]
            ymm5 = r5,

            [Symbol("ymm6")]
            ymm6 = r6,

            [Symbol("ymm7")]
            ymm7 = r7,

            [Symbol("ymm8")]
            ymm8 = r8,

            [Symbol("ymm9")]
            ymm9 = r9,

            [Symbol("ymm10")]
            ymm10 = r10,

            [Symbol("ymm11")]
            ymm11 = r11,

            [Symbol("ymm12")]
            ymm12 = r12,

            [Symbol("ymm13")]
            ymm13 = r13,

            [Symbol("ymm14")]
            ymm14 = r14,

            [Symbol("ymm15")]
            ymm15 = r15,

            [Symbol("ymm16")]
            ymm16 = r16,

            [Symbol("ymm17")]
            ymm17 = r17,

            [Symbol("ymm18")]
            ymm18 = r18,

            [Symbol("ymm19")]
            ymm19 = r19,

            [Symbol("ymm20")]
            ymm20 = r20,

            [Symbol("ymm21")]
            ymm21 = r21,

            [Symbol("ymm22")]
            ymm22 = r22,

            [Symbol("ymm23")]
            ymm23 = r23,

            [Symbol("ymm24")]
            ymm24 = r24,

            [Symbol("ymm25")]
            ymm25 = r25,

            [Symbol("ymm26")]
            ymm26 = r26,

            [Symbol("ymm27")]
            ymm27 = r27,

            [Symbol("ymm28")]
            ymm28 = r28,

            [Symbol("ymm29")]
            ymm29 = r29,

            [Symbol("ymm30")]
            ymm30 = r30,

            [Symbol("ymm31")]
            ymm31 = r31,
        }

         /// <summary>
        /// Specifies the ZMM registers
        /// </summary>
        [SymbolSource]
        public enum ZmmReg : byte
        {
            [Symbol("zmm0")]
            zmm0 = r0,

            [Symbol("zmm1")]
            zmm1 = r1,

            [Symbol("zmm2")]
            zmm2 = r2,

            [Symbol("zmm3")]
            zmm3 = r3,

            [Symbol("zmm4")]
            zmm4 = r4,

            [Symbol("zmm5")]
            zmm5 = r5,

            [Symbol("zmm6")]
            zmm6 = r6,

            [Symbol("zmm7")]
            zmm7 = r7,

            [Symbol("zmm8")]
            zmm8 = r8,

            [Symbol("zmm9")]
            zmm9 = r9,

            [Symbol("zmm10")]
            zmm10 = r10,

            [Symbol("zmm11")]
            zmm11 = r11,

            [Symbol("zmm12")]
            zmm12 = r12,

            [Symbol("zmm13")]
            zmm13 = r13,

            [Symbol("zmm14")]
            zmm14 = r14,

            [Symbol("zmm15")]
            zmm15 = r15,

            [Symbol("zmm16")]
            zmm16 = r16,

            [Symbol("zmm17")]
            zmm17 = r17,

            [Symbol("zmm18")]
            zmm18 = r18,

            [Symbol("zmm19")]
            zmm19 = r19,

            [Symbol("zmm20")]
            zmm20 = r20,

            [Symbol("zmm21")]
            zmm21 = r21,

            [Symbol("zmm22")]
            zmm22 = r22,

            [Symbol("zmm23")]
            zmm23 = r23,

            [Symbol("zmm24")]
            zmm24 = r24,

            [Symbol("zmm25")]
            zmm25 = r25,

            [Symbol("zmm26")]
            zmm26 = r26,

            [Symbol("zmm27")]
            zmm27 = r27,

            [Symbol("zmm28")]
            zmm28 = r28,

            [Symbol("zmm29")]
            zmm29 = r29,

            [Symbol("zmm30")]
            zmm30 = r30,

            [Symbol("zmm31")]
            zmm31 = r31,
        }

        public enum BndReg : byte
        {
            [Symbol("bnd0")]
            bnd0 = r0,

            [Symbol("bnd1")]
            bnd1 = r1,

            [Symbol("bnd2")]
            bnd2 = r2,

            [Symbol("bnd3")]
            bnd3 = r3,
        }

        /// <summary>
        /// Defines accessible control register indices
        /// </summary>
        [SymbolSource]
        public enum ControlReg : byte
        {
            [Symbol("CR0")]
            cr0 = r0,

            [Symbol("CR1")]
            cr1 = r1,

            [Symbol("CR2")]
            cr2 = r2,

            [Symbol("CR3")]
            cr3 = r3,

            [Symbol("CR4")]
            cr4 = r4,

            [Symbol("CR5")]
            cr5 = r5,

            [Symbol("CR6")]
            cr6 = r6,

            [Symbol("CR7")]
            cr7 = r7,
        }

        /// <summary>
        /// Defines accessible debug register indices
        /// </summary>
        [SymbolSource]
        public enum DebugReg : uint
        {
            [Symbol("DR0")]
            dr0 = r0,

            [Symbol("DR1")]
            dr1 = r1,

            [Symbol("DR2")]
            dr2 = r2,

            [Symbol("DR3")]
            dr3 = r3,

            [Symbol("DR4")]
            dr4 = r4,

            [Symbol("DR5")]
            dr5 = r5,

            [Symbol("DR6")]
            dr6 = r6,

            [Symbol("DR7")]
            dr7 = r7,
        }

        /// <summary>
        /// Defines mask register indices
        /// </summary>
        [SymbolSource]
        public enum KReg : byte
        {
            [Symbol("k0")]
            k0 = r0,

            [Symbol("k1")]
            k1 = r1,

            [Symbol("k2")]
            k2 = r2,

            [Symbol("k3")]
            k3 = r3,

            [Symbol("k4")]
            k4 = r4,

            [Symbol("k5")]
            k5 = r5,

            [Symbol("k6")]
            k6 = r6,

            [Symbol("k7")]
            k7 = r7
        }

        [SymbolSource]
        public enum TestReg : byte
        {
            [Symbol("TR0")]
            tr0 = r0,

            [Symbol("TR1")]
            tr1 = r1,

            [Symbol("TR2")]
            tr2 = r2,

            [Symbol("TR3")]
            tr3 = r3,

            [Symbol("TR4")]
            tr4 = r4,

            [Symbol("TR5")]
            tr5 = r5,

            [Symbol("TR6")]
            tr6 = r6,

            [Symbol("TR7")]
            tr7 = r7
        }

        [SymbolSource]
        public enum FpuReg : byte
        {
            [Symbol("ST(0)")]
            st0 = r0,

            [Symbol("ST(1)")]
            st1 = r1,

            [Symbol("ST(2)")]
            st2 = r2,

            [Symbol("ST(3)")]
            st3 = r3,

            [Symbol("ST(4)")]
            st4 = r4,

            [Symbol("ST(5)")]
            st5 = r5,

            [Symbol("ST(6)")]
            st6 = r6,

            [Symbol("ST(7)")]
            st7 = r7,
        }

        [SymbolSource]
        public enum SegReg : byte
        {
            /// <summary>
            /// Code segment register
            /// </summary>
            [Symbol("cs", "Code segment register")]
            cs = r0,

            /// <summary>
            /// Data segment register
            /// </summary>
            [Symbol("ds", "Data segment register")]
            ds = r1,

            /// <summary>
            /// Stack segment register
            /// </summary>
            [Symbol("ss", "Stack segment register")]
            ss = r2,

            /// <summary>
            /// Extra segment (1)
            /// </summary>
            [Symbol("es", "Extra segment (1)")]
            es = r3,

            /// <summary>
            /// Extra segment (2)
            /// </summary>
            [Symbol("fs","Extra segment (2)")]
            fs = r4,

            /// <summary>
            /// Extra segment (3)
            /// </summary>
            [Symbol("gs","Extra segment (3)")]
            gs = r5,
        }

        [SymbolSource]
        public enum TableReg : byte
        {
            [Symbol("GDTR","The global descriptor table register")]
            gdtr = r0,

            [Symbol("LDTR","The localal descriptor table register")]
            ldtr = r1,

            [Symbol("IDTR","The interrupt descriptor table register")]
            idtr = r2,
        }

        /// <summary>
        /// Specifies the MMX registers
        /// </summary>
        [SymbolSource]
        public enum MmxReg : byte
        {
            [Symbol("mmx0")]
            mm0 = r0,

            [Symbol("mmx1")]
            mm1 = r1,

            [Symbol("mmx2")]
            mm2 = r2,

            [Symbol("mmx3")]
            mm3 = r3,

            [Symbol("mmx4")]
            mm4 = r4,

            [Symbol("mmx5")]
            mm5 = r5,

            [Symbol("mmx6")]
            mm6 = r6,

            [Symbol("mmx7")]
            mm7 = r7,
        }
    }
}