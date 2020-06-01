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
    using static RegisterField;

    /// <summary>
    /// [RegisterField:0..7 | RegisterClass:8..15 | RegisterWidth: 16..31]
    /// </summary>
    public enum RegisterKind : uint
    {
        AL = r0 | GP << FK | W8 << FW,

        CL = r1 | GP << FK | W8 << FW,

        DL = r2 | GP << FK | W8 << FW,

        BL = r3 | GP << FK | W8 << FW,

        SPL = r4 | GP << FK | W8 << FW,

        BPL = r5 | GP << FK | W8 << FW,

        SIL = r6 | GP << FK | W8 << FW,

        DIL = r7 | GP << FK | W8 << FW,

        AX = r0 | GP << FK | W16 << FW,

        CX = r1 | GP << FK | W16 << FW,

        DX = r2 | GP << FK | W16 << FW,

        BX = r3 | GP << FK | W16 << FW,

        SP = r4 | GP << FK | W16 << FW,

        BP = r5 | GP << FK | W16 << FW,

        SI = r6 | GP << FK | W16 << FW,

        DI = r7 | GP << FK | W16 << FW,

        EAX = r0 | GP << FK | W32 << FW,

        ECX = r1 | GP << FK | W32 << FW,

        EDX = r2 | GP << FK | W32 << FW,

        EBX = r3 | GP << FK | W32 << FW,

        ESP = r4 | GP << FK | W32 << FW,

        EBP = r5 | GP << FK | W32 << FW,

        ESI = r6 | GP << FK | W32 << FW,

        EDI = r7 | GP << FK | W32 << FW,

        RAX = r0 | GP << FK | W64 << FW,

        RCX = r1 | GP << FK | W64 << FW,

        RDX = r2 | GP << FK | W64 << FW,

        RBX = r3 | GP << FK | W64 << FW,

        RSP = r4 | GP << FK | W64 << FW,

        RBP = r5 | GP << FK | W64 << FW,

        RSI = r6 | GP << FK | W64 << FW,

        RDI = r7 | GP << FK | W64 << FW,

        R8L = r0 | GPN << FK | W8 << FW,

        R9L = r1 | GPN << FK | W8 << FW,

        R10L = r2 | GPN << FK | W8 << FW,

        R11L = r3 | GPN << FK | W8 << FW,

        R12L = r4 | GPN << FK | W8 << FW,

        R13L = r5 | GPN << FK | W8 << FW,

        R14L = r6 | GPN << FK | W8 << FW,

        R15L = r7 | GPN << FK | W8 << FW,

        R8W = r0 | GPN << FK | W16 << FW,

        R9W = r1 | GPN << FK | W16 << FW,

        R10W = r2 | GPN << FK | W16 << FW,

        R11W = r3 | GPN << FK | W16 << FW,

        R12W = r4 | GPN << FK | W16 << FW,

        R13W = r5 | GPN << FK | W16 << FW,

        R14W = r6 | GPN << FK | W16 << FW,

        R15W = r7 | GPN << FK | W16 << FW,

        R8D = r0 | GPN << FK | W32 << FW,

        R9D = r1 | GPN << FK | W32 << FW,

        R10D = r2 | GPN << FK | W32 << FW,

        R11D = r3 | GPN << FK | W32 << FW,

        R12D = r4 | GPN << FK | W32 << FW,

        R13D = r5 | GPN << FK | W32 << FW,

        R14D = r6 | GPN << FK | W32 << FW,

        R15D = r7 | GPN << FK | W32 << FW,

        R8 = r0 | GPN << FK | W64 << FW,

        R9 = r1 | GPN << FK | W64 << FW,

        R10 = r2 | GPN << FK | W64 << FW,

        R11 = r3 | GPN << FK | W64 << FW,

        R12 = r4 | GPN << FK | W64 << FW,

        R13 = r5 | GPN << FK | W64 << FW,

        R14 = r6 | GPN << FK | W64 << FW,

        R15 = r7 | GPN << FK | W64 << FW,

        XMM0 = r0 | XMM << FK | W128 << FW,

        XMM1 = r1 | XMM << FK | W128 << FW,

        XMM2 = r2 | XMM << FK | W128 << FW,

        XMM3 = r3 | XMM << FK | W128 << FW,

        XMM4 = r4 | XMM << FK | W128 << FW,

        XMM5 = r5 | XMM << FK | W128 << FW,

        XMM6 = r6 | XMM << FK | W128 << FW,

        XMM7 = r7 | XMM << FK | W128 << FW,

        XMM8 = r8 | XMM << FK | W128 << FW,

        XMM9 = r9 | XMM << FK | W128 << FW,

        XMM10 = r10 | XMM << FK | W128 << FW,

        XMM11 = r11 | XMM << FK | W128 << FW,

        XMM12 = r12 | XMM << FK | W128 << FW,

        XMM13 = r13 | XMM << FK | W128 << FW,

        XMM14 = r14 | XMM << FK | W128 << FW,

        XMM15 = r15 | XMM << FK | W128 << FW,

        XMM16 = r16 | XMM << FK | W128 << FW,

        XMM17 = r17 | XMM << FK | W128 << FW,

        XMM18 = r18 | XMM << FK | W128 << FW,

        XMM19 = r19 | XMM << FK | W128 << FW,

        XMM20 = r20 | XMM << FK | W128 << FW,

        XMM21 = r21 | XMM << FK | W128 << FW,

        XMM22 = r22 | XMM << FK | W128 << FW,

        XMM23 = r23 | XMM << FK | W128 << FW,

        XMM24 = r24 | XMM << FK | W128 << FW,

        XMM25 = r25 | XMM << FK | W128 << FW,

        XMM26 = r26 | XMM << FK | W128 << FW,

        XMM27 = r27 | XMM << FK | W128 << FW,

        XMM28 = r28 | XMM << FK | W128 << FW,

        XMM29 = r29 | XMM << FK | W128 << FW,

        XMM30 = r30 | XMM << FK | W128 << FW,

        XMM31 = r31 | XMM << FK | W128 << FW,

        YMM0 = r0 | YMM << FK | W256 << FW,

        YMM1 = r1 | YMM << FK | W256 << FW,

        YMM2 = r2 | YMM << FK | W256 << FW,

        YMM3 = r3 | YMM << FK | W256 << FW,

        YMM4 = r4 | YMM << FK | W256 << FW,

        YMM5 = r5 | YMM << FK | W256 << FW,

        YMM6 = r6 | YMM << FK | W256 << FW,

        YMM7 = r7 | YMM << FK | W256 << FW,

        YMM8 = r8 | YMM << FK | W256 << FW,

        YMM9 = r9 | YMM << FK | W256 << FW,

        YMM10 = r10 | YMM << FK | W256 << FW,

        YMM11 = r11 | YMM << FK | W256 << FW,

        YMM12 = r12 | YMM << FK | W256 << FW,

        YMM13 = r13 | YMM << FK | W256 << FW,

        YMM14 = r14 | YMM << FK | W256 << FW,

        YMM15 = r15 | YMM << FK | W256 << FW,

        YMM16 = r16 | YMM << FK | W256 << FW,

        YMM17 = r17 | YMM << FK | W256 << FW,

        YMM18 = r18 | YMM << FK | W256 << FW,

        YMM19 = r19 | YMM << FK | W256 << FW,

        YMM20 = r20 | YMM << FK | W256 << FW,

        YMM21 = r21 | YMM << FK | W256 << FW,

        YMM22 = r22 | YMM << FK | W256 << FW,

        YMM23 = r23 | YMM << FK | W256 << FW,

        YMM24 = r24 | YMM << FK | W256 << FW,

        YMM25 = r25 | YMM << FK | W256 << FW,

        YMM26 = r26 | YMM << FK | W256 << FW,

        YMM27 = r27 | YMM << FK | W256 << FW,

        YMM28 = r28 | YMM << FK | W256 << FW,

        YMM29 = r29 | YMM << FK | W256 << FW,

        YMM30 = r30 | YMM << FK | W256 << FW,

        YMM31 = r31 | YMM << FK | W256 << FW,

        ZMM0 = r0 | ZMM << FK | W512 << FW,

        ZMM1 = r1 | ZMM << FK | W512 << FW,

        ZMM2 = r2 | ZMM << FK | W512 << FW,

        ZMM3 = r3 | ZMM << FK | W512 << FW,

        ZMM4 = r4 | ZMM << FK | W512 << FW,

        ZMM5 = r5 | ZMM << FK | W512 << FW,

        ZMM6 = r6 | ZMM << FK | W512 << FW,

        ZMM7 = r7 | ZMM << FK | W512 << FW,

        ZMM8 = r8 | ZMM << FK | W512 << FW,

        ZMM9 = r9 | ZMM << FK | W512 << FW,

        ZMM10 = r10 | ZMM << FK | W512 << FW,

        ZMM11 = r11 | ZMM << FK | W512 << FW,

        ZMM12 = r12 | ZMM << FK | W512 << FW,

        ZMM13 = r13 | ZMM << FK | W512 << FW,

        ZMM14 = r14 | ZMM << FK | W512 << FW,

        ZMM15 = r15 | ZMM << FK | W512 << FW,

        ZMM16 = r16 | ZMM << FK | W512 << FW,

        ZMM17 = r17 | ZMM << FK | W512 << FW,

        ZMM18 = r18 | ZMM << FK | W512 << FW,

        ZMM19 = r19 | ZMM << FK | W512 << FW,

        ZMM20 = r20 | ZMM << FK | W512 << FW,

        ZMM21 = r21 | ZMM << FK | W512 << FW,

        ZMM22 = r22 | ZMM << FK | W512 << FW,

        ZMM23 = r23 | ZMM << FK | W512 << FW,

        ZMM24 = r24 | ZMM << FK | W512 << FW,

        ZMM25 = r25 | ZMM << FK | W512 << FW,

        ZMM26 = r26 | ZMM << FK | W512 << FW,

        ZMM27 = r27 | ZMM << FK | W512 << FW,

        ZMM28 = r28 | ZMM << FK | W512 << FW,

        ZMM29 = r29 | ZMM << FK | W512 << FW,

        ZMM30 = r30 | ZMM << FK | W512 << FW,

        ZMM31 = r31 | ZMM << FK | W512 << FW,
    }
}