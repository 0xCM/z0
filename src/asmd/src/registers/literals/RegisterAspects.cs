//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore; 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using static RegisterAspect;
    
    /// <summary>
    /// Defines register characteristics
    /// </summary>
    /// <remarks>
    /// References:
    /// https://cs.brown.edu/courses/cs033/docs/guides/x64_cheatsheet.pdf
    /// https://en.wikipedia.org/wiki/X86_calling_conventions
    /// </remarks>
    public readonly struct RegisterAspects
    {
        // ~ 8-bit registers
        // ~ ------------------------------------------------------------------
        
        public const RegisterAspect AL = default;

        public const RegisterAspect CL = default;

        public const RegisterAspect DL = default;

        public const RegisterAspect BL = default;

        public const RegisterAspect SPL = default;

        public const RegisterAspect BPL = default;

        public const RegisterAspect SIL = default;

        public const RegisterAspect DIL = default;

        public const RegisterAspect R8L = default;

        public const RegisterAspect R9L = default;

        public const RegisterAspect R10L = default;

        public const RegisterAspect R11L = default;

        public const RegisterAspect R12L = default;

        public const RegisterAspect R13L = default;

        public const RegisterAspect R14L = default;

        public const RegisterAspect R15L = default;

        // ~ 16-bit registers
        // ~ ------------------------------------------------------------------

        public const RegisterAspect AX = default;

        public const RegisterAspect CX = default;

        public const RegisterAspect DX = default;

        public const RegisterAspect BX = default;

        public const RegisterAspect SP = default;

        public const RegisterAspect BP = default;

        public const RegisterAspect SI = default;

        public const RegisterAspect DI = default;

        public const RegisterAspect R8W = default;

        public const RegisterAspect R9W = default;

        public const RegisterAspect R10W = default;

        public const RegisterAspect R11W = default;

        public const RegisterAspect R12W = default;

        public const RegisterAspect R13W = default;

        public const RegisterAspect R14W = default;

        public const RegisterAspect R15W = default;

        // ~ 32-bit registers
        // ~ ------------------------------------------------------------------

        public const RegisterAspect EAX = default;

        public const RegisterAspect ECX = default;

        public const RegisterAspect EDX = default;

        public const RegisterAspect EBX = default;

        public const RegisterAspect ESP = default;

        public const RegisterAspect EBP = default;

        public const RegisterAspect ESI = default;

        public const RegisterAspect EDI = default;

        public const RegisterAspect R8D = default;

        public const RegisterAspect R9D = default;

        public const RegisterAspect R10D = default;

        public const RegisterAspect R11D = default;

        public const RegisterAspect R12D = default;

        public const RegisterAspect R13D = default;

        public const RegisterAspect R14D = default;

        public const RegisterAspect R15D = default;

        // ~ 64-bit registers
        // ~ ------------------------------------------------------------------

        //  %rdi, %rsi, %rdx, %rcx, %r8, and %r9
        public const RegisterAspect RAX = Volatile | ReturnStore;

        public const RegisterAspect RCX = Volatile | ArgStore;

        public const RegisterAspect RDX = Volatile | ArgStore;

        public const RegisterAspect RBX = Persistent;

        public const RegisterAspect RSP = Volatile | StackPointer;

        public const RegisterAspect RBP = Persistent;

        public const RegisterAspect RSI = Volatile | ArgStore;

        public const RegisterAspect RDI = Volatile | ArgStore;

        public const RegisterAspect R8Q = Volatile | ArgStore;

        public const RegisterAspect R9Q = Volatile | ArgStore;

        public const RegisterAspect R10Q = Volatile;

        public const RegisterAspect R11Q = Volatile;

        public const RegisterAspect R12Q = Persistent;

        public const RegisterAspect R13Q = Persistent;

        public const RegisterAspect R14Q = Persistent;

        public const RegisterAspect R15Q = Persistent;

        public const RegisterAspect XMM0 = default;

        public const RegisterAspect XMM1 = default;

        public const RegisterAspect XMM2 = default;

        public const RegisterAspect XMM3 = default;

        public const RegisterAspect XMM4 = default;

        public const RegisterAspect XMM5 = default;

        public const RegisterAspect XMM6 = default;

        public const RegisterAspect XMM7 = default;

        public const RegisterAspect XMM8 = default;

        public const RegisterAspect XMM9 = default;

        public const RegisterAspect XMM10 = default;

        public const RegisterAspect XMM11 = default;

        public const RegisterAspect XMM12 = default;

        public const RegisterAspect XMM13 = default;

        public const RegisterAspect XMM14 = default;

        public const RegisterAspect XMM15 = default;

        public const RegisterAspect XMM16 = default;

        public const RegisterAspect XMM17 = default;

        public const RegisterAspect XMM18 = default;

        public const RegisterAspect XMM19 = default;

        public const RegisterAspect XMM20 = default;

        public const RegisterAspect XMM21 = default;

        public const RegisterAspect XMM22 = default;

        public const RegisterAspect XMM23 = default;

        public const RegisterAspect XMM24 = default;

        public const RegisterAspect XMM25 = default;

        public const RegisterAspect XMM26 = default;

        public const RegisterAspect XMM27 = default;

        public const RegisterAspect XMM28 = default;

        public const RegisterAspect XMM29 = default;

        public const RegisterAspect XMM30 = default;

        public const RegisterAspect XMM31 = default;

        public const RegisterAspect YMM0 = default;

        public const RegisterAspect YMM1 = default;

        public const RegisterAspect YMM2 = default;

        public const RegisterAspect YMM3 = default;

        public const RegisterAspect YMM4 = default;

        public const RegisterAspect YMM5 = default;

        public const RegisterAspect YMM6 = default;

        public const RegisterAspect YMM7 = default;

        public const RegisterAspect YMM8 = default;

        public const RegisterAspect YMM9 = default;

        public const RegisterAspect YMM10 = default;

        public const RegisterAspect YMM11 = default;

        public const RegisterAspect YMM12 = default;

        public const RegisterAspect YMM13 = default;

        public const RegisterAspect YMM14 = default;

        public const RegisterAspect YMM15 = default;

        public const RegisterAspect YMM16 = default;

        public const RegisterAspect YMM17 = default;

        public const RegisterAspect YMM18 = default;

        public const RegisterAspect YMM19 = default;

        public const RegisterAspect YMM20 = default;

        public const RegisterAspect YMM21 = default;

        public const RegisterAspect YMM22 = default;

        public const RegisterAspect YMM23 = default;

        public const RegisterAspect YMM24 = default;

        public const RegisterAspect YMM25 = default;

        public const RegisterAspect YMM26 = default;

        public const RegisterAspect YMM27 = default;

        public const RegisterAspect YMM28 = default;

        public const RegisterAspect YMM29 = default;

        public const RegisterAspect YMM30 = default;

        public const RegisterAspect YMM31 = default;

        public const RegisterAspect ZMM0 = default;

        public const RegisterAspect ZMM1 = default;

        public const RegisterAspect ZMM2 = default;

        public const RegisterAspect ZMM3 = default;

        public const RegisterAspect ZMM4 = default;

        public const RegisterAspect ZMM5 = default;

        public const RegisterAspect ZMM6 = default;

        public const RegisterAspect ZMM7 = default;

        public const RegisterAspect ZMM8 = default;

        public const RegisterAspect ZMM9 = default;

        public const RegisterAspect ZMM10 = default;

        public const RegisterAspect ZMM11 = default;

        public const RegisterAspect ZMM12 = default;

        public const RegisterAspect ZMM13 = default;

        public const RegisterAspect ZMM14 = default;

        public const RegisterAspect ZMM15 = default;

        public const RegisterAspect ZMM16 = default;

        public const RegisterAspect ZMM17 = default;

        public const RegisterAspect ZMM18 = default;

        public const RegisterAspect ZMM19 = default;

        public const RegisterAspect ZMM20 = default;

        public const RegisterAspect ZMM21 = default;

        public const RegisterAspect ZMM22 = default;

        public const RegisterAspect ZMM23 = default;

        public const RegisterAspect ZMM24 = default;

        public const RegisterAspect ZMM25 = default;

        public const RegisterAspect ZMM26 = default;

        public const RegisterAspect ZMM27 = default;

        public const RegisterAspect ZMM28 = default;

        public const RegisterAspect ZMM29 = default;

        public const RegisterAspect ZMM30 = default;

        public const RegisterAspect ZMM31 = default;
    }
}