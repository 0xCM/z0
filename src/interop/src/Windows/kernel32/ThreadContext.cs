namespace Windows
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Size=2, Pack=0)]
    public struct WORD
    {

    }

    [StructLayout(LayoutKind.Sequential, Size=1, Pack=0)]
    public struct BYTE
    {

    }

    [StructLayout(LayoutKind.Sequential, Size=4, Pack=0)]
    public struct DWORD
    {

    }

    [StructLayout(LayoutKind.Sequential, Size=8, Pack=0)]
    public struct DWORD64
    {

    }

    [StructLayout(LayoutKind.Sequential, Size=16, Pack=16)]
    public struct M128A
    {


    }


    [StructLayout(LayoutKind.Sequential, Pack=16)]
    public struct Fp128x8Regs
    {
        public M128A Xmm0;

        public M128A Xmm1;

        public M128A Xmm2;

        public M128A Xmm3;

        public M128A Xmm4;

        public M128A Xmm5;

        public M128A Xmm6;

        public M128A Xmm7;
    }


    [StructLayout(LayoutKind.Sequential, Pack=16)]
    public struct Xmm16x16Regs
    {
        public M128A Xmm0;

        public M128A Xmm1;

        public M128A Xmm2;

        public M128A Xmm3;

        public M128A Xmm4;

        public M128A Xmm5;

        public M128A Xmm6;

        public M128A Xmm7;

        public M128A Xmm8;

        public M128A Xmm9;

        public M128A Xmm10;

        public M128A Xmm11;

        public M128A Xmm12;

        public M128A Xmm13;

        public M128A Xmm14;

        public M128A Xmm15;
    }


    [StructLayout(LayoutKind.Sequential, Pack=16)]
    public struct Xmm16x26Regs
    {
        public M128A Xmm0;

        public M128A Xmm1;

        public M128A Xmm2;

        public M128A Xmm3;

        public M128A Xmm4;

        public M128A Xmm5;

        public M128A Xmm6;

        public M128A Xmm7;

        public M128A Xmm8;

        public M128A Xmm9;

        public M128A Xmm10;

        public M128A Xmm11;

        public M128A Xmm12;

        public M128A Xmm13;

        public M128A Xmm14;

        public M128A Xmm15;

        public M128A Xmm16;

        public M128A Xmm17;

        public M128A Xmm18;

        public M128A Xmm19;

        public M128A Xmm20;

        public M128A Xmm21;

        public M128A Xmm22;

        public M128A Xmm23;

        public M128A Xmm24;

        public M128A Xmm25;

        public M128A Xmm26;
    }


    [StructLayout(LayoutKind.Sequential, Pack=16)]
    public struct XMM_SAVE_AREA32
    {
        public WORD ControlWord;

        public WORD StatusWord;

        public BYTE TagWord;

        public BYTE Reserved1;

        public WORD ErrorOpcode;

        public DWORD ErrorOffset;

        public WORD ErrorSelector;

        public WORD Reserved2;

        public DWORD DataOffset;

        public WORD DataSelector;

        public WORD Reserved3;

        public DWORD MxCsr;

        public DWORD MxCsr_Mask;

        public Fp128x8Regs Fp;

        public Xmm16x16Regs Xmm;

        public RESERVE_96 Reserved4;

        [StructLayout(LayoutKind.Sequential, Size=96)]
        public struct RESERVE_96
        {

        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=16)]
    public struct ThreadContext
    {
        public DWORD64 P1Home;

        public DWORD64 P2Home;

        public DWORD64 P3Home;

        public DWORD64 P4Home;

        public DWORD64 P5Home;

        public DWORD64 P6Home;

        public ContextFlags ContextFlags;

        public DWORD MxCsr;

        public WORD SegCs;

        public WORD SegDs;

        public WORD SegEs;

        public WORD SegFs;

        public WORD SegGs;

        public WORD SegSs;

        public DWORD EFlags;

        public DWORD64 Dr0;

        public DWORD64 Dr1;

        public DWORD64 Dr2;

        public DWORD64 Dr3;

        public DWORD64 Dr6;

        public DWORD64 Dr7;

        public DWORD64 Rax;

        public DWORD64 Rcx;

        public DWORD64 Rdx;

        public DWORD64 Rbx;

        public DWORD64 Rsp;

        public DWORD64 Rbp;

        public DWORD64 Rsi;

        public DWORD64 Rdi;

        public DWORD64 R8;

        public DWORD64 R9;

        public DWORD64 R10;

        public DWORD64 R11;

        public DWORD64 R12;

        public DWORD64 R13;

        public DWORD64 R14;

        public DWORD64 R15;

        public DWORD64 Rip;

        public XMM_SAVE_AREA32 FpReg;

        public Xmm16x26Regs VectorRegisters;

        public DWORD64 VectorControl;

        public DWORD64 DebugControl;

        public DWORD64 LastBranchToRip;

        public DWORD64 LastBranchFromRip;

        public DWORD64 LastExceptionToRip;

        public DWORD64 LastExceptionFromRip;
    }

    public enum ContextFlags : uint
    {
        CONTEXT_AMD64 = 0x00100000,

        CONTEXT_CONTROL = CONTEXT_AMD64 | 0x00000001,

        CONTEXT_INTEGER = CONTEXT_AMD64 | 0x00000002,

        CONTEXT_SEGMENTS = CONTEXT_AMD64 | 0x00000004,

        CONTEXT_FLOATING_POINT = CONTEXT_AMD64 | 0x00000008,

        CONTEXT_DEBUG_REGISTERS = CONTEXT_AMD64 | 0x00000010,

        CONTEXT_FULL = CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_FLOATING_POINT,

        CONTEXT_ALL = CONTEXT_CONTROL | CONTEXT_INTEGER |CONTEXT_SEGMENTS | CONTEXT_FLOATING_POINT | CONTEXT_DEBUG_REGISTERS,

        CONTEXT_XSTATE = CONTEXT_AMD64 | 0x00000040,
    }
}