//-----------------------------------------------------------------------------
// Generated   :  2021-04-09.14.40.58.8883
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum AsmMnemonicCode : ushort
    {
        None = 0,

        [Symbol("aaa")]
        AAA = 1,

        [Symbol("aad")]
        AAD = 2,

        [Symbol("aam")]
        AAM = 3,

        [Symbol("aas")]
        AAS = 4,

        [Symbol("adc")]
        ADC = 5,

        [Symbol("add")]
        ADD = 6,

        [Symbol("addpd")]
        ADDPD = 7,

        [Symbol("vaddpd")]
        VADDPD = 8,

        [Symbol("addps")]
        ADDPS = 9,

        [Symbol("vaddps")]
        VADDPS = 10,

        [Symbol("addsd")]
        ADDSD = 11,

        [Symbol("vaddsd")]
        VADDSD = 12,

        [Symbol("addss")]
        ADDSS = 13,

        [Symbol("vaddss")]
        VADDSS = 14,

        [Symbol("addsubpd")]
        ADDSUBPD = 15,

        [Symbol("vaddsubpd")]
        VADDSUBPD = 16,

        [Symbol("addsubps")]
        ADDSUBPS = 17,

        [Symbol("vaddsubps")]
        VADDSUBPS = 18,

        [Symbol("aesdec")]
        AESDEC = 19,

        [Symbol("vaesdec")]
        VAESDEC = 20,

        [Symbol("aesdeclast")]
        AESDECLAST = 21,

        [Symbol("vaesdeclast")]
        VAESDECLAST = 22,

        [Symbol("aesenc")]
        AESENC = 23,

        [Symbol("vaesenc")]
        VAESENC = 24,

        [Symbol("aesenclast")]
        AESENCLAST = 25,

        [Symbol("vaesenclast")]
        VAESENCLAST = 26,

        [Symbol("aesimc")]
        AESIMC = 27,

        [Symbol("vaesimc")]
        VAESIMC = 28,

        [Symbol("aeskeygenassist")]
        AESKEYGENASSIST = 29,

        [Symbol("vaeskeygenassist")]
        VAESKEYGENASSIST = 30,

        [Symbol("and")]
        AND = 31,

        [Symbol("andn")]
        ANDN = 32,

        [Symbol("andpd")]
        ANDPD = 33,

        [Symbol("vandpd")]
        VANDPD = 34,

        [Symbol("andps")]
        ANDPS = 35,

        [Symbol("vandps")]
        VANDPS = 36,

        [Symbol("andnpd")]
        ANDNPD = 37,

        [Symbol("vandnpd")]
        VANDNPD = 38,

        [Symbol("andnps")]
        ANDNPS = 39,

        [Symbol("vandnps")]
        VANDNPS = 40,

        [Symbol("arpl")]
        ARPL = 41,

        [Symbol("blendpd")]
        BLENDPD = 42,

        [Symbol("vblendpd")]
        VBLENDPD = 43,

        [Symbol("bextr")]
        BEXTR = 44,

        [Symbol("blendps")]
        BLENDPS = 45,

        [Symbol("vblendps")]
        VBLENDPS = 46,

        [Symbol("blendvpd")]
        BLENDVPD = 47,

        [Symbol("vblendvpd")]
        VBLENDVPD = 48,

        [Symbol("blendvps")]
        BLENDVPS = 49,

        [Symbol("vblendvps")]
        VBLENDVPS = 50,

        [Symbol("blsi")]
        BLSI = 51,

        [Symbol("blsmsk")]
        BLSMSK = 52,

        [Symbol("blsr")]
        BLSR = 53,

        [Symbol("bound")]
        BOUND = 54,

        [Symbol("bsf")]
        BSF = 55,

        [Symbol("bsr")]
        BSR = 56,

        [Symbol("bswap")]
        BSWAP = 57,

        [Symbol("bt")]
        BT = 58,

        [Symbol("btc")]
        BTC = 59,

        [Symbol("btr")]
        BTR = 60,

        [Symbol("bts")]
        BTS = 61,

        [Symbol("bzhi")]
        BZHI = 62,

        [Symbol("call")]
        CALL = 63,

        [Symbol("cbw")]
        CBW = 64,

        [Symbol("cwde")]
        CWDE = 65,

        [Symbol("cdqe")]
        CDQE = 66,

        [Symbol("clc")]
        CLC = 67,

        [Symbol("cld")]
        CLD = 68,

        [Symbol("clflush")]
        CLFLUSH = 69,

        [Symbol("cli")]
        CLI = 70,

        [Symbol("clts")]
        CLTS = 71,

        [Symbol("cmc")]
        CMC = 72,

        [Symbol("cmova")]
        CMOVA = 73,

        [Symbol("cmovae")]
        CMOVAE = 74,

        [Symbol("cmovb")]
        CMOVB = 75,

        [Symbol("cmovbe")]
        CMOVBE = 76,

        [Symbol("cmovc")]
        CMOVC = 77,

        [Symbol("cmove")]
        CMOVE = 78,

        [Symbol("cmovg")]
        CMOVG = 79,

        [Symbol("cmovge")]
        CMOVGE = 80,

        [Symbol("cmovl")]
        CMOVL = 81,

        [Symbol("cmovle")]
        CMOVLE = 82,

        [Symbol("cmovna")]
        CMOVNA = 83,

        [Symbol("cmovnae")]
        CMOVNAE = 84,

        [Symbol("cmovnb")]
        CMOVNB = 85,

        [Symbol("cmovnbe")]
        CMOVNBE = 86,

        [Symbol("cmovnc")]
        CMOVNC = 87,

        [Symbol("cmovne")]
        CMOVNE = 88,

        [Symbol("cmovng")]
        CMOVNG = 89,

        [Symbol("cmovnge")]
        CMOVNGE = 90,

        [Symbol("cmovnl")]
        CMOVNL = 91,

        [Symbol("cmovnle")]
        CMOVNLE = 92,

        [Symbol("cmovno")]
        CMOVNO = 93,

        [Symbol("cmovnp")]
        CMOVNP = 94,

        [Symbol("cmovns")]
        CMOVNS = 95,

        [Symbol("cmovnz")]
        CMOVNZ = 96,

        [Symbol("cmovo")]
        CMOVO = 97,

        [Symbol("cmovp")]
        CMOVP = 98,

        [Symbol("cmovpe")]
        CMOVPE = 99,

        [Symbol("cmovpo")]
        CMOVPO = 100,

        [Symbol("cmovs")]
        CMOVS = 101,

        [Symbol("cmovz")]
        CMOVZ = 102,

        [Symbol("cmp")]
        CMP = 103,

        [Symbol("cmppd")]
        CMPPD = 104,

        [Symbol("vcmppd")]
        VCMPPD = 105,

        [Symbol("cmpps")]
        CMPPS = 106,

        [Symbol("vcmpps")]
        VCMPPS = 107,

        [Symbol("cmps")]
        CMPS = 108,

        [Symbol("cmpsb")]
        CMPSB = 109,

        [Symbol("cmpsw")]
        CMPSW = 110,

        [Symbol("cmpsd")]
        CMPSD = 111,

        [Symbol("cmpsq")]
        CMPSQ = 112,

        [Symbol("vcmpsd")]
        VCMPSD = 113,

        [Symbol("cmpss")]
        CMPSS = 114,

        [Symbol("vcmpss")]
        VCMPSS = 115,

        [Symbol("cmpxchg")]
        CMPXCHG = 116,

        [Symbol("cmpxchg8b")]
        CMPXCHG8B = 117,

        [Symbol("cmpxchg16b")]
        CMPXCHG16B = 118,

        [Symbol("comisd")]
        COMISD = 119,

        [Symbol("vcomisd")]
        VCOMISD = 120,

        [Symbol("comiss")]
        COMISS = 121,

        [Symbol("vcomiss")]
        VCOMISS = 122,

        [Symbol("cpuid")]
        CPUID = 123,

        [Symbol("crc32")]
        CRC32 = 124,

        [Symbol("cvtdq2pd")]
        CVTDQ2PD = 125,

        [Symbol("vcvtdq2pd")]
        VCVTDQ2PD = 126,

        [Symbol("cvtdq2ps")]
        CVTDQ2PS = 127,

        [Symbol("vcvtdq2ps")]
        VCVTDQ2PS = 128,

        [Symbol("cvtpd2dq")]
        CVTPD2DQ = 129,

        [Symbol("vcvtpd2dq")]
        VCVTPD2DQ = 130,

        [Symbol("cvtpd2pi")]
        CVTPD2PI = 131,

        [Symbol("cvtpd2ps")]
        CVTPD2PS = 132,

        [Symbol("vcvtpd2ps")]
        VCVTPD2PS = 133,

        [Symbol("cvtpi2pd")]
        CVTPI2PD = 134,

        [Symbol("cvtpi2ps")]
        CVTPI2PS = 135,

        [Symbol("cvtps2dq")]
        CVTPS2DQ = 136,

        [Symbol("vcvtps2dq")]
        VCVTPS2DQ = 137,

        [Symbol("cvtps2pd")]
        CVTPS2PD = 138,

        [Symbol("vcvtps2pd")]
        VCVTPS2PD = 139,

        [Symbol("cvtps2pi")]
        CVTPS2PI = 140,

        [Symbol("cvtsd2si")]
        CVTSD2SI = 141,

        [Symbol("vcvtsd2si")]
        VCVTSD2SI = 142,

        [Symbol("cvtsd2ss")]
        CVTSD2SS = 143,

        [Symbol("vcvtsd2ss")]
        VCVTSD2SS = 144,

        [Symbol("cvtsi2sd")]
        CVTSI2SD = 145,

        [Symbol("vcvtsi2sd")]
        VCVTSI2SD = 146,

        [Symbol("cvtsi2ss")]
        CVTSI2SS = 147,

        [Symbol("vcvtsi2ss")]
        VCVTSI2SS = 148,

        [Symbol("cvtss2sd")]
        CVTSS2SD = 149,

        [Symbol("vcvtss2sd")]
        VCVTSS2SD = 150,

        [Symbol("cvtss2si")]
        CVTSS2SI = 151,

        [Symbol("vcvtss2si")]
        VCVTSS2SI = 152,

        [Symbol("cvttpd2dq")]
        CVTTPD2DQ = 153,

        [Symbol("vcvttpd2dq")]
        VCVTTPD2DQ = 154,

        [Symbol("cvttpd2pi")]
        CVTTPD2PI = 155,

        [Symbol("cvttps2dq")]
        CVTTPS2DQ = 156,

        [Symbol("vcvttps2dq")]
        VCVTTPS2DQ = 157,

        [Symbol("cvttps2pi")]
        CVTTPS2PI = 158,

        [Symbol("cvttsd2si")]
        CVTTSD2SI = 159,

        [Symbol("vcvttsd2si")]
        VCVTTSD2SI = 160,

        [Symbol("cvttss2si")]
        CVTTSS2SI = 161,

        [Symbol("vcvttss2si")]
        VCVTTSS2SI = 162,

        [Symbol("cwd")]
        CWD = 163,

        [Symbol("cdq")]
        CDQ = 164,

        [Symbol("cqo")]
        CQO = 165,

        [Symbol("daa")]
        DAA = 166,

        [Symbol("das")]
        DAS = 167,

        [Symbol("dec")]
        DEC = 168,

        [Symbol("div")]
        DIV = 169,

        [Symbol("divpd")]
        DIVPD = 170,

        [Symbol("vdivpd")]
        VDIVPD = 171,

        [Symbol("divps")]
        DIVPS = 172,

        [Symbol("vdivps")]
        VDIVPS = 173,

        [Symbol("divsd")]
        DIVSD = 174,

        [Symbol("vdivsd")]
        VDIVSD = 175,

        [Symbol("divss")]
        DIVSS = 176,

        [Symbol("vdivss")]
        VDIVSS = 177,

        [Symbol("dppd")]
        DPPD = 178,

        [Symbol("vdppd")]
        VDPPD = 179,

        [Symbol("dpps")]
        DPPS = 180,

        [Symbol("vdpps")]
        VDPPS = 181,

        [Symbol("emms")]
        EMMS = 182,

        [Symbol("enter")]
        ENTER = 183,

        [Symbol("extractps")]
        EXTRACTPS = 184,

        [Symbol("vextractps")]
        VEXTRACTPS = 185,

        [Symbol("f2xm1")]
        F2XM1 = 186,

        [Symbol("fabs")]
        FABS = 187,

        [Symbol("fadd")]
        FADD = 188,

        [Symbol("faddp")]
        FADDP = 189,

        [Symbol("fiadd")]
        FIADD = 190,

        [Symbol("fbld")]
        FBLD = 191,

        [Symbol("fbstp")]
        FBSTP = 192,

        [Symbol("fchs")]
        FCHS = 193,

        [Symbol("fclex")]
        FCLEX = 194,

        [Symbol("fnclex")]
        FNCLEX = 195,

        [Symbol("fcmovb")]
        FCMOVB = 196,

        [Symbol("fcmove")]
        FCMOVE = 197,

        [Symbol("fcmovbe")]
        FCMOVBE = 198,

        [Symbol("fcmovu")]
        FCMOVU = 199,

        [Symbol("fcmovnb")]
        FCMOVNB = 200,

        [Symbol("fcmovne")]
        FCMOVNE = 201,

        [Symbol("fcmovnbe")]
        FCMOVNBE = 202,

        [Symbol("fcmovnu")]
        FCMOVNU = 203,

        [Symbol("fcom")]
        FCOM = 204,

        [Symbol("fcomp")]
        FCOMP = 205,

        [Symbol("fcompp")]
        FCOMPP = 206,

        [Symbol("fcomi")]
        FCOMI = 207,

        [Symbol("fcomip")]
        FCOMIP = 208,

        [Symbol("fucomi")]
        FUCOMI = 209,

        [Symbol("fucomip")]
        FUCOMIP = 210,

        [Symbol("fcos")]
        FCOS = 211,

        [Symbol("fdecstp")]
        FDECSTP = 212,

        [Symbol("fdiv")]
        FDIV = 213,

        [Symbol("fdivp")]
        FDIVP = 214,

        [Symbol("fidiv")]
        FIDIV = 215,

        [Symbol("fdivr")]
        FDIVR = 216,

        [Symbol("fdivrp")]
        FDIVRP = 217,

        [Symbol("fidivr")]
        FIDIVR = 218,

        [Symbol("ffree")]
        FFREE = 219,

        [Symbol("ficom")]
        FICOM = 220,

        [Symbol("ficomp")]
        FICOMP = 221,

        [Symbol("fild")]
        FILD = 222,

        [Symbol("fincstp")]
        FINCSTP = 223,

        [Symbol("finit")]
        FINIT = 224,

        [Symbol("fninit")]
        FNINIT = 225,

        [Symbol("fist")]
        FIST = 226,

        [Symbol("fistp")]
        FISTP = 227,

        [Symbol("fisttp")]
        FISTTP = 228,

        [Symbol("fld")]
        FLD = 229,

        [Symbol("fld1")]
        FLD1 = 230,

        [Symbol("fldl2t")]
        FLDL2T = 231,

        [Symbol("fldl2e")]
        FLDL2E = 232,

        [Symbol("fldpi")]
        FLDPI = 233,

        [Symbol("fldlg2")]
        FLDLG2 = 234,

        [Symbol("fldln2")]
        FLDLN2 = 235,

        [Symbol("fldz")]
        FLDZ = 236,

        [Symbol("fldcw")]
        FLDCW = 237,

        [Symbol("fldenv")]
        FLDENV = 238,

        [Symbol("fmul")]
        FMUL = 239,

        [Symbol("fmulp")]
        FMULP = 240,

        [Symbol("fimul")]
        FIMUL = 241,

        [Symbol("fnop")]
        FNOP = 242,

        [Symbol("fpatan")]
        FPATAN = 243,

        [Symbol("fprem")]
        FPREM = 244,

        [Symbol("fprem1")]
        FPREM1 = 245,

        [Symbol("fptan")]
        FPTAN = 246,

        [Symbol("frndint")]
        FRNDINT = 247,

        [Symbol("frstor")]
        FRSTOR = 248,

        [Symbol("fsave")]
        FSAVE = 249,

        [Symbol("fnsave")]
        FNSAVE = 250,

        [Symbol("fscale")]
        FSCALE = 251,

        [Symbol("fsin")]
        FSIN = 252,

        [Symbol("fsincos")]
        FSINCOS = 253,

        [Symbol("fsqrt")]
        FSQRT = 254,

        [Symbol("fst")]
        FST = 255,

        [Symbol("fstp")]
        FSTP = 256,

        [Symbol("fstcw")]
        FSTCW = 257,

        [Symbol("fnstcw")]
        FNSTCW = 258,

        [Symbol("fstenv")]
        FSTENV = 259,

        [Symbol("fnstenv")]
        FNSTENV = 260,

        [Symbol("fstsw")]
        FSTSW = 261,

        [Symbol("fnstsw")]
        FNSTSW = 262,

        [Symbol("fsub")]
        FSUB = 263,

        [Symbol("fsubp")]
        FSUBP = 264,

        [Symbol("fisub")]
        FISUB = 265,

        [Symbol("fsubr")]
        FSUBR = 266,

        [Symbol("fsubrp")]
        FSUBRP = 267,

        [Symbol("fisubr")]
        FISUBR = 268,

        [Symbol("ftst")]
        FTST = 269,

        [Symbol("fucom")]
        FUCOM = 270,

        [Symbol("fucomp")]
        FUCOMP = 271,

        [Symbol("fucompp")]
        FUCOMPP = 272,

        [Symbol("fxam")]
        FXAM = 273,

        [Symbol("fxch")]
        FXCH = 274,

        [Symbol("fxrstor")]
        FXRSTOR = 275,

        [Symbol("fxrstor64")]
        FXRSTOR64 = 276,

        [Symbol("fxsave")]
        FXSAVE = 277,

        [Symbol("fxsave64")]
        FXSAVE64 = 278,

        [Symbol("fxtract")]
        FXTRACT = 279,

        [Symbol("fyl2x")]
        FYL2X = 280,

        [Symbol("fyl2xp1")]
        FYL2XP1 = 281,

        [Symbol("haddpd")]
        HADDPD = 282,

        [Symbol("vhaddpd")]
        VHADDPD = 283,

        [Symbol("haddps")]
        HADDPS = 284,

        [Symbol("vhaddps")]
        VHADDPS = 285,

        [Symbol("hlt")]
        HLT = 286,

        [Symbol("hsubpd")]
        HSUBPD = 287,

        [Symbol("vhsubpd")]
        VHSUBPD = 288,

        [Symbol("hsubps")]
        HSUBPS = 289,

        [Symbol("vhsubps")]
        VHSUBPS = 290,

        [Symbol("idiv")]
        IDIV = 291,

        [Symbol("imul")]
        IMUL = 292,

        [Symbol("in")]
        IN = 293,

        [Symbol("inc")]
        INC = 294,

        [Symbol("ins")]
        INS = 295,

        [Symbol("insb")]
        INSB = 296,

        [Symbol("insw")]
        INSW = 297,

        [Symbol("insd")]
        INSD = 298,

        [Symbol("insertps")]
        INSERTPS = 299,

        [Symbol("vinsertps")]
        VINSERTPS = 300,

        [Symbol("int")]
        INT = 301,

        [Symbol("into")]
        INTO = 302,

        [Symbol("invd")]
        INVD = 303,

        [Symbol("invlpg")]
        INVLPG = 304,

        [Symbol("invpcid")]
        INVPCID = 305,

        [Symbol("iret")]
        IRET = 306,

        [Symbol("iretd")]
        IRETD = 307,

        [Symbol("iretq")]
        IRETQ = 308,

        [Symbol("ja")]
        JA = 309,

        [Symbol("jae")]
        JAE = 310,

        [Symbol("jb")]
        JB = 311,

        [Symbol("jbe")]
        JBE = 312,

        [Symbol("jc")]
        JC = 313,

        [Symbol("jcxz")]
        JCXZ = 314,

        [Symbol("jecxz")]
        JECXZ = 315,

        [Symbol("jrcxz")]
        JRCXZ = 316,

        [Symbol("je")]
        JE = 317,

        [Symbol("jg")]
        JG = 318,

        [Symbol("jge")]
        JGE = 319,

        [Symbol("jl")]
        JL = 320,

        [Symbol("jle")]
        JLE = 321,

        [Symbol("jna")]
        JNA = 322,

        [Symbol("jnae")]
        JNAE = 323,

        [Symbol("jnb")]
        JNB = 324,

        [Symbol("jnbe")]
        JNBE = 325,

        [Symbol("jnc")]
        JNC = 326,

        [Symbol("jne")]
        JNE = 327,

        [Symbol("jng")]
        JNG = 328,

        [Symbol("jnge")]
        JNGE = 329,

        [Symbol("jnl")]
        JNL = 330,

        [Symbol("jnle")]
        JNLE = 331,

        [Symbol("jno")]
        JNO = 332,

        [Symbol("jnp")]
        JNP = 333,

        [Symbol("jns")]
        JNS = 334,

        [Symbol("jnz")]
        JNZ = 335,

        [Symbol("jo")]
        JO = 336,

        [Symbol("jp")]
        JP = 337,

        [Symbol("jpe")]
        JPE = 338,

        [Symbol("jpo")]
        JPO = 339,

        [Symbol("js")]
        JS = 340,

        [Symbol("jz")]
        JZ = 341,

        [Symbol("jmp")]
        JMP = 342,

        [Symbol("lahf")]
        LAHF = 343,

        [Symbol("lar")]
        LAR = 344,

        [Symbol("lddqu")]
        LDDQU = 345,

        [Symbol("vlddqu")]
        VLDDQU = 346,

        [Symbol("ldmxcsr")]
        LDMXCSR = 347,

        [Symbol("vldmxcsr")]
        VLDMXCSR = 348,

        [Symbol("lds")]
        LDS = 349,

        [Symbol("lss")]
        LSS = 350,

        [Symbol("les")]
        LES = 351,

        [Symbol("lfs")]
        LFS = 352,

        [Symbol("lgs")]
        LGS = 353,

        [Symbol("lea")]
        LEA = 354,

        [Symbol("leave")]
        LEAVE = 355,

        [Symbol("lfence")]
        LFENCE = 356,

        [Symbol("lgdt")]
        LGDT = 357,

        [Symbol("lidt")]
        LIDT = 358,

        [Symbol("lldt")]
        LLDT = 359,

        [Symbol("lmsw")]
        LMSW = 360,

        [Symbol("lock")]
        LOCK = 361,

        [Symbol("lods")]
        LODS = 362,

        [Symbol("lodsb")]
        LODSB = 363,

        [Symbol("lodsw")]
        LODSW = 364,

        [Symbol("lodsd")]
        LODSD = 365,

        [Symbol("lodsq")]
        LODSQ = 366,

        [Symbol("loop")]
        LOOP = 367,

        [Symbol("loope")]
        LOOPE = 368,

        [Symbol("loopne")]
        LOOPNE = 369,

        [Symbol("lsl")]
        LSL = 370,

        [Symbol("ltr")]
        LTR = 371,

        [Symbol("lzcnt")]
        LZCNT = 372,

        [Symbol("maskmovdqu")]
        MASKMOVDQU = 373,

        [Symbol("vmaskmovdqu")]
        VMASKMOVDQU = 374,

        [Symbol("maskmovq")]
        MASKMOVQ = 375,

        [Symbol("maxpd")]
        MAXPD = 376,

        [Symbol("vmaxpd")]
        VMAXPD = 377,

        [Symbol("maxps")]
        MAXPS = 378,

        [Symbol("vmaxps")]
        VMAXPS = 379,

        [Symbol("maxsd")]
        MAXSD = 380,

        [Symbol("vmaxsd")]
        VMAXSD = 381,

        [Symbol("maxss")]
        MAXSS = 382,

        [Symbol("vmaxss")]
        VMAXSS = 383,

        [Symbol("mfence")]
        MFENCE = 384,

        [Symbol("minpd")]
        MINPD = 385,

        [Symbol("vminpd")]
        VMINPD = 386,

        [Symbol("minps")]
        MINPS = 387,

        [Symbol("vminps")]
        VMINPS = 388,

        [Symbol("minsd")]
        MINSD = 389,

        [Symbol("vminsd")]
        VMINSD = 390,

        [Symbol("minss")]
        MINSS = 391,

        [Symbol("vminss")]
        VMINSS = 392,

        [Symbol("monitor")]
        MONITOR = 393,

        [Symbol("mov")]
        MOV = 394,

        [Symbol("movapd")]
        MOVAPD = 395,

        [Symbol("vmovapd")]
        VMOVAPD = 396,

        [Symbol("movaps")]
        MOVAPS = 397,

        [Symbol("vmovaps")]
        VMOVAPS = 398,

        [Symbol("movbe")]
        MOVBE = 399,

        [Symbol("movd")]
        MOVD = 400,

        [Symbol("movq")]
        MOVQ = 401,

        [Symbol("vmovd")]
        VMOVD = 402,

        [Symbol("vmovq")]
        VMOVQ = 403,

        [Symbol("movddup")]
        MOVDDUP = 404,

        [Symbol("vmovddup")]
        VMOVDDUP = 405,

        [Symbol("movdqa")]
        MOVDQA = 406,

        [Symbol("vmovdqa")]
        VMOVDQA = 407,

        [Symbol("movdqu")]
        MOVDQU = 408,

        [Symbol("vmovdqu")]
        VMOVDQU = 409,

        [Symbol("movdq2q")]
        MOVDQ2Q = 410,

        [Symbol("movhlps")]
        MOVHLPS = 411,

        [Symbol("vmovhlps")]
        VMOVHLPS = 412,

        [Symbol("movhpd")]
        MOVHPD = 413,

        [Symbol("vmovhpd")]
        VMOVHPD = 414,

        [Symbol("movhps")]
        MOVHPS = 415,

        [Symbol("vmovhps")]
        VMOVHPS = 416,

        [Symbol("movlhps")]
        MOVLHPS = 417,

        [Symbol("vmovlhps")]
        VMOVLHPS = 418,

        [Symbol("movlpd")]
        MOVLPD = 419,

        [Symbol("vmovlpd")]
        VMOVLPD = 420,

        [Symbol("movlps")]
        MOVLPS = 421,

        [Symbol("vmovlps")]
        VMOVLPS = 422,

        [Symbol("movmskpd")]
        MOVMSKPD = 423,

        [Symbol("vmovmskpd")]
        VMOVMSKPD = 424,

        [Symbol("movmskps")]
        MOVMSKPS = 425,

        [Symbol("vmovmskps")]
        VMOVMSKPS = 426,

        [Symbol("movntdqa")]
        MOVNTDQA = 427,

        [Symbol("vmovntdqa")]
        VMOVNTDQA = 428,

        [Symbol("movntdq")]
        MOVNTDQ = 429,

        [Symbol("vmovntdq")]
        VMOVNTDQ = 430,

        [Symbol("movnti")]
        MOVNTI = 431,

        [Symbol("movntpd")]
        MOVNTPD = 432,

        [Symbol("vmovntpd")]
        VMOVNTPD = 433,

        [Symbol("movntps")]
        MOVNTPS = 434,

        [Symbol("vmovntps")]
        VMOVNTPS = 435,

        [Symbol("movntq")]
        MOVNTQ = 436,

        [Symbol("movq2dq")]
        MOVQ2DQ = 437,

        [Symbol("movs")]
        MOVS = 438,

        [Symbol("movsb")]
        MOVSB = 439,

        [Symbol("movsw")]
        MOVSW = 440,

        [Symbol("movsd")]
        MOVSD = 441,

        [Symbol("movsq")]
        MOVSQ = 442,

        [Symbol("vmovsd")]
        VMOVSD = 443,

        [Symbol("movshdup")]
        MOVSHDUP = 444,

        [Symbol("vmovshdup")]
        VMOVSHDUP = 445,

        [Symbol("movsldup")]
        MOVSLDUP = 446,

        [Symbol("vmovsldup")]
        VMOVSLDUP = 447,

        [Symbol("movss")]
        MOVSS = 448,

        [Symbol("vmovss")]
        VMOVSS = 449,

        [Symbol("movsx")]
        MOVSX = 450,

        [Symbol("movsxd")]
        MOVSXD = 451,

        [Symbol("movupd")]
        MOVUPD = 452,

        [Symbol("vmovupd")]
        VMOVUPD = 453,

        [Symbol("movups")]
        MOVUPS = 454,

        [Symbol("vmovups")]
        VMOVUPS = 455,

        [Symbol("movzx")]
        MOVZX = 456,

        [Symbol("mpsadbw")]
        MPSADBW = 457,

        [Symbol("vmpsadbw")]
        VMPSADBW = 458,

        [Symbol("mul")]
        MUL = 459,

        [Symbol("mulpd")]
        MULPD = 460,

        [Symbol("vmulpd")]
        VMULPD = 461,

        [Symbol("mulps")]
        MULPS = 462,

        [Symbol("vmulps")]
        VMULPS = 463,

        [Symbol("mulsd")]
        MULSD = 464,

        [Symbol("vmulsd")]
        VMULSD = 465,

        [Symbol("mulss")]
        MULSS = 466,

        [Symbol("vmulss")]
        VMULSS = 467,

        [Symbol("mulx")]
        MULX = 468,

        [Symbol("mwait")]
        MWAIT = 469,

        [Symbol("neg")]
        NEG = 470,

        [Symbol("nop")]
        NOP = 471,

        [Symbol("not")]
        NOT = 472,

        [Symbol("or")]
        OR = 473,

        [Symbol("orpd")]
        ORPD = 474,

        [Symbol("vorpd")]
        VORPD = 475,

        [Symbol("orps")]
        ORPS = 476,

        [Symbol("vorps")]
        VORPS = 477,

        [Symbol("out")]
        OUT = 478,

        [Symbol("outs")]
        OUTS = 479,

        [Symbol("outsb")]
        OUTSB = 480,

        [Symbol("outsw")]
        OUTSW = 481,

        [Symbol("outsd")]
        OUTSD = 482,

        [Symbol("pabsb")]
        PABSB = 483,

        [Symbol("pabsw")]
        PABSW = 484,

        [Symbol("pabsd")]
        PABSD = 485,

        [Symbol("vpabsb")]
        VPABSB = 486,

        [Symbol("vpabsw")]
        VPABSW = 487,

        [Symbol("vpabsd")]
        VPABSD = 488,

        [Symbol("packsswb")]
        PACKSSWB = 489,

        [Symbol("packssdw")]
        PACKSSDW = 490,

        [Symbol("vpacksswb")]
        VPACKSSWB = 491,

        [Symbol("vpackssdw")]
        VPACKSSDW = 492,

        [Symbol("packusdw")]
        PACKUSDW = 493,

        [Symbol("vpackusdw")]
        VPACKUSDW = 494,

        [Symbol("packuswb")]
        PACKUSWB = 495,

        [Symbol("vpackuswb")]
        VPACKUSWB = 496,

        [Symbol("paddb")]
        PADDB = 497,

        [Symbol("paddw")]
        PADDW = 498,

        [Symbol("paddd")]
        PADDD = 499,

        [Symbol("vpaddb")]
        VPADDB = 500,

        [Symbol("vpaddw")]
        VPADDW = 501,

        [Symbol("vpaddd")]
        VPADDD = 502,

        [Symbol("paddq")]
        PADDQ = 503,

        [Symbol("vpaddq")]
        VPADDQ = 504,

        [Symbol("paddsb")]
        PADDSB = 505,

        [Symbol("paddsw")]
        PADDSW = 506,

        [Symbol("vpaddsb")]
        VPADDSB = 507,

        [Symbol("vpaddsw")]
        VPADDSW = 508,

        [Symbol("paddusb")]
        PADDUSB = 509,

        [Symbol("paddusw")]
        PADDUSW = 510,

        [Symbol("vpaddusb")]
        VPADDUSB = 511,

        [Symbol("vpaddusw")]
        VPADDUSW = 512,

        [Symbol("palignr")]
        PALIGNR = 513,

        [Symbol("vpalignr")]
        VPALIGNR = 514,

        [Symbol("pand")]
        PAND = 515,

        [Symbol("vpand")]
        VPAND = 516,

        [Symbol("pandn")]
        PANDN = 517,

        [Symbol("vpandn")]
        VPANDN = 518,

        [Symbol("pause")]
        PAUSE = 519,

        [Symbol("pavgb")]
        PAVGB = 520,

        [Symbol("pavgw")]
        PAVGW = 521,

        [Symbol("vpavgb")]
        VPAVGB = 522,

        [Symbol("vpavgw")]
        VPAVGW = 523,

        [Symbol("pblendvb")]
        PBLENDVB = 524,

        [Symbol("vpblendvb")]
        VPBLENDVB = 525,

        [Symbol("pblendw")]
        PBLENDW = 526,

        [Symbol("vpblendw")]
        VPBLENDW = 527,

        [Symbol("pclmulqdq")]
        PCLMULQDQ = 528,

        [Symbol("vpclmulqdq")]
        VPCLMULQDQ = 529,

        [Symbol("pcmpeqb")]
        PCMPEQB = 530,

        [Symbol("pcmpeqw")]
        PCMPEQW = 531,

        [Symbol("pcmpeqd")]
        PCMPEQD = 532,

        [Symbol("vpcmpeqb")]
        VPCMPEQB = 533,

        [Symbol("vpcmpeqw")]
        VPCMPEQW = 534,

        [Symbol("vpcmpeqd")]
        VPCMPEQD = 535,

        [Symbol("pcmpeqq")]
        PCMPEQQ = 536,

        [Symbol("vpcmpeqq")]
        VPCMPEQQ = 537,

        [Symbol("pcmpestri")]
        PCMPESTRI = 538,

        [Symbol("vpcmpestri")]
        VPCMPESTRI = 539,

        [Symbol("pcmpestrm")]
        PCMPESTRM = 540,

        [Symbol("vpcmpestrm")]
        VPCMPESTRM = 541,

        [Symbol("pcmpgtb")]
        PCMPGTB = 542,

        [Symbol("pcmpgtw")]
        PCMPGTW = 543,

        [Symbol("pcmpgtd")]
        PCMPGTD = 544,

        [Symbol("vpcmpgtb")]
        VPCMPGTB = 545,

        [Symbol("vpcmpgtw")]
        VPCMPGTW = 546,

        [Symbol("vpcmpgtd")]
        VPCMPGTD = 547,

        [Symbol("pcmpgtq")]
        PCMPGTQ = 548,

        [Symbol("vpcmpgtq")]
        VPCMPGTQ = 549,

        [Symbol("pcmpistri")]
        PCMPISTRI = 550,

        [Symbol("vpcmpistri")]
        VPCMPISTRI = 551,

        [Symbol("pcmpistrm")]
        PCMPISTRM = 552,

        [Symbol("vpcmpistrm")]
        VPCMPISTRM = 553,

        [Symbol("pdep")]
        PDEP = 554,

        [Symbol("pext")]
        PEXT = 555,

        [Symbol("pextrb")]
        PEXTRB = 556,

        [Symbol("pextrd")]
        PEXTRD = 557,

        [Symbol("pextrq")]
        PEXTRQ = 558,

        [Symbol("vpextrb")]
        VPEXTRB = 559,

        [Symbol("vpextrd")]
        VPEXTRD = 560,

        [Symbol("vpextrq")]
        VPEXTRQ = 561,

        [Symbol("pextrw")]
        PEXTRW = 562,

        [Symbol("vpextrw")]
        VPEXTRW = 563,

        [Symbol("phaddw")]
        PHADDW = 564,

        [Symbol("phaddd")]
        PHADDD = 565,

        [Symbol("vphaddw")]
        VPHADDW = 566,

        [Symbol("vphaddd")]
        VPHADDD = 567,

        [Symbol("phaddsw")]
        PHADDSW = 568,

        [Symbol("vphaddsw")]
        VPHADDSW = 569,

        [Symbol("phminposuw")]
        PHMINPOSUW = 570,

        [Symbol("vphminposuw")]
        VPHMINPOSUW = 571,

        [Symbol("phsubw")]
        PHSUBW = 572,

        [Symbol("phsubd")]
        PHSUBD = 573,

        [Symbol("vphsubw")]
        VPHSUBW = 574,

        [Symbol("vphsubd")]
        VPHSUBD = 575,

        [Symbol("phsubsw")]
        PHSUBSW = 576,

        [Symbol("vphsubsw")]
        VPHSUBSW = 577,

        [Symbol("pinsrb")]
        PINSRB = 578,

        [Symbol("pinsrd")]
        PINSRD = 579,

        [Symbol("pinsrq")]
        PINSRQ = 580,

        [Symbol("vpinsrb")]
        VPINSRB = 581,

        [Symbol("vpinsrd")]
        VPINSRD = 582,

        [Symbol("vpinsrq")]
        VPINSRQ = 583,

        [Symbol("pinsrw")]
        PINSRW = 584,

        [Symbol("vpinsrw")]
        VPINSRW = 585,

        [Symbol("pmaddubsw")]
        PMADDUBSW = 586,

        [Symbol("vpmaddubsw")]
        VPMADDUBSW = 587,

        [Symbol("pmaddwd")]
        PMADDWD = 588,

        [Symbol("vpmaddwd")]
        VPMADDWD = 589,

        [Symbol("pmaxsb")]
        PMAXSB = 590,

        [Symbol("vpmaxsb")]
        VPMAXSB = 591,

        [Symbol("pmaxsd")]
        PMAXSD = 592,

        [Symbol("vpmaxsd")]
        VPMAXSD = 593,

        [Symbol("pmaxsw")]
        PMAXSW = 594,

        [Symbol("vpmaxsw")]
        VPMAXSW = 595,

        [Symbol("pmaxub")]
        PMAXUB = 596,

        [Symbol("vpmaxub")]
        VPMAXUB = 597,

        [Symbol("pmaxud")]
        PMAXUD = 598,

        [Symbol("vpmaxud")]
        VPMAXUD = 599,

        [Symbol("pmaxuw")]
        PMAXUW = 600,

        [Symbol("vpmaxuw")]
        VPMAXUW = 601,

        [Symbol("pminsb")]
        PMINSB = 602,

        [Symbol("vpminsb")]
        VPMINSB = 603,

        [Symbol("pminsd")]
        PMINSD = 604,

        [Symbol("vpminsd")]
        VPMINSD = 605,

        [Symbol("pminsw")]
        PMINSW = 606,

        [Symbol("vpminsw")]
        VPMINSW = 607,

        [Symbol("pminub")]
        PMINUB = 608,

        [Symbol("vpminub")]
        VPMINUB = 609,

        [Symbol("pminud")]
        PMINUD = 610,

        [Symbol("vpminud")]
        VPMINUD = 611,

        [Symbol("pminuw")]
        PMINUW = 612,

        [Symbol("vpminuw")]
        VPMINUW = 613,

        [Symbol("pmovmskb")]
        PMOVMSKB = 614,

        [Symbol("vpmovmskb")]
        VPMOVMSKB = 615,

        [Symbol("pmovsxbw")]
        PMOVSXBW = 616,

        [Symbol("pmovsxbd")]
        PMOVSXBD = 617,

        [Symbol("pmovsxbq")]
        PMOVSXBQ = 618,

        [Symbol("pmovsxwd")]
        PMOVSXWD = 619,

        [Symbol("pmovsxwq")]
        PMOVSXWQ = 620,

        [Symbol("pmovsxdq")]
        PMOVSXDQ = 621,

        [Symbol("vpmovsxbw")]
        VPMOVSXBW = 622,

        [Symbol("vpmovsxbd")]
        VPMOVSXBD = 623,

        [Symbol("vpmovsxbq")]
        VPMOVSXBQ = 624,

        [Symbol("vpmovsxwd")]
        VPMOVSXWD = 625,

        [Symbol("vpmovsxwq")]
        VPMOVSXWQ = 626,

        [Symbol("vpmovsxdq")]
        VPMOVSXDQ = 627,

        [Symbol("pmovzxbw")]
        PMOVZXBW = 628,

        [Symbol("pmovzxbd")]
        PMOVZXBD = 629,

        [Symbol("pmovzxbq")]
        PMOVZXBQ = 630,

        [Symbol("pmovzxwd")]
        PMOVZXWD = 631,

        [Symbol("pmovzxwq")]
        PMOVZXWQ = 632,

        [Symbol("pmovzxdq")]
        PMOVZXDQ = 633,

        [Symbol("vpmovzxbw")]
        VPMOVZXBW = 634,

        [Symbol("vpmovzxbd")]
        VPMOVZXBD = 635,

        [Symbol("vpmovzxbq")]
        VPMOVZXBQ = 636,

        [Symbol("vpmovzxwd")]
        VPMOVZXWD = 637,

        [Symbol("vpmovzxwq")]
        VPMOVZXWQ = 638,

        [Symbol("vpmovzxdq")]
        VPMOVZXDQ = 639,

        [Symbol("pmuldq")]
        PMULDQ = 640,

        [Symbol("vpmuldq")]
        VPMULDQ = 641,

        [Symbol("pmulhrsw")]
        PMULHRSW = 642,

        [Symbol("vpmulhrsw")]
        VPMULHRSW = 643,

        [Symbol("pmulhuw")]
        PMULHUW = 644,

        [Symbol("vpmulhuw")]
        VPMULHUW = 645,

        [Symbol("pmulhw")]
        PMULHW = 646,

        [Symbol("vpmulhw")]
        VPMULHW = 647,

        [Symbol("pmulld")]
        PMULLD = 648,

        [Symbol("vpmulld")]
        VPMULLD = 649,

        [Symbol("pmullw")]
        PMULLW = 650,

        [Symbol("vpmullw")]
        VPMULLW = 651,

        [Symbol("pmuludq")]
        PMULUDQ = 652,

        [Symbol("vpmuludq")]
        VPMULUDQ = 653,

        [Symbol("pop")]
        POP = 654,

        [Symbol("popa")]
        POPA = 655,

        [Symbol("popad")]
        POPAD = 656,

        [Symbol("popcnt")]
        POPCNT = 657,

        [Symbol("popf")]
        POPF = 658,

        [Symbol("popfd")]
        POPFD = 659,

        [Symbol("popfq")]
        POPFQ = 660,

        [Symbol("por")]
        POR = 661,

        [Symbol("vpor")]
        VPOR = 662,

        [Symbol("prefetcht0")]
        PREFETCHT0 = 663,

        [Symbol("prefetcht1")]
        PREFETCHT1 = 664,

        [Symbol("prefetcht2")]
        PREFETCHT2 = 665,

        [Symbol("prefetchnta")]
        PREFETCHNTA = 666,

        [Symbol("psadbw")]
        PSADBW = 667,

        [Symbol("vpsadbw")]
        VPSADBW = 668,

        [Symbol("pshufb")]
        PSHUFB = 669,

        [Symbol("vpshufb")]
        VPSHUFB = 670,

        [Symbol("pshufd")]
        PSHUFD = 671,

        [Symbol("vpshufd")]
        VPSHUFD = 672,

        [Symbol("pshufhw")]
        PSHUFHW = 673,

        [Symbol("vpshufhw")]
        VPSHUFHW = 674,

        [Symbol("pshuflw")]
        PSHUFLW = 675,

        [Symbol("vpshuflw")]
        VPSHUFLW = 676,

        [Symbol("pshufw")]
        PSHUFW = 677,

        [Symbol("psignb")]
        PSIGNB = 678,

        [Symbol("psignw")]
        PSIGNW = 679,

        [Symbol("psignd")]
        PSIGND = 680,

        [Symbol("vpsignb")]
        VPSIGNB = 681,

        [Symbol("vpsignw")]
        VPSIGNW = 682,

        [Symbol("vpsignd")]
        VPSIGND = 683,

        [Symbol("pslldq")]
        PSLLDQ = 684,

        [Symbol("vpslldq")]
        VPSLLDQ = 685,

        [Symbol("psllw")]
        PSLLW = 686,

        [Symbol("pslld")]
        PSLLD = 687,

        [Symbol("psllq")]
        PSLLQ = 688,

        [Symbol("vpsllw")]
        VPSLLW = 689,

        [Symbol("vpslld")]
        VPSLLD = 690,

        [Symbol("vpsllq")]
        VPSLLQ = 691,

        [Symbol("psraw")]
        PSRAW = 692,

        [Symbol("psrad")]
        PSRAD = 693,

        [Symbol("vpsraw")]
        VPSRAW = 694,

        [Symbol("vpsrad")]
        VPSRAD = 695,

        [Symbol("psrldq")]
        PSRLDQ = 696,

        [Symbol("vpsrldq")]
        VPSRLDQ = 697,

        [Symbol("psrlw")]
        PSRLW = 698,

        [Symbol("psrld")]
        PSRLD = 699,

        [Symbol("psrlq")]
        PSRLQ = 700,

        [Symbol("vpsrlw")]
        VPSRLW = 701,

        [Symbol("vpsrld")]
        VPSRLD = 702,

        [Symbol("vpsrlq")]
        VPSRLQ = 703,

        [Symbol("psubb")]
        PSUBB = 704,

        [Symbol("psubw")]
        PSUBW = 705,

        [Symbol("psubd")]
        PSUBD = 706,

        [Symbol("vpsubb")]
        VPSUBB = 707,

        [Symbol("vpsubw")]
        VPSUBW = 708,

        [Symbol("vpsubd")]
        VPSUBD = 709,

        [Symbol("psubq")]
        PSUBQ = 710,

        [Symbol("vpsubq")]
        VPSUBQ = 711,

        [Symbol("psubsb")]
        PSUBSB = 712,

        [Symbol("psubsw")]
        PSUBSW = 713,

        [Symbol("vpsubsb")]
        VPSUBSB = 714,

        [Symbol("vpsubsw")]
        VPSUBSW = 715,

        [Symbol("psubusb")]
        PSUBUSB = 716,

        [Symbol("psubusw")]
        PSUBUSW = 717,

        [Symbol("vpsubusb")]
        VPSUBUSB = 718,

        [Symbol("vpsubusw")]
        VPSUBUSW = 719,

        [Symbol("ptest")]
        PTEST = 720,

        [Symbol("vptest")]
        VPTEST = 721,

        [Symbol("punpckhbw")]
        PUNPCKHBW = 722,

        [Symbol("punpckhwd")]
        PUNPCKHWD = 723,

        [Symbol("punpckhdq")]
        PUNPCKHDQ = 724,

        [Symbol("punpckhqdq")]
        PUNPCKHQDQ = 725,

        [Symbol("vpunpckhbw")]
        VPUNPCKHBW = 726,

        [Symbol("vpunpckhwd")]
        VPUNPCKHWD = 727,

        [Symbol("vpunpckhdq")]
        VPUNPCKHDQ = 728,

        [Symbol("vpunpckhqdq")]
        VPUNPCKHQDQ = 729,

        [Symbol("punpcklbw")]
        PUNPCKLBW = 730,

        [Symbol("punpcklwd")]
        PUNPCKLWD = 731,

        [Symbol("punpckldq")]
        PUNPCKLDQ = 732,

        [Symbol("punpcklqdq")]
        PUNPCKLQDQ = 733,

        [Symbol("vpunpcklbw")]
        VPUNPCKLBW = 734,

        [Symbol("vpunpcklwd")]
        VPUNPCKLWD = 735,

        [Symbol("vpunpckldq")]
        VPUNPCKLDQ = 736,

        [Symbol("vpunpcklqdq")]
        VPUNPCKLQDQ = 737,

        [Symbol("push")]
        PUSH = 738,

        [Symbol("pushq")]
        PUSHQ = 739,

        [Symbol("pushw")]
        PUSHW = 740,

        [Symbol("pusha")]
        PUSHA = 741,

        [Symbol("pushad")]
        PUSHAD = 742,

        [Symbol("pushf")]
        PUSHF = 743,

        [Symbol("pushfd")]
        PUSHFD = 744,

        [Symbol("pushfq")]
        PUSHFQ = 745,

        [Symbol("pxor")]
        PXOR = 746,

        [Symbol("vpxor")]
        VPXOR = 747,

        [Symbol("rcl")]
        RCL = 748,

        [Symbol("rcr")]
        RCR = 749,

        [Symbol("rol")]
        ROL = 750,

        [Symbol("ror")]
        ROR = 751,

        [Symbol("rcpps")]
        RCPPS = 752,

        [Symbol("vrcpps")]
        VRCPPS = 753,

        [Symbol("rcpss")]
        RCPSS = 754,

        [Symbol("vrcpss")]
        VRCPSS = 755,

        [Symbol("rdfsbase")]
        RDFSBASE = 756,

        [Symbol("rdgsbase")]
        RDGSBASE = 757,

        [Symbol("rdmsr")]
        RDMSR = 758,

        [Symbol("rdpmc")]
        RDPMC = 759,

        [Symbol("rdrand")]
        RDRAND = 760,

        [Symbol("rdtsc")]
        RDTSC = 761,

        [Symbol("rdtscp")]
        RDTSCP = 762,

        [Symbol("rep_ins")]
        REP_INS = 763,

        [Symbol("rep_movs")]
        REP_MOVS = 764,

        [Symbol("rep_outs")]
        REP_OUTS = 765,

        [Symbol("rep_lods")]
        REP_LODS = 766,

        [Symbol("rep_stos")]
        REP_STOS = 767,

        [Symbol("repe_cmps")]
        REPE_CMPS = 768,

        [Symbol("repe_scas")]
        REPE_SCAS = 769,

        [Symbol("repne_cmps")]
        REPNE_CMPS = 770,

        [Symbol("repne_scas")]
        REPNE_SCAS = 771,

        [Symbol("ret")]
        RET = 772,

        [Symbol("rorx")]
        RORX = 773,

        [Symbol("roundpd")]
        ROUNDPD = 774,

        [Symbol("vroundpd")]
        VROUNDPD = 775,

        [Symbol("roundps")]
        ROUNDPS = 776,

        [Symbol("vroundps")]
        VROUNDPS = 777,

        [Symbol("roundsd")]
        ROUNDSD = 778,

        [Symbol("vroundsd")]
        VROUNDSD = 779,

        [Symbol("roundss")]
        ROUNDSS = 780,

        [Symbol("vroundss")]
        VROUNDSS = 781,

        [Symbol("rsm")]
        RSM = 782,

        [Symbol("rsqrtps")]
        RSQRTPS = 783,

        [Symbol("vrsqrtps")]
        VRSQRTPS = 784,

        [Symbol("rsqrtss")]
        RSQRTSS = 785,

        [Symbol("vrsqrtss")]
        VRSQRTSS = 786,

        [Symbol("sahf")]
        SAHF = 787,

        [Symbol("sal")]
        SAL = 788,

        [Symbol("sar")]
        SAR = 789,

        [Symbol("shl")]
        SHL = 790,

        [Symbol("shr")]
        SHR = 791,

        [Symbol("sarx")]
        SARX = 792,

        [Symbol("shlx")]
        SHLX = 793,

        [Symbol("shrx")]
        SHRX = 794,

        [Symbol("sbb")]
        SBB = 795,

        [Symbol("scas")]
        SCAS = 796,

        [Symbol("scasb")]
        SCASB = 797,

        [Symbol("scasw")]
        SCASW = 798,

        [Symbol("scasd")]
        SCASD = 799,

        [Symbol("scasq")]
        SCASQ = 800,

        [Symbol("seta")]
        SETA = 801,

        [Symbol("setae")]
        SETAE = 802,

        [Symbol("setb")]
        SETB = 803,

        [Symbol("setbe")]
        SETBE = 804,

        [Symbol("setc")]
        SETC = 805,

        [Symbol("sete")]
        SETE = 806,

        [Symbol("setg")]
        SETG = 807,

        [Symbol("setge")]
        SETGE = 808,

        [Symbol("setl")]
        SETL = 809,

        [Symbol("setle")]
        SETLE = 810,

        [Symbol("setna")]
        SETNA = 811,

        [Symbol("setnae")]
        SETNAE = 812,

        [Symbol("setnb")]
        SETNB = 813,

        [Symbol("setnbe")]
        SETNBE = 814,

        [Symbol("setnc")]
        SETNC = 815,

        [Symbol("setne")]
        SETNE = 816,

        [Symbol("setng")]
        SETNG = 817,

        [Symbol("setnge")]
        SETNGE = 818,

        [Symbol("setnl")]
        SETNL = 819,

        [Symbol("setnle")]
        SETNLE = 820,

        [Symbol("setno")]
        SETNO = 821,

        [Symbol("setnp")]
        SETNP = 822,

        [Symbol("setns")]
        SETNS = 823,

        [Symbol("setnz")]
        SETNZ = 824,

        [Symbol("seto")]
        SETO = 825,

        [Symbol("setp")]
        SETP = 826,

        [Symbol("setpe")]
        SETPE = 827,

        [Symbol("setpo")]
        SETPO = 828,

        [Symbol("sets")]
        SETS = 829,

        [Symbol("setz")]
        SETZ = 830,

        [Symbol("sfence")]
        SFENCE = 831,

        [Symbol("sgdt")]
        SGDT = 832,

        [Symbol("shld")]
        SHLD = 833,

        [Symbol("shrd")]
        SHRD = 834,

        [Symbol("shufpd")]
        SHUFPD = 835,

        [Symbol("vshufpd")]
        VSHUFPD = 836,

        [Symbol("shufps")]
        SHUFPS = 837,

        [Symbol("vshufps")]
        VSHUFPS = 838,

        [Symbol("sidt")]
        SIDT = 839,

        [Symbol("sldt")]
        SLDT = 840,

        [Symbol("smsw")]
        SMSW = 841,

        [Symbol("sqrtpd")]
        SQRTPD = 842,

        [Symbol("vsqrtpd")]
        VSQRTPD = 843,

        [Symbol("sqrtps")]
        SQRTPS = 844,

        [Symbol("vsqrtps")]
        VSQRTPS = 845,

        [Symbol("sqrtsd")]
        SQRTSD = 846,

        [Symbol("vsqrtsd")]
        VSQRTSD = 847,

        [Symbol("sqrtss")]
        SQRTSS = 848,

        [Symbol("vsqrtss")]
        VSQRTSS = 849,

        [Symbol("stc")]
        STC = 850,

        [Symbol("std")]
        STD = 851,

        [Symbol("sti")]
        STI = 852,

        [Symbol("stmxcsr")]
        STMXCSR = 853,

        [Symbol("vstmxcsr")]
        VSTMXCSR = 854,

        [Symbol("stos")]
        STOS = 855,

        [Symbol("stosb")]
        STOSB = 856,

        [Symbol("stosw")]
        STOSW = 857,

        [Symbol("stosd")]
        STOSD = 858,

        [Symbol("stosq")]
        STOSQ = 859,

        [Symbol("str")]
        STR = 860,

        [Symbol("sub")]
        SUB = 861,

        [Symbol("subpd")]
        SUBPD = 862,

        [Symbol("vsubpd")]
        VSUBPD = 863,

        [Symbol("subps")]
        SUBPS = 864,

        [Symbol("vsubps")]
        VSUBPS = 865,

        [Symbol("subsd")]
        SUBSD = 866,

        [Symbol("vsubsd")]
        VSUBSD = 867,

        [Symbol("subss")]
        SUBSS = 868,

        [Symbol("vsubss")]
        VSUBSS = 869,

        [Symbol("swapgs")]
        SWAPGS = 870,

        [Symbol("syscall")]
        SYSCALL = 871,

        [Symbol("sysenter")]
        SYSENTER = 872,

        [Symbol("sysexit")]
        SYSEXIT = 873,

        [Symbol("sysret")]
        SYSRET = 874,

        [Symbol("test")]
        TEST = 875,

        [Symbol("tzcnt")]
        TZCNT = 876,

        [Symbol("ucomisd")]
        UCOMISD = 877,

        [Symbol("vucomisd")]
        VUCOMISD = 878,

        [Symbol("ucomiss")]
        UCOMISS = 879,

        [Symbol("vucomiss")]
        VUCOMISS = 880,

        [Symbol("ud2")]
        UD2 = 881,

        [Symbol("unpckhpd")]
        UNPCKHPD = 882,

        [Symbol("vunpckhpd")]
        VUNPCKHPD = 883,

        [Symbol("unpckhps")]
        UNPCKHPS = 884,

        [Symbol("vunpckhps")]
        VUNPCKHPS = 885,

        [Symbol("unpcklpd")]
        UNPCKLPD = 886,

        [Symbol("vunpcklpd")]
        VUNPCKLPD = 887,

        [Symbol("unpcklps")]
        UNPCKLPS = 888,

        [Symbol("vunpcklps")]
        VUNPCKLPS = 889,

        [Symbol("vbroadcastss")]
        VBROADCASTSS = 890,

        [Symbol("vbroadcastsd")]
        VBROADCASTSD = 891,

        [Symbol("vbroadcastf128")]
        VBROADCASTF128 = 892,

        [Symbol("vcvtph2ps")]
        VCVTPH2PS = 893,

        [Symbol("vcvtps2ph")]
        VCVTPS2PH = 894,

        [Symbol("verr")]
        VERR = 895,

        [Symbol("verw")]
        VERW = 896,

        [Symbol("vextractf128")]
        VEXTRACTF128 = 897,

        [Symbol("vextracti128")]
        VEXTRACTI128 = 898,

        [Symbol("vfmadd132pd")]
        VFMADD132PD = 899,

        [Symbol("vfmadd213pd")]
        VFMADD213PD = 900,

        [Symbol("vfmadd231pd")]
        VFMADD231PD = 901,

        [Symbol("vfmadd132ps")]
        VFMADD132PS = 902,

        [Symbol("vfmadd213ps")]
        VFMADD213PS = 903,

        [Symbol("vfmadd231ps")]
        VFMADD231PS = 904,

        [Symbol("vfmadd132sd")]
        VFMADD132SD = 905,

        [Symbol("vfmadd213sd")]
        VFMADD213SD = 906,

        [Symbol("vfmadd231sd")]
        VFMADD231SD = 907,

        [Symbol("vfmadd132ss")]
        VFMADD132SS = 908,

        [Symbol("vfmadd213ss")]
        VFMADD213SS = 909,

        [Symbol("vfmadd231ss")]
        VFMADD231SS = 910,

        [Symbol("vfmaddsub132pd")]
        VFMADDSUB132PD = 911,

        [Symbol("vfmaddsub213pd")]
        VFMADDSUB213PD = 912,

        [Symbol("vfmaddsub231pd")]
        VFMADDSUB231PD = 913,

        [Symbol("vfmaddsub132ps")]
        VFMADDSUB132PS = 914,

        [Symbol("vfmaddsub213ps")]
        VFMADDSUB213PS = 915,

        [Symbol("vfmaddsub231ps")]
        VFMADDSUB231PS = 916,

        [Symbol("vfmsubadd132pd")]
        VFMSUBADD132PD = 917,

        [Symbol("vfmsubadd213pd")]
        VFMSUBADD213PD = 918,

        [Symbol("vfmsubadd231pd")]
        VFMSUBADD231PD = 919,

        [Symbol("vfmsubadd132ps")]
        VFMSUBADD132PS = 920,

        [Symbol("vfmsubadd213ps")]
        VFMSUBADD213PS = 921,

        [Symbol("vfmsubadd231ps")]
        VFMSUBADD231PS = 922,

        [Symbol("vfmsub132pd")]
        VFMSUB132PD = 923,

        [Symbol("vfmsub213pd")]
        VFMSUB213PD = 924,

        [Symbol("vfmsub231pd")]
        VFMSUB231PD = 925,

        [Symbol("vfmsub132ps")]
        VFMSUB132PS = 926,

        [Symbol("vfmsub213ps")]
        VFMSUB213PS = 927,

        [Symbol("vfmsub231ps")]
        VFMSUB231PS = 928,

        [Symbol("vfmsub132sd")]
        VFMSUB132SD = 929,

        [Symbol("vfmsub213sd")]
        VFMSUB213SD = 930,

        [Symbol("vfmsub231sd")]
        VFMSUB231SD = 931,

        [Symbol("vfmsub132ss")]
        VFMSUB132SS = 932,

        [Symbol("vfmsub213ss")]
        VFMSUB213SS = 933,

        [Symbol("vfmsub231ss")]
        VFMSUB231SS = 934,

        [Symbol("vfnmadd132pd")]
        VFNMADD132PD = 935,

        [Symbol("vfnmadd213pd")]
        VFNMADD213PD = 936,

        [Symbol("vfnmadd231pd")]
        VFNMADD231PD = 937,

        [Symbol("vfnmadd132ps")]
        VFNMADD132PS = 938,

        [Symbol("vfnmadd213ps")]
        VFNMADD213PS = 939,

        [Symbol("vfnmadd231ps")]
        VFNMADD231PS = 940,

        [Symbol("vfnmadd132sd")]
        VFNMADD132SD = 941,

        [Symbol("vfnmadd213sd")]
        VFNMADD213SD = 942,

        [Symbol("vfnmadd231sd")]
        VFNMADD231SD = 943,

        [Symbol("vfnmadd132ss")]
        VFNMADD132SS = 944,

        [Symbol("vfnmadd213ss")]
        VFNMADD213SS = 945,

        [Symbol("vfnmadd231ss")]
        VFNMADD231SS = 946,

        [Symbol("vfnmsub132pd")]
        VFNMSUB132PD = 947,

        [Symbol("vfnmsub213pd")]
        VFNMSUB213PD = 948,

        [Symbol("vfnmsub231pd")]
        VFNMSUB231PD = 949,

        [Symbol("vfnmsub132ps")]
        VFNMSUB132PS = 950,

        [Symbol("vfnmsub213ps")]
        VFNMSUB213PS = 951,

        [Symbol("vfnmsub231ps")]
        VFNMSUB231PS = 952,

        [Symbol("vfnmsub132sd")]
        VFNMSUB132SD = 953,

        [Symbol("vfnmsub213sd")]
        VFNMSUB213SD = 954,

        [Symbol("vfnmsub231sd")]
        VFNMSUB231SD = 955,

        [Symbol("vfnmsub132ss")]
        VFNMSUB132SS = 956,

        [Symbol("vfnmsub213ss")]
        VFNMSUB213SS = 957,

        [Symbol("vfnmsub231ss")]
        VFNMSUB231SS = 958,

        [Symbol("vgatherdpd")]
        VGATHERDPD = 959,

        [Symbol("vgatherqpd")]
        VGATHERQPD = 960,

        [Symbol("vgatherdps")]
        VGATHERDPS = 961,

        [Symbol("vgatherqps")]
        VGATHERQPS = 962,

        [Symbol("vpgatherdd")]
        VPGATHERDD = 963,

        [Symbol("vpgatherqd")]
        VPGATHERQD = 964,

        [Symbol("vpgatherdq")]
        VPGATHERDQ = 965,

        [Symbol("vpgatherqq")]
        VPGATHERQQ = 966,

        [Symbol("vinsertf128")]
        VINSERTF128 = 967,

        [Symbol("vinserti128")]
        VINSERTI128 = 968,

        [Symbol("vmaskmovps")]
        VMASKMOVPS = 969,

        [Symbol("vmaskmovpd")]
        VMASKMOVPD = 970,

        [Symbol("vpblendd")]
        VPBLENDD = 971,

        [Symbol("vpbroadcastb")]
        VPBROADCASTB = 972,

        [Symbol("vpbroadcastw")]
        VPBROADCASTW = 973,

        [Symbol("vpbroadcastd")]
        VPBROADCASTD = 974,

        [Symbol("vpbroadcastq")]
        VPBROADCASTQ = 975,

        [Symbol("vbroadcasti128")]
        VBROADCASTI128 = 976,

        [Symbol("vpermd")]
        VPERMD = 977,

        [Symbol("vpermpd")]
        VPERMPD = 978,

        [Symbol("vpermps")]
        VPERMPS = 979,

        [Symbol("vpermq")]
        VPERMQ = 980,

        [Symbol("vperm2i128")]
        VPERM2I128 = 981,

        [Symbol("vpermilpd")]
        VPERMILPD = 982,

        [Symbol("vpermilps")]
        VPERMILPS = 983,

        [Symbol("vperm2f128")]
        VPERM2F128 = 984,

        [Symbol("vpmaskmovd")]
        VPMASKMOVD = 985,

        [Symbol("vpmaskmovq")]
        VPMASKMOVQ = 986,

        [Symbol("vpsllvd")]
        VPSLLVD = 987,

        [Symbol("vpsllvq")]
        VPSLLVQ = 988,

        [Symbol("vpsravd")]
        VPSRAVD = 989,

        [Symbol("vpsrlvd")]
        VPSRLVD = 990,

        [Symbol("vpsrlvq")]
        VPSRLVQ = 991,

        [Symbol("vtestps")]
        VTESTPS = 992,

        [Symbol("vtestpd")]
        VTESTPD = 993,

        [Symbol("vzeroall")]
        VZEROALL = 994,

        [Symbol("vzeroupper")]
        VZEROUPPER = 995,

        [Symbol("wait")]
        WAIT = 996,

        [Symbol("fwait")]
        FWAIT = 997,

        [Symbol("wbinvd")]
        WBINVD = 998,

        [Symbol("wrfsbase")]
        WRFSBASE = 999,

        [Symbol("wrgsbase")]
        WRGSBASE = 1000,

        [Symbol("wrmsr")]
        WRMSR = 1001,

        [Symbol("xacquire")]
        XACQUIRE = 1002,

        [Symbol("xrelease")]
        XRELEASE = 1003,

        [Symbol("xabort")]
        XABORT = 1004,

        [Symbol("xadd")]
        XADD = 1005,

        [Symbol("xbegin")]
        XBEGIN = 1006,

        [Symbol("xchg")]
        XCHG = 1007,

        [Symbol("xend")]
        XEND = 1008,

        [Symbol("xgetbv")]
        XGETBV = 1009,

        [Symbol("xlat")]
        XLAT = 1010,

        [Symbol("xlatb")]
        XLATB = 1011,

        [Symbol("xor")]
        XOR = 1012,

        [Symbol("xorpd")]
        XORPD = 1013,

        [Symbol("vxorpd")]
        VXORPD = 1014,

        [Symbol("xorps")]
        XORPS = 1015,

        [Symbol("vxorps")]
        VXORPS = 1016,

        [Symbol("xrstor")]
        XRSTOR = 1017,

        [Symbol("xrstor64")]
        XRSTOR64 = 1018,

        [Symbol("xsave")]
        XSAVE = 1019,

        [Symbol("xsave64")]
        XSAVE64 = 1020,

        [Symbol("xsaveopt")]
        XSAVEOPT = 1021,

        [Symbol("xsaveopt64")]
        XSAVEOPT64 = 1022,

        [Symbol("xsetbv")]
        XSETBV = 1023,

        [Symbol("xtest")]
        XTEST = 1024,

    }
}
