//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using static RegisterCode;
    using static RegisterClass;
    using static RegisterWidth;
    using static RegisterBitFields;

    using SRK = SegRegKind;
    using FRK = FlagRegKind;
    using XRK = XmmRegKind;
    using YRK = YmmRegKind;
    using ZRK = ZmmRegKind;
    using G8K = Gp8Kind;
    using G16K = Gp16Kind;
    using G32K = Gp32Kind;
    using G64K = Gp64Kind;

    /// <summary>
    /// [RegisterCode:0..7 | RegisterClass:8..15 | RegisterWidth: 16..31]
    /// </summary>
    public enum RegisterKind : uint
    {
        // ~ FLAGS registers
        // ~ ------------------------------------------------------------------

        FLAGS = FRK.Flags,

        EFLAGS = FRK.EFlags,

        RFLAGS = FRK.RFlags,

        // ~ 16-bit segment registers
        // ~ ------------------------------------------------------------------
        CS = SRK.CS,

        DS = SRK.DS,

        SS = SRK.SS,

        ES = SRK.ES,

        FS = SRK.FS,

        GS = SRK.GS,

        // ~ 8-bit general-purpose registers
        // ~ ------------------------------------------------------------------

        AL = G8K.AL,

        CL = G8K.CL,

        DL = G8K.DL,

        BL = G8K.BL,

        SPL = G8K.SPL,

        BPL = G8K.BPL,

        SIL = G8K.SIL,

        DIL  = G8K.DIL,

        R8L = G8K.R8L,

        R9L = G8K.R9L,

        R10L = G8K.R10L,

        R11L = G8K.R11L,

        R12L = G8K.R12L,

        R13L = G8K.R13L,

        R14L = G8K.R14L,

        R15L = G8K.R15L,

        // ~ 16-bit general-purpose registers
        // ~ ------------------------------------------------------------------

        AX = G16K.AX,

        CX = G16K.CX,

        DX = G16K.DX,

        BX = G16K.BX,

        SP = G16K.SP,

        BP = G16K.BP,

        SI = G16K.SI,

        DI = G16K.DI,

        R8W = r0 | GPN << ClassIndex | W16 << WidthIndex,

        R9W = r1 | GPN << ClassIndex | W16 << WidthIndex,

        R10W = r2 | GPN << ClassIndex | W16 << WidthIndex,

        R11W = r3 | GPN << ClassIndex | W16 << WidthIndex,

        R12W = r4 | GPN << ClassIndex | W16 << WidthIndex,

        R13W = r5 | GPN << ClassIndex | W16 << WidthIndex,

        R14W = r6 | GPN << ClassIndex | W16 << WidthIndex,

        R15W = r7 | GPN << ClassIndex | W16 << WidthIndex,

        // ~ 32-bit general-purpose registers
        // ~ ------------------------------------------------------------------

        EAX = G32K.EAX,

        ECX = G32K.ECX,

        EDX = G32K.EDX,

        EBX = G32K.EBX,

        ESP = G32K.ESP,

        EBP = G32K.EBP,

        ESI = G32K.ESI,

        EDI = G32K.EDI,

        R8D = r0 | GPN << ClassIndex | W32 << WidthIndex,

        R9D = r1 | GPN << ClassIndex | W32 << WidthIndex,

        R10D = r2 | GPN << ClassIndex | W32 << WidthIndex,

        R11D = r3 | GPN << ClassIndex | W32 << WidthIndex,

        R12D = r4 | GPN << ClassIndex | W32 << WidthIndex,

        R13D = r5 | GPN << ClassIndex | W32 << WidthIndex,

        R14D = r6 | GPN << ClassIndex | W32 << WidthIndex,

        R15D = r7 | GPN << ClassIndex | W32 << WidthIndex,

        // ~ 64-bit general-purpose registers
        // ~ ------------------------------------------------------------------

        RAX = G64K.RAX,

        RCX = G64K.RCX,

        RDX = G64K.RDX,

        RBX = G64K.RBX,

        RSP = G64K.RSP,

        RBP = G64K.RBP,

        RSI = G64K.RSI,

        RDI = G64K.RDI,

        R8Q = r0 | GPN << ClassIndex | W64 << WidthIndex,

        R9Q = r1 | GPN << ClassIndex | W64 << WidthIndex,

        R10Q = r2 | GPN << ClassIndex | W64 << WidthIndex,

        R11Q = r3 | GPN << ClassIndex | W64 << WidthIndex,

        R12Q = r4 | GPN << ClassIndex | W64 << WidthIndex,

        R13Q = r5 | GPN << ClassIndex | W64 << WidthIndex,

        R14Q = r6 | GPN << ClassIndex | W64 << WidthIndex,

        R15Q = r7 | GPN << ClassIndex | W64 << WidthIndex,

        // ~ 128-bit vectorized registers
        // ~ ------------------------------------------------------------------

        XMM0 = XRK.XMM0,

        XMM1 = XRK.XMM1,

        XMM2 = XRK.XMM2,

        XMM3 = XRK.XMM3,

        XMM4 = XRK.XMM4,

        XMM5 = XRK.XMM5,

        XMM6 = XRK.XMM6,

        XMM7 = XRK.XMM7,

        XMM8 = XRK.XMM8,

        XMM9 = XRK.XMM9,

        XMM10 = XRK.XMM10,

        XMM11 = XRK.XMM11,

        XMM12 = XRK.XMM12,

        XMM13 = XRK.XMM13,

        XMM14 = XRK.XMM14,

        XMM15 = XRK.XMM15,

        XMM16 = XRK.XMM16,

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

        // ~ 256-bit vectorized registers
        // ~ ------------------------------------------------------------------

        YMM0 = YRK.YMM0,

        YMM1 = YRK.YMM1,

        YMM2 = YRK.YMM2,

        YMM3 = YRK.YMM3,

        YMM4 = YRK.YMM4,

        YMM5 = YRK.YMM5,

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

        // ~ 512-bit vectorized registers
        // ~ ------------------------------------------------------------------
        
        ZMM0 = ZRK.ZMM0,

        ZMM1 = ZRK.ZMM1,

        ZMM2 = ZRK.ZMM2,

        ZMM3 = ZRK.ZMM0,

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