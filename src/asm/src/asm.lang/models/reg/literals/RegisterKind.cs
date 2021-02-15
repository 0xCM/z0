//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;
    using static RegClass;
    using static RegWidth;
    using static AsmRegBits;

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
    using C = ControlRegKind;
    using D = DebugRegKind;
    using I = IpRegKind;

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

        AH = G8.AH,

        CL = G8.CL,

        CH = G8.CH,

        DL = G8.DL,

        DH = G8.DH,

        BL = G8.BL,

        BH = G8.BH,

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

        XMM27 = r27 | XMM << ClassField | W128 << WidthField,

        XMM28 = r28 | XMM << ClassField | W128 << WidthField,

        XMM29 = r29 | XMM << ClassField | W128 << WidthField,

        XMM30 = r30 | XMM << ClassField | W128 << WidthField,

        XMM31 = r31 | XMM << ClassField | W128 << WidthField,

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

        YMM11 = r11 | YMM << ClassField | W256 << WidthField,

        YMM12 = r12 | YMM << ClassField | W256 << WidthField,

        YMM13 = Y.YMM13,

        YMM14 = Y.YMM14,

        YMM15 = Y.YMM15,

        YMM16 = Y.YMM16,

        YMM17 = r17 | YMM << ClassField | W256 << WidthField,

        YMM18 = r18 | YMM << ClassField | W256 << WidthField,

        YMM19 = r19 | YMM << ClassField | W256 << WidthField,

        YMM20 = r20 | YMM << ClassField | W256 << WidthField,

        YMM21 = r21 | YMM << ClassField | W256 << WidthField,

        YMM22 = r22 | YMM << ClassField | W256 << WidthField,

        YMM23 = r23 | YMM << ClassField | W256 << WidthField,

        YMM24 = r24 | YMM << ClassField | W256 << WidthField,

        YMM25 = r25 | YMM << ClassField | W256 << WidthField,

        YMM26 = r26 | YMM << ClassField | W256 << WidthField,

        YMM27 = r27 | YMM << ClassField | W256 << WidthField,

        YMM28 = r28 | YMM << ClassField | W256 << WidthField,

        YMM29 = r29 | YMM << ClassField | W256 << WidthField,

        YMM30 = r30 | YMM << ClassField | W256 << WidthField,

        YMM31 = r31 | YMM << ClassField | W256 << WidthField,

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

        ZMM13 = r13 | ZMM << ClassField | W512 << WidthField,

        ZMM14 = r14 | ZMM << ClassField | W512 << WidthField,

        ZMM15 = r15 | ZMM << ClassField | W512 << WidthField,

        ZMM16 = RegIndex.r16 | ZMM << ClassField | W512 << WidthField,

        ZMM17 = r17 | ZMM << ClassField | W512 << WidthField,

        ZMM18 = r18 | ZMM << ClassField | W512 << WidthField,

        ZMM19 = r19 | ZMM << ClassField | W512 << WidthField,

        ZMM20 = r20 | ZMM << ClassField | W512 << WidthField,

        ZMM21 = r21 | ZMM << ClassField | W512 << WidthField,

        ZMM22 = r22 | ZMM << ClassField | W512 << WidthField,

        ZMM23 = r23 | ZMM << ClassField | W512 << WidthField,

        ZMM24 = r24 | ZMM << ClassField | W512 << WidthField,

        ZMM25 = r25 | ZMM << ClassField | W512 << WidthField,

        ZMM26 = r26 | ZMM << ClassField | W512 << WidthField,

        ZMM27 = r27 | ZMM << ClassField | W512 << WidthField,

        ZMM28 = r28 | ZMM << ClassField | W512 << WidthField,

        ZMM29 = r29 | ZMM << ClassField | W512 << WidthField,

        ZMM30 = r30 | ZMM << ClassField | W512 << WidthField,

        ZMM31 = r31 | ZMM << ClassField | W512 << WidthField,

        // ~ 64-bit mask registers
        // ~ ------------------------------------------------------------------

        K0 = M.K0,

        K1 = M.K1,

        K2 = M.K2,

        K3 = M.K3,

        K4 = M.K4,

        K5 = M.K5,

        K6 = M.K6,

        K7 = M.K7,

        // ~ Control registers
        // ~ ------------------------------------------------------------------

        CR0 = C.CR0,

        CR2 = C.CR2,

        CR3 = C.CR3,

        CR4 = C.CR4,

        CR8 = C.CR8,

        // ~ Debug registers
        // ~ ------------------------------------------------------------------

        DR0 = D.DR0,

        DR1 = D.DR1,

        DR2 = D.DR2,

        DR3 = D.DR3,

        DR6 = D.DR6,

        DR7 = D.DR7,

        // ~ Intruction pointer registers
        // ~ ------------------------------------------------------------------

        IP = I.IP,

        EIP = I.EIP,

        RIP = I.RIP,
    }
}