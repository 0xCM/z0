//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore; 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegAspect;

    /// <summary>
    /// Defines register characteristics
    /// </summary>
    /// <remarks>
    /// References:
    /// https://cs.brown.edu/courses/cs033/docs/guides/x64_cheatsheet.pdf
    /// https://en.wikipedia.org/wiki/X86_calling_conventions
    /// </remarks>
    [LiteralProvider]
    public readonly struct RegisterAspects
    {
        // ~ 8-bit registers
        // ~ ------------------------------------------------------------------

        public const RegAspect AL = default;

        public const RegAspect CL = default;

        public const RegAspect DL = default;

        public const RegAspect BL = default;

        public const RegAspect SPL = default;

        public const RegAspect BPL = default;

        public const RegAspect SIL = default;

        public const RegAspect DIL = default;

        public const RegAspect R8L = default;

        public const RegAspect R9L = default;

        public const RegAspect R10L = default;

        public const RegAspect R11L = default;

        public const RegAspect R12L = default;

        public const RegAspect R13L = default;

        public const RegAspect R14L = default;

        public const RegAspect R15L = default;

        // ~ 16-bit registers
        // ~ ------------------------------------------------------------------

        public const RegAspect AX = default;

        public const RegAspect CX = default;

        public const RegAspect DX = default;

        public const RegAspect BX = default;

        public const RegAspect SP = default;

        public const RegAspect BP = default;

        public const RegAspect SI = default;

        public const RegAspect DI = default;

        public const RegAspect R8W = default;

        public const RegAspect R9W = default;

        public const RegAspect R10W = default;

        public const RegAspect R11W = default;

        public const RegAspect R12W = default;

        public const RegAspect R13W = default;

        public const RegAspect R14W = default;

        public const RegAspect R15W = default;

        // ~ 32-bit registers
        // ~ ------------------------------------------------------------------

        public const RegAspect EAX = default;

        public const RegAspect ECX = default;

        public const RegAspect EDX = default;

        public const RegAspect EBX = default;

        public const RegAspect ESP = default;

        public const RegAspect EBP = default;

        public const RegAspect ESI = default;

        public const RegAspect EDI = default;

        public const RegAspect R8D = default;

        public const RegAspect R9D = default;

        public const RegAspect R10D = default;

        public const RegAspect R11D = default;

        public const RegAspect R12D = default;

        public const RegAspect R13D = default;

        public const RegAspect R14D = default;

        public const RegAspect R15D = default;

        // ~ 64-bit registers
        // ~ ------------------------------------------------------------------

        //  %rdi, %rsi, %rdx, %rcx, %r8, and %r9
        public const RegAspect RAX = Volatile | Return;

        public const RegAspect RCX = Volatile | ArgSequence;

        public const RegAspect RDX = Volatile | ArgSequence;

        public const RegAspect RBX = Persistent;

        public const RegAspect RSP = Volatile | StackPointer;

        public const RegAspect RBP = Persistent;

        public const RegAspect RSI = Volatile | ArgSequence;

        public const RegAspect RDI = Volatile | ArgSequence;

        public const RegAspect R8Q = Volatile | ArgSequence;

        public const RegAspect R9Q = Volatile | ArgSequence;

        public const RegAspect R10Q = Volatile;

        public const RegAspect R11Q = Volatile;

        public const RegAspect R12Q = Persistent;

        public const RegAspect R13Q = Persistent;

        public const RegAspect R14Q = Persistent;

        public const RegAspect R15Q = Persistent;

        public const RegAspect XMM0 = default;

        public const RegAspect XMM1 = default;

        public const RegAspect XMM2 = default;

        public const RegAspect XMM3 = default;

        public const RegAspect XMM4 = default;

        public const RegAspect XMM5 = default;

        public const RegAspect XMM6 = default;

        public const RegAspect XMM7 = default;

        public const RegAspect XMM8 = default;

        public const RegAspect XMM9 = default;

        public const RegAspect XMM10 = default;

        public const RegAspect XMM11 = default;

        public const RegAspect XMM12 = default;

        public const RegAspect XMM13 = default;

        public const RegAspect XMM14 = default;

        public const RegAspect XMM15 = default;

        public const RegAspect XMM16 = default;

        public const RegAspect XMM17 = default;

        public const RegAspect XMM18 = default;

        public const RegAspect XMM19 = default;

        public const RegAspect XMM20 = default;

        public const RegAspect XMM21 = default;

        public const RegAspect XMM22 = default;

        public const RegAspect XMM23 = default;

        public const RegAspect XMM24 = default;

        public const RegAspect XMM25 = default;

        public const RegAspect XMM26 = default;

        public const RegAspect XMM27 = default;

        public const RegAspect XMM28 = default;

        public const RegAspect XMM29 = default;

        public const RegAspect XMM30 = default;

        public const RegAspect XMM31 = default;

        public const RegAspect YMM0 = default;

        public const RegAspect YMM1 = default;

        public const RegAspect YMM2 = default;

        public const RegAspect YMM3 = default;

        public const RegAspect YMM4 = default;

        public const RegAspect YMM5 = default;

        public const RegAspect YMM6 = default;

        public const RegAspect YMM7 = default;

        public const RegAspect YMM8 = default;

        public const RegAspect YMM9 = default;

        public const RegAspect YMM10 = default;

        public const RegAspect YMM11 = default;

        public const RegAspect YMM12 = default;

        public const RegAspect YMM13 = default;

        public const RegAspect YMM14 = default;

        public const RegAspect YMM15 = default;

        public const RegAspect YMM16 = default;

        public const RegAspect YMM17 = default;

        public const RegAspect YMM18 = default;

        public const RegAspect YMM19 = default;

        public const RegAspect YMM20 = default;

        public const RegAspect YMM21 = default;

        public const RegAspect YMM22 = default;

        public const RegAspect YMM23 = default;

        public const RegAspect YMM24 = default;

        public const RegAspect YMM25 = default;

        public const RegAspect YMM26 = default;

        public const RegAspect YMM27 = default;

        public const RegAspect YMM28 = default;

        public const RegAspect YMM29 = default;

        public const RegAspect YMM30 = default;

        public const RegAspect YMM31 = default;

        public const RegAspect ZMM0 = default;

        public const RegAspect ZMM1 = default;

        public const RegAspect ZMM2 = default;

        public const RegAspect ZMM3 = default;

        public const RegAspect ZMM4 = default;

        public const RegAspect ZMM5 = default;

        public const RegAspect ZMM6 = default;

        public const RegAspect ZMM7 = default;

        public const RegAspect ZMM8 = default;

        public const RegAspect ZMM9 = default;

        public const RegAspect ZMM10 = default;

        public const RegAspect ZMM11 = default;

        public const RegAspect ZMM12 = default;

        public const RegAspect ZMM13 = default;

        public const RegAspect ZMM14 = default;

        public const RegAspect ZMM15 = default;

        public const RegAspect ZMM16 = default;

        public const RegAspect ZMM17 = default;

        public const RegAspect ZMM18 = default;

        public const RegAspect ZMM19 = default;

        public const RegAspect ZMM20 = default;

        public const RegAspect ZMM21 = default;

        public const RegAspect ZMM22 = default;

        public const RegAspect ZMM23 = default;

        public const RegAspect ZMM24 = default;

        public const RegAspect ZMM25 = default;

        public const RegAspect ZMM26 = default;

        public const RegAspect ZMM27 = default;

        public const RegAspect ZMM28 = default;

        public const RegAspect ZMM29 = default;

        public const RegAspect ZMM30 = default;

        public const RegAspect ZMM31 = default;
    }
}