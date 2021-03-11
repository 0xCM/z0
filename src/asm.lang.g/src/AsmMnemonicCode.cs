//-----------------------------------------------------------------------------
// Generated   :  2021-03-11.15.45.32.4688
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum AsmMnemonicCode : ushort
    {
        None = 0,

        AAA = 1,

        AAD = 2,

        AAM = 3,

        AAS = 4,

        ADC = 5,

        ADD = 6,

        ADDPD = 7,

        VADDPD = 8,

        ADDPS = 9,

        VADDPS = 10,

        ADDSD = 11,

        VADDSD = 12,

        ADDSS = 13,

        VADDSS = 14,

        ADDSUBPD = 15,

        VADDSUBPD = 16,

        ADDSUBPS = 17,

        VADDSUBPS = 18,

        AESDEC = 19,

        VAESDEC = 20,

        AESDECLAST = 21,

        VAESDECLAST = 22,

        AESENC = 23,

        VAESENC = 24,

        AESENCLAST = 25,

        VAESENCLAST = 26,

        AESIMC = 27,

        VAESIMC = 28,

        AESKEYGENASSIST = 29,

        VAESKEYGENASSIST = 30,

        AND = 31,

        ANDN = 32,

        ANDPD = 33,

        VANDPD = 34,

        ANDPS = 35,

        VANDPS = 36,

        ANDNPD = 37,

        VANDNPD = 38,

        ANDNPS = 39,

        VANDNPS = 40,

        ARPL = 41,

        BLENDPD = 42,

        VBLENDPD = 43,

        BEXTR = 44,

        BLENDPS = 45,

        VBLENDPS = 46,

        BLENDVPD = 47,

        VBLENDVPD = 48,

        BLENDVPS = 49,

        VBLENDVPS = 50,

        BLSI = 51,

        BLSMSK = 52,

        BLSR = 53,

        BOUND = 54,

        BSF = 55,

        BSR = 56,

        BSWAP = 57,

        BT = 58,

        BTC = 59,

        BTR = 60,

        BTS = 61,

        BZHI = 62,

        CALL = 63,

        CBW = 64,

        CWDE = 65,

        CDQE = 66,

        CLC = 67,

        CLD = 68,

        CLFLUSH = 69,

        CLI = 70,

        CLTS = 71,

        CMC = 72,

        CMOVA = 73,

        CMOVAE = 74,

        CMOVB = 75,

        CMOVBE = 76,

        CMOVC = 77,

        CMOVE = 78,

        CMOVG = 79,

        CMOVGE = 80,

        CMOVL = 81,

        CMOVLE = 82,

        CMOVNA = 83,

        CMOVNAE = 84,

        CMOVNB = 85,

        CMOVNBE = 86,

        CMOVNC = 87,

        CMOVNE = 88,

        CMOVNG = 89,

        CMOVNGE = 90,

        CMOVNL = 91,

        CMOVNLE = 92,

        CMOVNO = 93,

        CMOVNP = 94,

        CMOVNS = 95,

        CMOVNZ = 96,

        CMOVO = 97,

        CMOVP = 98,

        CMOVPE = 99,

        CMOVPO = 100,

        CMOVS = 101,

        CMOVZ = 102,

        CMP = 103,

        CMPPD = 104,

        VCMPPD = 105,

        CMPPS = 106,

        VCMPPS = 107,

        CMPS = 108,

        CMPSB = 109,

        CMPSW = 110,

        CMPSD = 111,

        CMPSQ = 112,

        VCMPSD = 113,

        CMPSS = 114,

        VCMPSS = 115,

        CMPXCHG = 116,

        CMPXCHG8B = 117,

        CMPXCHG16B = 118,

        COMISD = 119,

        VCOMISD = 120,

        COMISS = 121,

        VCOMISS = 122,

        CPUID = 123,

        CRC32 = 124,

        CVTDQ2PD = 125,

        VCVTDQ2PD = 126,

        CVTDQ2PS = 127,

        VCVTDQ2PS = 128,

        CVTPD2DQ = 129,

        VCVTPD2DQ = 130,

        CVTPD2PI = 131,

        CVTPD2PS = 132,

        VCVTPD2PS = 133,

        CVTPI2PD = 134,

        CVTPI2PS = 135,

        CVTPS2DQ = 136,

        VCVTPS2DQ = 137,

        CVTPS2PD = 138,

        VCVTPS2PD = 139,

        CVTPS2PI = 140,

        CVTSD2SI = 141,

        VCVTSD2SI = 142,

        CVTSD2SS = 143,

        VCVTSD2SS = 144,

        CVTSI2SD = 145,

        VCVTSI2SD = 146,

        CVTSI2SS = 147,

        VCVTSI2SS = 148,

        CVTSS2SD = 149,

        VCVTSS2SD = 150,

        CVTSS2SI = 151,

        VCVTSS2SI = 152,

        CVTTPD2DQ = 153,

        VCVTTPD2DQ = 154,

        CVTTPD2PI = 155,

        CVTTPS2DQ = 156,

        VCVTTPS2DQ = 157,

        CVTTPS2PI = 158,

        CVTTSD2SI = 159,

        VCVTTSD2SI = 160,

        CVTTSS2SI = 161,

        VCVTTSS2SI = 162,

        CWD = 163,

        CDQ = 164,

        CQO = 165,

        DAA = 166,

        DAS = 167,

        DEC = 168,

        DIV = 169,

        DIVPD = 170,

        VDIVPD = 171,

        DIVPS = 172,

        VDIVPS = 173,

        DIVSD = 174,

        VDIVSD = 175,

        DIVSS = 176,

        VDIVSS = 177,

        DPPD = 178,

        VDPPD = 179,

        DPPS = 180,

        VDPPS = 181,

        EMMS = 182,

        ENTER = 183,

        EXTRACTPS = 184,

        VEXTRACTPS = 185,

        F2XM1 = 186,

        FABS = 187,

        FADD = 188,

        FADDP = 189,

        FIADD = 190,

        FBLD = 191,

        FBSTP = 192,

        FCHS = 193,

        FCLEX = 194,

        FNCLEX = 195,

        FCMOVB = 196,

        FCMOVE = 197,

        FCMOVBE = 198,

        FCMOVU = 199,

        FCMOVNB = 200,

        FCMOVNE = 201,

        FCMOVNBE = 202,

        FCMOVNU = 203,

        FCOM = 204,

        FCOMP = 205,

        FCOMPP = 206,

        FCOMI = 207,

        FCOMIP = 208,

        FUCOMI = 209,

        FUCOMIP = 210,

        FCOS = 211,

        FDECSTP = 212,

        FDIV = 213,

        FDIVP = 214,

        FIDIV = 215,

        FDIVR = 216,

        FDIVRP = 217,

        FIDIVR = 218,

        FFREE = 219,

        FICOM = 220,

        FICOMP = 221,

        FILD = 222,

        FINCSTP = 223,

        FINIT = 224,

        FNINIT = 225,

        FIST = 226,

        FISTP = 227,

        FISTTP = 228,

        FLD = 229,

        FLD1 = 230,

        FLDL2T = 231,

        FLDL2E = 232,

        FLDPI = 233,

        FLDLG2 = 234,

        FLDLN2 = 235,

        FLDZ = 236,

        FLDCW = 237,

        FLDENV = 238,

        FMUL = 239,

        FMULP = 240,

        FIMUL = 241,

        FNOP = 242,

        FPATAN = 243,

        FPREM = 244,

        FPREM1 = 245,

        FPTAN = 246,

        FRNDINT = 247,

        FRSTOR = 248,

        FSAVE = 249,

        FNSAVE = 250,

        FSCALE = 251,

        FSIN = 252,

        FSINCOS = 253,

        FSQRT = 254,

        FST = 255,

        FSTP = 256,

        FSTCW = 257,

        FNSTCW = 258,

        FSTENV = 259,

        FNSTENV = 260,

        FSTSW = 261,

        FNSTSW = 262,

        FSUB = 263,

        FSUBP = 264,

        FISUB = 265,

        FSUBR = 266,

        FSUBRP = 267,

        FISUBR = 268,

        FTST = 269,

        FUCOM = 270,

        FUCOMP = 271,

        FUCOMPP = 272,

        FXAM = 273,

        FXCH = 274,

        FXRSTOR = 275,

        FXRSTOR64 = 276,

        FXSAVE = 277,

        FXSAVE64 = 278,

        FXTRACT = 279,

        FYL2X = 280,

        FYL2XP1 = 281,

        HADDPD = 282,

        VHADDPD = 283,

        HADDPS = 284,

        VHADDPS = 285,

        HLT = 286,

        HSUBPD = 287,

        VHSUBPD = 288,

        HSUBPS = 289,

        VHSUBPS = 290,

        IDIV = 291,

        IMUL = 292,

        IN = 293,

        INC = 294,

        INS = 295,

        INSB = 296,

        INSW = 297,

        INSD = 298,

        INSERTPS = 299,

        VINSERTPS = 300,

        INT = 301,

        INTO = 302,

        INVD = 303,

        INVLPG = 304,

        INVPCID = 305,

        IRET = 306,

        IRETD = 307,

        IRETQ = 308,

        JA = 309,

        JAE = 310,

        JB = 311,

        JBE = 312,

        JC = 313,

        JCXZ = 314,

        JECXZ = 315,

        JRCXZ = 316,

        JE = 317,

        JG = 318,

        JGE = 319,

        JL = 320,

        JLE = 321,

        JNA = 322,

        JNAE = 323,

        JNB = 324,

        JNBE = 325,

        JNC = 326,

        JNE = 327,

        JNG = 328,

        JNGE = 329,

        JNL = 330,

        JNLE = 331,

        JNO = 332,

        JNP = 333,

        JNS = 334,

        JNZ = 335,

        JO = 336,

        JP = 337,

        JPE = 338,

        JPO = 339,

        JS = 340,

        JZ = 341,

        JMP = 342,

        LAHF = 343,

        LAR = 344,

        LDDQU = 345,

        VLDDQU = 346,

        LDMXCSR = 347,

        VLDMXCSR = 348,

        LDS = 349,

        LSS = 350,

        LES = 351,

        LFS = 352,

        LGS = 353,

        LEA = 354,

        LEAVE = 355,

        LFENCE = 356,

        LGDT = 357,

        LIDT = 358,

        LLDT = 359,

        LMSW = 360,

        LOCK = 361,

        LODS = 362,

        LODSB = 363,

        LODSW = 364,

        LODSD = 365,

        LODSQ = 366,

        LOOP = 367,

        LOOPE = 368,

        LOOPNE = 369,

        LSL = 370,

        LTR = 371,

        LZCNT = 372,

        MASKMOVDQU = 373,

        VMASKMOVDQU = 374,

        MASKMOVQ = 375,

        MAXPD = 376,

        VMAXPD = 377,

        MAXPS = 378,

        VMAXPS = 379,

        MAXSD = 380,

        VMAXSD = 381,

        MAXSS = 382,

        VMAXSS = 383,

        MFENCE = 384,

        MINPD = 385,

        VMINPD = 386,

        MINPS = 387,

        VMINPS = 388,

        MINSD = 389,

        VMINSD = 390,

        MINSS = 391,

        VMINSS = 392,

        MONITOR = 393,

        MOV = 394,

        MOVAPD = 395,

        VMOVAPD = 396,

        MOVAPS = 397,

        VMOVAPS = 398,

        MOVBE = 399,

        MOVD = 400,

        MOVQ = 401,

        VMOVD = 402,

        VMOVQ = 403,

        MOVDDUP = 404,

        VMOVDDUP = 405,

        MOVDQA = 406,

        VMOVDQA = 407,

        MOVDQU = 408,

        VMOVDQU = 409,

        MOVDQ2Q = 410,

        MOVHLPS = 411,

        VMOVHLPS = 412,

        MOVHPD = 413,

        VMOVHPD = 414,

        MOVHPS = 415,

        VMOVHPS = 416,

        MOVLHPS = 417,

        VMOVLHPS = 418,

        MOVLPD = 419,

        VMOVLPD = 420,

        MOVLPS = 421,

        VMOVLPS = 422,

        MOVMSKPD = 423,

        VMOVMSKPD = 424,

        MOVMSKPS = 425,

        VMOVMSKPS = 426,

        MOVNTDQA = 427,

        VMOVNTDQA = 428,

        MOVNTDQ = 429,

        VMOVNTDQ = 430,

        MOVNTI = 431,

        MOVNTPD = 432,

        VMOVNTPD = 433,

        MOVNTPS = 434,

        VMOVNTPS = 435,

        MOVNTQ = 436,

        MOVQ2DQ = 437,

        MOVS = 438,

        MOVSB = 439,

        MOVSW = 440,

        MOVSD = 441,

        MOVSQ = 442,

        VMOVSD = 443,

        MOVSHDUP = 444,

        VMOVSHDUP = 445,

        MOVSLDUP = 446,

        VMOVSLDUP = 447,

        MOVSS = 448,

        VMOVSS = 449,

        MOVSX = 450,

        MOVSXD = 451,

        MOVUPD = 452,

        VMOVUPD = 453,

        MOVUPS = 454,

        VMOVUPS = 455,

        MOVZX = 456,

        MPSADBW = 457,

        VMPSADBW = 458,

        MUL = 459,

        MULPD = 460,

        VMULPD = 461,

        MULPS = 462,

        VMULPS = 463,

        MULSD = 464,

        VMULSD = 465,

        MULSS = 466,

        VMULSS = 467,

        MULX = 468,

        MWAIT = 469,

        NEG = 470,

        NOP = 471,

        NOT = 472,

        OR = 473,

        ORPD = 474,

        VORPD = 475,

        ORPS = 476,

        VORPS = 477,

        OUT = 478,

        OUTS = 479,

        OUTSB = 480,

        OUTSW = 481,

        OUTSD = 482,

        PABSB = 483,

        PABSW = 484,

        PABSD = 485,

        VPABSB = 486,

        VPABSW = 487,

        VPABSD = 488,

        PACKSSWB = 489,

        PACKSSDW = 490,

        VPACKSSWB = 491,

        VPACKSSDW = 492,

        PACKUSDW = 493,

        VPACKUSDW = 494,

        PACKUSWB = 495,

        VPACKUSWB = 496,

        PADDB = 497,

        PADDW = 498,

        PADDD = 499,

        VPADDB = 500,

        VPADDW = 501,

        VPADDD = 502,

        PADDQ = 503,

        VPADDQ = 504,

        PADDSB = 505,

        PADDSW = 506,

        VPADDSB = 507,

        VPADDSW = 508,

        PADDUSB = 509,

        PADDUSW = 510,

        VPADDUSB = 511,

        VPADDUSW = 512,

        PALIGNR = 513,

        VPALIGNR = 514,

        PAND = 515,

        VPAND = 516,

        PANDN = 517,

        VPANDN = 518,

        PAUSE = 519,

        PAVGB = 520,

        PAVGW = 521,

        VPAVGB = 522,

        VPAVGW = 523,

        PBLENDVB = 524,

        VPBLENDVB = 525,

        PBLENDW = 526,

        VPBLENDW = 527,

        PCLMULQDQ = 528,

        VPCLMULQDQ = 529,

        PCMPEQB = 530,

        PCMPEQW = 531,

        PCMPEQD = 532,

        VPCMPEQB = 533,

        VPCMPEQW = 534,

        VPCMPEQD = 535,

        PCMPEQQ = 536,

        VPCMPEQQ = 537,

        PCMPESTRI = 538,

        VPCMPESTRI = 539,

        PCMPESTRM = 540,

        VPCMPESTRM = 541,

        PCMPGTB = 542,

        PCMPGTW = 543,

        PCMPGTD = 544,

        VPCMPGTB = 545,

        VPCMPGTW = 546,

        VPCMPGTD = 547,

        PCMPGTQ = 548,

        VPCMPGTQ = 549,

        PCMPISTRI = 550,

        VPCMPISTRI = 551,

        PCMPISTRM = 552,

        VPCMPISTRM = 553,

        PDEP = 554,

        PEXT = 555,

        PEXTRB = 556,

        PEXTRD = 557,

        PEXTRQ = 558,

        VPEXTRB = 559,

        VPEXTRD = 560,

        VPEXTRQ = 561,

        PEXTRW = 562,

        VPEXTRW = 563,

        PHADDW = 564,

        PHADDD = 565,

        VPHADDW = 566,

        VPHADDD = 567,

        PHADDSW = 568,

        VPHADDSW = 569,

        PHMINPOSUW = 570,

        VPHMINPOSUW = 571,

        PHSUBW = 572,

        PHSUBD = 573,

        VPHSUBW = 574,

        VPHSUBD = 575,

        PHSUBSW = 576,

        VPHSUBSW = 577,

        PINSRB = 578,

        PINSRD = 579,

        PINSRQ = 580,

        VPINSRB = 581,

        VPINSRD = 582,

        VPINSRQ = 583,

        PINSRW = 584,

        VPINSRW = 585,

        PMADDUBSW = 586,

        VPMADDUBSW = 587,

        PMADDWD = 588,

        VPMADDWD = 589,

        PMAXSB = 590,

        VPMAXSB = 591,

        PMAXSD = 592,

        VPMAXSD = 593,

        PMAXSW = 594,

        VPMAXSW = 595,

        PMAXUB = 596,

        VPMAXUB = 597,

        PMAXUD = 598,

        VPMAXUD = 599,

        PMAXUW = 600,

        VPMAXUW = 601,

        PMINSB = 602,

        VPMINSB = 603,

        PMINSD = 604,

        VPMINSD = 605,

        PMINSW = 606,

        VPMINSW = 607,

        PMINUB = 608,

        VPMINUB = 609,

        PMINUD = 610,

        VPMINUD = 611,

        PMINUW = 612,

        VPMINUW = 613,

        PMOVMSKB = 614,

        VPMOVMSKB = 615,

        PMOVSXBW = 616,

        PMOVSXBD = 617,

        PMOVSXBQ = 618,

        PMOVSXWD = 619,

        PMOVSXWQ = 620,

        PMOVSXDQ = 621,

        VPMOVSXBW = 622,

        VPMOVSXBD = 623,

        VPMOVSXBQ = 624,

        VPMOVSXWD = 625,

        VPMOVSXWQ = 626,

        VPMOVSXDQ = 627,

        PMOVZXBW = 628,

        PMOVZXBD = 629,

        PMOVZXBQ = 630,

        PMOVZXWD = 631,

        PMOVZXWQ = 632,

        PMOVZXDQ = 633,

        VPMOVZXBW = 634,

        VPMOVZXBD = 635,

        VPMOVZXBQ = 636,

        VPMOVZXWD = 637,

        VPMOVZXWQ = 638,

        VPMOVZXDQ = 639,

        PMULDQ = 640,

        VPMULDQ = 641,

        PMULHRSW = 642,

        VPMULHRSW = 643,

        PMULHUW = 644,

        VPMULHUW = 645,

        PMULHW = 646,

        VPMULHW = 647,

        PMULLD = 648,

        VPMULLD = 649,

        PMULLW = 650,

        VPMULLW = 651,

        PMULUDQ = 652,

        VPMULUDQ = 653,

        POP = 654,

        POPA = 655,

        POPAD = 656,

        POPCNT = 657,

        POPF = 658,

        POPFD = 659,

        POPFQ = 660,

        POR = 661,

        VPOR = 662,

        PREFETCHT0 = 663,

        PREFETCHT1 = 664,

        PREFETCHT2 = 665,

        PREFETCHNTA = 666,

        PSADBW = 667,

        VPSADBW = 668,

        PSHUFB = 669,

        VPSHUFB = 670,

        PSHUFD = 671,

        VPSHUFD = 672,

        PSHUFHW = 673,

        VPSHUFHW = 674,

        PSHUFLW = 675,

        VPSHUFLW = 676,

        PSHUFW = 677,

        PSIGNB = 678,

        PSIGNW = 679,

        PSIGND = 680,

        VPSIGNB = 681,

        VPSIGNW = 682,

        VPSIGND = 683,

        PSLLDQ = 684,

        VPSLLDQ = 685,

        PSLLW = 686,

        PSLLD = 687,

        PSLLQ = 688,

        VPSLLW = 689,

        VPSLLD = 690,

        VPSLLQ = 691,

        PSRAW = 692,

        PSRAD = 693,

        VPSRAW = 694,

        VPSRAD = 695,

        PSRLDQ = 696,

        VPSRLDQ = 697,

        PSRLW = 698,

        PSRLD = 699,

        PSRLQ = 700,

        VPSRLW = 701,

        VPSRLD = 702,

        VPSRLQ = 703,

        PSUBB = 704,

        PSUBW = 705,

        PSUBD = 706,

        VPSUBB = 707,

        VPSUBW = 708,

        VPSUBD = 709,

        PSUBQ = 710,

        VPSUBQ = 711,

        PSUBSB = 712,

        PSUBSW = 713,

        VPSUBSB = 714,

        VPSUBSW = 715,

        PSUBUSB = 716,

        PSUBUSW = 717,

        VPSUBUSB = 718,

        VPSUBUSW = 719,

        PTEST = 720,

        VPTEST = 721,

        PUNPCKHBW = 722,

        PUNPCKHWD = 723,

        PUNPCKHDQ = 724,

        PUNPCKHQDQ = 725,

        VPUNPCKHBW = 726,

        VPUNPCKHWD = 727,

        VPUNPCKHDQ = 728,

        VPUNPCKHQDQ = 729,

        PUNPCKLBW = 730,

        PUNPCKLWD = 731,

        PUNPCKLDQ = 732,

        PUNPCKLQDQ = 733,

        VPUNPCKLBW = 734,

        VPUNPCKLWD = 735,

        VPUNPCKLDQ = 736,

        VPUNPCKLQDQ = 737,

        PUSH = 738,

        PUSHQ = 739,

        PUSHW = 740,

        PUSHA = 741,

        PUSHAD = 742,

        PUSHF = 743,

        PUSHFD = 744,

        PUSHFQ = 745,

        PXOR = 746,

        VPXOR = 747,

        RCL = 748,

        RCR = 749,

        ROL = 750,

        ROR = 751,

        RCPPS = 752,

        VRCPPS = 753,

        RCPSS = 754,

        VRCPSS = 755,

        RDFSBASE = 756,

        RDGSBASE = 757,

        RDMSR = 758,

        RDPMC = 759,

        RDRAND = 760,

        RDTSC = 761,

        RDTSCP = 762,

        REP_INS = 763,

        REP_MOVS = 764,

        REP_OUTS = 765,

        REP_LODS = 766,

        REP_STOS = 767,

        REPE_CMPS = 768,

        REPE_SCAS = 769,

        REPNE_CMPS = 770,

        REPNE_SCAS = 771,

        RET = 772,

        RORX = 773,

        ROUNDPD = 774,

        VROUNDPD = 775,

        ROUNDPS = 776,

        VROUNDPS = 777,

        ROUNDSD = 778,

        VROUNDSD = 779,

        ROUNDSS = 780,

        VROUNDSS = 781,

        RSM = 782,

        RSQRTPS = 783,

        VRSQRTPS = 784,

        RSQRTSS = 785,

        VRSQRTSS = 786,

        SAHF = 787,

        SAL = 788,

        SAR = 789,

        SHL = 790,

        SHR = 791,

        SARX = 792,

        SHLX = 793,

        SHRX = 794,

        SBB = 795,

        SCAS = 796,

        SCASB = 797,

        SCASW = 798,

        SCASD = 799,

        SCASQ = 800,

        SETA = 801,

        SETAE = 802,

        SETB = 803,

        SETBE = 804,

        SETC = 805,

        SETE = 806,

        SETG = 807,

        SETGE = 808,

        SETL = 809,

        SETLE = 810,

        SETNA = 811,

        SETNAE = 812,

        SETNB = 813,

        SETNBE = 814,

        SETNC = 815,

        SETNE = 816,

        SETNG = 817,

        SETNGE = 818,

        SETNL = 819,

        SETNLE = 820,

        SETNO = 821,

        SETNP = 822,

        SETNS = 823,

        SETNZ = 824,

        SETO = 825,

        SETP = 826,

        SETPE = 827,

        SETPO = 828,

        SETS = 829,

        SETZ = 830,

        SFENCE = 831,

        SGDT = 832,

        SHLD = 833,

        SHRD = 834,

        SHUFPD = 835,

        VSHUFPD = 836,

        SHUFPS = 837,

        VSHUFPS = 838,

        SIDT = 839,

        SLDT = 840,

        SMSW = 841,

        SQRTPD = 842,

        VSQRTPD = 843,

        SQRTPS = 844,

        VSQRTPS = 845,

        SQRTSD = 846,

        VSQRTSD = 847,

        SQRTSS = 848,

        VSQRTSS = 849,

        STC = 850,

        STD = 851,

        STI = 852,

        STMXCSR = 853,

        VSTMXCSR = 854,

        STOS = 855,

        STOSB = 856,

        STOSW = 857,

        STOSD = 858,

        STOSQ = 859,

        STR = 860,

        SUB = 861,

        SUBPD = 862,

        VSUBPD = 863,

        SUBPS = 864,

        VSUBPS = 865,

        SUBSD = 866,

        VSUBSD = 867,

        SUBSS = 868,

        VSUBSS = 869,

        SWAPGS = 870,

        SYSCALL = 871,

        SYSENTER = 872,

        SYSEXIT = 873,

        SYSRET = 874,

        TEST = 875,

        TZCNT = 876,

        UCOMISD = 877,

        VUCOMISD = 878,

        UCOMISS = 879,

        VUCOMISS = 880,

        UD2 = 881,

        UNPCKHPD = 882,

        VUNPCKHPD = 883,

        UNPCKHPS = 884,

        VUNPCKHPS = 885,

        UNPCKLPD = 886,

        VUNPCKLPD = 887,

        UNPCKLPS = 888,

        VUNPCKLPS = 889,

        VBROADCASTSS = 890,

        VBROADCASTSD = 891,

        VBROADCASTF128 = 892,

        VCVTPH2PS = 893,

        VCVTPS2PH = 894,

        VERR = 895,

        VERW = 896,

        VEXTRACTF128 = 897,

        VEXTRACTI128 = 898,

        VFMADD132PD = 899,

        VFMADD213PD = 900,

        VFMADD231PD = 901,

        VFMADD132PS = 902,

        VFMADD213PS = 903,

        VFMADD231PS = 904,

        VFMADD132SD = 905,

        VFMADD213SD = 906,

        VFMADD231SD = 907,

        VFMADD132SS = 908,

        VFMADD213SS = 909,

        VFMADD231SS = 910,

        VFMADDSUB132PD = 911,

        VFMADDSUB213PD = 912,

        VFMADDSUB231PD = 913,

        VFMADDSUB132PS = 914,

        VFMADDSUB213PS = 915,

        VFMADDSUB231PS = 916,

        VFMSUBADD132PD = 917,

        VFMSUBADD213PD = 918,

        VFMSUBADD231PD = 919,

        VFMSUBADD132PS = 920,

        VFMSUBADD213PS = 921,

        VFMSUBADD231PS = 922,

        VFMSUB132PD = 923,

        VFMSUB213PD = 924,

        VFMSUB231PD = 925,

        VFMSUB132PS = 926,

        VFMSUB213PS = 927,

        VFMSUB231PS = 928,

        VFMSUB132SD = 929,

        VFMSUB213SD = 930,

        VFMSUB231SD = 931,

        VFMSUB132SS = 932,

        VFMSUB213SS = 933,

        VFMSUB231SS = 934,

        VFNMADD132PD = 935,

        VFNMADD213PD = 936,

        VFNMADD231PD = 937,

        VFNMADD132PS = 938,

        VFNMADD213PS = 939,

        VFNMADD231PS = 940,

        VFNMADD132SD = 941,

        VFNMADD213SD = 942,

        VFNMADD231SD = 943,

        VFNMADD132SS = 944,

        VFNMADD213SS = 945,

        VFNMADD231SS = 946,

        VFNMSUB132PD = 947,

        VFNMSUB213PD = 948,

        VFNMSUB231PD = 949,

        VFNMSUB132PS = 950,

        VFNMSUB213PS = 951,

        VFNMSUB231PS = 952,

        VFNMSUB132SD = 953,

        VFNMSUB213SD = 954,

        VFNMSUB231SD = 955,

        VFNMSUB132SS = 956,

        VFNMSUB213SS = 957,

        VFNMSUB231SS = 958,

        VGATHERDPD = 959,

        VGATHERQPD = 960,

        VGATHERDPS = 961,

        VGATHERQPS = 962,

        VPGATHERDD = 963,

        VPGATHERQD = 964,

        VPGATHERDQ = 965,

        VPGATHERQQ = 966,

        VINSERTF128 = 967,

        VINSERTI128 = 968,

        VMASKMOVPS = 969,

        VMASKMOVPD = 970,

        VPBLENDD = 971,

        VPBROADCASTB = 972,

        VPBROADCASTW = 973,

        VPBROADCASTD = 974,

        VPBROADCASTQ = 975,

        VBROADCASTI128 = 976,

        VPERMD = 977,

        VPERMPD = 978,

        VPERMPS = 979,

        VPERMQ = 980,

        VPERM2I128 = 981,

        VPERMILPD = 982,

        VPERMILPS = 983,

        VPERM2F128 = 984,

        VPMASKMOVD = 985,

        VPMASKMOVQ = 986,

        VPSLLVD = 987,

        VPSLLVQ = 988,

        VPSRAVD = 989,

        VPSRLVD = 990,

        VPSRLVQ = 991,

        VTESTPS = 992,

        VTESTPD = 993,

        VZEROALL = 994,

        VZEROUPPER = 995,

        WAIT = 996,

        FWAIT = 997,

        WBINVD = 998,

        WRFSBASE = 999,

        WRGSBASE = 1000,

        WRMSR = 1001,

        XACQUIRE = 1002,

        XRELEASE = 1003,

        XABORT = 1004,

        XADD = 1005,

        XBEGIN = 1006,

        XCHG = 1007,

        XEND = 1008,

        XGETBV = 1009,

        XLAT = 1010,

        XLATB = 1011,

        XOR = 1012,

        XORPD = 1013,

        VXORPD = 1014,

        XORPS = 1015,

        VXORPS = 1016,

        XRSTOR = 1017,

        XRSTOR64 = 1018,

        XSAVE = 1019,

        XSAVE64 = 1020,

        XSAVEOPT = 1021,

        XSAVEOPT64 = 1022,

        XSETBV = 1023,

        XTEST = 1024,

    }
}
