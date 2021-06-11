//-----------------------------------------------------------------------------
// Generated   :  2021-06-10.20.22.20.291
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum AsmMnemonicCode : ushort
    {
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

        [Symbol("adc_lock")]
        ADC_LOCK = 6,

        [Symbol("adcx")]
        ADCX = 7,

        [Symbol("add")]
        ADD = 8,

        [Symbol("add_lock")]
        ADD_LOCK = 9,

        [Symbol("addpd")]
        ADDPD = 10,

        [Symbol("addps")]
        ADDPS = 11,

        [Symbol("addsd")]
        ADDSD = 12,

        [Symbol("addss")]
        ADDSS = 13,

        [Symbol("addsubpd")]
        ADDSUBPD = 14,

        [Symbol("addsubps")]
        ADDSUBPS = 15,

        [Symbol("adox")]
        ADOX = 16,

        [Symbol("aesdec")]
        AESDEC = 17,

        [Symbol("aesdec128kl")]
        AESDEC128KL = 18,

        [Symbol("aesdec256kl")]
        AESDEC256KL = 19,

        [Symbol("aesdeclast")]
        AESDECLAST = 20,

        [Symbol("aesdecwide128kl")]
        AESDECWIDE128KL = 21,

        [Symbol("aesdecwide256kl")]
        AESDECWIDE256KL = 22,

        [Symbol("aesenc")]
        AESENC = 23,

        [Symbol("aesenc128kl")]
        AESENC128KL = 24,

        [Symbol("aesenc256kl")]
        AESENC256KL = 25,

        [Symbol("aesenclast")]
        AESENCLAST = 26,

        [Symbol("aesencwide128kl")]
        AESENCWIDE128KL = 27,

        [Symbol("aesencwide256kl")]
        AESENCWIDE256KL = 28,

        [Symbol("aesimc")]
        AESIMC = 29,

        [Symbol("aeskeygenassist")]
        AESKEYGENASSIST = 30,

        [Symbol("and")]
        AND = 31,

        [Symbol("and_lock")]
        AND_LOCK = 32,

        [Symbol("andn")]
        ANDN = 33,

        [Symbol("andnpd")]
        ANDNPD = 34,

        [Symbol("andnps")]
        ANDNPS = 35,

        [Symbol("andpd")]
        ANDPD = 36,

        [Symbol("andps")]
        ANDPS = 37,

        [Symbol("arpl")]
        ARPL = 38,

        [Symbol("bextr")]
        BEXTR = 39,

        [Symbol("bextr_xop")]
        BEXTR_XOP = 40,

        [Symbol("blcfill")]
        BLCFILL = 41,

        [Symbol("blci")]
        BLCI = 42,

        [Symbol("blcic")]
        BLCIC = 43,

        [Symbol("blcmsk")]
        BLCMSK = 44,

        [Symbol("blcs")]
        BLCS = 45,

        [Symbol("blendpd")]
        BLENDPD = 46,

        [Symbol("blendps")]
        BLENDPS = 47,

        [Symbol("blendvpd")]
        BLENDVPD = 48,

        [Symbol("blendvps")]
        BLENDVPS = 49,

        [Symbol("blsfill")]
        BLSFILL = 50,

        [Symbol("blsi")]
        BLSI = 51,

        [Symbol("blsic")]
        BLSIC = 52,

        [Symbol("blsmsk")]
        BLSMSK = 53,

        [Symbol("blsr")]
        BLSR = 54,

        [Symbol("bndcl")]
        BNDCL = 55,

        [Symbol("bndcn")]
        BNDCN = 56,

        [Symbol("bndcu")]
        BNDCU = 57,

        [Symbol("bndldx")]
        BNDLDX = 58,

        [Symbol("bndmk")]
        BNDMK = 59,

        [Symbol("bndmov")]
        BNDMOV = 60,

        [Symbol("bndstx")]
        BNDSTX = 61,

        [Symbol("bound")]
        BOUND = 62,

        [Symbol("bsf")]
        BSF = 63,

        [Symbol("bsr")]
        BSR = 64,

        [Symbol("bswap")]
        BSWAP = 65,

        [Symbol("bt")]
        BT = 66,

        [Symbol("btc")]
        BTC = 67,

        [Symbol("btc_lock")]
        BTC_LOCK = 68,

        [Symbol("btr")]
        BTR = 69,

        [Symbol("btr_lock")]
        BTR_LOCK = 70,

        [Symbol("bts")]
        BTS = 71,

        [Symbol("bts_lock")]
        BTS_LOCK = 72,

        [Symbol("bzhi")]
        BZHI = 73,

        [Symbol("call_far")]
        CALL_FAR = 74,

        [Symbol("call_near")]
        CALL_NEAR = 75,

        [Symbol("cbw")]
        CBW = 76,

        [Symbol("cdq")]
        CDQ = 77,

        [Symbol("cdqe")]
        CDQE = 78,

        [Symbol("clac")]
        CLAC = 79,

        [Symbol("clc")]
        CLC = 80,

        [Symbol("cld")]
        CLD = 81,

        [Symbol("cldemote")]
        CLDEMOTE = 82,

        [Symbol("clflush")]
        CLFLUSH = 83,

        [Symbol("clflushopt")]
        CLFLUSHOPT = 84,

        [Symbol("clgi")]
        CLGI = 85,

        [Symbol("cli")]
        CLI = 86,

        [Symbol("clrssbsy")]
        CLRSSBSY = 87,

        [Symbol("clts")]
        CLTS = 88,

        [Symbol("clui")]
        CLUI = 89,

        [Symbol("clwb")]
        CLWB = 90,

        [Symbol("clzero")]
        CLZERO = 91,

        [Symbol("cmc")]
        CMC = 92,

        [Symbol("cmovb")]
        CMOVB = 93,

        [Symbol("cmovbe")]
        CMOVBE = 94,

        [Symbol("cmovl")]
        CMOVL = 95,

        [Symbol("cmovle")]
        CMOVLE = 96,

        [Symbol("cmovnb")]
        CMOVNB = 97,

        [Symbol("cmovnbe")]
        CMOVNBE = 98,

        [Symbol("cmovnl")]
        CMOVNL = 99,

        [Symbol("cmovnle")]
        CMOVNLE = 100,

        [Symbol("cmovno")]
        CMOVNO = 101,

        [Symbol("cmovnp")]
        CMOVNP = 102,

        [Symbol("cmovns")]
        CMOVNS = 103,

        [Symbol("cmovnz")]
        CMOVNZ = 104,

        [Symbol("cmovo")]
        CMOVO = 105,

        [Symbol("cmovp")]
        CMOVP = 106,

        [Symbol("cmovs")]
        CMOVS = 107,

        [Symbol("cmovz")]
        CMOVZ = 108,

        [Symbol("cmp")]
        CMP = 109,

        [Symbol("cmppd")]
        CMPPD = 110,

        [Symbol("cmpps")]
        CMPPS = 111,

        [Symbol("cmpsb")]
        CMPSB = 112,

        [Symbol("cmpsd")]
        CMPSD = 113,

        [Symbol("cmpsd_xmm")]
        CMPSD_XMM = 114,

        [Symbol("cmpsq")]
        CMPSQ = 115,

        [Symbol("cmpss")]
        CMPSS = 116,

        [Symbol("cmpsw")]
        CMPSW = 117,

        [Symbol("cmpxchg")]
        CMPXCHG = 118,

        [Symbol("cmpxchg_lock")]
        CMPXCHG_LOCK = 119,

        [Symbol("cmpxchg16b")]
        CMPXCHG16B = 120,

        [Symbol("cmpxchg16b_lock")]
        CMPXCHG16B_LOCK = 121,

        [Symbol("cmpxchg8b")]
        CMPXCHG8B = 122,

        [Symbol("cmpxchg8b_lock")]
        CMPXCHG8B_LOCK = 123,

        [Symbol("comisd")]
        COMISD = 124,

        [Symbol("comiss")]
        COMISS = 125,

        [Symbol("cpuid")]
        CPUID = 126,

        [Symbol("cqo")]
        CQO = 127,

        [Symbol("crc32")]
        CRC32 = 128,

        [Symbol("cvtdq2pd")]
        CVTDQ2PD = 129,

        [Symbol("cvtdq2ps")]
        CVTDQ2PS = 130,

        [Symbol("cvtpd2dq")]
        CVTPD2DQ = 131,

        [Symbol("cvtpd2pi")]
        CVTPD2PI = 132,

        [Symbol("cvtpd2ps")]
        CVTPD2PS = 133,

        [Symbol("cvtpi2pd")]
        CVTPI2PD = 134,

        [Symbol("cvtpi2ps")]
        CVTPI2PS = 135,

        [Symbol("cvtps2dq")]
        CVTPS2DQ = 136,

        [Symbol("cvtps2pd")]
        CVTPS2PD = 137,

        [Symbol("cvtps2pi")]
        CVTPS2PI = 138,

        [Symbol("cvtsd2si")]
        CVTSD2SI = 139,

        [Symbol("cvtsd2ss")]
        CVTSD2SS = 140,

        [Symbol("cvtsi2sd")]
        CVTSI2SD = 141,

        [Symbol("cvtsi2ss")]
        CVTSI2SS = 142,

        [Symbol("cvtss2sd")]
        CVTSS2SD = 143,

        [Symbol("cvtss2si")]
        CVTSS2SI = 144,

        [Symbol("cvttpd2dq")]
        CVTTPD2DQ = 145,

        [Symbol("cvttpd2pi")]
        CVTTPD2PI = 146,

        [Symbol("cvttps2dq")]
        CVTTPS2DQ = 147,

        [Symbol("cvttps2pi")]
        CVTTPS2PI = 148,

        [Symbol("cvttsd2si")]
        CVTTSD2SI = 149,

        [Symbol("cvttss2si")]
        CVTTSS2SI = 150,

        [Symbol("cwd")]
        CWD = 151,

        [Symbol("cwde")]
        CWDE = 152,

        [Symbol("daa")]
        DAA = 153,

        [Symbol("das")]
        DAS = 154,

        [Symbol("dec")]
        DEC = 155,

        [Symbol("dec_lock")]
        DEC_LOCK = 156,

        [Symbol("div")]
        DIV = 157,

        [Symbol("divpd")]
        DIVPD = 158,

        [Symbol("divps")]
        DIVPS = 159,

        [Symbol("divsd")]
        DIVSD = 160,

        [Symbol("divss")]
        DIVSS = 161,

        [Symbol("dppd")]
        DPPD = 162,

        [Symbol("dpps")]
        DPPS = 163,

        [Symbol("emms")]
        EMMS = 164,

        [Symbol("encls")]
        ENCLS = 165,

        [Symbol("enclu")]
        ENCLU = 166,

        [Symbol("enclv")]
        ENCLV = 167,

        [Symbol("encodekey128")]
        ENCODEKEY128 = 168,

        [Symbol("encodekey256")]
        ENCODEKEY256 = 169,

        [Symbol("endbr32")]
        ENDBR32 = 170,

        [Symbol("endbr64")]
        ENDBR64 = 171,

        [Symbol("enqcmd")]
        ENQCMD = 172,

        [Symbol("enqcmds")]
        ENQCMDS = 173,

        [Symbol("enter")]
        ENTER = 174,

        [Symbol("extractps")]
        EXTRACTPS = 175,

        [Symbol("extrq")]
        EXTRQ = 176,

        [Symbol("f2xm1")]
        F2XM1 = 177,

        [Symbol("fabs")]
        FABS = 178,

        [Symbol("fadd")]
        FADD = 179,

        [Symbol("faddp")]
        FADDP = 180,

        [Symbol("fbld")]
        FBLD = 181,

        [Symbol("fbstp")]
        FBSTP = 182,

        [Symbol("fchs")]
        FCHS = 183,

        [Symbol("fcmovb")]
        FCMOVB = 184,

        [Symbol("fcmovbe")]
        FCMOVBE = 185,

        [Symbol("fcmove")]
        FCMOVE = 186,

        [Symbol("fcmovnb")]
        FCMOVNB = 187,

        [Symbol("fcmovnbe")]
        FCMOVNBE = 188,

        [Symbol("fcmovne")]
        FCMOVNE = 189,

        [Symbol("fcmovnu")]
        FCMOVNU = 190,

        [Symbol("fcmovu")]
        FCMOVU = 191,

        [Symbol("fcom")]
        FCOM = 192,

        [Symbol("fcomi")]
        FCOMI = 193,

        [Symbol("fcomip")]
        FCOMIP = 194,

        [Symbol("fcomp")]
        FCOMP = 195,

        [Symbol("fcompp")]
        FCOMPP = 196,

        [Symbol("fcos")]
        FCOS = 197,

        [Symbol("fdecstp")]
        FDECSTP = 198,

        [Symbol("fdisi8087_nop")]
        FDISI8087_NOP = 199,

        [Symbol("fdiv")]
        FDIV = 200,

        [Symbol("fdivp")]
        FDIVP = 201,

        [Symbol("fdivr")]
        FDIVR = 202,

        [Symbol("fdivrp")]
        FDIVRP = 203,

        [Symbol("femms")]
        FEMMS = 204,

        [Symbol("feni8087_nop")]
        FENI8087_NOP = 205,

        [Symbol("ffree")]
        FFREE = 206,

        [Symbol("ffreep")]
        FFREEP = 207,

        [Symbol("fiadd")]
        FIADD = 208,

        [Symbol("ficom")]
        FICOM = 209,

        [Symbol("ficomp")]
        FICOMP = 210,

        [Symbol("fidiv")]
        FIDIV = 211,

        [Symbol("fidivr")]
        FIDIVR = 212,

        [Symbol("fild")]
        FILD = 213,

        [Symbol("fimul")]
        FIMUL = 214,

        [Symbol("fincstp")]
        FINCSTP = 215,

        [Symbol("fist")]
        FIST = 216,

        [Symbol("fistp")]
        FISTP = 217,

        [Symbol("fisttp")]
        FISTTP = 218,

        [Symbol("fisub")]
        FISUB = 219,

        [Symbol("fisubr")]
        FISUBR = 220,

        [Symbol("fld")]
        FLD = 221,

        [Symbol("fld1")]
        FLD1 = 222,

        [Symbol("fldcw")]
        FLDCW = 223,

        [Symbol("fldenv")]
        FLDENV = 224,

        [Symbol("fldl2e")]
        FLDL2E = 225,

        [Symbol("fldl2t")]
        FLDL2T = 226,

        [Symbol("fldlg2")]
        FLDLG2 = 227,

        [Symbol("fldln2")]
        FLDLN2 = 228,

        [Symbol("fldpi")]
        FLDPI = 229,

        [Symbol("fldz")]
        FLDZ = 230,

        [Symbol("fmul")]
        FMUL = 231,

        [Symbol("fmulp")]
        FMULP = 232,

        [Symbol("fnclex")]
        FNCLEX = 233,

        [Symbol("fninit")]
        FNINIT = 234,

        [Symbol("fnop")]
        FNOP = 235,

        [Symbol("fnsave")]
        FNSAVE = 236,

        [Symbol("fnstcw")]
        FNSTCW = 237,

        [Symbol("fnstenv")]
        FNSTENV = 238,

        [Symbol("fnstsw")]
        FNSTSW = 239,

        [Symbol("fpatan")]
        FPATAN = 240,

        [Symbol("fprem")]
        FPREM = 241,

        [Symbol("fprem1")]
        FPREM1 = 242,

        [Symbol("fptan")]
        FPTAN = 243,

        [Symbol("frndint")]
        FRNDINT = 244,

        [Symbol("frstor")]
        FRSTOR = 245,

        [Symbol("fscale")]
        FSCALE = 246,

        [Symbol("fsetpm287_nop")]
        FSETPM287_NOP = 247,

        [Symbol("fsin")]
        FSIN = 248,

        [Symbol("fsincos")]
        FSINCOS = 249,

        [Symbol("fsqrt")]
        FSQRT = 250,

        [Symbol("fst")]
        FST = 251,

        [Symbol("fstp")]
        FSTP = 252,

        [Symbol("fstpnce")]
        FSTPNCE = 253,

        [Symbol("fsub")]
        FSUB = 254,

        [Symbol("fsubp")]
        FSUBP = 255,

        [Symbol("fsubr")]
        FSUBR = 256,

        [Symbol("fsubrp")]
        FSUBRP = 257,

        [Symbol("ftst")]
        FTST = 258,

        [Symbol("fucom")]
        FUCOM = 259,

        [Symbol("fucomi")]
        FUCOMI = 260,

        [Symbol("fucomip")]
        FUCOMIP = 261,

        [Symbol("fucomp")]
        FUCOMP = 262,

        [Symbol("fucompp")]
        FUCOMPP = 263,

        [Symbol("fwait")]
        FWAIT = 264,

        [Symbol("fxam")]
        FXAM = 265,

        [Symbol("fxch")]
        FXCH = 266,

        [Symbol("fxrstor")]
        FXRSTOR = 267,

        [Symbol("fxrstor64")]
        FXRSTOR64 = 268,

        [Symbol("fxsave")]
        FXSAVE = 269,

        [Symbol("fxsave64")]
        FXSAVE64 = 270,

        [Symbol("fxtract")]
        FXTRACT = 271,

        [Symbol("fyl2x")]
        FYL2X = 272,

        [Symbol("fyl2xp1")]
        FYL2XP1 = 273,

        [Symbol("getsec")]
        GETSEC = 274,

        [Symbol("gf2p8affineinvqb")]
        GF2P8AFFINEINVQB = 275,

        [Symbol("gf2p8affineqb")]
        GF2P8AFFINEQB = 276,

        [Symbol("gf2p8mulb")]
        GF2P8MULB = 277,

        [Symbol("haddpd")]
        HADDPD = 278,

        [Symbol("haddps")]
        HADDPS = 279,

        [Symbol("hlt")]
        HLT = 280,

        [Symbol("hreset")]
        HRESET = 281,

        [Symbol("hsubpd")]
        HSUBPD = 282,

        [Symbol("hsubps")]
        HSUBPS = 283,

        [Symbol("idiv")]
        IDIV = 284,

        [Symbol("imul")]
        IMUL = 285,

        [Symbol("in")]
        IN = 286,

        [Symbol("inc")]
        INC = 287,

        [Symbol("inc_lock")]
        INC_LOCK = 288,

        [Symbol("incsspd")]
        INCSSPD = 289,

        [Symbol("incsspq")]
        INCSSPQ = 290,

        [Symbol("insb")]
        INSB = 291,

        [Symbol("insd")]
        INSD = 292,

        [Symbol("insertps")]
        INSERTPS = 293,

        [Symbol("insertq")]
        INSERTQ = 294,

        [Symbol("insw")]
        INSW = 295,

        [Symbol("int")]
        INT = 296,

        [Symbol("int1")]
        INT1 = 297,

        [Symbol("int3")]
        INT3 = 298,

        [Symbol("into")]
        INTO = 299,

        [Symbol("invd")]
        INVD = 300,

        [Symbol("invept")]
        INVEPT = 301,

        [Symbol("invlpg")]
        INVLPG = 302,

        [Symbol("invlpga")]
        INVLPGA = 303,

        [Symbol("invlpgb")]
        INVLPGB = 304,

        [Symbol("invpcid")]
        INVPCID = 305,

        [Symbol("invvpid")]
        INVVPID = 306,

        [Symbol("iret")]
        IRET = 307,

        [Symbol("iretd")]
        IRETD = 308,

        [Symbol("iretq")]
        IRETQ = 309,

        [Symbol("jb")]
        JB = 310,

        [Symbol("jbe")]
        JBE = 311,

        [Symbol("jcxz")]
        JCXZ = 312,

        [Symbol("jecxz")]
        JECXZ = 313,

        [Symbol("jl")]
        JL = 314,

        [Symbol("jle")]
        JLE = 315,

        [Symbol("jmp")]
        JMP = 316,

        [Symbol("jmp_far")]
        JMP_FAR = 317,

        [Symbol("jnb")]
        JNB = 318,

        [Symbol("jnbe")]
        JNBE = 319,

        [Symbol("jnl")]
        JNL = 320,

        [Symbol("jnle")]
        JNLE = 321,

        [Symbol("jno")]
        JNO = 322,

        [Symbol("jnp")]
        JNP = 323,

        [Symbol("jns")]
        JNS = 324,

        [Symbol("jnz")]
        JNZ = 325,

        [Symbol("jo")]
        JO = 326,

        [Symbol("jp")]
        JP = 327,

        [Symbol("jrcxz")]
        JRCXZ = 328,

        [Symbol("js")]
        JS = 329,

        [Symbol("jz")]
        JZ = 330,

        [Symbol("kaddb")]
        KADDB = 331,

        [Symbol("kaddd")]
        KADDD = 332,

        [Symbol("kaddq")]
        KADDQ = 333,

        [Symbol("kaddw")]
        KADDW = 334,

        [Symbol("kandb")]
        KANDB = 335,

        [Symbol("kandd")]
        KANDD = 336,

        [Symbol("kandnb")]
        KANDNB = 337,

        [Symbol("kandnd")]
        KANDND = 338,

        [Symbol("kandnq")]
        KANDNQ = 339,

        [Symbol("kandnw")]
        KANDNW = 340,

        [Symbol("kandq")]
        KANDQ = 341,

        [Symbol("kandw")]
        KANDW = 342,

        [Symbol("kmovb")]
        KMOVB = 343,

        [Symbol("kmovd")]
        KMOVD = 344,

        [Symbol("kmovq")]
        KMOVQ = 345,

        [Symbol("kmovw")]
        KMOVW = 346,

        [Symbol("knotb")]
        KNOTB = 347,

        [Symbol("knotd")]
        KNOTD = 348,

        [Symbol("knotq")]
        KNOTQ = 349,

        [Symbol("knotw")]
        KNOTW = 350,

        [Symbol("korb")]
        KORB = 351,

        [Symbol("kord")]
        KORD = 352,

        [Symbol("korq")]
        KORQ = 353,

        [Symbol("kortestb")]
        KORTESTB = 354,

        [Symbol("kortestd")]
        KORTESTD = 355,

        [Symbol("kortestq")]
        KORTESTQ = 356,

        [Symbol("kortestw")]
        KORTESTW = 357,

        [Symbol("korw")]
        KORW = 358,

        [Symbol("kshiftlb")]
        KSHIFTLB = 359,

        [Symbol("kshiftld")]
        KSHIFTLD = 360,

        [Symbol("kshiftlq")]
        KSHIFTLQ = 361,

        [Symbol("kshiftlw")]
        KSHIFTLW = 362,

        [Symbol("kshiftrb")]
        KSHIFTRB = 363,

        [Symbol("kshiftrd")]
        KSHIFTRD = 364,

        [Symbol("kshiftrq")]
        KSHIFTRQ = 365,

        [Symbol("kshiftrw")]
        KSHIFTRW = 366,

        [Symbol("ktestb")]
        KTESTB = 367,

        [Symbol("ktestd")]
        KTESTD = 368,

        [Symbol("ktestq")]
        KTESTQ = 369,

        [Symbol("ktestw")]
        KTESTW = 370,

        [Symbol("kunpckbw")]
        KUNPCKBW = 371,

        [Symbol("kunpckdq")]
        KUNPCKDQ = 372,

        [Symbol("kunpckwd")]
        KUNPCKWD = 373,

        [Symbol("kxnorb")]
        KXNORB = 374,

        [Symbol("kxnord")]
        KXNORD = 375,

        [Symbol("kxnorq")]
        KXNORQ = 376,

        [Symbol("kxnorw")]
        KXNORW = 377,

        [Symbol("kxorb")]
        KXORB = 378,

        [Symbol("kxord")]
        KXORD = 379,

        [Symbol("kxorq")]
        KXORQ = 380,

        [Symbol("kxorw")]
        KXORW = 381,

        [Symbol("lahf")]
        LAHF = 382,

        [Symbol("lar")]
        LAR = 383,

        [Symbol("lddqu")]
        LDDQU = 384,

        [Symbol("ldmxcsr")]
        LDMXCSR = 385,

        [Symbol("lds")]
        LDS = 386,

        [Symbol("ldtilecfg")]
        LDTILECFG = 387,

        [Symbol("lea")]
        LEA = 388,

        [Symbol("leave")]
        LEAVE = 389,

        [Symbol("les")]
        LES = 390,

        [Symbol("lfence")]
        LFENCE = 391,

        [Symbol("lfs")]
        LFS = 392,

        [Symbol("lgdt")]
        LGDT = 393,

        [Symbol("lgs")]
        LGS = 394,

        [Symbol("lidt")]
        LIDT = 395,

        [Symbol("lldt")]
        LLDT = 396,

        [Symbol("llwpcb")]
        LLWPCB = 397,

        [Symbol("lmsw")]
        LMSW = 398,

        [Symbol("loadiwkey")]
        LOADIWKEY = 399,

        [Symbol("lodsb")]
        LODSB = 400,

        [Symbol("lodsd")]
        LODSD = 401,

        [Symbol("lodsq")]
        LODSQ = 402,

        [Symbol("lodsw")]
        LODSW = 403,

        [Symbol("loop")]
        LOOP = 404,

        [Symbol("loope")]
        LOOPE = 405,

        [Symbol("loopne")]
        LOOPNE = 406,

        [Symbol("lsl")]
        LSL = 407,

        [Symbol("lss")]
        LSS = 408,

        [Symbol("ltr")]
        LTR = 409,

        [Symbol("lwpins")]
        LWPINS = 410,

        [Symbol("lwpval")]
        LWPVAL = 411,

        [Symbol("lzcnt")]
        LZCNT = 412,

        [Symbol("maskmovdqu")]
        MASKMOVDQU = 413,

        [Symbol("maskmovq")]
        MASKMOVQ = 414,

        [Symbol("maxpd")]
        MAXPD = 415,

        [Symbol("maxps")]
        MAXPS = 416,

        [Symbol("maxsd")]
        MAXSD = 417,

        [Symbol("maxss")]
        MAXSS = 418,

        [Symbol("mcommit")]
        MCOMMIT = 419,

        [Symbol("mfence")]
        MFENCE = 420,

        [Symbol("minpd")]
        MINPD = 421,

        [Symbol("minps")]
        MINPS = 422,

        [Symbol("minsd")]
        MINSD = 423,

        [Symbol("minss")]
        MINSS = 424,

        [Symbol("monitor")]
        MONITOR = 425,

        [Symbol("monitorx")]
        MONITORX = 426,

        [Symbol("mov")]
        MOV = 427,

        [Symbol("mov_cr")]
        MOV_CR = 428,

        [Symbol("mov_dr")]
        MOV_DR = 429,

        [Symbol("movapd")]
        MOVAPD = 430,

        [Symbol("movaps")]
        MOVAPS = 431,

        [Symbol("movbe")]
        MOVBE = 432,

        [Symbol("movd")]
        MOVD = 433,

        [Symbol("movddup")]
        MOVDDUP = 434,

        [Symbol("movdir64b")]
        MOVDIR64B = 435,

        [Symbol("movdiri")]
        MOVDIRI = 436,

        [Symbol("movdq2q")]
        MOVDQ2Q = 437,

        [Symbol("movdqa")]
        MOVDQA = 438,

        [Symbol("movdqu")]
        MOVDQU = 439,

        [Symbol("movhlps")]
        MOVHLPS = 440,

        [Symbol("movhpd")]
        MOVHPD = 441,

        [Symbol("movhps")]
        MOVHPS = 442,

        [Symbol("movlhps")]
        MOVLHPS = 443,

        [Symbol("movlpd")]
        MOVLPD = 444,

        [Symbol("movlps")]
        MOVLPS = 445,

        [Symbol("movmskpd")]
        MOVMSKPD = 446,

        [Symbol("movmskps")]
        MOVMSKPS = 447,

        [Symbol("movntdq")]
        MOVNTDQ = 448,

        [Symbol("movntdqa")]
        MOVNTDQA = 449,

        [Symbol("movnti")]
        MOVNTI = 450,

        [Symbol("movntpd")]
        MOVNTPD = 451,

        [Symbol("movntps")]
        MOVNTPS = 452,

        [Symbol("movntq")]
        MOVNTQ = 453,

        [Symbol("movntsd")]
        MOVNTSD = 454,

        [Symbol("movntss")]
        MOVNTSS = 455,

        [Symbol("movq")]
        MOVQ = 456,

        [Symbol("movq2dq")]
        MOVQ2DQ = 457,

        [Symbol("movsb")]
        MOVSB = 458,

        [Symbol("movsd")]
        MOVSD = 459,

        [Symbol("movsd_xmm")]
        MOVSD_XMM = 460,

        [Symbol("movshdup")]
        MOVSHDUP = 461,

        [Symbol("movsldup")]
        MOVSLDUP = 462,

        [Symbol("movsq")]
        MOVSQ = 463,

        [Symbol("movss")]
        MOVSS = 464,

        [Symbol("movsw")]
        MOVSW = 465,

        [Symbol("movsx")]
        MOVSX = 466,

        [Symbol("movsxd")]
        MOVSXD = 467,

        [Symbol("movupd")]
        MOVUPD = 468,

        [Symbol("movups")]
        MOVUPS = 469,

        [Symbol("movzx")]
        MOVZX = 470,

        [Symbol("mpsadbw")]
        MPSADBW = 471,

        [Symbol("mul")]
        MUL = 472,

        [Symbol("mulpd")]
        MULPD = 473,

        [Symbol("mulps")]
        MULPS = 474,

        [Symbol("mulsd")]
        MULSD = 475,

        [Symbol("mulss")]
        MULSS = 476,

        [Symbol("mulx")]
        MULX = 477,

        [Symbol("mwait")]
        MWAIT = 478,

        [Symbol("mwaitx")]
        MWAITX = 479,

        [Symbol("neg")]
        NEG = 480,

        [Symbol("neg_lock")]
        NEG_LOCK = 481,

        [Symbol("none")]
        None = 482,

        [Symbol("nop")]
        NOP = 483,

        [Symbol("nop2")]
        NOP2 = 484,

        [Symbol("nop3")]
        NOP3 = 485,

        [Symbol("nop4")]
        NOP4 = 486,

        [Symbol("nop5")]
        NOP5 = 487,

        [Symbol("nop6")]
        NOP6 = 488,

        [Symbol("nop7")]
        NOP7 = 489,

        [Symbol("nop8")]
        NOP8 = 490,

        [Symbol("nop9")]
        NOP9 = 491,

        [Symbol("not")]
        NOT = 492,

        [Symbol("not_lock")]
        NOT_LOCK = 493,

        [Symbol("or")]
        OR = 494,

        [Symbol("or_lock")]
        OR_LOCK = 495,

        [Symbol("orpd")]
        ORPD = 496,

        [Symbol("orps")]
        ORPS = 497,

        [Symbol("out")]
        OUT = 498,

        [Symbol("outsb")]
        OUTSB = 499,

        [Symbol("outsd")]
        OUTSD = 500,

        [Symbol("outsw")]
        OUTSW = 501,

        [Symbol("pabsb")]
        PABSB = 502,

        [Symbol("pabsd")]
        PABSD = 503,

        [Symbol("pabsw")]
        PABSW = 504,

        [Symbol("packssdw")]
        PACKSSDW = 505,

        [Symbol("packsswb")]
        PACKSSWB = 506,

        [Symbol("packusdw")]
        PACKUSDW = 507,

        [Symbol("packuswb")]
        PACKUSWB = 508,

        [Symbol("paddb")]
        PADDB = 509,

        [Symbol("paddd")]
        PADDD = 510,

        [Symbol("paddq")]
        PADDQ = 511,

        [Symbol("paddsb")]
        PADDSB = 512,

        [Symbol("paddsw")]
        PADDSW = 513,

        [Symbol("paddusb")]
        PADDUSB = 514,

        [Symbol("paddusw")]
        PADDUSW = 515,

        [Symbol("paddw")]
        PADDW = 516,

        [Symbol("palignr")]
        PALIGNR = 517,

        [Symbol("pand")]
        PAND = 518,

        [Symbol("pandn")]
        PANDN = 519,

        [Symbol("pause")]
        PAUSE = 520,

        [Symbol("pavgb")]
        PAVGB = 521,

        [Symbol("pavgusb")]
        PAVGUSB = 522,

        [Symbol("pavgw")]
        PAVGW = 523,

        [Symbol("pblendvb")]
        PBLENDVB = 524,

        [Symbol("pblendw")]
        PBLENDW = 525,

        [Symbol("pclmulqdq")]
        PCLMULQDQ = 526,

        [Symbol("pcmpeqb")]
        PCMPEQB = 527,

        [Symbol("pcmpeqd")]
        PCMPEQD = 528,

        [Symbol("pcmpeqq")]
        PCMPEQQ = 529,

        [Symbol("pcmpeqw")]
        PCMPEQW = 530,

        [Symbol("pcmpestri")]
        PCMPESTRI = 531,

        [Symbol("pcmpestri64")]
        PCMPESTRI64 = 532,

        [Symbol("pcmpestrm")]
        PCMPESTRM = 533,

        [Symbol("pcmpestrm64")]
        PCMPESTRM64 = 534,

        [Symbol("pcmpgtb")]
        PCMPGTB = 535,

        [Symbol("pcmpgtd")]
        PCMPGTD = 536,

        [Symbol("pcmpgtq")]
        PCMPGTQ = 537,

        [Symbol("pcmpgtw")]
        PCMPGTW = 538,

        [Symbol("pcmpistri")]
        PCMPISTRI = 539,

        [Symbol("pcmpistri64")]
        PCMPISTRI64 = 540,

        [Symbol("pcmpistrm")]
        PCMPISTRM = 541,

        [Symbol("pconfig")]
        PCONFIG = 542,

        [Symbol("pdep")]
        PDEP = 543,

        [Symbol("pext")]
        PEXT = 544,

        [Symbol("pextrb")]
        PEXTRB = 545,

        [Symbol("pextrd")]
        PEXTRD = 546,

        [Symbol("pextrq")]
        PEXTRQ = 547,

        [Symbol("pextrw")]
        PEXTRW = 548,

        [Symbol("pextrw_sse4")]
        PEXTRW_SSE4 = 549,

        [Symbol("pf2id")]
        PF2ID = 550,

        [Symbol("pf2iw")]
        PF2IW = 551,

        [Symbol("pfacc")]
        PFACC = 552,

        [Symbol("pfadd")]
        PFADD = 553,

        [Symbol("pfcmpeq")]
        PFCMPEQ = 554,

        [Symbol("pfcmpge")]
        PFCMPGE = 555,

        [Symbol("pfcmpgt")]
        PFCMPGT = 556,

        [Symbol("pfmax")]
        PFMAX = 557,

        [Symbol("pfmin")]
        PFMIN = 558,

        [Symbol("pfmul")]
        PFMUL = 559,

        [Symbol("pfnacc")]
        PFNACC = 560,

        [Symbol("pfpnacc")]
        PFPNACC = 561,

        [Symbol("pfrcp")]
        PFRCP = 562,

        [Symbol("pfrcpit1")]
        PFRCPIT1 = 563,

        [Symbol("pfrcpit2")]
        PFRCPIT2 = 564,

        [Symbol("pfrsqit1")]
        PFRSQIT1 = 565,

        [Symbol("pfrsqrt")]
        PFRSQRT = 566,

        [Symbol("pfsub")]
        PFSUB = 567,

        [Symbol("pfsubr")]
        PFSUBR = 568,

        [Symbol("phaddd")]
        PHADDD = 569,

        [Symbol("phaddsw")]
        PHADDSW = 570,

        [Symbol("phaddw")]
        PHADDW = 571,

        [Symbol("phminposuw")]
        PHMINPOSUW = 572,

        [Symbol("phsubd")]
        PHSUBD = 573,

        [Symbol("phsubsw")]
        PHSUBSW = 574,

        [Symbol("phsubw")]
        PHSUBW = 575,

        [Symbol("pi2fd")]
        PI2FD = 576,

        [Symbol("pi2fw")]
        PI2FW = 577,

        [Symbol("pinsrb")]
        PINSRB = 578,

        [Symbol("pinsrd")]
        PINSRD = 579,

        [Symbol("pinsrq")]
        PINSRQ = 580,

        [Symbol("pinsrw")]
        PINSRW = 581,

        [Symbol("pmaddubsw")]
        PMADDUBSW = 582,

        [Symbol("pmaddwd")]
        PMADDWD = 583,

        [Symbol("pmaxsb")]
        PMAXSB = 584,

        [Symbol("pmaxsd")]
        PMAXSD = 585,

        [Symbol("pmaxsw")]
        PMAXSW = 586,

        [Symbol("pmaxub")]
        PMAXUB = 587,

        [Symbol("pmaxud")]
        PMAXUD = 588,

        [Symbol("pmaxuw")]
        PMAXUW = 589,

        [Symbol("pminsb")]
        PMINSB = 590,

        [Symbol("pminsd")]
        PMINSD = 591,

        [Symbol("pminsw")]
        PMINSW = 592,

        [Symbol("pminub")]
        PMINUB = 593,

        [Symbol("pminud")]
        PMINUD = 594,

        [Symbol("pminuw")]
        PMINUW = 595,

        [Symbol("pmovmskb")]
        PMOVMSKB = 596,

        [Symbol("pmovsxbd")]
        PMOVSXBD = 597,

        [Symbol("pmovsxbq")]
        PMOVSXBQ = 598,

        [Symbol("pmovsxbw")]
        PMOVSXBW = 599,

        [Symbol("pmovsxdq")]
        PMOVSXDQ = 600,

        [Symbol("pmovsxwd")]
        PMOVSXWD = 601,

        [Symbol("pmovsxwq")]
        PMOVSXWQ = 602,

        [Symbol("pmovzxbd")]
        PMOVZXBD = 603,

        [Symbol("pmovzxbq")]
        PMOVZXBQ = 604,

        [Symbol("pmovzxbw")]
        PMOVZXBW = 605,

        [Symbol("pmovzxdq")]
        PMOVZXDQ = 606,

        [Symbol("pmovzxwd")]
        PMOVZXWD = 607,

        [Symbol("pmovzxwq")]
        PMOVZXWQ = 608,

        [Symbol("pmuldq")]
        PMULDQ = 609,

        [Symbol("pmulhrsw")]
        PMULHRSW = 610,

        [Symbol("pmulhrw")]
        PMULHRW = 611,

        [Symbol("pmulhuw")]
        PMULHUW = 612,

        [Symbol("pmulhw")]
        PMULHW = 613,

        [Symbol("pmulld")]
        PMULLD = 614,

        [Symbol("pmullw")]
        PMULLW = 615,

        [Symbol("pmuludq")]
        PMULUDQ = 616,

        [Symbol("pop")]
        POP = 617,

        [Symbol("popa")]
        POPA = 618,

        [Symbol("popad")]
        POPAD = 619,

        [Symbol("popcnt")]
        POPCNT = 620,

        [Symbol("popf")]
        POPF = 621,

        [Symbol("popfd")]
        POPFD = 622,

        [Symbol("popfq")]
        POPFQ = 623,

        [Symbol("por")]
        POR = 624,

        [Symbol("prefetch_exclusive")]
        PREFETCH_EXCLUSIVE = 625,

        [Symbol("prefetch_reserved")]
        PREFETCH_RESERVED = 626,

        [Symbol("prefetchnta")]
        PREFETCHNTA = 627,

        [Symbol("prefetcht0")]
        PREFETCHT0 = 628,

        [Symbol("prefetcht1")]
        PREFETCHT1 = 629,

        [Symbol("prefetcht2")]
        PREFETCHT2 = 630,

        [Symbol("prefetchw")]
        PREFETCHW = 631,

        [Symbol("prefetchwt1")]
        PREFETCHWT1 = 632,

        [Symbol("psadbw")]
        PSADBW = 633,

        [Symbol("pshufb")]
        PSHUFB = 634,

        [Symbol("pshufd")]
        PSHUFD = 635,

        [Symbol("pshufhw")]
        PSHUFHW = 636,

        [Symbol("pshuflw")]
        PSHUFLW = 637,

        [Symbol("pshufw")]
        PSHUFW = 638,

        [Symbol("psignb")]
        PSIGNB = 639,

        [Symbol("psignd")]
        PSIGND = 640,

        [Symbol("psignw")]
        PSIGNW = 641,

        [Symbol("pslld")]
        PSLLD = 642,

        [Symbol("pslldq")]
        PSLLDQ = 643,

        [Symbol("psllq")]
        PSLLQ = 644,

        [Symbol("psllw")]
        PSLLW = 645,

        [Symbol("psmash")]
        PSMASH = 646,

        [Symbol("psrad")]
        PSRAD = 647,

        [Symbol("psraw")]
        PSRAW = 648,

        [Symbol("psrld")]
        PSRLD = 649,

        [Symbol("psrldq")]
        PSRLDQ = 650,

        [Symbol("psrlq")]
        PSRLQ = 651,

        [Symbol("psrlw")]
        PSRLW = 652,

        [Symbol("psubb")]
        PSUBB = 653,

        [Symbol("psubd")]
        PSUBD = 654,

        [Symbol("psubq")]
        PSUBQ = 655,

        [Symbol("psubsb")]
        PSUBSB = 656,

        [Symbol("psubsw")]
        PSUBSW = 657,

        [Symbol("psubusb")]
        PSUBUSB = 658,

        [Symbol("psubusw")]
        PSUBUSW = 659,

        [Symbol("psubw")]
        PSUBW = 660,

        [Symbol("pswapd")]
        PSWAPD = 661,

        [Symbol("ptest")]
        PTEST = 662,

        [Symbol("ptwrite")]
        PTWRITE = 663,

        [Symbol("punpckhbw")]
        PUNPCKHBW = 664,

        [Symbol("punpckhdq")]
        PUNPCKHDQ = 665,

        [Symbol("punpckhqdq")]
        PUNPCKHQDQ = 666,

        [Symbol("punpckhwd")]
        PUNPCKHWD = 667,

        [Symbol("punpcklbw")]
        PUNPCKLBW = 668,

        [Symbol("punpckldq")]
        PUNPCKLDQ = 669,

        [Symbol("punpcklqdq")]
        PUNPCKLQDQ = 670,

        [Symbol("punpcklwd")]
        PUNPCKLWD = 671,

        [Symbol("push")]
        PUSH = 672,

        [Symbol("pusha")]
        PUSHA = 673,

        [Symbol("pushad")]
        PUSHAD = 674,

        [Symbol("pushf")]
        PUSHF = 675,

        [Symbol("pushfd")]
        PUSHFD = 676,

        [Symbol("pushfq")]
        PUSHFQ = 677,

        [Symbol("pvalidate")]
        PVALIDATE = 678,

        [Symbol("pxor")]
        PXOR = 679,

        [Symbol("rcl")]
        RCL = 680,

        [Symbol("rcpps")]
        RCPPS = 681,

        [Symbol("rcpss")]
        RCPSS = 682,

        [Symbol("rcr")]
        RCR = 683,

        [Symbol("rdfsbase")]
        RDFSBASE = 684,

        [Symbol("rdgsbase")]
        RDGSBASE = 685,

        [Symbol("rdmsr")]
        RDMSR = 686,

        [Symbol("rdpid")]
        RDPID = 687,

        [Symbol("rdpkru")]
        RDPKRU = 688,

        [Symbol("rdpmc")]
        RDPMC = 689,

        [Symbol("rdpru")]
        RDPRU = 690,

        [Symbol("rdrand")]
        RDRAND = 691,

        [Symbol("rdseed")]
        RDSEED = 692,

        [Symbol("rdsspd")]
        RDSSPD = 693,

        [Symbol("rdsspq")]
        RDSSPQ = 694,

        [Symbol("rdtsc")]
        RDTSC = 695,

        [Symbol("rdtscp")]
        RDTSCP = 696,

        [Symbol("rep_insb")]
        REP_INSB = 697,

        [Symbol("rep_insd")]
        REP_INSD = 698,

        [Symbol("rep_insw")]
        REP_INSW = 699,

        [Symbol("rep_lodsb")]
        REP_LODSB = 700,

        [Symbol("rep_lodsd")]
        REP_LODSD = 701,

        [Symbol("rep_lodsq")]
        REP_LODSQ = 702,

        [Symbol("rep_lodsw")]
        REP_LODSW = 703,

        [Symbol("rep_montmul")]
        REP_MONTMUL = 704,

        [Symbol("rep_movsb")]
        REP_MOVSB = 705,

        [Symbol("rep_movsd")]
        REP_MOVSD = 706,

        [Symbol("rep_movsq")]
        REP_MOVSQ = 707,

        [Symbol("rep_movsw")]
        REP_MOVSW = 708,

        [Symbol("rep_outsb")]
        REP_OUTSB = 709,

        [Symbol("rep_outsd")]
        REP_OUTSD = 710,

        [Symbol("rep_outsw")]
        REP_OUTSW = 711,

        [Symbol("rep_stosb")]
        REP_STOSB = 712,

        [Symbol("rep_stosd")]
        REP_STOSD = 713,

        [Symbol("rep_stosq")]
        REP_STOSQ = 714,

        [Symbol("rep_stosw")]
        REP_STOSW = 715,

        [Symbol("rep_xcryptcbc")]
        REP_XCRYPTCBC = 716,

        [Symbol("rep_xcryptcfb")]
        REP_XCRYPTCFB = 717,

        [Symbol("rep_xcryptctr")]
        REP_XCRYPTCTR = 718,

        [Symbol("rep_xcryptecb")]
        REP_XCRYPTECB = 719,

        [Symbol("rep_xcryptofb")]
        REP_XCRYPTOFB = 720,

        [Symbol("rep_xsha1")]
        REP_XSHA1 = 721,

        [Symbol("rep_xsha256")]
        REP_XSHA256 = 722,

        [Symbol("rep_xstore")]
        REP_XSTORE = 723,

        [Symbol("repe_cmpsb")]
        REPE_CMPSB = 724,

        [Symbol("repe_cmpsd")]
        REPE_CMPSD = 725,

        [Symbol("repe_cmpsq")]
        REPE_CMPSQ = 726,

        [Symbol("repe_cmpsw")]
        REPE_CMPSW = 727,

        [Symbol("repe_scasb")]
        REPE_SCASB = 728,

        [Symbol("repe_scasd")]
        REPE_SCASD = 729,

        [Symbol("repe_scasq")]
        REPE_SCASQ = 730,

        [Symbol("repe_scasw")]
        REPE_SCASW = 731,

        [Symbol("repne_cmpsb")]
        REPNE_CMPSB = 732,

        [Symbol("repne_cmpsd")]
        REPNE_CMPSD = 733,

        [Symbol("repne_cmpsq")]
        REPNE_CMPSQ = 734,

        [Symbol("repne_cmpsw")]
        REPNE_CMPSW = 735,

        [Symbol("repne_scasb")]
        REPNE_SCASB = 736,

        [Symbol("repne_scasd")]
        REPNE_SCASD = 737,

        [Symbol("repne_scasq")]
        REPNE_SCASQ = 738,

        [Symbol("repne_scasw")]
        REPNE_SCASW = 739,

        [Symbol("ret_far")]
        RET_FAR = 740,

        [Symbol("ret_near")]
        RET_NEAR = 741,

        [Symbol("rmpadjust")]
        RMPADJUST = 742,

        [Symbol("rmpupdate")]
        RMPUPDATE = 743,

        [Symbol("rol")]
        ROL = 744,

        [Symbol("ror")]
        ROR = 745,

        [Symbol("rorx")]
        RORX = 746,

        [Symbol("roundpd")]
        ROUNDPD = 747,

        [Symbol("roundps")]
        ROUNDPS = 748,

        [Symbol("roundsd")]
        ROUNDSD = 749,

        [Symbol("roundss")]
        ROUNDSS = 750,

        [Symbol("rsm")]
        RSM = 751,

        [Symbol("rsqrtps")]
        RSQRTPS = 752,

        [Symbol("rsqrtss")]
        RSQRTSS = 753,

        [Symbol("rstorssp")]
        RSTORSSP = 754,

        [Symbol("sahf")]
        SAHF = 755,

        [Symbol("salc")]
        SALC = 756,

        [Symbol("sar")]
        SAR = 757,

        [Symbol("sarx")]
        SARX = 758,

        [Symbol("saveprevssp")]
        SAVEPREVSSP = 759,

        [Symbol("sbb")]
        SBB = 760,

        [Symbol("sbb_lock")]
        SBB_LOCK = 761,

        [Symbol("scasb")]
        SCASB = 762,

        [Symbol("scasd")]
        SCASD = 763,

        [Symbol("scasq")]
        SCASQ = 764,

        [Symbol("scasw")]
        SCASW = 765,

        [Symbol("seamcall")]
        SEAMCALL = 766,

        [Symbol("seamops")]
        SEAMOPS = 767,

        [Symbol("seamret")]
        SEAMRET = 768,

        [Symbol("senduipi")]
        SENDUIPI = 769,

        [Symbol("serialize")]
        SERIALIZE = 770,

        [Symbol("setb")]
        SETB = 771,

        [Symbol("setbe")]
        SETBE = 772,

        [Symbol("setl")]
        SETL = 773,

        [Symbol("setle")]
        SETLE = 774,

        [Symbol("setnb")]
        SETNB = 775,

        [Symbol("setnbe")]
        SETNBE = 776,

        [Symbol("setnl")]
        SETNL = 777,

        [Symbol("setnle")]
        SETNLE = 778,

        [Symbol("setno")]
        SETNO = 779,

        [Symbol("setnp")]
        SETNP = 780,

        [Symbol("setns")]
        SETNS = 781,

        [Symbol("setnz")]
        SETNZ = 782,

        [Symbol("seto")]
        SETO = 783,

        [Symbol("setp")]
        SETP = 784,

        [Symbol("sets")]
        SETS = 785,

        [Symbol("setssbsy")]
        SETSSBSY = 786,

        [Symbol("setz")]
        SETZ = 787,

        [Symbol("sfence")]
        SFENCE = 788,

        [Symbol("sgdt")]
        SGDT = 789,

        [Symbol("sha1msg1")]
        SHA1MSG1 = 790,

        [Symbol("sha1msg2")]
        SHA1MSG2 = 791,

        [Symbol("sha1nexte")]
        SHA1NEXTE = 792,

        [Symbol("sha1rnds4")]
        SHA1RNDS4 = 793,

        [Symbol("sha256msg1")]
        SHA256MSG1 = 794,

        [Symbol("sha256msg2")]
        SHA256MSG2 = 795,

        [Symbol("sha256rnds2")]
        SHA256RNDS2 = 796,

        [Symbol("shl")]
        SHL = 797,

        [Symbol("shld")]
        SHLD = 798,

        [Symbol("shlx")]
        SHLX = 799,

        [Symbol("shr")]
        SHR = 800,

        [Symbol("shrd")]
        SHRD = 801,

        [Symbol("shrx")]
        SHRX = 802,

        [Symbol("shufpd")]
        SHUFPD = 803,

        [Symbol("shufps")]
        SHUFPS = 804,

        [Symbol("sidt")]
        SIDT = 805,

        [Symbol("skinit")]
        SKINIT = 806,

        [Symbol("sldt")]
        SLDT = 807,

        [Symbol("slwpcb")]
        SLWPCB = 808,

        [Symbol("smsw")]
        SMSW = 809,

        [Symbol("sqrtpd")]
        SQRTPD = 810,

        [Symbol("sqrtps")]
        SQRTPS = 811,

        [Symbol("sqrtsd")]
        SQRTSD = 812,

        [Symbol("sqrtss")]
        SQRTSS = 813,

        [Symbol("stac")]
        STAC = 814,

        [Symbol("stc")]
        STC = 815,

        [Symbol("std")]
        STD = 816,

        [Symbol("stgi")]
        STGI = 817,

        [Symbol("sti")]
        STI = 818,

        [Symbol("stmxcsr")]
        STMXCSR = 819,

        [Symbol("stosb")]
        STOSB = 820,

        [Symbol("stosd")]
        STOSD = 821,

        [Symbol("stosq")]
        STOSQ = 822,

        [Symbol("stosw")]
        STOSW = 823,

        [Symbol("str")]
        STR = 824,

        [Symbol("sttilecfg")]
        STTILECFG = 825,

        [Symbol("stui")]
        STUI = 826,

        [Symbol("sub")]
        SUB = 827,

        [Symbol("sub_lock")]
        SUB_LOCK = 828,

        [Symbol("subpd")]
        SUBPD = 829,

        [Symbol("subps")]
        SUBPS = 830,

        [Symbol("subsd")]
        SUBSD = 831,

        [Symbol("subss")]
        SUBSS = 832,

        [Symbol("swapgs")]
        SWAPGS = 833,

        [Symbol("syscall")]
        SYSCALL = 834,

        [Symbol("syscall_amd")]
        SYSCALL_AMD = 835,

        [Symbol("sysenter")]
        SYSENTER = 836,

        [Symbol("sysexit")]
        SYSEXIT = 837,

        [Symbol("sysret")]
        SYSRET = 838,

        [Symbol("sysret_amd")]
        SYSRET_AMD = 839,

        [Symbol("sysret64")]
        SYSRET64 = 840,

        [Symbol("t1mskc")]
        T1MSKC = 841,

        [Symbol("tdcall")]
        TDCALL = 842,

        [Symbol("tdpbf16ps")]
        TDPBF16PS = 843,

        [Symbol("tdpbssd")]
        TDPBSSD = 844,

        [Symbol("tdpbsud")]
        TDPBSUD = 845,

        [Symbol("tdpbusd")]
        TDPBUSD = 846,

        [Symbol("tdpbuud")]
        TDPBUUD = 847,

        [Symbol("test")]
        TEST = 848,

        [Symbol("testui")]
        TESTUI = 849,

        [Symbol("tileloadd")]
        TILELOADD = 850,

        [Symbol("tileloaddt1")]
        TILELOADDT1 = 851,

        [Symbol("tilerelease")]
        TILERELEASE = 852,

        [Symbol("tilestored")]
        TILESTORED = 853,

        [Symbol("tilezero")]
        TILEZERO = 854,

        [Symbol("tlbsync")]
        TLBSYNC = 855,

        [Symbol("tpause")]
        TPAUSE = 856,

        [Symbol("tzcnt")]
        TZCNT = 857,

        [Symbol("tzmsk")]
        TZMSK = 858,

        [Symbol("ucomisd")]
        UCOMISD = 859,

        [Symbol("ucomiss")]
        UCOMISS = 860,

        [Symbol("ud0")]
        UD0 = 861,

        [Symbol("ud1")]
        UD1 = 862,

        [Symbol("ud2")]
        UD2 = 863,

        [Symbol("uiret")]
        UIRET = 864,

        [Symbol("umonitor")]
        UMONITOR = 865,

        [Symbol("umwait")]
        UMWAIT = 866,

        [Symbol("unpckhpd")]
        UNPCKHPD = 867,

        [Symbol("unpckhps")]
        UNPCKHPS = 868,

        [Symbol("unpcklpd")]
        UNPCKLPD = 869,

        [Symbol("unpcklps")]
        UNPCKLPS = 870,

        [Symbol("v4fmaddps")]
        V4FMADDPS = 871,

        [Symbol("v4fmaddss")]
        V4FMADDSS = 872,

        [Symbol("v4fnmaddps")]
        V4FNMADDPS = 873,

        [Symbol("v4fnmaddss")]
        V4FNMADDSS = 874,

        [Symbol("vaddpd")]
        VADDPD = 875,

        [Symbol("vaddps")]
        VADDPS = 876,

        [Symbol("vaddsd")]
        VADDSD = 877,

        [Symbol("vaddss")]
        VADDSS = 878,

        [Symbol("vaddsubpd")]
        VADDSUBPD = 879,

        [Symbol("vaddsubps")]
        VADDSUBPS = 880,

        [Symbol("vaesdec")]
        VAESDEC = 881,

        [Symbol("vaesdeclast")]
        VAESDECLAST = 882,

        [Symbol("vaesenc")]
        VAESENC = 883,

        [Symbol("vaesenclast")]
        VAESENCLAST = 884,

        [Symbol("vaesimc")]
        VAESIMC = 885,

        [Symbol("vaeskeygenassist")]
        VAESKEYGENASSIST = 886,

        [Symbol("valignd")]
        VALIGND = 887,

        [Symbol("valignq")]
        VALIGNQ = 888,

        [Symbol("vandnpd")]
        VANDNPD = 889,

        [Symbol("vandnps")]
        VANDNPS = 890,

        [Symbol("vandpd")]
        VANDPD = 891,

        [Symbol("vandps")]
        VANDPS = 892,

        [Symbol("vblendmpd")]
        VBLENDMPD = 893,

        [Symbol("vblendmps")]
        VBLENDMPS = 894,

        [Symbol("vblendpd")]
        VBLENDPD = 895,

        [Symbol("vblendps")]
        VBLENDPS = 896,

        [Symbol("vblendvpd")]
        VBLENDVPD = 897,

        [Symbol("vblendvps")]
        VBLENDVPS = 898,

        [Symbol("vbroadcastf128")]
        VBROADCASTF128 = 899,

        [Symbol("vbroadcastf32x2")]
        VBROADCASTF32X2 = 900,

        [Symbol("vbroadcastf32x4")]
        VBROADCASTF32X4 = 901,

        [Symbol("vbroadcastf32x8")]
        VBROADCASTF32X8 = 902,

        [Symbol("vbroadcastf64x2")]
        VBROADCASTF64X2 = 903,

        [Symbol("vbroadcastf64x4")]
        VBROADCASTF64X4 = 904,

        [Symbol("vbroadcasti128")]
        VBROADCASTI128 = 905,

        [Symbol("vbroadcasti32x2")]
        VBROADCASTI32X2 = 906,

        [Symbol("vbroadcasti32x4")]
        VBROADCASTI32X4 = 907,

        [Symbol("vbroadcasti32x8")]
        VBROADCASTI32X8 = 908,

        [Symbol("vbroadcasti64x2")]
        VBROADCASTI64X2 = 909,

        [Symbol("vbroadcasti64x4")]
        VBROADCASTI64X4 = 910,

        [Symbol("vbroadcastsd")]
        VBROADCASTSD = 911,

        [Symbol("vbroadcastss")]
        VBROADCASTSS = 912,

        [Symbol("vcmppd")]
        VCMPPD = 913,

        [Symbol("vcmpps")]
        VCMPPS = 914,

        [Symbol("vcmpsd")]
        VCMPSD = 915,

        [Symbol("vcmpss")]
        VCMPSS = 916,

        [Symbol("vcomisd")]
        VCOMISD = 917,

        [Symbol("vcomiss")]
        VCOMISS = 918,

        [Symbol("vcompresspd")]
        VCOMPRESSPD = 919,

        [Symbol("vcompressps")]
        VCOMPRESSPS = 920,

        [Symbol("vcvtdq2pd")]
        VCVTDQ2PD = 921,

        [Symbol("vcvtdq2ps")]
        VCVTDQ2PS = 922,

        [Symbol("vcvtne2ps2bf16")]
        VCVTNE2PS2BF16 = 923,

        [Symbol("vcvtneps2bf16")]
        VCVTNEPS2BF16 = 924,

        [Symbol("vcvtpd2dq")]
        VCVTPD2DQ = 925,

        [Symbol("vcvtpd2ps")]
        VCVTPD2PS = 926,

        [Symbol("vcvtpd2qq")]
        VCVTPD2QQ = 927,

        [Symbol("vcvtpd2udq")]
        VCVTPD2UDQ = 928,

        [Symbol("vcvtpd2uqq")]
        VCVTPD2UQQ = 929,

        [Symbol("vcvtph2ps")]
        VCVTPH2PS = 930,

        [Symbol("vcvtps2dq")]
        VCVTPS2DQ = 931,

        [Symbol("vcvtps2pd")]
        VCVTPS2PD = 932,

        [Symbol("vcvtps2ph")]
        VCVTPS2PH = 933,

        [Symbol("vcvtps2qq")]
        VCVTPS2QQ = 934,

        [Symbol("vcvtps2udq")]
        VCVTPS2UDQ = 935,

        [Symbol("vcvtps2uqq")]
        VCVTPS2UQQ = 936,

        [Symbol("vcvtqq2pd")]
        VCVTQQ2PD = 937,

        [Symbol("vcvtqq2ps")]
        VCVTQQ2PS = 938,

        [Symbol("vcvtsd2si")]
        VCVTSD2SI = 939,

        [Symbol("vcvtsd2ss")]
        VCVTSD2SS = 940,

        [Symbol("vcvtsd2usi")]
        VCVTSD2USI = 941,

        [Symbol("vcvtsi2sd")]
        VCVTSI2SD = 942,

        [Symbol("vcvtsi2ss")]
        VCVTSI2SS = 943,

        [Symbol("vcvtss2sd")]
        VCVTSS2SD = 944,

        [Symbol("vcvtss2si")]
        VCVTSS2SI = 945,

        [Symbol("vcvtss2usi")]
        VCVTSS2USI = 946,

        [Symbol("vcvttpd2dq")]
        VCVTTPD2DQ = 947,

        [Symbol("vcvttpd2qq")]
        VCVTTPD2QQ = 948,

        [Symbol("vcvttpd2udq")]
        VCVTTPD2UDQ = 949,

        [Symbol("vcvttpd2uqq")]
        VCVTTPD2UQQ = 950,

        [Symbol("vcvttps2dq")]
        VCVTTPS2DQ = 951,

        [Symbol("vcvttps2qq")]
        VCVTTPS2QQ = 952,

        [Symbol("vcvttps2udq")]
        VCVTTPS2UDQ = 953,

        [Symbol("vcvttps2uqq")]
        VCVTTPS2UQQ = 954,

        [Symbol("vcvttsd2si")]
        VCVTTSD2SI = 955,

        [Symbol("vcvttsd2usi")]
        VCVTTSD2USI = 956,

        [Symbol("vcvttss2si")]
        VCVTTSS2SI = 957,

        [Symbol("vcvttss2usi")]
        VCVTTSS2USI = 958,

        [Symbol("vcvtudq2pd")]
        VCVTUDQ2PD = 959,

        [Symbol("vcvtudq2ps")]
        VCVTUDQ2PS = 960,

        [Symbol("vcvtuqq2pd")]
        VCVTUQQ2PD = 961,

        [Symbol("vcvtuqq2ps")]
        VCVTUQQ2PS = 962,

        [Symbol("vcvtusi2sd")]
        VCVTUSI2SD = 963,

        [Symbol("vcvtusi2ss")]
        VCVTUSI2SS = 964,

        [Symbol("vdbpsadbw")]
        VDBPSADBW = 965,

        [Symbol("vdivpd")]
        VDIVPD = 966,

        [Symbol("vdivps")]
        VDIVPS = 967,

        [Symbol("vdivsd")]
        VDIVSD = 968,

        [Symbol("vdivss")]
        VDIVSS = 969,

        [Symbol("vdpbf16ps")]
        VDPBF16PS = 970,

        [Symbol("vdppd")]
        VDPPD = 971,

        [Symbol("vdpps")]
        VDPPS = 972,

        [Symbol("verr")]
        VERR = 973,

        [Symbol("verw")]
        VERW = 974,

        [Symbol("vexp2pd")]
        VEXP2PD = 975,

        [Symbol("vexp2ps")]
        VEXP2PS = 976,

        [Symbol("vexpandpd")]
        VEXPANDPD = 977,

        [Symbol("vexpandps")]
        VEXPANDPS = 978,

        [Symbol("vextractf128")]
        VEXTRACTF128 = 979,

        [Symbol("vextractf32x4")]
        VEXTRACTF32X4 = 980,

        [Symbol("vextractf32x8")]
        VEXTRACTF32X8 = 981,

        [Symbol("vextractf64x2")]
        VEXTRACTF64X2 = 982,

        [Symbol("vextractf64x4")]
        VEXTRACTF64X4 = 983,

        [Symbol("vextracti128")]
        VEXTRACTI128 = 984,

        [Symbol("vextracti32x4")]
        VEXTRACTI32X4 = 985,

        [Symbol("vextracti32x8")]
        VEXTRACTI32X8 = 986,

        [Symbol("vextracti64x2")]
        VEXTRACTI64X2 = 987,

        [Symbol("vextracti64x4")]
        VEXTRACTI64X4 = 988,

        [Symbol("vextractps")]
        VEXTRACTPS = 989,

        [Symbol("vfixupimmpd")]
        VFIXUPIMMPD = 990,

        [Symbol("vfixupimmps")]
        VFIXUPIMMPS = 991,

        [Symbol("vfixupimmsd")]
        VFIXUPIMMSD = 992,

        [Symbol("vfixupimmss")]
        VFIXUPIMMSS = 993,

        [Symbol("vfmadd132pd")]
        VFMADD132PD = 994,

        [Symbol("vfmadd132ps")]
        VFMADD132PS = 995,

        [Symbol("vfmadd132sd")]
        VFMADD132SD = 996,

        [Symbol("vfmadd132ss")]
        VFMADD132SS = 997,

        [Symbol("vfmadd213pd")]
        VFMADD213PD = 998,

        [Symbol("vfmadd213ps")]
        VFMADD213PS = 999,

        [Symbol("vfmadd213sd")]
        VFMADD213SD = 1000,

        [Symbol("vfmadd213ss")]
        VFMADD213SS = 1001,

        [Symbol("vfmadd231pd")]
        VFMADD231PD = 1002,

        [Symbol("vfmadd231ps")]
        VFMADD231PS = 1003,

        [Symbol("vfmadd231sd")]
        VFMADD231SD = 1004,

        [Symbol("vfmadd231ss")]
        VFMADD231SS = 1005,

        [Symbol("vfmaddpd")]
        VFMADDPD = 1006,

        [Symbol("vfmaddps")]
        VFMADDPS = 1007,

        [Symbol("vfmaddsd")]
        VFMADDSD = 1008,

        [Symbol("vfmaddss")]
        VFMADDSS = 1009,

        [Symbol("vfmaddsub132pd")]
        VFMADDSUB132PD = 1010,

        [Symbol("vfmaddsub132ps")]
        VFMADDSUB132PS = 1011,

        [Symbol("vfmaddsub213pd")]
        VFMADDSUB213PD = 1012,

        [Symbol("vfmaddsub213ps")]
        VFMADDSUB213PS = 1013,

        [Symbol("vfmaddsub231pd")]
        VFMADDSUB231PD = 1014,

        [Symbol("vfmaddsub231ps")]
        VFMADDSUB231PS = 1015,

        [Symbol("vfmaddsubpd")]
        VFMADDSUBPD = 1016,

        [Symbol("vfmaddsubps")]
        VFMADDSUBPS = 1017,

        [Symbol("vfmsub132pd")]
        VFMSUB132PD = 1018,

        [Symbol("vfmsub132ps")]
        VFMSUB132PS = 1019,

        [Symbol("vfmsub132sd")]
        VFMSUB132SD = 1020,

        [Symbol("vfmsub132ss")]
        VFMSUB132SS = 1021,

        [Symbol("vfmsub213pd")]
        VFMSUB213PD = 1022,

        [Symbol("vfmsub213ps")]
        VFMSUB213PS = 1023,

        [Symbol("vfmsub213sd")]
        VFMSUB213SD = 1024,

        [Symbol("vfmsub213ss")]
        VFMSUB213SS = 1025,

        [Symbol("vfmsub231pd")]
        VFMSUB231PD = 1026,

        [Symbol("vfmsub231ps")]
        VFMSUB231PS = 1027,

        [Symbol("vfmsub231sd")]
        VFMSUB231SD = 1028,

        [Symbol("vfmsub231ss")]
        VFMSUB231SS = 1029,

        [Symbol("vfmsubadd132pd")]
        VFMSUBADD132PD = 1030,

        [Symbol("vfmsubadd132ps")]
        VFMSUBADD132PS = 1031,

        [Symbol("vfmsubadd213pd")]
        VFMSUBADD213PD = 1032,

        [Symbol("vfmsubadd213ps")]
        VFMSUBADD213PS = 1033,

        [Symbol("vfmsubadd231pd")]
        VFMSUBADD231PD = 1034,

        [Symbol("vfmsubadd231ps")]
        VFMSUBADD231PS = 1035,

        [Symbol("vfmsubaddpd")]
        VFMSUBADDPD = 1036,

        [Symbol("vfmsubaddps")]
        VFMSUBADDPS = 1037,

        [Symbol("vfmsubpd")]
        VFMSUBPD = 1038,

        [Symbol("vfmsubps")]
        VFMSUBPS = 1039,

        [Symbol("vfmsubsd")]
        VFMSUBSD = 1040,

        [Symbol("vfmsubss")]
        VFMSUBSS = 1041,

        [Symbol("vfnmadd132pd")]
        VFNMADD132PD = 1042,

        [Symbol("vfnmadd132ps")]
        VFNMADD132PS = 1043,

        [Symbol("vfnmadd132sd")]
        VFNMADD132SD = 1044,

        [Symbol("vfnmadd132ss")]
        VFNMADD132SS = 1045,

        [Symbol("vfnmadd213pd")]
        VFNMADD213PD = 1046,

        [Symbol("vfnmadd213ps")]
        VFNMADD213PS = 1047,

        [Symbol("vfnmadd213sd")]
        VFNMADD213SD = 1048,

        [Symbol("vfnmadd213ss")]
        VFNMADD213SS = 1049,

        [Symbol("vfnmadd231pd")]
        VFNMADD231PD = 1050,

        [Symbol("vfnmadd231ps")]
        VFNMADD231PS = 1051,

        [Symbol("vfnmadd231sd")]
        VFNMADD231SD = 1052,

        [Symbol("vfnmadd231ss")]
        VFNMADD231SS = 1053,

        [Symbol("vfnmaddpd")]
        VFNMADDPD = 1054,

        [Symbol("vfnmaddps")]
        VFNMADDPS = 1055,

        [Symbol("vfnmaddsd")]
        VFNMADDSD = 1056,

        [Symbol("vfnmaddss")]
        VFNMADDSS = 1057,

        [Symbol("vfnmsub132pd")]
        VFNMSUB132PD = 1058,

        [Symbol("vfnmsub132ps")]
        VFNMSUB132PS = 1059,

        [Symbol("vfnmsub132sd")]
        VFNMSUB132SD = 1060,

        [Symbol("vfnmsub132ss")]
        VFNMSUB132SS = 1061,

        [Symbol("vfnmsub213pd")]
        VFNMSUB213PD = 1062,

        [Symbol("vfnmsub213ps")]
        VFNMSUB213PS = 1063,

        [Symbol("vfnmsub213sd")]
        VFNMSUB213SD = 1064,

        [Symbol("vfnmsub213ss")]
        VFNMSUB213SS = 1065,

        [Symbol("vfnmsub231pd")]
        VFNMSUB231PD = 1066,

        [Symbol("vfnmsub231ps")]
        VFNMSUB231PS = 1067,

        [Symbol("vfnmsub231sd")]
        VFNMSUB231SD = 1068,

        [Symbol("vfnmsub231ss")]
        VFNMSUB231SS = 1069,

        [Symbol("vfnmsubpd")]
        VFNMSUBPD = 1070,

        [Symbol("vfnmsubps")]
        VFNMSUBPS = 1071,

        [Symbol("vfnmsubsd")]
        VFNMSUBSD = 1072,

        [Symbol("vfnmsubss")]
        VFNMSUBSS = 1073,

        [Symbol("vfpclasspd")]
        VFPCLASSPD = 1074,

        [Symbol("vfpclassps")]
        VFPCLASSPS = 1075,

        [Symbol("vfpclasssd")]
        VFPCLASSSD = 1076,

        [Symbol("vfpclassss")]
        VFPCLASSSS = 1077,

        [Symbol("vfrczpd")]
        VFRCZPD = 1078,

        [Symbol("vfrczps")]
        VFRCZPS = 1079,

        [Symbol("vfrczsd")]
        VFRCZSD = 1080,

        [Symbol("vfrczss")]
        VFRCZSS = 1081,

        [Symbol("vgatherdpd")]
        VGATHERDPD = 1082,

        [Symbol("vgatherdps")]
        VGATHERDPS = 1083,

        [Symbol("vgatherpf0dpd")]
        VGATHERPF0DPD = 1084,

        [Symbol("vgatherpf0dps")]
        VGATHERPF0DPS = 1085,

        [Symbol("vgatherpf0qpd")]
        VGATHERPF0QPD = 1086,

        [Symbol("vgatherpf0qps")]
        VGATHERPF0QPS = 1087,

        [Symbol("vgatherpf1dpd")]
        VGATHERPF1DPD = 1088,

        [Symbol("vgatherpf1dps")]
        VGATHERPF1DPS = 1089,

        [Symbol("vgatherpf1qpd")]
        VGATHERPF1QPD = 1090,

        [Symbol("vgatherpf1qps")]
        VGATHERPF1QPS = 1091,

        [Symbol("vgatherqpd")]
        VGATHERQPD = 1092,

        [Symbol("vgatherqps")]
        VGATHERQPS = 1093,

        [Symbol("vgetexppd")]
        VGETEXPPD = 1094,

        [Symbol("vgetexpps")]
        VGETEXPPS = 1095,

        [Symbol("vgetexpsd")]
        VGETEXPSD = 1096,

        [Symbol("vgetexpss")]
        VGETEXPSS = 1097,

        [Symbol("vgetmantpd")]
        VGETMANTPD = 1098,

        [Symbol("vgetmantps")]
        VGETMANTPS = 1099,

        [Symbol("vgetmantsd")]
        VGETMANTSD = 1100,

        [Symbol("vgetmantss")]
        VGETMANTSS = 1101,

        [Symbol("vgf2p8affineinvqb")]
        VGF2P8AFFINEINVQB = 1102,

        [Symbol("vgf2p8affineqb")]
        VGF2P8AFFINEQB = 1103,

        [Symbol("vgf2p8mulb")]
        VGF2P8MULB = 1104,

        [Symbol("vhaddpd")]
        VHADDPD = 1105,

        [Symbol("vhaddps")]
        VHADDPS = 1106,

        [Symbol("vhsubpd")]
        VHSUBPD = 1107,

        [Symbol("vhsubps")]
        VHSUBPS = 1108,

        [Symbol("vinsertf128")]
        VINSERTF128 = 1109,

        [Symbol("vinsertf32x4")]
        VINSERTF32X4 = 1110,

        [Symbol("vinsertf32x8")]
        VINSERTF32X8 = 1111,

        [Symbol("vinsertf64x2")]
        VINSERTF64X2 = 1112,

        [Symbol("vinsertf64x4")]
        VINSERTF64X4 = 1113,

        [Symbol("vinserti128")]
        VINSERTI128 = 1114,

        [Symbol("vinserti32x4")]
        VINSERTI32X4 = 1115,

        [Symbol("vinserti32x8")]
        VINSERTI32X8 = 1116,

        [Symbol("vinserti64x2")]
        VINSERTI64X2 = 1117,

        [Symbol("vinserti64x4")]
        VINSERTI64X4 = 1118,

        [Symbol("vinsertps")]
        VINSERTPS = 1119,

        [Symbol("vlddqu")]
        VLDDQU = 1120,

        [Symbol("vldmxcsr")]
        VLDMXCSR = 1121,

        [Symbol("vmaskmovdqu")]
        VMASKMOVDQU = 1122,

        [Symbol("vmaskmovpd")]
        VMASKMOVPD = 1123,

        [Symbol("vmaskmovps")]
        VMASKMOVPS = 1124,

        [Symbol("vmaxpd")]
        VMAXPD = 1125,

        [Symbol("vmaxps")]
        VMAXPS = 1126,

        [Symbol("vmaxsd")]
        VMAXSD = 1127,

        [Symbol("vmaxss")]
        VMAXSS = 1128,

        [Symbol("vmcall")]
        VMCALL = 1129,

        [Symbol("vmclear")]
        VMCLEAR = 1130,

        [Symbol("vmfunc")]
        VMFUNC = 1131,

        [Symbol("vminpd")]
        VMINPD = 1132,

        [Symbol("vminps")]
        VMINPS = 1133,

        [Symbol("vminsd")]
        VMINSD = 1134,

        [Symbol("vminss")]
        VMINSS = 1135,

        [Symbol("vmlaunch")]
        VMLAUNCH = 1136,

        [Symbol("vmload")]
        VMLOAD = 1137,

        [Symbol("vmmcall")]
        VMMCALL = 1138,

        [Symbol("vmovapd")]
        VMOVAPD = 1139,

        [Symbol("vmovaps")]
        VMOVAPS = 1140,

        [Symbol("vmovd")]
        VMOVD = 1141,

        [Symbol("vmovddup")]
        VMOVDDUP = 1142,

        [Symbol("vmovdqa")]
        VMOVDQA = 1143,

        [Symbol("vmovdqa32")]
        VMOVDQA32 = 1144,

        [Symbol("vmovdqa64")]
        VMOVDQA64 = 1145,

        [Symbol("vmovdqu")]
        VMOVDQU = 1146,

        [Symbol("vmovdqu16")]
        VMOVDQU16 = 1147,

        [Symbol("vmovdqu32")]
        VMOVDQU32 = 1148,

        [Symbol("vmovdqu64")]
        VMOVDQU64 = 1149,

        [Symbol("vmovdqu8")]
        VMOVDQU8 = 1150,

        [Symbol("vmovhlps")]
        VMOVHLPS = 1151,

        [Symbol("vmovhpd")]
        VMOVHPD = 1152,

        [Symbol("vmovhps")]
        VMOVHPS = 1153,

        [Symbol("vmovlhps")]
        VMOVLHPS = 1154,

        [Symbol("vmovlpd")]
        VMOVLPD = 1155,

        [Symbol("vmovlps")]
        VMOVLPS = 1156,

        [Symbol("vmovmskpd")]
        VMOVMSKPD = 1157,

        [Symbol("vmovmskps")]
        VMOVMSKPS = 1158,

        [Symbol("vmovntdq")]
        VMOVNTDQ = 1159,

        [Symbol("vmovntdqa")]
        VMOVNTDQA = 1160,

        [Symbol("vmovntpd")]
        VMOVNTPD = 1161,

        [Symbol("vmovntps")]
        VMOVNTPS = 1162,

        [Symbol("vmovq")]
        VMOVQ = 1163,

        [Symbol("vmovsd")]
        VMOVSD = 1164,

        [Symbol("vmovshdup")]
        VMOVSHDUP = 1165,

        [Symbol("vmovsldup")]
        VMOVSLDUP = 1166,

        [Symbol("vmovss")]
        VMOVSS = 1167,

        [Symbol("vmovupd")]
        VMOVUPD = 1168,

        [Symbol("vmovups")]
        VMOVUPS = 1169,

        [Symbol("vmpsadbw")]
        VMPSADBW = 1170,

        [Symbol("vmptrld")]
        VMPTRLD = 1171,

        [Symbol("vmptrst")]
        VMPTRST = 1172,

        [Symbol("vmread")]
        VMREAD = 1173,

        [Symbol("vmresume")]
        VMRESUME = 1174,

        [Symbol("vmrun")]
        VMRUN = 1175,

        [Symbol("vmsave")]
        VMSAVE = 1176,

        [Symbol("vmulpd")]
        VMULPD = 1177,

        [Symbol("vmulps")]
        VMULPS = 1178,

        [Symbol("vmulsd")]
        VMULSD = 1179,

        [Symbol("vmulss")]
        VMULSS = 1180,

        [Symbol("vmwrite")]
        VMWRITE = 1181,

        [Symbol("vmxoff")]
        VMXOFF = 1182,

        [Symbol("vmxon")]
        VMXON = 1183,

        [Symbol("vorpd")]
        VORPD = 1184,

        [Symbol("vorps")]
        VORPS = 1185,

        [Symbol("vp2intersectd")]
        VP2INTERSECTD = 1186,

        [Symbol("vp2intersectq")]
        VP2INTERSECTQ = 1187,

        [Symbol("vp4dpwssd")]
        VP4DPWSSD = 1188,

        [Symbol("vp4dpwssds")]
        VP4DPWSSDS = 1189,

        [Symbol("vpabsb")]
        VPABSB = 1190,

        [Symbol("vpabsd")]
        VPABSD = 1191,

        [Symbol("vpabsq")]
        VPABSQ = 1192,

        [Symbol("vpabsw")]
        VPABSW = 1193,

        [Symbol("vpackssdw")]
        VPACKSSDW = 1194,

        [Symbol("vpacksswb")]
        VPACKSSWB = 1195,

        [Symbol("vpackusdw")]
        VPACKUSDW = 1196,

        [Symbol("vpackuswb")]
        VPACKUSWB = 1197,

        [Symbol("vpaddb")]
        VPADDB = 1198,

        [Symbol("vpaddd")]
        VPADDD = 1199,

        [Symbol("vpaddq")]
        VPADDQ = 1200,

        [Symbol("vpaddsb")]
        VPADDSB = 1201,

        [Symbol("vpaddsw")]
        VPADDSW = 1202,

        [Symbol("vpaddusb")]
        VPADDUSB = 1203,

        [Symbol("vpaddusw")]
        VPADDUSW = 1204,

        [Symbol("vpaddw")]
        VPADDW = 1205,

        [Symbol("vpalignr")]
        VPALIGNR = 1206,

        [Symbol("vpand")]
        VPAND = 1207,

        [Symbol("vpandd")]
        VPANDD = 1208,

        [Symbol("vpandn")]
        VPANDN = 1209,

        [Symbol("vpandnd")]
        VPANDND = 1210,

        [Symbol("vpandnq")]
        VPANDNQ = 1211,

        [Symbol("vpandq")]
        VPANDQ = 1212,

        [Symbol("vpavgb")]
        VPAVGB = 1213,

        [Symbol("vpavgw")]
        VPAVGW = 1214,

        [Symbol("vpblendd")]
        VPBLENDD = 1215,

        [Symbol("vpblendmb")]
        VPBLENDMB = 1216,

        [Symbol("vpblendmd")]
        VPBLENDMD = 1217,

        [Symbol("vpblendmq")]
        VPBLENDMQ = 1218,

        [Symbol("vpblendmw")]
        VPBLENDMW = 1219,

        [Symbol("vpblendvb")]
        VPBLENDVB = 1220,

        [Symbol("vpblendw")]
        VPBLENDW = 1221,

        [Symbol("vpbroadcastb")]
        VPBROADCASTB = 1222,

        [Symbol("vpbroadcastd")]
        VPBROADCASTD = 1223,

        [Symbol("vpbroadcastmb2q")]
        VPBROADCASTMB2Q = 1224,

        [Symbol("vpbroadcastmw2d")]
        VPBROADCASTMW2D = 1225,

        [Symbol("vpbroadcastq")]
        VPBROADCASTQ = 1226,

        [Symbol("vpbroadcastw")]
        VPBROADCASTW = 1227,

        [Symbol("vpclmulqdq")]
        VPCLMULQDQ = 1228,

        [Symbol("vpcmov")]
        VPCMOV = 1229,

        [Symbol("vpcmpb")]
        VPCMPB = 1230,

        [Symbol("vpcmpd")]
        VPCMPD = 1231,

        [Symbol("vpcmpeqb")]
        VPCMPEQB = 1232,

        [Symbol("vpcmpeqd")]
        VPCMPEQD = 1233,

        [Symbol("vpcmpeqq")]
        VPCMPEQQ = 1234,

        [Symbol("vpcmpeqw")]
        VPCMPEQW = 1235,

        [Symbol("vpcmpestri")]
        VPCMPESTRI = 1236,

        [Symbol("vpcmpestri64")]
        VPCMPESTRI64 = 1237,

        [Symbol("vpcmpestrm")]
        VPCMPESTRM = 1238,

        [Symbol("vpcmpestrm64")]
        VPCMPESTRM64 = 1239,

        [Symbol("vpcmpgtb")]
        VPCMPGTB = 1240,

        [Symbol("vpcmpgtd")]
        VPCMPGTD = 1241,

        [Symbol("vpcmpgtq")]
        VPCMPGTQ = 1242,

        [Symbol("vpcmpgtw")]
        VPCMPGTW = 1243,

        [Symbol("vpcmpistri")]
        VPCMPISTRI = 1244,

        [Symbol("vpcmpistri64")]
        VPCMPISTRI64 = 1245,

        [Symbol("vpcmpistrm")]
        VPCMPISTRM = 1246,

        [Symbol("vpcmpq")]
        VPCMPQ = 1247,

        [Symbol("vpcmpub")]
        VPCMPUB = 1248,

        [Symbol("vpcmpud")]
        VPCMPUD = 1249,

        [Symbol("vpcmpuq")]
        VPCMPUQ = 1250,

        [Symbol("vpcmpuw")]
        VPCMPUW = 1251,

        [Symbol("vpcmpw")]
        VPCMPW = 1252,

        [Symbol("vpcomb")]
        VPCOMB = 1253,

        [Symbol("vpcomd")]
        VPCOMD = 1254,

        [Symbol("vpcompressb")]
        VPCOMPRESSB = 1255,

        [Symbol("vpcompressd")]
        VPCOMPRESSD = 1256,

        [Symbol("vpcompressq")]
        VPCOMPRESSQ = 1257,

        [Symbol("vpcompressw")]
        VPCOMPRESSW = 1258,

        [Symbol("vpcomq")]
        VPCOMQ = 1259,

        [Symbol("vpcomub")]
        VPCOMUB = 1260,

        [Symbol("vpcomud")]
        VPCOMUD = 1261,

        [Symbol("vpcomuq")]
        VPCOMUQ = 1262,

        [Symbol("vpcomuw")]
        VPCOMUW = 1263,

        [Symbol("vpcomw")]
        VPCOMW = 1264,

        [Symbol("vpconflictd")]
        VPCONFLICTD = 1265,

        [Symbol("vpconflictq")]
        VPCONFLICTQ = 1266,

        [Symbol("vpdpbusd")]
        VPDPBUSD = 1267,

        [Symbol("vpdpbusds")]
        VPDPBUSDS = 1268,

        [Symbol("vpdpwssd")]
        VPDPWSSD = 1269,

        [Symbol("vpdpwssds")]
        VPDPWSSDS = 1270,

        [Symbol("vperm2f128")]
        VPERM2F128 = 1271,

        [Symbol("vperm2i128")]
        VPERM2I128 = 1272,

        [Symbol("vpermb")]
        VPERMB = 1273,

        [Symbol("vpermd")]
        VPERMD = 1274,

        [Symbol("vpermi2b")]
        VPERMI2B = 1275,

        [Symbol("vpermi2d")]
        VPERMI2D = 1276,

        [Symbol("vpermi2pd")]
        VPERMI2PD = 1277,

        [Symbol("vpermi2ps")]
        VPERMI2PS = 1278,

        [Symbol("vpermi2q")]
        VPERMI2Q = 1279,

        [Symbol("vpermi2w")]
        VPERMI2W = 1280,

        [Symbol("vpermil2pd")]
        VPERMIL2PD = 1281,

        [Symbol("vpermil2ps")]
        VPERMIL2PS = 1282,

        [Symbol("vpermilpd")]
        VPERMILPD = 1283,

        [Symbol("vpermilps")]
        VPERMILPS = 1284,

        [Symbol("vpermpd")]
        VPERMPD = 1285,

        [Symbol("vpermps")]
        VPERMPS = 1286,

        [Symbol("vpermq")]
        VPERMQ = 1287,

        [Symbol("vpermt2b")]
        VPERMT2B = 1288,

        [Symbol("vpermt2d")]
        VPERMT2D = 1289,

        [Symbol("vpermt2pd")]
        VPERMT2PD = 1290,

        [Symbol("vpermt2ps")]
        VPERMT2PS = 1291,

        [Symbol("vpermt2q")]
        VPERMT2Q = 1292,

        [Symbol("vpermt2w")]
        VPERMT2W = 1293,

        [Symbol("vpermw")]
        VPERMW = 1294,

        [Symbol("vpexpandb")]
        VPEXPANDB = 1295,

        [Symbol("vpexpandd")]
        VPEXPANDD = 1296,

        [Symbol("vpexpandq")]
        VPEXPANDQ = 1297,

        [Symbol("vpexpandw")]
        VPEXPANDW = 1298,

        [Symbol("vpextrb")]
        VPEXTRB = 1299,

        [Symbol("vpextrd")]
        VPEXTRD = 1300,

        [Symbol("vpextrq")]
        VPEXTRQ = 1301,

        [Symbol("vpextrw")]
        VPEXTRW = 1302,

        [Symbol("vpextrw_c5")]
        VPEXTRW_C5 = 1303,

        [Symbol("vpgatherdd")]
        VPGATHERDD = 1304,

        [Symbol("vpgatherdq")]
        VPGATHERDQ = 1305,

        [Symbol("vpgatherqd")]
        VPGATHERQD = 1306,

        [Symbol("vpgatherqq")]
        VPGATHERQQ = 1307,

        [Symbol("vphaddbd")]
        VPHADDBD = 1308,

        [Symbol("vphaddbq")]
        VPHADDBQ = 1309,

        [Symbol("vphaddbw")]
        VPHADDBW = 1310,

        [Symbol("vphaddd")]
        VPHADDD = 1311,

        [Symbol("vphadddq")]
        VPHADDDQ = 1312,

        [Symbol("vphaddsw")]
        VPHADDSW = 1313,

        [Symbol("vphaddubd")]
        VPHADDUBD = 1314,

        [Symbol("vphaddubq")]
        VPHADDUBQ = 1315,

        [Symbol("vphaddubw")]
        VPHADDUBW = 1316,

        [Symbol("vphaddudq")]
        VPHADDUDQ = 1317,

        [Symbol("vphadduwd")]
        VPHADDUWD = 1318,

        [Symbol("vphadduwq")]
        VPHADDUWQ = 1319,

        [Symbol("vphaddw")]
        VPHADDW = 1320,

        [Symbol("vphaddwd")]
        VPHADDWD = 1321,

        [Symbol("vphaddwq")]
        VPHADDWQ = 1322,

        [Symbol("vphminposuw")]
        VPHMINPOSUW = 1323,

        [Symbol("vphsubbw")]
        VPHSUBBW = 1324,

        [Symbol("vphsubd")]
        VPHSUBD = 1325,

        [Symbol("vphsubdq")]
        VPHSUBDQ = 1326,

        [Symbol("vphsubsw")]
        VPHSUBSW = 1327,

        [Symbol("vphsubw")]
        VPHSUBW = 1328,

        [Symbol("vphsubwd")]
        VPHSUBWD = 1329,

        [Symbol("vpinsrb")]
        VPINSRB = 1330,

        [Symbol("vpinsrd")]
        VPINSRD = 1331,

        [Symbol("vpinsrq")]
        VPINSRQ = 1332,

        [Symbol("vpinsrw")]
        VPINSRW = 1333,

        [Symbol("vplzcntd")]
        VPLZCNTD = 1334,

        [Symbol("vplzcntq")]
        VPLZCNTQ = 1335,

        [Symbol("vpmacsdd")]
        VPMACSDD = 1336,

        [Symbol("vpmacsdqh")]
        VPMACSDQH = 1337,

        [Symbol("vpmacsdql")]
        VPMACSDQL = 1338,

        [Symbol("vpmacssdd")]
        VPMACSSDD = 1339,

        [Symbol("vpmacssdqh")]
        VPMACSSDQH = 1340,

        [Symbol("vpmacssdql")]
        VPMACSSDQL = 1341,

        [Symbol("vpmacsswd")]
        VPMACSSWD = 1342,

        [Symbol("vpmacssww")]
        VPMACSSWW = 1343,

        [Symbol("vpmacswd")]
        VPMACSWD = 1344,

        [Symbol("vpmacsww")]
        VPMACSWW = 1345,

        [Symbol("vpmadcsswd")]
        VPMADCSSWD = 1346,

        [Symbol("vpmadcswd")]
        VPMADCSWD = 1347,

        [Symbol("vpmadd52huq")]
        VPMADD52HUQ = 1348,

        [Symbol("vpmadd52luq")]
        VPMADD52LUQ = 1349,

        [Symbol("vpmaddubsw")]
        VPMADDUBSW = 1350,

        [Symbol("vpmaddwd")]
        VPMADDWD = 1351,

        [Symbol("vpmaskmovd")]
        VPMASKMOVD = 1352,

        [Symbol("vpmaskmovq")]
        VPMASKMOVQ = 1353,

        [Symbol("vpmaxsb")]
        VPMAXSB = 1354,

        [Symbol("vpmaxsd")]
        VPMAXSD = 1355,

        [Symbol("vpmaxsq")]
        VPMAXSQ = 1356,

        [Symbol("vpmaxsw")]
        VPMAXSW = 1357,

        [Symbol("vpmaxub")]
        VPMAXUB = 1358,

        [Symbol("vpmaxud")]
        VPMAXUD = 1359,

        [Symbol("vpmaxuq")]
        VPMAXUQ = 1360,

        [Symbol("vpmaxuw")]
        VPMAXUW = 1361,

        [Symbol("vpminsb")]
        VPMINSB = 1362,

        [Symbol("vpminsd")]
        VPMINSD = 1363,

        [Symbol("vpminsq")]
        VPMINSQ = 1364,

        [Symbol("vpminsw")]
        VPMINSW = 1365,

        [Symbol("vpminub")]
        VPMINUB = 1366,

        [Symbol("vpminud")]
        VPMINUD = 1367,

        [Symbol("vpminuq")]
        VPMINUQ = 1368,

        [Symbol("vpminuw")]
        VPMINUW = 1369,

        [Symbol("vpmovb2m")]
        VPMOVB2M = 1370,

        [Symbol("vpmovd2m")]
        VPMOVD2M = 1371,

        [Symbol("vpmovdb")]
        VPMOVDB = 1372,

        [Symbol("vpmovdw")]
        VPMOVDW = 1373,

        [Symbol("vpmovm2b")]
        VPMOVM2B = 1374,

        [Symbol("vpmovm2d")]
        VPMOVM2D = 1375,

        [Symbol("vpmovm2q")]
        VPMOVM2Q = 1376,

        [Symbol("vpmovm2w")]
        VPMOVM2W = 1377,

        [Symbol("vpmovmskb")]
        VPMOVMSKB = 1378,

        [Symbol("vpmovq2m")]
        VPMOVQ2M = 1379,

        [Symbol("vpmovqb")]
        VPMOVQB = 1380,

        [Symbol("vpmovqd")]
        VPMOVQD = 1381,

        [Symbol("vpmovqw")]
        VPMOVQW = 1382,

        [Symbol("vpmovsdb")]
        VPMOVSDB = 1383,

        [Symbol("vpmovsdw")]
        VPMOVSDW = 1384,

        [Symbol("vpmovsqb")]
        VPMOVSQB = 1385,

        [Symbol("vpmovsqd")]
        VPMOVSQD = 1386,

        [Symbol("vpmovsqw")]
        VPMOVSQW = 1387,

        [Symbol("vpmovswb")]
        VPMOVSWB = 1388,

        [Symbol("vpmovsxbd")]
        VPMOVSXBD = 1389,

        [Symbol("vpmovsxbq")]
        VPMOVSXBQ = 1390,

        [Symbol("vpmovsxbw")]
        VPMOVSXBW = 1391,

        [Symbol("vpmovsxdq")]
        VPMOVSXDQ = 1392,

        [Symbol("vpmovsxwd")]
        VPMOVSXWD = 1393,

        [Symbol("vpmovsxwq")]
        VPMOVSXWQ = 1394,

        [Symbol("vpmovusdb")]
        VPMOVUSDB = 1395,

        [Symbol("vpmovusdw")]
        VPMOVUSDW = 1396,

        [Symbol("vpmovusqb")]
        VPMOVUSQB = 1397,

        [Symbol("vpmovusqd")]
        VPMOVUSQD = 1398,

        [Symbol("vpmovusqw")]
        VPMOVUSQW = 1399,

        [Symbol("vpmovuswb")]
        VPMOVUSWB = 1400,

        [Symbol("vpmovw2m")]
        VPMOVW2M = 1401,

        [Symbol("vpmovwb")]
        VPMOVWB = 1402,

        [Symbol("vpmovzxbd")]
        VPMOVZXBD = 1403,

        [Symbol("vpmovzxbq")]
        VPMOVZXBQ = 1404,

        [Symbol("vpmovzxbw")]
        VPMOVZXBW = 1405,

        [Symbol("vpmovzxdq")]
        VPMOVZXDQ = 1406,

        [Symbol("vpmovzxwd")]
        VPMOVZXWD = 1407,

        [Symbol("vpmovzxwq")]
        VPMOVZXWQ = 1408,

        [Symbol("vpmuldq")]
        VPMULDQ = 1409,

        [Symbol("vpmulhrsw")]
        VPMULHRSW = 1410,

        [Symbol("vpmulhuw")]
        VPMULHUW = 1411,

        [Symbol("vpmulhw")]
        VPMULHW = 1412,

        [Symbol("vpmulld")]
        VPMULLD = 1413,

        [Symbol("vpmullq")]
        VPMULLQ = 1414,

        [Symbol("vpmullw")]
        VPMULLW = 1415,

        [Symbol("vpmultishiftqb")]
        VPMULTISHIFTQB = 1416,

        [Symbol("vpmuludq")]
        VPMULUDQ = 1417,

        [Symbol("vpopcntb")]
        VPOPCNTB = 1418,

        [Symbol("vpopcntd")]
        VPOPCNTD = 1419,

        [Symbol("vpopcntq")]
        VPOPCNTQ = 1420,

        [Symbol("vpopcntw")]
        VPOPCNTW = 1421,

        [Symbol("vpor")]
        VPOR = 1422,

        [Symbol("vpord")]
        VPORD = 1423,

        [Symbol("vporq")]
        VPORQ = 1424,

        [Symbol("vpperm")]
        VPPERM = 1425,

        [Symbol("vprold")]
        VPROLD = 1426,

        [Symbol("vprolq")]
        VPROLQ = 1427,

        [Symbol("vprolvd")]
        VPROLVD = 1428,

        [Symbol("vprolvq")]
        VPROLVQ = 1429,

        [Symbol("vprord")]
        VPRORD = 1430,

        [Symbol("vprorq")]
        VPRORQ = 1431,

        [Symbol("vprorvd")]
        VPRORVD = 1432,

        [Symbol("vprorvq")]
        VPRORVQ = 1433,

        [Symbol("vprotb")]
        VPROTB = 1434,

        [Symbol("vprotd")]
        VPROTD = 1435,

        [Symbol("vprotq")]
        VPROTQ = 1436,

        [Symbol("vprotw")]
        VPROTW = 1437,

        [Symbol("vpsadbw")]
        VPSADBW = 1438,

        [Symbol("vpscatterdd")]
        VPSCATTERDD = 1439,

        [Symbol("vpscatterdq")]
        VPSCATTERDQ = 1440,

        [Symbol("vpscatterqd")]
        VPSCATTERQD = 1441,

        [Symbol("vpscatterqq")]
        VPSCATTERQQ = 1442,

        [Symbol("vpshab")]
        VPSHAB = 1443,

        [Symbol("vpshad")]
        VPSHAD = 1444,

        [Symbol("vpshaq")]
        VPSHAQ = 1445,

        [Symbol("vpshaw")]
        VPSHAW = 1446,

        [Symbol("vpshlb")]
        VPSHLB = 1447,

        [Symbol("vpshld")]
        VPSHLD = 1448,

        [Symbol("vpshldd")]
        VPSHLDD = 1449,

        [Symbol("vpshldq")]
        VPSHLDQ = 1450,

        [Symbol("vpshldvd")]
        VPSHLDVD = 1451,

        [Symbol("vpshldvq")]
        VPSHLDVQ = 1452,

        [Symbol("vpshldvw")]
        VPSHLDVW = 1453,

        [Symbol("vpshldw")]
        VPSHLDW = 1454,

        [Symbol("vpshlq")]
        VPSHLQ = 1455,

        [Symbol("vpshlw")]
        VPSHLW = 1456,

        [Symbol("vpshrdd")]
        VPSHRDD = 1457,

        [Symbol("vpshrdq")]
        VPSHRDQ = 1458,

        [Symbol("vpshrdvd")]
        VPSHRDVD = 1459,

        [Symbol("vpshrdvq")]
        VPSHRDVQ = 1460,

        [Symbol("vpshrdvw")]
        VPSHRDVW = 1461,

        [Symbol("vpshrdw")]
        VPSHRDW = 1462,

        [Symbol("vpshufb")]
        VPSHUFB = 1463,

        [Symbol("vpshufbitqmb")]
        VPSHUFBITQMB = 1464,

        [Symbol("vpshufd")]
        VPSHUFD = 1465,

        [Symbol("vpshufhw")]
        VPSHUFHW = 1466,

        [Symbol("vpshuflw")]
        VPSHUFLW = 1467,

        [Symbol("vpsignb")]
        VPSIGNB = 1468,

        [Symbol("vpsignd")]
        VPSIGND = 1469,

        [Symbol("vpsignw")]
        VPSIGNW = 1470,

        [Symbol("vpslld")]
        VPSLLD = 1471,

        [Symbol("vpslldq")]
        VPSLLDQ = 1472,

        [Symbol("vpsllq")]
        VPSLLQ = 1473,

        [Symbol("vpsllvd")]
        VPSLLVD = 1474,

        [Symbol("vpsllvq")]
        VPSLLVQ = 1475,

        [Symbol("vpsllvw")]
        VPSLLVW = 1476,

        [Symbol("vpsllw")]
        VPSLLW = 1477,

        [Symbol("vpsrad")]
        VPSRAD = 1478,

        [Symbol("vpsraq")]
        VPSRAQ = 1479,

        [Symbol("vpsravd")]
        VPSRAVD = 1480,

        [Symbol("vpsravq")]
        VPSRAVQ = 1481,

        [Symbol("vpsravw")]
        VPSRAVW = 1482,

        [Symbol("vpsraw")]
        VPSRAW = 1483,

        [Symbol("vpsrld")]
        VPSRLD = 1484,

        [Symbol("vpsrldq")]
        VPSRLDQ = 1485,

        [Symbol("vpsrlq")]
        VPSRLQ = 1486,

        [Symbol("vpsrlvd")]
        VPSRLVD = 1487,

        [Symbol("vpsrlvq")]
        VPSRLVQ = 1488,

        [Symbol("vpsrlvw")]
        VPSRLVW = 1489,

        [Symbol("vpsrlw")]
        VPSRLW = 1490,

        [Symbol("vpsubb")]
        VPSUBB = 1491,

        [Symbol("vpsubd")]
        VPSUBD = 1492,

        [Symbol("vpsubq")]
        VPSUBQ = 1493,

        [Symbol("vpsubsb")]
        VPSUBSB = 1494,

        [Symbol("vpsubsw")]
        VPSUBSW = 1495,

        [Symbol("vpsubusb")]
        VPSUBUSB = 1496,

        [Symbol("vpsubusw")]
        VPSUBUSW = 1497,

        [Symbol("vpsubw")]
        VPSUBW = 1498,

        [Symbol("vpternlogd")]
        VPTERNLOGD = 1499,

        [Symbol("vpternlogq")]
        VPTERNLOGQ = 1500,

        [Symbol("vptest")]
        VPTEST = 1501,

        [Symbol("vptestmb")]
        VPTESTMB = 1502,

        [Symbol("vptestmd")]
        VPTESTMD = 1503,

        [Symbol("vptestmq")]
        VPTESTMQ = 1504,

        [Symbol("vptestmw")]
        VPTESTMW = 1505,

        [Symbol("vptestnmb")]
        VPTESTNMB = 1506,

        [Symbol("vptestnmd")]
        VPTESTNMD = 1507,

        [Symbol("vptestnmq")]
        VPTESTNMQ = 1508,

        [Symbol("vptestnmw")]
        VPTESTNMW = 1509,

        [Symbol("vpunpckhbw")]
        VPUNPCKHBW = 1510,

        [Symbol("vpunpckhdq")]
        VPUNPCKHDQ = 1511,

        [Symbol("vpunpckhqdq")]
        VPUNPCKHQDQ = 1512,

        [Symbol("vpunpckhwd")]
        VPUNPCKHWD = 1513,

        [Symbol("vpunpcklbw")]
        VPUNPCKLBW = 1514,

        [Symbol("vpunpckldq")]
        VPUNPCKLDQ = 1515,

        [Symbol("vpunpcklqdq")]
        VPUNPCKLQDQ = 1516,

        [Symbol("vpunpcklwd")]
        VPUNPCKLWD = 1517,

        [Symbol("vpxor")]
        VPXOR = 1518,

        [Symbol("vpxord")]
        VPXORD = 1519,

        [Symbol("vpxorq")]
        VPXORQ = 1520,

        [Symbol("vrangepd")]
        VRANGEPD = 1521,

        [Symbol("vrangeps")]
        VRANGEPS = 1522,

        [Symbol("vrangesd")]
        VRANGESD = 1523,

        [Symbol("vrangess")]
        VRANGESS = 1524,

        [Symbol("vrcp14pd")]
        VRCP14PD = 1525,

        [Symbol("vrcp14ps")]
        VRCP14PS = 1526,

        [Symbol("vrcp14sd")]
        VRCP14SD = 1527,

        [Symbol("vrcp14ss")]
        VRCP14SS = 1528,

        [Symbol("vrcp28pd")]
        VRCP28PD = 1529,

        [Symbol("vrcp28ps")]
        VRCP28PS = 1530,

        [Symbol("vrcp28sd")]
        VRCP28SD = 1531,

        [Symbol("vrcp28ss")]
        VRCP28SS = 1532,

        [Symbol("vrcpps")]
        VRCPPS = 1533,

        [Symbol("vrcpss")]
        VRCPSS = 1534,

        [Symbol("vreducepd")]
        VREDUCEPD = 1535,

        [Symbol("vreduceps")]
        VREDUCEPS = 1536,

        [Symbol("vreducesd")]
        VREDUCESD = 1537,

        [Symbol("vreducess")]
        VREDUCESS = 1538,

        [Symbol("vrndscalepd")]
        VRNDSCALEPD = 1539,

        [Symbol("vrndscaleps")]
        VRNDSCALEPS = 1540,

        [Symbol("vrndscalesd")]
        VRNDSCALESD = 1541,

        [Symbol("vrndscaless")]
        VRNDSCALESS = 1542,

        [Symbol("vroundpd")]
        VROUNDPD = 1543,

        [Symbol("vroundps")]
        VROUNDPS = 1544,

        [Symbol("vroundsd")]
        VROUNDSD = 1545,

        [Symbol("vroundss")]
        VROUNDSS = 1546,

        [Symbol("vrsqrt14pd")]
        VRSQRT14PD = 1547,

        [Symbol("vrsqrt14ps")]
        VRSQRT14PS = 1548,

        [Symbol("vrsqrt14sd")]
        VRSQRT14SD = 1549,

        [Symbol("vrsqrt14ss")]
        VRSQRT14SS = 1550,

        [Symbol("vrsqrt28pd")]
        VRSQRT28PD = 1551,

        [Symbol("vrsqrt28ps")]
        VRSQRT28PS = 1552,

        [Symbol("vrsqrt28sd")]
        VRSQRT28SD = 1553,

        [Symbol("vrsqrt28ss")]
        VRSQRT28SS = 1554,

        [Symbol("vrsqrtps")]
        VRSQRTPS = 1555,

        [Symbol("vrsqrtss")]
        VRSQRTSS = 1556,

        [Symbol("vscalefpd")]
        VSCALEFPD = 1557,

        [Symbol("vscalefps")]
        VSCALEFPS = 1558,

        [Symbol("vscalefsd")]
        VSCALEFSD = 1559,

        [Symbol("vscalefss")]
        VSCALEFSS = 1560,

        [Symbol("vscatterdpd")]
        VSCATTERDPD = 1561,

        [Symbol("vscatterdps")]
        VSCATTERDPS = 1562,

        [Symbol("vscatterpf0dpd")]
        VSCATTERPF0DPD = 1563,

        [Symbol("vscatterpf0dps")]
        VSCATTERPF0DPS = 1564,

        [Symbol("vscatterpf0qpd")]
        VSCATTERPF0QPD = 1565,

        [Symbol("vscatterpf0qps")]
        VSCATTERPF0QPS = 1566,

        [Symbol("vscatterpf1dpd")]
        VSCATTERPF1DPD = 1567,

        [Symbol("vscatterpf1dps")]
        VSCATTERPF1DPS = 1568,

        [Symbol("vscatterpf1qpd")]
        VSCATTERPF1QPD = 1569,

        [Symbol("vscatterpf1qps")]
        VSCATTERPF1QPS = 1570,

        [Symbol("vscatterqpd")]
        VSCATTERQPD = 1571,

        [Symbol("vscatterqps")]
        VSCATTERQPS = 1572,

        [Symbol("vshuff32x4")]
        VSHUFF32X4 = 1573,

        [Symbol("vshuff64x2")]
        VSHUFF64X2 = 1574,

        [Symbol("vshufi32x4")]
        VSHUFI32X4 = 1575,

        [Symbol("vshufi64x2")]
        VSHUFI64X2 = 1576,

        [Symbol("vshufpd")]
        VSHUFPD = 1577,

        [Symbol("vshufps")]
        VSHUFPS = 1578,

        [Symbol("vsqrtpd")]
        VSQRTPD = 1579,

        [Symbol("vsqrtps")]
        VSQRTPS = 1580,

        [Symbol("vsqrtsd")]
        VSQRTSD = 1581,

        [Symbol("vsqrtss")]
        VSQRTSS = 1582,

        [Symbol("vstmxcsr")]
        VSTMXCSR = 1583,

        [Symbol("vsubpd")]
        VSUBPD = 1584,

        [Symbol("vsubps")]
        VSUBPS = 1585,

        [Symbol("vsubsd")]
        VSUBSD = 1586,

        [Symbol("vsubss")]
        VSUBSS = 1587,

        [Symbol("vtestpd")]
        VTESTPD = 1588,

        [Symbol("vtestps")]
        VTESTPS = 1589,

        [Symbol("vucomisd")]
        VUCOMISD = 1590,

        [Symbol("vucomiss")]
        VUCOMISS = 1591,

        [Symbol("vunpckhpd")]
        VUNPCKHPD = 1592,

        [Symbol("vunpckhps")]
        VUNPCKHPS = 1593,

        [Symbol("vunpcklpd")]
        VUNPCKLPD = 1594,

        [Symbol("vunpcklps")]
        VUNPCKLPS = 1595,

        [Symbol("vxorpd")]
        VXORPD = 1596,

        [Symbol("vxorps")]
        VXORPS = 1597,

        [Symbol("vzeroall")]
        VZEROALL = 1598,

        [Symbol("vzeroupper")]
        VZEROUPPER = 1599,

        [Symbol("wbinvd")]
        WBINVD = 1600,

        [Symbol("wbnoinvd")]
        WBNOINVD = 1601,

        [Symbol("wrfsbase")]
        WRFSBASE = 1602,

        [Symbol("wrgsbase")]
        WRGSBASE = 1603,

        [Symbol("wrmsr")]
        WRMSR = 1604,

        [Symbol("wrpkru")]
        WRPKRU = 1605,

        [Symbol("wrssd")]
        WRSSD = 1606,

        [Symbol("wrssq")]
        WRSSQ = 1607,

        [Symbol("wrussd")]
        WRUSSD = 1608,

        [Symbol("wrussq")]
        WRUSSQ = 1609,

        [Symbol("xabort")]
        XABORT = 1610,

        [Symbol("xadd")]
        XADD = 1611,

        [Symbol("xadd_lock")]
        XADD_LOCK = 1612,

        [Symbol("xbegin")]
        XBEGIN = 1613,

        [Symbol("xchg")]
        XCHG = 1614,

        [Symbol("xend")]
        XEND = 1615,

        [Symbol("xgetbv")]
        XGETBV = 1616,

        [Symbol("xlat")]
        XLAT = 1617,

        [Symbol("xor")]
        XOR = 1618,

        [Symbol("xor_lock")]
        XOR_LOCK = 1619,

        [Symbol("xorpd")]
        XORPD = 1620,

        [Symbol("xorps")]
        XORPS = 1621,

        [Symbol("xresldtrk")]
        XRESLDTRK = 1622,

        [Symbol("xrstor")]
        XRSTOR = 1623,

        [Symbol("xrstor64")]
        XRSTOR64 = 1624,

        [Symbol("xrstors")]
        XRSTORS = 1625,

        [Symbol("xrstors64")]
        XRSTORS64 = 1626,

        [Symbol("xsave")]
        XSAVE = 1627,

        [Symbol("xsave64")]
        XSAVE64 = 1628,

        [Symbol("xsavec")]
        XSAVEC = 1629,

        [Symbol("xsavec64")]
        XSAVEC64 = 1630,

        [Symbol("xsaveopt")]
        XSAVEOPT = 1631,

        [Symbol("xsaveopt64")]
        XSAVEOPT64 = 1632,

        [Symbol("xsaves")]
        XSAVES = 1633,

        [Symbol("xsaves64")]
        XSAVES64 = 1634,

        [Symbol("xsetbv")]
        XSETBV = 1635,

        [Symbol("xstore")]
        XSTORE = 1636,

        [Symbol("xsusldtrk")]
        XSUSLDTRK = 1637,

        [Symbol("xtest")]
        XTEST = 1638,

    }
}
