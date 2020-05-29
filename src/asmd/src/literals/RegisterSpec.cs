//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using static RegisterCode;
    using static RegisterClass;
    using static RegisterWidth;

    public enum RegisterSpec : uint
    {
        AL = r0 | GP << 4 | W8 << 8,

        CL = r1 | GP << 4 | W8 << 8,

        DL = r2 | GP << 4 | W8 << 8,

        BL = r3 | GP << 4 | W8 << 8,

        SPL = r4 | GP << 4 | W8 << 8,

        BPL = r5 | GP << 4 | W8 << 8,

        SIL = r6 | GP << 4 | W8 << 8,

        DIL = r7 | GP << 4 | W8 << 8,

        AX = r0 | GP << 4 | W16 << 8,

        CX = r1 | GP << 4 | W16 << 8,

        DX = r2 | GP << 4 | W16 << 8,

        BX = r3 | GP << 4 | W16 << 8,

        SP = r4 | GP << 4 | W16 << 8,

        BP = r5 | GP << 4 | W16 << 8,

        SI = r6 | GP << 4 | W16 << 8,

        DI = r7 | GP << 4 | W16 << 8,

        EAX = r0 | GP << 4 | W32 << 8,

        ECX = r1 | GP << 4 | W32 << 8,

        EDX = r2 | GP << 4 | W32 << 8,

        EBX = r3 | GP << 4 | W32 << 8,

        ESP = r4 | GP << 4 | W32 << 8,

        EBP = r5 | GP << 4 | W32 << 8,

        ESI = r6 | GP << 4 | W32 << 8,

        EDI = r7 | GP << 4 | W32 << 8,

        RAX = r0 | GP << 4 | W64 << 8,

        RCX = r1 | GP << 4 | W64 << 8,

        RDX = r2 | GP << 4 | W64 << 8,

        RBX = r3 | GP << 4 | W64 << 8,

        RSP = r4 | GP << 4 | W64 << 8,

        RBP = r5 | GP << 4 | W64 << 8,

        RSI = r6 | GP << 4 | W64 << 8,

        RDI = r7 | GP << 4 | W64 << 8,

        R8L = r0 | GPN << 4 | W8 << 8,

        R9L = r1 | GPN << 4 | W8 << 8,

        R10L = r2 | GPN << 4 | W8 << 8,

        R11L = r3 | GPN << 4 | W8 << 8,

        R12L = r4 | GPN << 4 | W8 << 8,

        R13L = r5 | GPN << 4 | W8 << 8,

        R14L = r6 | GPN << 4 | W8 << 8,

        R15L = r7 | GPN << 4 | W8 << 8,

        R8W = r0 | GPN << 4 | W16 << 8,

        R9W = r1 | GPN << 4 | W16 << 8,

        R10W = r2 | GPN << 4 | W16 << 8,

        R11W = r3 | GPN << 4 | W16 << 8,

        R12W = r4 | GPN << 4 | W16 << 8,

        R13W = r5 | GPN << 4 | W16 << 8,

        R14W = r6 | GPN << 4 | W16 << 8,

        R15W = r7 | GPN << 4 | W16 << 8,

        R8D = r0 | GPN << 4 | W32 << 8,

        R9D = r1 | GPN << 4 | W32 << 8,

        R10D = r2 | GPN << 4 | W32 << 8,

        R11D = r3 | GPN << 4 | W32 << 8,

        R12D = r4 | GPN << 4 | W32 << 8,

        R13D = r5 | GPN << 4 | W32 << 8,

        R14D = r6 | GPN << 4 | W32 << 8,

        R15E = r7 | GPN << 4 | W32 << 8,

        R8 = r0 | GPN << 4 | W64 << 8,

        R9 = r1 | GPN << 4 | W64 << 8,

        R10 = r2 | GPN << 4 | W64 << 8,

        R11 = r3 | GPN << 4 | W64 << 8,

        R12 = r4 | GPN << 4 | W64 << 8,

        R13 = r5 | GPN << 4 | W64 << 8,

        R14 = r6 | GPN << 4 | W64 << 8,

        R15 = r7 | GPN << 4 | W64 << 8,

        XMM0 = r0 | XMM << 4 | W128 << 8,

        XMM1 = r1 | XMM << 4 | W128 << 8,

        XMM2 = r2 | XMM << 4 | W128 << 8,

        XMM3 = r3 | XMM << 4 | W128 << 8,

        XMM4 = r4 | XMM << 4 | W128 << 8,

        XMM5 = r5 | XMM << 4 | W128 << 8,

        XMM6 = r6 | XMM << 4 | W128 << 8,

        XMM7 = r7 | XMM << 4 | W128 << 8,
    }
}