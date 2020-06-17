//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using static RegisterCode;
    using static RegisterClass;
    using static RegisterWidth;
    using static RegisterFieldSpecs;

    /// <summary>
    /// [RegisterCode:0..7 | RegisterClass:8..15 | RegisterWidth: 16..31]
    /// </summary>
    public enum RegisterKind : uint
    {
        AL = r0 | GP << ClassIndex | W8 << WidthIndex,

        CL = r1 | GP << ClassIndex | W8 << WidthIndex,

        DL = r2 | GP << ClassIndex | W8 << WidthIndex,

        BL = r3 | GP << ClassIndex | W8 << WidthIndex,

        SPL = r4 | GP << ClassIndex | W8 << WidthIndex,

        BPL = r5 | GP << ClassIndex | W8 << WidthIndex,

        SIL = r6 | GP << ClassIndex | W8 << WidthIndex,

        DIL = r7 | GP << ClassIndex | W8 << WidthIndex,

        AX = r0 | GP << ClassIndex | W16 << WidthIndex,

        CX = r1 | GP << ClassIndex | W16 << WidthIndex,

        DX = r2 | GP << ClassIndex | W16 << WidthIndex,

        BX = r3 | GP << ClassIndex | W16 << WidthIndex,

        SP = r4 | GP << ClassIndex | W16 << WidthIndex,

        BP = r5 | GP << ClassIndex | W16 << WidthIndex,

        SI = r6 | GP << ClassIndex | W16 << WidthIndex,

        DI = r7 | GP << ClassIndex | W16 << WidthIndex,

        EAX = r0 | GP << ClassIndex | W32 << WidthIndex,

        ECX = r1 | GP << ClassIndex | W32 << WidthIndex,

        EDX = r2 | GP << ClassIndex | W32 << WidthIndex,

        EBX = r3 | GP << ClassIndex | W32 << WidthIndex,

        ESP = r4 | GP << ClassIndex | W32 << WidthIndex,

        EBP = r5 | GP << ClassIndex | W32 << WidthIndex,

        ESI = r6 | GP << ClassIndex | W32 << WidthIndex,

        EDI = r7 | GP << ClassIndex | W32 << WidthIndex,

        RAX = r0 | GP << ClassIndex | W64 << WidthIndex,

        RCX = r1 | GP << ClassIndex | W64 << WidthIndex,

        RDX = r2 | GP << ClassIndex | W64 << WidthIndex,

        RBX = r3 | GP << ClassIndex | W64 << WidthIndex,

        RSP = r4 | GP << ClassIndex | W64 << WidthIndex,

        RBP = r5 | GP << ClassIndex | W64 << WidthIndex,

        RSI = r6 | GP << ClassIndex | W64 << WidthIndex,

        RDI = r7 | GP << ClassIndex | W64 << WidthIndex,

        R8L = r0 | GPN << ClassIndex | W8 << WidthIndex,

        R9L = r1 | GPN << ClassIndex | W8 << WidthIndex,

        R10L = r2 | GPN << ClassIndex | W8 << WidthIndex,

        R11L = r3 | GPN << ClassIndex | W8 << WidthIndex,

        R12L = r4 | GPN << ClassIndex | W8 << WidthIndex,

        R13L = r5 | GPN << ClassIndex | W8 << WidthIndex,

        R14L = r6 | GPN << ClassIndex | W8 << WidthIndex,

        R15L = r7 | GPN << ClassIndex | W8 << WidthIndex,

        R8W = r0 | GPN << ClassIndex | W16 << WidthIndex,

        R9W = r1 | GPN << ClassIndex | W16 << WidthIndex,

        R10W = r2 | GPN << ClassIndex | W16 << WidthIndex,

        R11W = r3 | GPN << ClassIndex | W16 << WidthIndex,

        R12W = r4 | GPN << ClassIndex | W16 << WidthIndex,

        R13W = r5 | GPN << ClassIndex | W16 << WidthIndex,

        R14W = r6 | GPN << ClassIndex | W16 << WidthIndex,

        R15W = r7 | GPN << ClassIndex | W16 << WidthIndex,

        R8D = r0 | GPN << ClassIndex | W32 << WidthIndex,

        R9D = r1 | GPN << ClassIndex | W32 << WidthIndex,

        R10D = r2 | GPN << ClassIndex | W32 << WidthIndex,

        R11D = r3 | GPN << ClassIndex | W32 << WidthIndex,

        R12D = r4 | GPN << ClassIndex | W32 << WidthIndex,

        R13D = r5 | GPN << ClassIndex | W32 << WidthIndex,

        R14D = r6 | GPN << ClassIndex | W32 << WidthIndex,

        R15D = r7 | GPN << ClassIndex | W32 << WidthIndex,

        R8q = r0 | GPN << ClassIndex | W64 << WidthIndex,

        R9q = r1 | GPN << ClassIndex | W64 << WidthIndex,

        R10q = r2 | GPN << ClassIndex | W64 << WidthIndex,

        R11q = r3 | GPN << ClassIndex | W64 << WidthIndex,

        R12q = r4 | GPN << ClassIndex | W64 << WidthIndex,

        R13q = r5 | GPN << ClassIndex | W64 << WidthIndex,

        R14q = r6 | GPN << ClassIndex | W64 << WidthIndex,

        R15q = r7 | GPN << ClassIndex | W64 << WidthIndex,

        XMM0 = r0 | XMM << ClassIndex | W128 << WidthIndex,

        XMM1 = r1 | XMM << ClassIndex | W128 << WidthIndex,

        XMM2 = r2 | XMM << ClassIndex | W128 << WidthIndex,

        XMM3 = r3 | XMM << ClassIndex | W128 << WidthIndex,

        XMM4 = r4 | XMM << ClassIndex | W128 << WidthIndex,

        XMM5 = r5 | XMM << ClassIndex | W128 << WidthIndex,

        XMM6 = r6 | XMM << ClassIndex | W128 << WidthIndex,

        XMM7 = r7 | XMM << ClassIndex | W128 << WidthIndex,

        XMM8 = RegisterCode.r8 | XMM << ClassIndex | W128 << WidthIndex,

        XMM9 = r9 | XMM << ClassIndex | W128 << WidthIndex,

        XMM10 = r10 | XMM << ClassIndex | W128 << WidthIndex,

        XMM11 = r11 | XMM << ClassIndex | W128 << WidthIndex,

        XMM12 = r12 | XMM << ClassIndex | W128 << WidthIndex,

        XMM13 = r13 | XMM << ClassIndex | W128 << WidthIndex,

        XMM14 = r14 | XMM << ClassIndex | W128 << WidthIndex,

        XMM15 = r15 | XMM << ClassIndex | W128 << WidthIndex,

        XMM16 = RegisterCode.r16 | XMM << ClassIndex | W128 << WidthIndex,

        XMM17 = r17 | XMM << ClassIndex | W128 << WidthIndex,

        XMM18 = r18 | XMM << ClassIndex | W128 << WidthIndex,

        XMM19 = r19 | XMM << ClassIndex | W128 << WidthIndex,

        XMM20 = r20 | XMM << ClassIndex | W128 << WidthIndex,

        XMM21 = r21 | XMM << ClassIndex | W128 << WidthIndex,

        XMM22 = r22 | XMM << ClassIndex | W128 << WidthIndex,

        XMM23 = r23 | XMM << ClassIndex | W128 << WidthIndex,

        XMM24 = r24 | XMM << ClassIndex | W128 << WidthIndex,

        XMM25 = r25 | XMM << ClassIndex | W128 << WidthIndex,

        XMM26 = r26 | XMM << ClassIndex | W128 << WidthIndex,

        XMM27 = r27 | XMM << ClassIndex | W128 << WidthIndex,

        XMM28 = r28 | XMM << ClassIndex | W128 << WidthIndex,

        XMM29 = r29 | XMM << ClassIndex | W128 << WidthIndex,

        XMM30 = r30 | XMM << ClassIndex | W128 << WidthIndex,

        XMM31 = r31 | XMM << ClassIndex | W128 << WidthIndex,

        YMM0 = r0 | YMM << ClassIndex | W256 << WidthIndex,

        YMM1 = r1 | YMM << ClassIndex | W256 << WidthIndex,

        YMM2 = r2 | YMM << ClassIndex | W256 << WidthIndex,

        YMM3 = r3 | YMM << ClassIndex | W256 << WidthIndex,

        YMM4 = r4 | YMM << ClassIndex | W256 << WidthIndex,

        YMM5 = r5 | YMM << ClassIndex | W256 << WidthIndex,

        YMM6 = r6 | YMM << ClassIndex | W256 << WidthIndex,

        YMM7 = r7 | YMM << ClassIndex | W256 << WidthIndex,

        YMM8 = RegisterCode.r8 | YMM << ClassIndex | W256 << WidthIndex,

        YMM9 = r9 | YMM << ClassIndex | W256 << WidthIndex,

        YMM10 = r10 | YMM << ClassIndex | W256 << WidthIndex,

        YMM11 = r11 | YMM << ClassIndex | W256 << WidthIndex,

        YMM12 = r12 | YMM << ClassIndex | W256 << WidthIndex,

        YMM13 = r13 | YMM << ClassIndex | W256 << WidthIndex,

        YMM14 = r14 | YMM << ClassIndex | W256 << WidthIndex,

        YMM15 = r15 | YMM << ClassIndex | W256 << WidthIndex,

        YMM16 = RegisterCode.r16 | YMM << ClassIndex | W256 << WidthIndex,

        YMM17 = r17 | YMM << ClassIndex | W256 << WidthIndex,

        YMM18 = r18 | YMM << ClassIndex | W256 << WidthIndex,

        YMM19 = r19 | YMM << ClassIndex | W256 << WidthIndex,

        YMM20 = r20 | YMM << ClassIndex | W256 << WidthIndex,

        YMM21 = r21 | YMM << ClassIndex | W256 << WidthIndex,

        YMM22 = r22 | YMM << ClassIndex | W256 << WidthIndex,

        YMM23 = r23 | YMM << ClassIndex | W256 << WidthIndex,

        YMM24 = r24 | YMM << ClassIndex | W256 << WidthIndex,

        YMM25 = r25 | YMM << ClassIndex | W256 << WidthIndex,

        YMM26 = r26 | YMM << ClassIndex | W256 << WidthIndex,

        YMM27 = r27 | YMM << ClassIndex | W256 << WidthIndex,

        YMM28 = r28 | YMM << ClassIndex | W256 << WidthIndex,

        YMM29 = r29 | YMM << ClassIndex | W256 << WidthIndex,

        YMM30 = r30 | YMM << ClassIndex | W256 << WidthIndex,

        YMM31 = r31 | YMM << ClassIndex | W256 << WidthIndex,

        ZMM0 = r0 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM1 = r1 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM2 = r2 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM3 = r3 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM4 = r4 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM5 = r5 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM6 = r6 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM7 = r7 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM8 = RegisterCode.r8 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM9 = r9 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM10 = r10 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM11 = r11 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM12 = r12 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM13 = r13 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM14 = r14 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM15 = r15 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM16 = RegisterCode.r16 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM17 = r17 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM18 = r18 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM19 = r19 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM20 = r20 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM21 = r21 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM22 = r22 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM23 = r23 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM24 = r24 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM25 = r25 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM26 = r26 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM27 = r27 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM28 = r28 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM29 = r29 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM30 = r30 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM31 = r31 | ZMM << ClassIndex | W512 << WidthIndex,
    }
}