//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using K = RegisterKind;

    using static RegisterWidth;
    using static RegisterIndex;
    using static RegisterRole;

    /// <summary>
    /// Defines a kind-concident symbol for each supported register
    /// </summary>
    public enum RegisterSymbol : ulong
    {
        [Literal("The 8-bit AL general-purpose register")]
        AL = K.AL,
        
        [Literal("The 8-bit CL general-purpose register")]        
        CL = K.CL,
        
        [Literal("The 8-bit DL general-purpose register")]
        DL = K.DL,        
        
        [Literal("The 8-bit BL general-purpose register")]        
        BL = K.BL,

        [Literal("The 8-bit SIL general-purpose register")]
        SIL = K.SIL,

        [Literal("The 8-bit DIL general-purpose register")]
        DIL = K.DIL,

        [Literal("The 8-bit SPL general-purpose register")]
        SPL = K.SPL,

        [Literal("The 8-bit BPL general-purpose register")]
        BPL = K.BPL,

        [Literal("The 8-bit R8B general-purpose register")]
        R8B = K.R8B,

        [Literal("The 8-bit R9B general-purpose register")]
        R9B = K.R9B,
        
        [Literal("The 8-bit R10B general-purpose register")]        
        R10B = K.R10B,

        [Literal("The 8-bit R11B general-purpose register")]        
        R11B = IX11 | GP | W8,
        
        [Literal("The 8-bit R12B general-purpose register")]        
        R12B = IX12 | GP | W8,
        
        [Literal("The 8-bit R13B general-purpose register")]        
        R13B = IX13 | GP | W8,
        
        [Literal("The 8-bit R14B general-purpose register")]        
        R14B = IX14 | GP | W8,
        
        [Literal("The 8-bit R15B general-purpose register")]        
        R15B = IX15 | GP | W8,
        
        [Literal("The 16-bit AX general-purpose register")]        
        AX = IX0 | GP | W16,
        
        [Literal("The 16-bit CX general-purpose register")]        
        CX = IX1 | GP | W16,
        
        [Literal("The 16-bit DX general-purpose register")]
        
        DX = IX2 | GP | W16,

        
        [Literal("The 16-bit BX general-purpose register")]
        
        BX = IX3 | GP | W16,

        
        [Literal("The 16-bit Si general-purpose register")]        
        SI = IX4 | GP | W16,

        
        [Literal("The 16-bit DI general-purpose register")]        
        DI = IX5 | GP | W16,

        
        [Literal("The 16-bit SP general-purpose register")]        
        SP = IX6 | GP | W16,

        
        [Literal("The 16-bit BP general-purpose register")]        
        BP = IX7 | GP | W16,

        
        [Literal("The 16-bit R8W general-purpose register")]    
        R8W = IX8 | GP | W16,

        
        [Literal("The 16-bit R9W general-purpose register")]
        
        R9W = IX9 | GP | W16,

        
        [Literal("The 16-bit R10W general-purpose register")]        
        R10W = IX10 | GP | W16,

        
        [Literal("The 16-bit R11W general-purpose register")]
        
        R11W = IX11 | GP | W16,

        
        [Literal("The 16-bit R12W general-purpose register")]
        
        R12W = IX12 | GP | W16,

        
        [Literal("The 16-bit R13W general-purpose register")]
        
        R13W = IX13 | GP | W16,

        
        [Literal("The 16-bit R14W general-purpose register")]
        
        R14W = IX14 | GP | W16,

        
        [Literal("The 16-bit R15W general-purpose register")]        
        R15W = IX15 | GP | W16,

        
        [Literal("The 32-bit EAX general-purpose register")]
        
        EAX = IX0 | GP | W32,

        
        [Literal("The 32-bit ECX general-purpose register")]
        
        ECX = IX1 | GP | W32,

        
        [Literal("The 32-bit EDX general-purpose register")]
        
        EDX = IX2 | GP | W32,

        
        [Literal("The 32-bit EBX general-purpose register")]
        
        EBX = IX3 | GP | W32,

        
        [Literal("The 32-bit ESI general-purpose register")]
        
        ESI = IX4 | GP | W32,

        
        [Literal("The 32-bit EDI general-purpose register")]
        
        EDI = IX5 | GP | W32,

        
        [Literal("The 32-bit ESP general-purpose register")]        
        ESP = IX6 | GP | W32,

        
        [Literal("The 32-bit EBP general-purpose register")]        
        EBP = IX7 | GP | W32,

        
        [Literal("The 32-bit R8D general-purpose register")]        
        R8D = IX8 | GP | W32,

        
        [Literal("The 32-bit R9D general-purpose register")]
        
        R9D = IX9 | GP | W32,

        
        [Literal("The 32-bit R10D general-purpose register")]
        
        R10D = IX10 | GP | W32,

        
        [Literal("The 32-bit R11D general-purpose register")]
        
        R11D = IX11 | GP | W32,

        
        [Literal("The 32-bit R11D general-purpose register")]
        
        R12D = IX12 | GP | W32,

        
        [Literal("The 32-bit R13D general-purpose register")]        
        R13D = IX13 | GP | W32,

        
        [Literal("The 32-bit R14D general-purpose register")]        
        R14D = IX14 | GP | W32,

        
        [Literal("The 32-bit R15D general-purpose register")]        
        R15D = IX15 | GP | W32,

        
        [Literal("The 64-bit RAX general-purpose register")]        
        RAX = IX0 | GP | W64,

        
        [Literal("The 64-bit RCX general-purpose register")]        
        RCX = IX1 | GP | W64,

        
        [Literal("The 64-bit RDX general-purpose register")]
        
        RDX = IX2 | GP | W64, 

        
        [Literal("The 64-bit RBX general-purpose register")]
        
        RBX = IX3 | GP | W64, 

        
        [Literal("The 64-bit RSI general-purpose register")]
        
        RSI = IX4 | GP | W64, 

        
        [Literal("The 64-bit RDI general-purpose register")]
        
        RDI = IX5 | GP | W64, 

        
        [Literal("The 64-bit RSP general-purpose register")]
        
        RSP = IX6 | GP | W64, 

        
        [Literal("The 64-bit RBP general-purpose register")]
        
        RBP = IX7 | GP | W64, 

        
        [Literal("The 64-bit R8 general-purpose register")]
        
        R8 = IX8 | GP | W64, 

        
        [Literal("The 64-bit R9 general-purpose register")]
        
        R9 = IX9 | GP | W64, 

        
        [Literal("The 64-bit R10 general-purpose register")]
        
        R10 = IX10 | GP | W64, 

        
        [Literal("The 64-bit R11 general-purpose register")]
        
        R11 = IX11 | GP | W64, 

        
        [Literal("The 64-bit R12 general-purpose register")]
        
        R12 = IX12 | GP | W64, 

        
        [Literal("The 64-bit R13 general-purpose register")]
        
        R13 = IX13 | GP | W64, 

        
        [Literal("The 64-bit R14 general-purpose register")]
        
        R14 = IX14 | GP | W64, 

        
        [Literal("The 64-bit R15 general-purpose register")]
        
        R15 = IX15 | GP | W64, 
        
        
        /// [Literal("The 128-bit XMM[0] vectorized register
        
        XMM0 = IX0 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[1] vectorized register
        
        XMM1 = IX1 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[2] vectorized register
        
        XMM2 = IX2 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[3] vectorized register
        
        XMM3 = IX3 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[4] vectorized register
        
        XMM4 = IX4 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[5] vectorized register
        
        XMM5 = IX5 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[6] vectorized register
        
        XMM6 = IX6 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[7] vectorized register
        
        XMM7 = IX7 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[8] vectorized register
        
        XMM8 = IX8 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[9] vectorized register
        
        XMM9 = IX9 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[10] vectorized register
        
        XMM10 = IX10 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[11] vectorized register
        
        XMM11 = IX11 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[12] vectorized register
        
        XMM12 = IX12 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[13] vectorized register
        
        XMM13 = IX13 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[14] vectorized register
        
        XMM14 = IX14 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[15] vectorized register
        
        XMM15 = IX15 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[16] vectorized register
        
        XMM16 = IX16 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[17] vectorized register
        
        XMM17 = IX17 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[18] vectorized register
        
        XMM18 = IX18 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[19] vectorized register
        
        XMM19 = IX19 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[20] vectorized register
        
        XMM20 = IX20 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[21] vectorized register
        
        XMM21 = IX21 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[22] vectorized register
        
        XMM22 = IX22 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[23] vectorized register
        
        XMM23 = IX23 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[24] vectorized register
        
        XMM24 = IX24 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[25] vectorized register
        
        XMM25 = IX25 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[26] vectorized register
        
        XMM26 = IX26 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[27] vectorized register
        
        XMM27 = IX27 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[28] vectorized register
        
        XMM28 = IX28 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[29] vectorized register
        
        XMM29 = IX29 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[30] vectorized register
        
        XMM30 = IX30 | Vec | W128,

        
        /// [Literal("The 128-bit XMM[31] vectorized register
        
        XMM31 = IX31 | Vec | W128,

        
        /// [Literal("The 256-bit YMM[0] vectorized register
        
        YMM0 = IX0 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[1] vectorized register
        
        YMM1 = IX1 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[2] vectorized register
        
        YMM2 = IX2 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[3] vectorized register
        
        YMM3 = IX3 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[4] vectorized register
        
        YMM4 = IX4 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[5] vectorized register
        
        YMM5 = IX5 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[6] vectorized register
        
        YMM6 = IX6 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[7] vectorized register
        
        YMM7 = IX7 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[8] vectorized register
        
        YMM8 = IX8 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[9] vectorized register
        
        YMM9 = IX9 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[10] vectorized register
        
        YMM10 = IX10 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[11] vectorized register
        
        YMM11 = IX11 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[12] vectorized register
        
        YMM12 = IX12 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[13] vectorized register
        
        YMM13 = IX13 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[14] vectorized register
        
        YMM14 = IX14 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[15] vectorized register
        
        YMM15 = IX15 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[16] vectorized register
        
        YMM16 = IX16 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[17] vectorized register
        
        YMM17 = IX17 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[18] vectorized register
        
        YMM18 = IX18 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[19] vectorized register
        
        YMM19 = IX19 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[20] vectorized register
        
        YMM20 = IX20 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[21] vectorized register
        
        YMM21 = IX21 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[22] vectorized register
        
        YMM22 = IX22 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[23] vectorized register
        
        YMM23 = IX23 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[24] vectorized register
        
        YMM24 = IX24 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[25] vectorized register
        
        YMM25 = IX25 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[26] vectorized register
        
        YMM26 = IX26 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[27] vectorized register
        
        YMM27 = IX27 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[28] vectorized register
        
        YMM28 = IX28 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[29] vectorized register
        
        YMM29 = IX29 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[30] vectorized register
        
        YMM30 = IX30 | Vec | W256,

        
        /// [Literal("The 256-bit YMM[31] vectorized register
        
        YMM31 = IX31 | Vec | W256,

        
        /// [Literal("The 512-bit YMM[0] vectorized register
        
        ZMM0 = IX0 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[1] vectorized register
        
        ZMM1 = IX1 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[2] vectorized register
        
        ZMM2 = IX2 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[3] vectorized register
        
        ZMM3 = IX3 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[4] vectorized register
        
        ZMM4 = IX4 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[5] vectorized register
        
        ZMM5 = IX5 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[6] vectorized register
        
        ZMM6 = IX6 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[7] vectorized register
        
        ZMM7 = IX7 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[8] vectorized register
        
        ZMM8 = IX8 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[9] vectorized register
        
        ZMM9 = IX9 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[10] vectorized register
        
        ZMM10 = IX10 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[11] vectorized register
        
        ZMM11 = IX11 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[12] vectorized register
        
        ZMM12 = IX12 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[13] vectorized register
        
        ZMM13 = IX13 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[14] vectorized register
        
        ZMM14 = IX14 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[15] vectorized register
        
        ZMM15 = IX15 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[16] vectorized register
        
        ZMM16 = IX16 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[17] vectorized register
        
        ZMM17 = IX17 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[18] vectorized register
        
        ZMM18 = IX18 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[19] vectorized register
        
        ZMM19 = IX19 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[20] vectorized register
        
        ZMM20 = IX20 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[21] vectorized register
        
        ZMM21 = IX21 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[22] vectorized register
        
        ZMM22 = IX22 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[23] vectorized register
        
        ZMM23 = IX23 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[24] vectorized register
        
        ZMM24 = IX24 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[25] vectorized register
        
        ZMM25 = IX25 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[26] vectorized register
        
        ZMM26 = IX26 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[27] vectorized register
        
        ZMM27 = IX27 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[28] vectorized register
        
        ZMM28 = IX28 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[29] vectorized register
        
        ZMM29 = IX29 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[30] vectorized register
        
        ZMM30 = IX30 | Vec | W512,

        
        /// [Literal("The 512-bit ZMM[31] vectorized register
        
        ZMM31 = IX31 | Vec | W512,
    }
}