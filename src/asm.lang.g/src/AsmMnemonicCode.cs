//-----------------------------------------------------------------------------
// Generated   :  20210219.04.04.06.5181
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum AsmMnemonicCode : ushort
    {
        None = 0,

        AAD = 1,

        AAM = 2,

        ADC = 3,

        ADD = 4,

        ADDPD = 5,

        VADDPD = 6,

        ADDPS = 7,

        VADDPS = 8,

        ADDSD = 9,

        VADDSD = 10,

        ADDSS = 11,

        VADDSS = 12,

        ADDSUBPD = 13,

        VADDSUBPD = 14,

        ADDSUBPS = 15,

        VADDSUBPS = 16,

        AESDEC = 17,

        VAESDEC = 18,

        AESDECLAST = 19,

        VAESDECLAST = 20,

        AESENC = 21,

        VAESENC = 22,

        AESENCLAST = 23,

        VAESENCLAST = 24,

        AESIMC = 25,

        VAESIMC = 26,

        AESKEYGENASSIST = 27,

        VAESKEYGENASSIST = 28,

        AND = 29,

        ANDN = 30,

        ANDPD = 31,

        VANDPD = 32,

        ANDPS = 33,

        VANDPS = 34,

        ANDNPD = 35,

        VANDNPD = 36,

        ANDNPS = 37,

        VANDNPS = 38,

        ARPL = 39,

        BLENDPD = 40,

        VBLENDPD = 41,

        BEXTR = 42,

        BLENDPS = 43,

        VBLENDPS = 44,

        BLENDVPD = 45,

        VBLENDVPD = 46,

        BLENDVPS = 47,

        VBLENDVPS = 48,

        BLSI = 49,

        BLSMSK = 50,

        BLSR = 51,

        BOUND = 52,

        BSF = 53,

        BSR = 54,

        BSWAP = 55,

        BT = 56,

        BTC = 57,

        BTR = 58,

        BTS = 59,

        BZHI = 60,

        CALL = 61,

        CLFLUSH = 62,

        CMOVA = 63,

        CMOVAE = 64,

        CMOVB = 65,

        CMOVBE = 66,

        CMOVC = 67,

        CMOVE = 68,

        CMOVG = 69,

        CMOVGE = 70,

        CMOVL = 71,

        CMOVLE = 72,

        CMOVNA = 73,

        CMOVNAE = 74,

        CMOVNB = 75,

        CMOVNBE = 76,

        CMOVNC = 77,

        CMOVNE = 78,

        CMOVNG = 79,

        CMOVNGE = 80,

        CMOVNL = 81,

        CMOVNLE = 82,

        CMOVNO = 83,

        CMOVNP = 84,

        CMOVNS = 85,

        CMOVNZ = 86,

        CMOVO = 87,

        CMOVP = 88,

        CMOVPE = 89,

        CMOVPO = 90,

        CMOVS = 91,

        CMOVZ = 92,

        CMP = 93,

        CMPPD = 94,

        VCMPPD = 95,

        CMPPS = 96,

        VCMPPS = 97,

        CMPS = 98,

        CMPSD = 99,

        VCMPSD = 100,

        CMPSS = 101,

        VCMPSS = 102,

        CMPXCHG = 103,

        CMPXCHG8B = 104,

        CMPXCHG16B = 105,

        COMISD = 106,

        VCOMISD = 107,

        COMISS = 108,

        VCOMISS = 109,

        CRC32 = 110,

        CVTDQ2PD = 111,

        VCVTDQ2PD = 112,

        CVTDQ2PS = 113,

        VCVTDQ2PS = 114,

        CVTPD2DQ = 115,

        VCVTPD2DQ = 116,

        CVTPD2PI = 117,

        CVTPD2PS = 118,

        VCVTPD2PS = 119,

        CVTPI2PD = 120,

        CVTPI2PS = 121,

        CVTPS2DQ = 122,

        VCVTPS2DQ = 123,

        CVTPS2PD = 124,

        VCVTPS2PD = 125,

        CVTPS2PI = 126,

        CVTSD2SI = 127,

        VCVTSD2SI = 128,

        CVTSD2SS = 129,

        VCVTSD2SS = 130,

        CVTSI2SD = 131,

        VCVTSI2SD = 132,

        CVTSI2SS = 133,

        VCVTSI2SS = 134,

        CVTSS2SD = 135,

        VCVTSS2SD = 136,

        CVTSS2SI = 137,

        VCVTSS2SI = 138,

        CVTTPD2DQ = 139,

        VCVTTPD2DQ = 140,

        CVTTPD2PI = 141,

        CVTTPS2DQ = 142,

        VCVTTPS2DQ = 143,

        CVTTPS2PI = 144,

        CVTTSD2SI = 145,

        VCVTTSD2SI = 146,

        CVTTSS2SI = 147,

        VCVTTSS2SI = 148,

        DEC = 149,

        DIV = 150,

        DIVPD = 151,

        VDIVPD = 152,

        DIVPS = 153,

        VDIVPS = 154,

        DIVSD = 155,

        VDIVSD = 156,

        DIVSS = 157,

        VDIVSS = 158,

        DPPD = 159,

        VDPPD = 160,

        DPPS = 161,

        VDPPS = 162,

        ENTER = 163,

        EXTRACTPS = 164,

        VEXTRACTPS = 165,

        FADD = 166,

        FADDP = 167,

        FIADD = 168,

        FBLD = 169,

        FBSTP = 170,

        FCMOVB = 171,

        FCMOVE = 172,

        FCMOVBE = 173,

        FCMOVU = 174,

        FCMOVNB = 175,

        FCMOVNE = 176,

        FCMOVNBE = 177,

        FCMOVNU = 178,

        FCOM = 179,

        FCOMP = 180,

        FCOMI = 181,

        FCOMIP = 182,

        FUCOMI = 183,

        FUCOMIP = 184,

        FDIV = 185,

        FDIVP = 186,

        FIDIV = 187,

        FDIVR = 188,

        FDIVRP = 189,

        FIDIVR = 190,

        FFREE = 191,

        FICOM = 192,

        FICOMP = 193,

        FILD = 194,

        FIST = 195,

        FISTP = 196,

        FISTTP = 197,

        FLD = 198,

        FLDCW = 199,

        FLDENV = 200,

        FMUL = 201,

        FMULP = 202,

        FIMUL = 203,

        FRSTOR = 204,

        FSAVE = 205,

        FNSAVE = 206,

        FST = 207,

        FSTP = 208,

        FSTCW = 209,

        FNSTCW = 210,

        FSTENV = 211,

        FNSTENV = 212,

        FSTSW = 213,

        FNSTSW = 214,

        FSUB = 215,

        FSUBP = 216,

        FISUB = 217,

        FSUBR = 218,

        FSUBRP = 219,

        FISUBR = 220,

        FUCOM = 221,

        FUCOMP = 222,

        FXCH = 223,

        FXRSTOR = 224,

        FXRSTOR64 = 225,

        FXSAVE = 226,

        FXSAVE64 = 227,

        HADDPD = 228,

        VHADDPD = 229,

        HADDPS = 230,

        VHADDPS = 231,

        HSUBPD = 232,

        VHSUBPD = 233,

        HSUBPS = 234,

        VHSUBPS = 235,

        IDIV = 236,

        IMUL = 237,

        IN = 238,

        INC = 239,

        INS = 240,

        INSERTPS = 241,

        VINSERTPS = 242,

        INT = 243,

        INVLPG = 244,

        INVPCID = 245,

        JA = 246,

        JAE = 247,

        JB = 248,

        JBE = 249,

        JC = 250,

        JCXZ = 251,

        JECXZ = 252,

        JRCXZ = 253,

        JE = 254,

        JG = 255,

        JGE = 256,

        JL = 257,

        JLE = 258,

        JNA = 259,

        JNAE = 260,

        JNB = 261,

        JNBE = 262,

        JNC = 263,

        JNE = 264,

        JNG = 265,

        JNGE = 266,

        JNL = 267,

        JNLE = 268,

        JNO = 269,

        JNP = 270,

        JNS = 271,

        JNZ = 272,

        JO = 273,

        JP = 274,

        JPE = 275,

        JPO = 276,

        JS = 277,

        JZ = 278,

        JMP = 279,

        LAR = 280,

        LDDQU = 281,

        VLDDQU = 282,

        LDMXCSR = 283,

        VLDMXCSR = 284,

        LDS = 285,

        LSS = 286,

        LES = 287,

        LFS = 288,

        LGS = 289,

        LEA = 290,

        LEAVE = 291,

        LGDT = 292,

        LIDT = 293,

        LLDT = 294,

        LMSW = 295,

        LODS = 296,

        LOOP = 297,

        LOOPE = 298,

        LOOPNE = 299,

        LSL = 300,

        LTR = 301,

        LZCNT = 302,

        MASKMOVDQU = 303,

        VMASKMOVDQU = 304,

        MASKMOVQ = 305,

        MAXPD = 306,

        VMAXPD = 307,

        MAXPS = 308,

        VMAXPS = 309,

        MAXSD = 310,

        VMAXSD = 311,

        MAXSS = 312,

        VMAXSS = 313,

        MINPD = 314,

        VMINPD = 315,

        MINPS = 316,

        VMINPS = 317,

        MINSD = 318,

        VMINSD = 319,

        MINSS = 320,

        VMINSS = 321,

        MOV = 322,

        MOVAPD = 323,

        VMOVAPD = 324,

        MOVAPS = 325,

        VMOVAPS = 326,

        MOVBE = 327,

        MOVD = 328,

        MOVQ = 329,

        VMOVD = 330,

        VMOVQ = 331,

        MOVDDUP = 332,

        VMOVDDUP = 333,

        MOVDQA = 334,

        VMOVDQA = 335,

        MOVDQU = 336,

        VMOVDQU = 337,

        MOVDQ2Q = 338,

        MOVHLPS = 339,

        VMOVHLPS = 340,

        MOVHPD = 341,

        VMOVHPD = 342,

        MOVHPS = 343,

        VMOVHPS = 344,

        MOVLHPS = 345,

        VMOVLHPS = 346,

        MOVLPD = 347,

        VMOVLPD = 348,

        MOVLPS = 349,

        VMOVLPS = 350,

        MOVMSKPD = 351,

        VMOVMSKPD = 352,

        MOVMSKPS = 353,

        VMOVMSKPS = 354,

        MOVNTDQA = 355,

        VMOVNTDQA = 356,

        MOVNTDQ = 357,

        VMOVNTDQ = 358,

        MOVNTI = 359,

        MOVNTPD = 360,

        VMOVNTPD = 361,

        MOVNTPS = 362,

        VMOVNTPS = 363,

        MOVNTQ = 364,

        MOVQ2DQ = 365,

        MOVS = 366,

        MOVSD = 367,

        VMOVSD = 368,

        MOVSHDUP = 369,

        VMOVSHDUP = 370,

        MOVSLDUP = 371,

        VMOVSLDUP = 372,

        MOVSS = 373,

        VMOVSS = 374,

        MOVSX = 375,

        MOVSXD = 376,

        MOVUPD = 377,

        VMOVUPD = 378,

        MOVUPS = 379,

        VMOVUPS = 380,

        MOVZX = 381,

        MPSADBW = 382,

        VMPSADBW = 383,

        MUL = 384,

        MULPD = 385,

        VMULPD = 386,

        MULPS = 387,

        VMULPS = 388,

        MULSD = 389,

        VMULSD = 390,

        MULSS = 391,

        VMULSS = 392,

        MULX = 393,

        NEG = 394,

        NOP = 395,

        NOT = 396,

        OR = 397,

        ORPD = 398,

        VORPD = 399,

        ORPS = 400,

        VORPS = 401,

        OUT = 402,

        OUTS = 403,

        PABSB = 404,

        PABSW = 405,

        PABSD = 406,

        VPABSB = 407,

        VPABSW = 408,

        VPABSD = 409,

        PACKSSWB = 410,

        PACKSSDW = 411,

        VPACKSSWB = 412,

        VPACKSSDW = 413,

        PACKUSDW = 414,

        VPACKUSDW = 415,

        PACKUSWB = 416,

        VPACKUSWB = 417,

        PADDB = 418,

        PADDW = 419,

        PADDD = 420,

        VPADDB = 421,

        VPADDW = 422,

        VPADDD = 423,

        PADDQ = 424,

        VPADDQ = 425,

        PADDSB = 426,

        PADDSW = 427,

        VPADDSB = 428,

        VPADDSW = 429,

        PADDUSB = 430,

        PADDUSW = 431,

        VPADDUSB = 432,

        VPADDUSW = 433,

        PALIGNR = 434,

        VPALIGNR = 435,

        PAND = 436,

        VPAND = 437,

        PANDN = 438,

        VPANDN = 439,

        PAVGB = 440,

        PAVGW = 441,

        VPAVGB = 442,

        VPAVGW = 443,

        PBLENDVB = 444,

        VPBLENDVB = 445,

        PBLENDW = 446,

        VPBLENDW = 447,

        PCLMULQDQ = 448,

        VPCLMULQDQ = 449,

        PCMPEQB = 450,

        PCMPEQW = 451,

        PCMPEQD = 452,

        VPCMPEQB = 453,

        VPCMPEQW = 454,

        VPCMPEQD = 455,

        PCMPEQQ = 456,

        VPCMPEQQ = 457,

        PCMPESTRI = 458,

        VPCMPESTRI = 459,

        PCMPESTRM = 460,

        VPCMPESTRM = 461,

        PCMPGTB = 462,

        PCMPGTW = 463,

        PCMPGTD = 464,

        VPCMPGTB = 465,

        VPCMPGTW = 466,

        VPCMPGTD = 467,

        PCMPGTQ = 468,

        VPCMPGTQ = 469,

        PCMPISTRI = 470,

        VPCMPISTRI = 471,

        PCMPISTRM = 472,

        VPCMPISTRM = 473,

        PDEP = 474,

        PEXT = 475,

        PEXTRB = 476,

        PEXTRD = 477,

        PEXTRQ = 478,

        VPEXTRB = 479,

        VPEXTRD = 480,

        VPEXTRQ = 481,

        PEXTRW = 482,

        VPEXTRW = 483,

        PHADDW = 484,

        PHADDD = 485,

        VPHADDW = 486,

        VPHADDD = 487,

        PHADDSW = 488,

        VPHADDSW = 489,

        PHMINPOSUW = 490,

        VPHMINPOSUW = 491,

        PHSUBW = 492,

        PHSUBD = 493,

        VPHSUBW = 494,

        VPHSUBD = 495,

        PHSUBSW = 496,

        VPHSUBSW = 497,

        PINSRB = 498,

        PINSRD = 499,

        PINSRQ = 500,

        VPINSRB = 501,

        VPINSRD = 502,

        VPINSRQ = 503,

        PINSRW = 504,

        VPINSRW = 505,

        PMADDUBSW = 506,

        VPMADDUBSW = 507,

        PMADDWD = 508,

        VPMADDWD = 509,

        PMAXSB = 510,

        VPMAXSB = 511,

        PMAXSD = 512,

        VPMAXSD = 513,

        PMAXSW = 514,

        VPMAXSW = 515,

        PMAXUB = 516,

        VPMAXUB = 517,

        PMAXUD = 518,

        VPMAXUD = 519,

        PMAXUW = 520,

        VPMAXUW = 521,

        PMINSB = 522,

        VPMINSB = 523,

        PMINSD = 524,

        VPMINSD = 525,

        PMINSW = 526,

        VPMINSW = 527,

        PMINUB = 528,

        VPMINUB = 529,

        PMINUD = 530,

        VPMINUD = 531,

        PMINUW = 532,

        VPMINUW = 533,

        PMOVMSKB = 534,

        VPMOVMSKB = 535,

        PMOVSXBW = 536,

        PMOVSXBD = 537,

        PMOVSXBQ = 538,

        PMOVSXWD = 539,

        PMOVSXWQ = 540,

        PMOVSXDQ = 541,

        VPMOVSXBW = 542,

        VPMOVSXBD = 543,

        VPMOVSXBQ = 544,

        VPMOVSXWD = 545,

        VPMOVSXWQ = 546,

        VPMOVSXDQ = 547,

        PMOVZXBW = 548,

        PMOVZXBD = 549,

        PMOVZXBQ = 550,

        PMOVZXWD = 551,

        PMOVZXWQ = 552,

        PMOVZXDQ = 553,

        VPMOVZXBW = 554,

        VPMOVZXBD = 555,

        VPMOVZXBQ = 556,

        VPMOVZXWD = 557,

        VPMOVZXWQ = 558,

        VPMOVZXDQ = 559,

        PMULDQ = 560,

        VPMULDQ = 561,

        PMULHRSW = 562,

        VPMULHRSW = 563,

        PMULHUW = 564,

        VPMULHUW = 565,

        PMULHW = 566,

        VPMULHW = 567,

        PMULLD = 568,

        VPMULLD = 569,

        PMULLW = 570,

        VPMULLW = 571,

        PMULUDQ = 572,

        VPMULUDQ = 573,

        POP = 574,

        POPCNT = 575,

        POR = 576,

        VPOR = 577,

        PREFETCHT0 = 578,

        PREFETCHT1 = 579,

        PREFETCHT2 = 580,

        PREFETCHNTA = 581,

        PSADBW = 582,

        VPSADBW = 583,

        PSHUFB = 584,

        VPSHUFB = 585,

        PSHUFD = 586,

        VPSHUFD = 587,

        PSHUFHW = 588,

        VPSHUFHW = 589,

        PSHUFLW = 590,

        VPSHUFLW = 591,

        PSHUFW = 592,

        PSIGNB = 593,

        PSIGNW = 594,

        PSIGND = 595,

        VPSIGNB = 596,

        VPSIGNW = 597,

        VPSIGND = 598,

        PSLLDQ = 599,

        VPSLLDQ = 600,

        PSLLW = 601,

        PSLLD = 602,

        PSLLQ = 603,

        VPSLLW = 604,

        VPSLLD = 605,

        VPSLLQ = 606,

        PSRAW = 607,

        PSRAD = 608,

        VPSRAW = 609,

        VPSRAD = 610,

        PSRLDQ = 611,

        VPSRLDQ = 612,

        PSRLW = 613,

        PSRLD = 614,

        PSRLQ = 615,

        VPSRLW = 616,

        VPSRLD = 617,

        VPSRLQ = 618,

        PSUBB = 619,

        PSUBW = 620,

        PSUBD = 621,

        VPSUBB = 622,

        VPSUBW = 623,

        VPSUBD = 624,

        PSUBQ = 625,

        VPSUBQ = 626,

        PSUBSB = 627,

        PSUBSW = 628,

        VPSUBSB = 629,

        VPSUBSW = 630,

        PSUBUSB = 631,

        PSUBUSW = 632,

        VPSUBUSB = 633,

        VPSUBUSW = 634,

        PTEST = 635,

        VPTEST = 636,

        PUNPCKHBW = 637,

        PUNPCKHWD = 638,

        PUNPCKHDQ = 639,

        PUNPCKHQDQ = 640,

        VPUNPCKHBW = 641,

        VPUNPCKHWD = 642,

        VPUNPCKHDQ = 643,

        VPUNPCKHQDQ = 644,

        PUNPCKLBW = 645,

        PUNPCKLWD = 646,

        PUNPCKLDQ = 647,

        PUNPCKLQDQ = 648,

        VPUNPCKLBW = 649,

        VPUNPCKLWD = 650,

        VPUNPCKLDQ = 651,

        VPUNPCKLQDQ = 652,

        PUSH = 653,

        PUSHQ = 654,

        PUSHW = 655,

        PXOR = 656,

        VPXOR = 657,

        RCL = 658,

        RCR = 659,

        ROL = 660,

        ROR = 661,

        RCPPS = 662,

        VRCPPS = 663,

        RCPSS = 664,

        VRCPSS = 665,

        RDFSBASE = 666,

        RDGSBASE = 667,

        RDRAND = 668,

        REP_INS = 669,

        REP_MOVS = 670,

        REP_OUTS = 671,

        REP_LODS = 672,

        REP_STOS = 673,

        REPE_CMPS = 674,

        REPE_SCAS = 675,

        REPNE_CMPS = 676,

        REPNE_SCAS = 677,

        RET = 678,

        RORX = 679,

        ROUNDPD = 680,

        VROUNDPD = 681,

        ROUNDPS = 682,

        VROUNDPS = 683,

        ROUNDSD = 684,

        VROUNDSD = 685,

        ROUNDSS = 686,

        VROUNDSS = 687,

        RSQRTPS = 688,

        VRSQRTPS = 689,

        RSQRTSS = 690,

        VRSQRTSS = 691,

        SAL = 692,

        SAR = 693,

        SHL = 694,

        SHR = 695,

        SARX = 696,

        SHLX = 697,

        SHRX = 698,

        SBB = 699,

        SCAS = 700,

        SETA = 701,

        SETAE = 702,

        SETB = 703,

        SETBE = 704,

        SETC = 705,

        SETE = 706,

        SETG = 707,

        SETGE = 708,

        SETL = 709,

        SETLE = 710,

        SETNA = 711,

        SETNAE = 712,

        SETNB = 713,

        SETNBE = 714,

        SETNC = 715,

        SETNE = 716,

        SETNG = 717,

        SETNGE = 718,

        SETNL = 719,

        SETNLE = 720,

        SETNO = 721,

        SETNP = 722,

        SETNS = 723,

        SETNZ = 724,

        SETO = 725,

        SETP = 726,

        SETPE = 727,

        SETPO = 728,

        SETS = 729,

        SETZ = 730,

        SGDT = 731,

        SHLD = 732,

        SHRD = 733,

        SHUFPD = 734,

        VSHUFPD = 735,

        SHUFPS = 736,

        VSHUFPS = 737,

        SIDT = 738,

        SLDT = 739,

        SMSW = 740,

        SQRTPD = 741,

        VSQRTPD = 742,

        SQRTPS = 743,

        VSQRTPS = 744,

        SQRTSD = 745,

        VSQRTSD = 746,

        SQRTSS = 747,

        VSQRTSS = 748,

        STMXCSR = 749,

        VSTMXCSR = 750,

        STOS = 751,

        STR = 752,

        SUB = 753,

        SUBPD = 754,

        VSUBPD = 755,

        SUBPS = 756,

        VSUBPS = 757,

        SUBSD = 758,

        VSUBSD = 759,

        SUBSS = 760,

        VSUBSS = 761,

        SYSEXIT = 762,

        SYSRET = 763,

        TEST = 764,

        TZCNT = 765,

        UCOMISD = 766,

        VUCOMISD = 767,

        UCOMISS = 768,

        VUCOMISS = 769,

        UNPCKHPD = 770,

        VUNPCKHPD = 771,

        UNPCKHPS = 772,

        VUNPCKHPS = 773,

        UNPCKLPD = 774,

        VUNPCKLPD = 775,

        UNPCKLPS = 776,

        VUNPCKLPS = 777,

        VBROADCASTSS = 778,

        VBROADCASTSD = 779,

        VBROADCASTF128 = 780,

        VCVTPH2PS = 781,

        VCVTPS2PH = 782,

        VERR = 783,

        VERW = 784,

        VEXTRACTF128 = 785,

        VEXTRACTI128 = 786,

        VFMADD132PD = 787,

        VFMADD213PD = 788,

        VFMADD231PD = 789,

        VFMADD132PS = 790,

        VFMADD213PS = 791,

        VFMADD231PS = 792,

        VFMADD132SD = 793,

        VFMADD213SD = 794,

        VFMADD231SD = 795,

        VFMADD132SS = 796,

        VFMADD213SS = 797,

        VFMADD231SS = 798,

        VFMADDSUB132PD = 799,

        VFMADDSUB213PD = 800,

        VFMADDSUB231PD = 801,

        VFMADDSUB132PS = 802,

        VFMADDSUB213PS = 803,

        VFMADDSUB231PS = 804,

        VFMSUBADD132PD = 805,

        VFMSUBADD213PD = 806,

        VFMSUBADD231PD = 807,

        VFMSUBADD132PS = 808,

        VFMSUBADD213PS = 809,

        VFMSUBADD231PS = 810,

        VFMSUB132PD = 811,

        VFMSUB213PD = 812,

        VFMSUB231PD = 813,

        VFMSUB132PS = 814,

        VFMSUB213PS = 815,

        VFMSUB231PS = 816,

        VFMSUB132SD = 817,

        VFMSUB213SD = 818,

        VFMSUB231SD = 819,

        VFMSUB132SS = 820,

        VFMSUB213SS = 821,

        VFMSUB231SS = 822,

        VFNMADD132PD = 823,

        VFNMADD213PD = 824,

        VFNMADD231PD = 825,

        VFNMADD132PS = 826,

        VFNMADD213PS = 827,

        VFNMADD231PS = 828,

        VFNMADD132SD = 829,

        VFNMADD213SD = 830,

        VFNMADD231SD = 831,

        VFNMADD132SS = 832,

        VFNMADD213SS = 833,

        VFNMADD231SS = 834,

        VFNMSUB132PD = 835,

        VFNMSUB213PD = 836,

        VFNMSUB231PD = 837,

        VFNMSUB132PS = 838,

        VFNMSUB213PS = 839,

        VFNMSUB231PS = 840,

        VFNMSUB132SD = 841,

        VFNMSUB213SD = 842,

        VFNMSUB231SD = 843,

        VFNMSUB132SS = 844,

        VFNMSUB213SS = 845,

        VFNMSUB231SS = 846,

        VGATHERDPD = 847,

        VGATHERQPD = 848,

        VGATHERDPS = 849,

        VGATHERQPS = 850,

        VPGATHERDD = 851,

        VPGATHERQD = 852,

        VPGATHERDQ = 853,

        VPGATHERQQ = 854,

        VINSERTF128 = 855,

        VINSERTI128 = 856,

        VMASKMOVPS = 857,

        VMASKMOVPD = 858,

        VPBLENDD = 859,

        VPBROADCASTB = 860,

        VPBROADCASTW = 861,

        VPBROADCASTD = 862,

        VPBROADCASTQ = 863,

        VBROADCASTI128 = 864,

        VPERMD = 865,

        VPERMPD = 866,

        VPERMPS = 867,

        VPERMQ = 868,

        VPERM2I128 = 869,

        VPERMILPD = 870,

        VPERMILPS = 871,

        VPERM2F128 = 872,

        VPMASKMOVD = 873,

        VPMASKMOVQ = 874,

        VPSLLVD = 875,

        VPSLLVQ = 876,

        VPSRAVD = 877,

        VPSRLVD = 878,

        VPSRLVQ = 879,

        VTESTPS = 880,

        VTESTPD = 881,

        WRFSBASE = 882,

        WRGSBASE = 883,

        XABORT = 884,

        XADD = 885,

        XBEGIN = 886,

        XCHG = 887,

        XLAT = 888,

        XOR = 889,

        XORPD = 890,

        VXORPD = 891,

        XORPS = 892,

        VXORPS = 893,

        XRSTOR = 894,

        XRSTOR64 = 895,

        XSAVE = 896,

        XSAVE64 = 897,

        XSAVEOPT = 898,

        XSAVEOPT64 = 899,

    }
}
