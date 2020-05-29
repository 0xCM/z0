//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using static RegisterCode;
    
    public enum RegisterField
    {
        AL = r0,

        CL = r1,

        DL = r2,

        BL = r3,

        SPL = r4,

        BPL = r5,

        SIL = r6,

        DIL = r7,

        AX = r0,

        CX = r1,

        DX = r2,

        BX = r3,

        SP = r4,

        BP = r5,

        SI = r6,

        DI = r7,

        EAX = r0,

        ECX = r1,

        EDX = r2,

        EBX = r3,

        ESP = r4,

        EBP = r5,

        ESI = r6,

        EDI = r7,

        RAX = r0,

        RCX = r1,

        RDX = r2,

        RBX = r3,

        RSP = r4,

        RBP = r5,

        RSI = r6,

        RDI = r7,

        R8L = r0,

        R9L = r1,

        R10L = r2,

        R11L = r3,

        R12L = r4,

        R13L = r5,

        R14L = r6,

        R15L = r7,

        R8W = r0,

        R9W = r1,

        R10W = r2,

        R11W = r3,

        R12W = r4,

        R13W = r5,

        R14W = r6,

        R15W = r7,

        R8D = r0,

        R9D = r1,

        R10D = r2,

        R11D = r3,

        R12D = r4,

        R13D = r5,

        R14D = r6,

        R15E = r7,

        R8 = r0,

        R9 = r1,

        R10 = r2,

        R11 = r3,

        R12 = r4,

        R13 = r5,

        R14 = r6,

        R15 = r7,

        RAX_CL = RAX << 3 | CL,

        EAX_CL = EAX << 3 | CL,

        EAX_CX = EAX << 3 | CX,

        EAX_ECX = EAX << 3 | ECX
    }
}