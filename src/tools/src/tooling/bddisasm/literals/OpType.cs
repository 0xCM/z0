//-----------------------------------------------------------------------------
// Copyright   : 2020 Bitdefender
// License     : Apache-2.0
// Source      : generate_tables.py
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using static BdDisasm.OpTypeSymbols;

    partial class BdDisasm
    {
        [LiteralProvider]
        internal readonly struct OpTypeSymbols
        {
            public const string A = "A";

            public const string B = "B";

            public const string C = "C";

            public const string D = "D";

            public const string E = "E";

            public const string F = "F";

            public const string G = "G";

            public const string H = "H";

            public const string I = "I";

            public const string J = "J";

            public const string K = "K";

            public const string L = "L";

            public const string M = "M";

            public const string N = "N";

            public const string O = "O";

            public const string P = "P";
        }

        [SymbolSource]
        public enum OpType : byte
        {
            [Symbol(A)]
            ND_OPT_A,

            [Symbol(B)]
            ND_OPT_B,

            [Symbol(C)]
            ND_OPT_C,

            [Symbol(D)]
            ND_OPT_D,

            [Symbol(E)]
            ND_OPT_E,

            [Symbol(F)]
            ND_OPT_F,

            [Symbol(G)]
            ND_OPT_G,

            [Symbol(H)]
            ND_OPT_H,

            [Symbol(I)]
            ND_OPT_I,

            [Symbol(J)]
            ND_OPT_J,

            [Symbol(K)]
            ND_OPT_K,

            [Symbol(L)]
            ND_OPT_L,

            [Symbol("M")]
            ND_OPT_M,

            [Symbol("N")]
            ND_OPT_N,

            [Symbol("O")]
            ND_OPT_O,

            [Symbol("P")]
            ND_OPT_P,

            [Symbol("Q")]
            ND_OPT_Q,

            [Symbol("R")]
            ND_OPT_R,

            [Symbol("S")]
            ND_OPT_S,

            [Symbol("T")]
            ND_OPT_T,

            [Symbol("U")]
            ND_OPT_U,

            [Symbol("V")]
            ND_OPT_V,

            [Symbol("W")]
            ND_OPT_W,

            [Symbol("X")]
            ND_OPT_X,

            [Symbol("Y")]
            ND_OPT_Y,

            [Symbol("Z")]
            ND_OPT_Z,

            [Symbol("rB")]
            ND_OPT_rB,

            [Symbol("mB")]
            ND_OPT_mB,

            [Symbol("rK")]
            ND_OPT_rK,

            [Symbol("vK")]
            ND_OPT_vK,

            [Symbol("mK")]
            ND_OPT_mK,

            [Symbol("aK")]
            ND_OPT_aK,

            [Symbol("rM")]
            ND_OPT_rM,

            [Symbol("mM")]
            ND_OPT_mM,

            [Symbol("rT")]
            ND_OPT_rT,

            [Symbol("mT")]
            ND_OPT_mT,

            [Symbol("vT")]
            ND_OPT_vT,

            [Symbol("1")]
            ND_OPT_CONST_1,

            [Symbol("AH")]
            ND_OPT_GPR_AH,

            [Symbol("rAX")]
            ND_OPT_GPR_rAX,

            [Symbol("rCX")]
            ND_OPT_GPR_rCX,

            [Symbol("rDX")]
            ND_OPT_GPR_rDX,

            [Symbol("rBX")]
            ND_OPT_GPR_rBX,

            [Symbol("rSP")]
            ND_OPT_GPR_rSP,

            [Symbol("rBP")]
            ND_OPT_GPR_rBP,

            [Symbol("rSI")]
            ND_OPT_GPR_rSI,

            [Symbol("rDI")]
            ND_OPT_GPR_rDI,

            [Symbol("rR8")]
            ND_OPT_GPR_rR8,

            [Symbol("rR9")]
            ND_OPT_GPR_rR9,

            [Symbol("rR11")]
            ND_OPT_GPR_rR11,

            [Symbol("rIP")]
            ND_OPT_RIP,

            [Symbol("CS")]
            ND_OPT_SEG_CS,

            [Symbol("SS")]
            ND_OPT_SEG_SS,

            [Symbol("DS")]
            ND_OPT_SEG_DS,

            [Symbol("ES")]
            ND_OPT_SEG_ES,

            [Symbol("FS")]
            ND_OPT_SEG_FS,

            [Symbol("GS")]
            ND_OPT_SEG_GS,

            [Symbol("ST(0)")]
            ND_OPT_FPU_ST0,

            [Symbol("ST(i)")]
            ND_OPT_FPU_STX,

            [Symbol("XMM0")]
            ND_OPT_SSE_XMM0,

            [Symbol("XMM1")]
            ND_OPT_SSE_XMM1,

            [Symbol("XMM2")]
            ND_OPT_SSE_XMM2,

            [Symbol("XMM3")]
            ND_OPT_SSE_XMM3,

            [Symbol("XMM4")]
            ND_OPT_SSE_XMM4,

            [Symbol("XMM5")]
            ND_OPT_SSE_XMM5,

            [Symbol("XMM6")]
            ND_OPT_SSE_XMM6,

            [Symbol("XMM7")]
            ND_OPT_SSE_XMM7,

            [Symbol("pBXAL")]
            ND_OPT_MEM_rBX_AL,

            [Symbol("pDI")]
            ND_OPT_MEM_rDI,

            [Symbol("SHS")]
            ND_OPT_MEM_SHS,

            [Symbol("SHS0")]
            ND_OPT_MEM_SHS0,

            [Symbol("SHSP")]
            ND_OPT_MEM_SHSP,

            [Symbol("m2zI")]
            ND_OPT_Im2z,

            [Symbol("GDTR")]
            ND_OPT_SYS_GDTR,

            [Symbol("IDTR")]
            ND_OPT_SYS_IDTR,

            [Symbol("LDTR")]
            ND_OPT_SYS_LDTR,

            [Symbol("TR")]
            ND_OPT_SYS_TR,

            [Symbol("CR0")]
            ND_OPT_CR_0,

            [Symbol("XCR")]
            ND_OPT_XCR,

            [Symbol("XCR0")]
            ND_OPT_XCR_0,

            [Symbol("MSR")]
            ND_OPT_MSR,

            [Symbol("FSBASE")]
            ND_OPT_MSR_FSBASE,

            [Symbol("GSBASE")]
            ND_OPT_MSR_GSBASE,

            [Symbol("KGSBASE")]
            ND_OPT_MSR_KGSBASE,

            [Symbol("SCS")]
            ND_OPT_MSR_SCS,

            [Symbol("SEIP")]
            ND_OPT_MSR_SEIP,

            [Symbol("SESP")]
            ND_OPT_MSR_SESP,

            [Symbol("TSC")]
            ND_OPT_MSR_TSC,

            [Symbol("TSCAUX")]
            ND_OPT_MSR_TSCAUX,

            [Symbol("STAR")]
            ND_OPT_MSR_STAR,

            [Symbol("LSTAR")]
            ND_OPT_MSR_LSTAR,

            [Symbol("FMASK")]
            ND_OPT_MSR_FMASK,

            [Symbol("BANK")]
            ND_OPT_REG_BANK,

            [Symbol("X87CONTROL")]
            ND_OPT_X87_CONTROL,

            [Symbol("X87TAG")]
            ND_OPT_X87_TAG,

            [Symbol("X87STATUS")]
            ND_OPT_X87_STATUS,

            [Symbol("MXCSR")]
            ND_OPT_MXCSR,

            [Symbol("PKRU")]
            ND_OPT_PKRU,

            [Symbol("SSP")]
            ND_OPT_SSP,

            [Symbol("UIF")]
            ND_OPT_UIF
        }
    }
}