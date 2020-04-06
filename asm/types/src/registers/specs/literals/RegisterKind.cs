//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using W = RegisterWidth;

    /// <summary>
    /// Defines a register classification scheme
    /// </summary>
    [Flags]
    public enum RegisterKind : ulong
    {
        /// <summary>
        /// An ambivalent register
        ///</summary>
        None = 0,

        /// <summary>
        /// Classifies a register of bit-width 8
        ///</summary>
        W8 = W.W8,

        /// <summary>
        /// Classifies a register of bit-width 16
        ///</summary>
        W16 = W.W16,

        /// <summary>
        /// Classifies a register of bit-width 32
        ///</summary>
        W32 = W.W32,

        /// <summary>
        /// Classifies a register of bit-width 64
        ///</summary>
        W64 = W.W64,

        /// <summary>
        /// Classifies a register of bit-width 128
        ///</summary>
        W128 = W.W128,

        /// <summary>
        /// Classifies a register of bit-width 256
        ///</summary>
        W256 = W.W256,

        /// <summary>
        /// Classifies a register of bit-width 512
        ///</summary>
        W512 = W.W512,
                
        /// <summary>
        /// The maximum supported register width
        ///</summary>
        WMax = W512,

        /// <summary>
        /// Classifies a register that has been assigned index slot 0
        ///</summary>
        IX0 = WMax << 1,

        /// <summary>
        /// Classifies a register that has been assigned index slot 1
        ///</summary>
        IX1 = IX0 << 1,

        /// <summary>
        /// Classifies a register that has been assigned index slot 2
        ///</summary>
        IX2 = IX0 << 2,

        /// <summary>
        /// Classifies a register that has been assigned index slot 3
        ///</summary>
        IX3 = IX0 << 3,

        /// <summary>
        /// Classifies a register that has been assigned index slot 4
        ///</summary>
        IX4 = IX0 << 4,

        /// <summary>
        /// Classifies a register that has been assigned index slot 5
        ///</summary>
        IX5 = IX0 << 5,

        /// <summary>
        /// Classifies a register that has been assigned index slot 6
        ///</summary>
        IX6 = IX0 << 6,

        /// <summary>
        /// Classifies a register that has been assigned index slot 7
        ///</summary>
        IX7 = IX0 << 7,

        /// <summary>
        /// Classifies a register that has been assigned index slot 8
        ///</summary>
        IX8 = IX0 << 8,

        /// <summary>
        /// Classifies a register that has been assigned index slot 9
        ///</summary>
        IX9 = IX0 << 9,

        /// <summary>
        /// Classifies a register that has been assigned index slot 10
        ///</summary>
        IX10 = IX0 << 10,

        /// <summary>
        /// Classifies a register that has been assigned index slot 11
        ///</summary>
        IX11 = IX0 << 11,

        /// <summary>
        /// Classifies a register that has been assigned index slot 12
        ///</summary>
        IX12 = IX0 << 12,

        /// <summary>
        /// Classifies a register that has been assigned index slot 13
        ///</summary>
        IX13 = IX0 << 13,

        /// <summary>
        /// Classifies a register that has been assigned index slot 14
        ///</summary>
        IX14 = IX0 << 14,

        /// <summary>
        /// Classifies a register that has been assigned index slot 15
        ///</summary>
        IX15 = IX0 << 15,

        /// <summary>
        /// Classifies a register that has been assigned index slot 16
        ///</summary>
        IX16 = IX0 << 16,

        /// <summary>
        /// Classifies a register that has been assigned index slot 17
        ///</summary>
        IX17 = IX0 << 17,

        /// <summary>
        /// Classifies a register that has been assigned index slot 18
        ///</summary>
        IX18 = IX0 << 18,

        /// <summary>
        /// Classifies a register that has been assigned index slot 19
        ///</summary>
        IX19 = IX0 << 19,

        /// <summary>
        /// Classifies a register that has been assigned index slot 20
        ///</summary>
        IX20 = IX0 << 20,

        /// <summary>
        /// Classifies a register that has been assigned index slot 21
        ///</summary>
        IX21 = IX0 << 21,

        /// <summary>
        /// Classifies a register that has been assigned index slot 22
        ///</summary>
        IX22 = IX0 << 22,

        /// <summary>
        /// Classifies a register that has been assigned index slot 23
        ///</summary>
        IX23 = IX0 << 23,

        /// <summary>
        /// Classifies a register that has been assigned index slot 24
        ///</summary>
        IX24 = IX0 << 24,

        /// <summary>
        /// Classifies a register that has been assigned index slot 25
        ///</summary>
        IX25 = IX0 << 25,

        /// <summary>
        /// Classifies a register that has been assigned index slot 26
        ///</summary>
        IX26 = IX0 << 26,

        /// <summary>
        /// Classifies a register that has been assigned index slot 27
        ///</summary>
        IX27 = IX0 << 27,

        /// <summary>
        /// Classifies a register that has been assigned index slot 28
        ///</summary>
        IX28 = IX0 << 28,

        /// <summary>
        /// Classifies a register that has been assigned index slot 29
        ///</summary>
        IX29 = IX0 << 29,

        /// <summary>
        /// Classifies a register that has been assigned index slot 30
        ///</summary>
        IX30 = IX0 << 31,

        /// <summary>
        /// Classifies a register that has been assigned index slot 31
        ///</summary>
        IX31 = IX0 << 31,

        /// <summary>
        /// The first register category
        ///</summary>
        FirstCategory = IX31 << 1,

        /// <summary>
        /// A general-purpose register
        ///</summary>
        GP = FirstCategory,

        /// <summary>
        /// A segment register
        ///</summary>
        Seg = FirstCategory << 1,

        /// <summary>
        /// A vector register
        ///</summary>
        Vector  = FirstCategory << 2,

        /// <summary>
        /// An 8-bit general-purpose register
        ///</summary>
        GP8 = GP | W8,

        /// <summary>
        /// A 16-bit general-purpose register
        ///</summary>
        GP16 = GP | W16,

        /// <summary>
        /// A 32-bit general-purpose register
        ///</summary>
        GP32 = GP | W32,

        /// <summary>
        /// A 64-bit general-purpose register
        ///</summary>
        GP64 = GP | W64,

        /// <summary>
        /// A 128-bit vector register
        ///</summary>
        Xmm = Vector | W128,

        /// <summary>
        /// A 256-bit vector register
        ///</summary>
        Ymm = Vector | W256,

        /// <summary>
        /// A 512-bit vector register
        ///</summary>
        Zmm = Vector | W512,

        /// <summary>
        /// The 8-bit AL general-purpose register
        ///</summary>
        AL = IX0 | GP | W8,

        /// <summary>
        /// The 8-bit CL general-purpose register
        ///</summary>
        CL = IX1 | GP | W8,

        /// <summary>
        /// The 8-bit DL general-purpose register
        ///</summary>
        DL = IX2 | GP | W8,
        
        /// <summary>
        /// The 8-bit BL general-purpose register
        ///</summary>
        BL = IX3 | GP | W8,

        /// <summary>
        /// The 8-bit SIL general-purpose register
        ///</summary>
        SIL = IX4 | GP | W8,

        /// <summary>
        /// The 8-bit DIL general-purpose register
        ///</summary>
        DIL = IX5 | GP | W8,

        /// <summary>
        /// The 8-bit SPL general-purpose register
        ///</summary>
        SPL = IX6 | GP | W8,

        /// <summary>
        /// The 8-bit BPL general-purpose register
        ///</summary>
        BPL = IX7 | GP | W8,

        /// <summary>
        /// The 8-bit R8B general-purpose register
        ///</summary>
        R8B = IX8 | GP | W8,

        /// <summary>
        /// The 8-bit R9B general-purpose register
        ///</summary>
        R9B = IX9 | GP | W8,

        /// <summary>
        /// The 8-bit R10B general-purpose register
        ///</summary>
        R10B = IX10 | GP | W8,

        /// <summary>
        /// The 8-bit R11B general-purpose register
        ///</summary>
        R11B = IX11 | GP | W8,

        /// <summary>
        /// The 8-bit R12B general-purpose register
        ///</summary>
        R12B = IX12 | GP | W8,

        /// <summary>
        /// The 8-bit R13B general-purpose register
        ///</summary>
        R13B = IX13 | GP | W8,

        /// <summary>
        /// The 8-bit R14B general-purpose register
        ///</summary>
        R14B = IX14 | GP | W8,

        /// <summary>
        /// The 8-bit R15B general-purpose register
        ///</summary>
        R15B = IX15 | GP | W8,

        /// <summary>
        /// The 16-bit AX general-purpose register
        ///</summary>
        AX = IX0 | GP | W16,

        /// <summary>
        /// The 16-bit CX general-purpose register
        ///</summary>
        CX = IX1 | GP | W16,

        /// <summary>
        /// The 16-bit DX general-purpose register
        ///</summary>
        DX = IX2 | GP | W16,

        /// <summary>
        /// The 16-bit BX general-purpose register
        ///</summary>
        BX = IX3 | GP | W16,

        /// <summary>
        /// The 16-bit Si general-purpose register
        ///</summary>
        SI = IX4 | GP | W16,

        /// <summary>
        /// The 16-bit DI general-purpose register
        ///</summary>
        DI = IX5 | GP | W16,

        /// <summary>
        /// The 16-bit SP general-purpose register
        ///</summary>
        SP = IX6 | GP | W16,

        /// <summary>
        /// The 16-bit BP general-purpose register
        ///</summary>
        BP = IX7 | GP | W16,

        /// <summary>
        /// The 16-bit R8W general-purpose register
        ///</summary>
        R8W = IX8 | GP | W16,

        /// <summary>
        /// The 16-bit R9W general-purpose register
        ///</summary>
        R9W = IX9 | GP | W16,

        /// <summary>
        /// The 16-bit R10W general-purpose register
        ///</summary>
        R10W = IX10 | GP | W16,

        /// <summary>
        /// The 16-bit R11W general-purpose register
        ///</summary>
        R11W = IX11 | GP | W16,

        /// <summary>
        /// The 16-bit R12W general-purpose register
        ///</summary>
        R12W = IX12 | GP | W16,

        /// <summary>
        /// The 16-bit R13W general-purpose register
        ///</summary>
        R13W = IX13 | GP | W16,

        /// <summary>
        /// The 16-bit R14W general-purpose register
        ///</summary>
        R14W = IX14 | GP | W16,

        /// <summary>
        /// The 16-bit R15W general-purpose register
        ///</summary>
        R15W = IX15 | GP | W16,

        /// <summary>
        /// The 32-bit EAX general-purpose register
        ///</summary>
        EAX = IX0 | GP | W32,

        ECX = IX1 | GP | W32,

        EDX = IX2 | GP | W32,

        EBX = IX3 | GP | W32,

        ESI = IX4 | GP | W32,

        EDI = IX5 | GP | W32,

        ESP = IX6 | GP | W32,

        EBP = IX7 | GP | W32,

        R8D = IX8 | GP | W32,

        R9D = IX9 | GP | W32,

        R10D = IX10 | GP | W32,

        R11D = IX11 | GP | W32,

        R12D = IX12 | GP | W32,

        R13D = IX13 | GP | W32,

        R14D = IX14 | GP | W32,

        R15D = IX15 | GP | W32,

        /// <summary>
        /// The 64-bit RAX general-purpose register
        ///</summary>
        RAX = IX0 | GP | W64,

        /// <summary>
        /// The 64-bit RCX general-purpose register
        ///</summary>
        RCX = IX1 | GP | W64,

        RDX = IX2 | GP | W64, 

        RBX = IX3 | GP | W64, 

        RSI = IX4 | GP | W64, 

        RDI = IX5 | GP | W64, 

        RSP = IX6 | GP | W64, 

        RBP = IX7 | GP | W64, 

        R8 = IX8 | GP | W64, 

        R9 = IX9 | GP | W64, 

        R10 = IX10 | GP | W64, 

        /// <summary>
        /// The 64-bit R11 general-purpose register
        ///</summary>
        R11 = IX11 | GP | W64, 

        /// <summary>
        /// The 64-bit R12 general-purpose register
        ///</summary>
        R12 = IX12 | GP | W64, 

        /// <summary>
        /// The 64-bit R13 general-purpose register
        ///</summary>
        R13 = IX13 | GP | W64, 

        /// <summary>
        /// The 64-bit R14 general-purpose register
        ///</summary>
        R14 = IX14 | GP | W64, 

        /// <summary>
        /// The 64-bit R15 general-purpose register
        ///</summary>
        R15 = IX15 | GP | W64, 
        
        /// <summary>
        /// The 128-bit XMM[0] vectorized register
        ///</summary>
        XMM0 = IX0 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[1] vectorized register
        ///</summary>
        XMM1 = IX1 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[2] vectorized register
        ///</summary>
        XMM2 = IX2 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[3] vectorized register
        ///</summary>
        XMM3 = IX3 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[4] vectorized register
        ///</summary>
        XMM4 = IX4 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[5] vectorized register
        ///</summary>
        XMM5 = IX5 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[6] vectorized register
        ///</summary>
        XMM6 = IX6 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[7] vectorized register
        ///</summary>
        XMM7 = IX7 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[8] vectorized register
        ///</summary>
        XMM8 = IX8 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[9] vectorized register
        ///</summary>
        XMM9 = IX9 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[10] vectorized register
        ///</summary>
        XMM10 = IX10 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[11] vectorized register
        ///</summary>
        XMM11 = IX11 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[12] vectorized register
        ///</summary>
        XMM12 = IX12 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[13] vectorized register
        ///</summary>
        XMM13 = IX13 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[14] vectorized register
        ///</summary>
        XMM14 = IX14 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[15] vectorized register
        ///</summary>
        XMM15 = IX15 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[16] vectorized register
        ///</summary>
        XMM16 = IX16 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[17] vectorized register
        ///</summary>
        XMM17 = IX17 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[18] vectorized register
        ///</summary>
        XMM18 = IX18 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[19] vectorized register
        ///</summary>
        XMM19 = IX19 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[20] vectorized register
        ///</summary>
        XMM20 = IX20 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[21] vectorized register
        ///</summary>
        XMM21 = IX21 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[22] vectorized register
        ///</summary>
        XMM22 = IX22 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[23] vectorized register
        ///</summary>
        XMM23 = IX23 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[24] vectorized register
        ///</summary>
        XMM24 = IX24 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[25] vectorized register
        ///</summary>
        XMM25 = IX25 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[26] vectorized register
        ///</summary>
        XMM26 = IX26 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[27] vectorized register
        ///</summary>
        XMM27 = IX27 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[28] vectorized register
        ///</summary>
        XMM28 = IX28 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[29] vectorized register
        ///</summary>
        XMM29 = IX29 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[30] vectorized register
        ///</summary>
        XMM30 = IX30 | Vector | W128,

        /// <summary>
        /// The 128-bit XMM[31] vectorized register
        ///</summary>
        XMM31 = IX31 | Vector | W128,

        /// <summary>
        /// The 256-bit YMM[0] vectorized register
        ///</summary>
        YMM0 = IX0 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[1] vectorized register
        ///</summary>
        YMM1 = IX1 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[2] vectorized register
        ///</summary>
        YMM2 = IX2 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[3] vectorized register
        ///</summary>
        YMM3 = IX3 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[4] vectorized register
        ///</summary>
        YMM4 = IX4 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[5] vectorized register
        ///</summary>
        YMM5 = IX5 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[6] vectorized register
        ///</summary>
        YMM6 = IX6 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[7] vectorized register
        ///</summary>
        YMM7 = IX7 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[8] vectorized register
        ///</summary>
        YMM8 = IX8 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[9] vectorized register
        ///</summary>
        YMM9 = IX9 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[10] vectorized register
        ///</summary>
        YMM10 = IX10 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[11] vectorized register
        ///</summary>
        YMM11 = IX11 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[12] vectorized register
        ///</summary>
        YMM12 = IX12 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[13] vectorized register
        ///</summary>
        YMM13 = IX13 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[14] vectorized register
        ///</summary>
        YMM14 = IX14 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[15] vectorized register
        ///</summary>
        YMM15 = IX15 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[16] vectorized register
        ///</summary>
        YMM16 = IX16 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[17] vectorized register
        ///</summary>
        YMM17 = IX17 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[18] vectorized register
        ///</summary>
        YMM18 = IX18 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[19] vectorized register
        ///</summary>
        YMM19 = IX19 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[20] vectorized register
        ///</summary>
        YMM20 = IX20 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[21] vectorized register
        ///</summary>
        YMM21 = IX21 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[22] vectorized register
        ///</summary>
        YMM22 = IX22 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[23] vectorized register
        ///</summary>
        YMM23 = IX23 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[24] vectorized register
        ///</summary>
        YMM24 = IX24 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[25] vectorized register
        ///</summary>
        YMM25 = IX25 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[26] vectorized register
        ///</summary>
        YMM26 = IX26 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[27] vectorized register
        ///</summary>
        YMM27 = IX27 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[28] vectorized register
        ///</summary>
        YMM28 = IX28 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[29] vectorized register
        ///</summary>
        YMM29 = IX29 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[30] vectorized register
        ///</summary>
        YMM30 = IX30 | Vector | W256,

        /// <summary>
        /// The 256-bit YMM[31] vectorized register
        ///</summary>
        YMM31 = IX31 | Vector | W256,

        /// <summary>
        /// The 512-bit YMM[0] vectorized register
        ///</summary>
        ZMM0 = IX0 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[1] vectorized register
        ///</summary>
        ZMM1 = IX1 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[2] vectorized register
        ///</summary>
        ZMM2 = IX2 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[3] vectorized register
        ///</summary>
        ZMM3 = IX3 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[4] vectorized register
        ///</summary>
        ZMM4 = IX4 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[5] vectorized register
        ///</summary>
        ZMM5 = IX5 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[6] vectorized register
        ///</summary>
        ZMM6 = IX6 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[7] vectorized register
        ///</summary>
        ZMM7 = IX7 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[8] vectorized register
        ///</summary>
        ZMM8 = IX8 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[9] vectorized register
        ///</summary>
        ZMM9 = IX9 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[10] vectorized register
        ///</summary>
        ZMM10 = IX10 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[11] vectorized register
        ///</summary>
        ZMM11 = IX11 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[12] vectorized register
        ///</summary>
        ZMM12 = IX12 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[13] vectorized register
        ///</summary>
        ZMM13 = IX13 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[14] vectorized register
        ///</summary>
        ZMM14 = IX14 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[15] vectorized register
        ///</summary>
        ZMM15 = IX15 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[16] vectorized register
        ///</summary>
        ZMM16 = IX16 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[17] vectorized register
        ///</summary>
        ZMM17 = IX17 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[18] vectorized register
        ///</summary>
        ZMM18 = IX18 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[19] vectorized register
        ///</summary>
        ZMM19 = IX19 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[20] vectorized register
        ///</summary>
        ZMM20 = IX20 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[21] vectorized register
        ///</summary>
        ZMM21 = IX21 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[22] vectorized register
        ///</summary>
        ZMM22 = IX22 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[23] vectorized register
        ///</summary>
        ZMM23 = IX23 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[24] vectorized register
        ///</summary>
        ZMM24 = IX24 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[25] vectorized register
        ///</summary>
        ZMM25 = IX25 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[26] vectorized register
        ///</summary>
        ZMM26 = IX26 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[27] vectorized register
        ///</summary>
        ZMM27 = IX27 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[28] vectorized register
        ///</summary>
        ZMM28 = IX28 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[29] vectorized register
        ///</summary>
        ZMM29 = IX29 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[30] vectorized register
        ///</summary>
        ZMM30 = IX30 | Vector | W512,

        /// <summary>
        /// The 512-bit ZMM[31] vectorized register
        ///</summary>
        ZMM31 = IX31 | Vector | W512,
    }
}