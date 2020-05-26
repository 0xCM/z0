//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using K = RegisterKind;

    using static RegisterWidth;
    using static RegisterSlot;
    using static RegisterRole;

    public enum RegisterData : ulong
    {
        AL = K.AL,
        
        CL = K.CL,
        
        DL = K.DL,        
        
        BL = K.BL,

        SIL = K.SIL,

        DIL = K.DIL,

        SPL = K.SPL,

        BPL = K.BPL,

        R8B = K.R8B,

        R9B = K.R9B,
        
        R10B = K.R10B,

        R11B = IX11 | GP | W8,
        
        R12B = IX12 | GP | W8,
        
        R13B = IX13 | GP | W8,
        
        R14B = IX14 | GP | W8,
        
        R15B = IX15 | GP | W8,
        
        AX = IX0 | GP | W16,
        
        CX = IX1 | GP | W16,
        
        DX = IX2 | GP | W16,
        
        BX = IX3 | GP | W16,
        
        SI = IX4 | GP | W16,
        
        DI = IX5 | GP | W16,
        
        SP = IX6 | GP | W16,
        
        BP = IX7 | GP | W16,
        
        R8W = IX8 | GP | W16,
        
        R9W = IX9 | GP | W16,
        
        R10W = IX10 | GP | W16,
        
        R11W = IX11 | GP | W16,
        
        R12W = IX12 | GP | W16,
        
        R13W = IX13 | GP | W16,
        
        R14W = IX14 | GP | W16,
        
        R15W = IX15 | GP | W16,
        
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
        
        RAX = IX0 | GP | W64,
        
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
        
        R11 = IX11 | GP | W64, 
        
        R12 = IX12 | GP | W64, 
        
        R13 = IX13 | GP | W64, 
        
        R14 = IX14 | GP | W64, 
        
        R15 = IX15 | GP | W64, 
                
        XMM0 = IX0 | Vec | W128,
        
        XMM1 = IX1 | Vec | W128,
        
        XMM2 = IX2 | Vec | W128,
        
        XMM3 = IX3 | Vec | W128,
        
        XMM4 = IX4 | Vec | W128,
        
        XMM5 = IX5 | Vec | W128,
        
        XMM6 = IX6 | Vec | W128,
        
        XMM7 = IX7 | Vec | W128,

        XMM8 = IX8 | Vec | W128,
        
        XMM9 = IX9 | Vec | W128,
        
        XMM10 = IX10 | Vec | W128,

        
        XMM11 = IX11 | Vec | W128,
        
        XMM12 = IX12 | Vec | W128,

        XMM13 = IX13 | Vec | W128,
        
        XMM14 = IX14 | Vec | W128,
        
        XMM15 = IX15 | Vec | W128,

        XMM16 = IX16 | Vec | W128,
        
        XMM17 = IX17 | Vec | W128,
        
        XMM18 = IX18 | Vec | W128,
        
        XMM19 = IX19 | Vec | W128,
        
        XMM20 = IX20 | Vec | W128,
        
        XMM21 = IX21 | Vec | W128,
        
        XMM22 = IX22 | Vec | W128,

        XMM23 = IX23 | Vec | W128,

        XMM24 = IX24 | Vec | W128,

        XMM25 = IX25 | Vec | W128,

        XMM26 = IX26 | Vec | W128,

        XMM27 = IX27 | Vec | W128,

        XMM28 = IX28 | Vec | W128,

        XMM29 = IX29 | Vec | W128,

        XMM30 = IX30 | Vec | W128,

        XMM31 = IX31 | Vec | W128,
                    
        YMM0 = IX0 | Vec | W256,
            
        YMM1 = IX1 | Vec | W256,

        YMM2 = IX2 | Vec | W256,

        YMM3 = IX3 | Vec | W256,

        YMM4 = IX4 | Vec | W256,

        YMM5 = IX5 | Vec | W256,

        YMM6 = IX6 | Vec | W256,

        YMM7 = IX7 | Vec | W256,

        YMM8 = IX8 | Vec | W256,

        YMM9 = IX9 | Vec | W256,
        
        YMM10 = IX10 | Vec | W256,
                
        YMM11 = IX11 | Vec | W256,
        
        YMM12 = IX12 | Vec | W256,

        YMM13 = IX13 | Vec | W256,

        YMM14 = IX14 | Vec | W256,

        YMM15 = IX15 | Vec | W256,

        YMM16 = IX16 | Vec | W256,
        
        YMM17 = IX17 | Vec | W256,
        
        YMM18 = IX18 | Vec | W256,

        YMM19 = IX19 | Vec | W256,
        
        YMM20 = IX20 | Vec | W256,
        
        YMM21 = IX21 | Vec | W256,

        YMM22 = IX22 | Vec | W256,

        YMM23 = IX23 | Vec | W256,

        YMM24 = IX24 | Vec | W256,

        YMM25 = IX25 | Vec | W256,

        YMM26 = IX26 | Vec | W256,

        YMM27 = IX27 | Vec | W256,

        YMM28 = IX28 | Vec | W256,

        YMM29 = IX29 | Vec | W256,
        
        YMM30 = IX30 | Vec | W256,

        YMM31 = IX31 | Vec | W256,

        ZMM0 = IX0 | Vec | W512,

        ZMM1 = IX1 | Vec | W512,
        
        ZMM2 = IX2 | Vec | W512,
        
        ZMM3 = IX3 | Vec | W512,

        ZMM4 = IX4 | Vec | W512,
        
        ZMM5 = IX5 | Vec | W512,
        
        ZMM6 = IX6 | Vec | W512,
        
        ZMM7 = IX7 | Vec | W512,

        ZMM8 = IX8 | Vec | W512,

        ZMM9 = IX9 | Vec | W512,

        ZMM10 = IX10 | Vec | W512,
        
        ZMM11 = IX11 | Vec | W512,

        ZMM12 = IX12 | Vec | W512,

        ZMM13 = IX13 | Vec | W512,

        ZMM14 = IX14 | Vec | W512,
        
        ZMM15 = IX15 | Vec | W512,

        ZMM16 = IX16 | Vec | W512,

        ZMM17 = IX17 | Vec | W512,

        ZMM18 = IX18 | Vec | W512,
        
        ZMM19 = IX19 | Vec | W512,
        
        ZMM20 = IX20 | Vec | W512,
        
        ZMM21 = IX21 | Vec | W512,
        
        ZMM22 = IX22 | Vec | W512,
        
        ZMM23 = IX23 | Vec | W512,
        
        ZMM24 = IX24 | Vec | W512,
        
        ZMM25 = IX25 | Vec | W512,
        
        ZMM26 = IX26 | Vec | W512,

        ZMM27 = IX27 | Vec | W512,
        
        ZMM28 = IX28 | Vec | W512,
        
        ZMM29 = IX29 | Vec | W512,
               
        ZMM30 = IX30 | Vec | W512,
        
        ZMM31 = IX31 | Vec | W512,
    }
}