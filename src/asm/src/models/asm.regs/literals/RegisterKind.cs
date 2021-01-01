//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegisterIndex;
    using static RegisterClass;
    using static RegisterWidth;
    using static RegisterBits;

    using SR = SegRegKind;
    using F = FlagRegKind;
    using X = XmmRegKind;
    using Y = YmmRegKind;
    using Z = ZmmRegKind;
    using G8 = Gp8Kind;
    using G16 = Gp16Kind;
    using G32 = Gp32Kind;
    using G64 = Gp64Kind;
    using M = MaskRegKind;

    /// <summary>
    /// [RegisterCode:0..7 | RegisterClass:8..15 | RegisterWidth: 16..31]
    /// </summary>
    public enum RegisterKind : uint
    {
        // ~ FLAGS registers
        // ~ ------------------------------------------------------------------

        FLAGS = F.Flags,

        EFLAGS = F.EFlags,

        RFLAGS = F.RFlags,

        // ~ 16-bit segment registers
        // ~ ------------------------------------------------------------------
        CS = SR.CS,

        DS = SR.DS,

        SS = SR.SS,

        ES = SR.ES,

        FS = SR.FS,

        GS = SR.GS,

        // ~ 8-bit general-purpose registers
        // ~ ------------------------------------------------------------------

        AL = G8.AL,

        CL = G8.CL,

        DL = G8.DL,

        BL = G8.BL,

        SPL = G8.SPL,

        BPL = G8.BPL,

        SIL = G8.SIL,

        DIL  = G8.DIL,

        R8L = G8.R8L,

        R9L = G8.R9L,

        R10L = G8.R10L,

        R11L = G8.R11L,

        R12L = G8.R12L,

        R13L = G8.R13L,

        R14L = G8.R14L,

        R15L = G8.R15L,

        // ~ 16-bit general-purpose registers
        // ~ ------------------------------------------------------------------

        AX = G16.AX,

        CX = G16.CX,

        DX = G16.DX,

        BX = G16.BX,

        SP = G16.SP,

        BP = G16.BP,

        SI = G16.SI,

        DI = G16.DI,

        R8W = G16.R8W,

        R9W = G16.R9W,

        R10W = G16.R10W,

        R11W = G16.R11W,

        R12W = G16.R12W,

        R13W = G16.R13W,

        R14W = G16.R14W,

        R15W = G16.R15W,

        // ~ 32-bit general-purpose registers
        // ~ ------------------------------------------------------------------

        EAX = G32.EAX,

        ECX = G32.ECX,

        EDX = G32.EDX,

        EBX = G32.EBX,

        ESP = G32.ESP,

        EBP = G32.EBP,

        ESI = G32.ESI,

        EDI = G32.EDI,

        R8D = G32.R8D,

        R9D = G32.R9D,

        R10D = G32.R10D,

        R11D = G32.R11D,

        R12D = G32.R12D,

        R13D = G32.R13D,

        R14D = G32.R14D,

        R15D = G32.R15D,

        // ~ 64-bit general-purpose registers
        // ~ ------------------------------------------------------------------

        RAX = G64.RAX,

        RCX = G64.RCX,

        RDX = G64.RDX,

        RBX = G64.RBX,

        RSP = G64.RSP,

        RBP = G64.RBP,

        RSI = G64.RSI,

        RDI = G64.RDI,

        R8Q = G64.R8Q,

        R9Q = G64.R9Q,

        R10Q = G64.R10Q,

        R11Q = G64.R11Q,

        R12Q = G64.R12Q,

        R13Q = G64.R13Q,

        R14Q = G64.R14Q,

        R15Q = G64.R15Q,

        // ~ 128-bit vectorized registers
        // ~ ------------------------------------------------------------------

        XMM0 = X.XMM0,

        XMM1 = X.XMM1,

        XMM2 = X.XMM2,

        XMM3 = X.XMM3,

        XMM4 = X.XMM4,

        XMM5 = X.XMM5,

        XMM6 = X.XMM6,

        XMM7 = X.XMM7,

        XMM8 = X.XMM8,

        XMM9 = X.XMM9,

        XMM10 = X.XMM10,

        XMM11 = X.XMM11,

        XMM12 = X.XMM12,

        XMM13 = X.XMM13,

        XMM14 = X.XMM14,

        XMM15 = X.XMM15,

        XMM16 = X.XMM16,

        XMM17 = X.XMM17,

        XMM18 = X.XMM18,

        XMM19 = X.XMM19,

        XMM20 = X.XMM20,

        XMM21 = X.XMM21,

        XMM22 = X.XMM22,

        XMM23 = X.XMM23,

        XMM24 = X.XMM24,

        XMM25 = X.XMM25,

        XMM26 = X.XMM26,

        XMM27 = r27 | XMM << ClassIndex | W128 << WidthIndex,

        XMM28 = r28 | XMM << ClassIndex | W128 << WidthIndex,

        XMM29 = r29 | XMM << ClassIndex | W128 << WidthIndex,

        XMM30 = r30 | XMM << ClassIndex | W128 << WidthIndex,

        XMM31 = r31 | XMM << ClassIndex | W128 << WidthIndex,

        // ~ 256-bit vectorized registers
        // ~ ------------------------------------------------------------------

        YMM0 = Y.YMM0,

        YMM1 = Y.YMM1,

        YMM2 = Y.YMM2,

        YMM3 = Y.YMM3,

        YMM4 = Y.YMM4,

        YMM5 = Y.YMM5,

        YMM6 = Y.YMM6,

        YMM7 = Y.YMM7,

        YMM8 = Y.YMM8,

        YMM9 = Y.YMM9,

        YMM10 = Y.YMM10,

        YMM11 = r11 | YMM << ClassIndex | W256 << WidthIndex,

        YMM12 = r12 | YMM << ClassIndex | W256 << WidthIndex,

        YMM13 = Y.YMM13,

        YMM14 = Y.YMM14,

        YMM15 = Y.YMM15,

        YMM16 = Y.YMM16,

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

        ZMM0 = Z.ZMM0,

        ZMM1 = Z.ZMM1,

        ZMM2 = Z.ZMM2,

        ZMM3 = Z.ZMM3,

        ZMM4 = Z.ZMM4,

        ZMM5 = Z.ZMM5,

        ZMM6 = Z.ZMM6,

        ZMM7 = Z.ZMM7,

        ZMM8 = Z.ZMM8,

        ZMM9 = Z.ZMM9,

        ZMM10 = Z.ZMM10,

        ZMM11 = Z.ZMM11,

        ZMM12 = Z.ZMM12,

        ZMM13 = r13 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM14 = r14 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM15 = r15 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM16 = RegisterIndex.r16 | ZMM << ClassIndex | W512 << WidthIndex,

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

        // ~ 64-bit mask registers
        // ~ ------------------------------------------------------------------

        K0 = M.K0,

        K1 = M.K1,

        K2 = M.K2,

        K3 = M.K3,

        K4 = M.K4,

        K5 = r5 | Mask << ClassIndex | W64 << WidthIndex,

        K6 = r6 | Mask << ClassIndex | W64 << WidthIndex,

        K7 = r7 | Mask << ClassIndex | W64 << WidthIndex,
    }
}