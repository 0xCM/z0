//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore; 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegAspectKind;

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

        public const RegAspectKind AL = default;

        public const RegAspectKind CL = default;

        public const RegAspectKind DL = default;

        public const RegAspectKind BL = default;

        public const RegAspectKind SPL = default;

        public const RegAspectKind BPL = default;

        public const RegAspectKind SIL = default;

        public const RegAspectKind DIL = default;

        public const RegAspectKind R8L = default;

        public const RegAspectKind R9L = default;

        public const RegAspectKind R10L = default;

        public const RegAspectKind R11L = default;

        public const RegAspectKind R12L = default;

        public const RegAspectKind R13L = default;

        public const RegAspectKind R14L = default;

        public const RegAspectKind R15L = default;

        // ~ 16-bit registers
        // ~ ------------------------------------------------------------------

        public const RegAspectKind AX = default;

        public const RegAspectKind CX = default;

        public const RegAspectKind DX = default;

        public const RegAspectKind BX = default;

        public const RegAspectKind SP = default;

        public const RegAspectKind BP = default;

        public const RegAspectKind SI = default;

        public const RegAspectKind DI = default;

        public const RegAspectKind R8W = default;

        public const RegAspectKind R9W = default;

        public const RegAspectKind R10W = default;

        public const RegAspectKind R11W = default;

        public const RegAspectKind R12W = default;

        public const RegAspectKind R13W = default;

        public const RegAspectKind R14W = default;

        public const RegAspectKind R15W = default;

        // ~ 32-bit registers
        // ~ ------------------------------------------------------------------

        public const RegAspectKind EAX = default;

        public const RegAspectKind ECX = default;

        public const RegAspectKind EDX = default;

        public const RegAspectKind EBX = default;

        public const RegAspectKind ESP = default;

        public const RegAspectKind EBP = default;

        public const RegAspectKind ESI = default;

        public const RegAspectKind EDI = default;

        public const RegAspectKind R8D = default;

        public const RegAspectKind R9D = default;

        public const RegAspectKind R10D = default;

        public const RegAspectKind R11D = default;

        public const RegAspectKind R12D = default;

        public const RegAspectKind R13D = default;

        public const RegAspectKind R14D = default;

        public const RegAspectKind R15D = default;

        // ~ 64-bit registers
        // ~ ------------------------------------------------------------------

        //  %rdi, %rsi, %rdx, %rcx, %r8, and %r9
        public const RegAspectKind RAX = Volatile | Return;

        public const RegAspectKind RCX = Volatile | RegAspectKind.ArgSequence;

        public const RegAspectKind RDX = Volatile | RegAspectKind.ArgSequence;

        public const RegAspectKind RBX = Persistent;

        public const RegAspectKind RSP = Volatile | StackPointer;

        public const RegAspectKind RBP = Persistent;

        public const RegAspectKind RSI = Volatile | RegAspectKind.ArgSequence;

        public const RegAspectKind RDI = Volatile | RegAspectKind.ArgSequence;

        public const RegAspectKind R8Q = Volatile | RegAspectKind.ArgSequence;

        public const RegAspectKind R9Q = Volatile | RegAspectKind.ArgSequence;

        public const RegAspectKind R10Q = Volatile;

        public const RegAspectKind R11Q = Volatile;

        public const RegAspectKind R12Q = Persistent;

        public const RegAspectKind R13Q = Persistent;

        public const RegAspectKind R14Q = Persistent;

        public const RegAspectKind R15Q = Persistent;

        public const RegAspectKind XMM0 = default;

        public const RegAspectKind XMM1 = default;

        public const RegAspectKind XMM2 = default;

        public const RegAspectKind XMM3 = default;

        public const RegAspectKind XMM4 = default;

        public const RegAspectKind XMM5 = default;

        public const RegAspectKind XMM6 = default;

        public const RegAspectKind XMM7 = default;

        public const RegAspectKind XMM8 = default;

        public const RegAspectKind XMM9 = default;

        public const RegAspectKind XMM10 = default;

        public const RegAspectKind XMM11 = default;

        public const RegAspectKind XMM12 = default;

        public const RegAspectKind XMM13 = default;

        public const RegAspectKind XMM14 = default;

        public const RegAspectKind XMM15 = default;

        public const RegAspectKind XMM16 = default;

        public const RegAspectKind XMM17 = default;

        public const RegAspectKind XMM18 = default;

        public const RegAspectKind XMM19 = default;

        public const RegAspectKind XMM20 = default;

        public const RegAspectKind XMM21 = default;

        public const RegAspectKind XMM22 = default;

        public const RegAspectKind XMM23 = default;

        public const RegAspectKind XMM24 = default;

        public const RegAspectKind XMM25 = default;

        public const RegAspectKind XMM26 = default;

        public const RegAspectKind XMM27 = default;

        public const RegAspectKind XMM28 = default;

        public const RegAspectKind XMM29 = default;

        public const RegAspectKind XMM30 = default;

        public const RegAspectKind XMM31 = default;

        public const RegAspectKind YMM0 = default;

        public const RegAspectKind YMM1 = default;

        public const RegAspectKind YMM2 = default;

        public const RegAspectKind YMM3 = default;

        public const RegAspectKind YMM4 = default;

        public const RegAspectKind YMM5 = default;

        public const RegAspectKind YMM6 = default;

        public const RegAspectKind YMM7 = default;

        public const RegAspectKind YMM8 = default;

        public const RegAspectKind YMM9 = default;

        public const RegAspectKind YMM10 = default;

        public const RegAspectKind YMM11 = default;

        public const RegAspectKind YMM12 = default;

        public const RegAspectKind YMM13 = default;

        public const RegAspectKind YMM14 = default;

        public const RegAspectKind YMM15 = default;

        public const RegAspectKind YMM16 = default;

        public const RegAspectKind YMM17 = default;

        public const RegAspectKind YMM18 = default;

        public const RegAspectKind YMM19 = default;

        public const RegAspectKind YMM20 = default;

        public const RegAspectKind YMM21 = default;

        public const RegAspectKind YMM22 = default;

        public const RegAspectKind YMM23 = default;

        public const RegAspectKind YMM24 = default;

        public const RegAspectKind YMM25 = default;

        public const RegAspectKind YMM26 = default;

        public const RegAspectKind YMM27 = default;

        public const RegAspectKind YMM28 = default;

        public const RegAspectKind YMM29 = default;

        public const RegAspectKind YMM30 = default;

        public const RegAspectKind YMM31 = default;

        public const RegAspectKind ZMM0 = default;

        public const RegAspectKind ZMM1 = default;

        public const RegAspectKind ZMM2 = default;

        public const RegAspectKind ZMM3 = default;

        public const RegAspectKind ZMM4 = default;

        public const RegAspectKind ZMM5 = default;

        public const RegAspectKind ZMM6 = default;

        public const RegAspectKind ZMM7 = default;

        public const RegAspectKind ZMM8 = default;

        public const RegAspectKind ZMM9 = default;

        public const RegAspectKind ZMM10 = default;

        public const RegAspectKind ZMM11 = default;

        public const RegAspectKind ZMM12 = default;

        public const RegAspectKind ZMM13 = default;

        public const RegAspectKind ZMM14 = default;

        public const RegAspectKind ZMM15 = default;

        public const RegAspectKind ZMM16 = default;

        public const RegAspectKind ZMM17 = default;

        public const RegAspectKind ZMM18 = default;

        public const RegAspectKind ZMM19 = default;

        public const RegAspectKind ZMM20 = default;

        public const RegAspectKind ZMM21 = default;

        public const RegAspectKind ZMM22 = default;

        public const RegAspectKind ZMM23 = default;

        public const RegAspectKind ZMM24 = default;

        public const RegAspectKind ZMM25 = default;

        public const RegAspectKind ZMM26 = default;

        public const RegAspectKind ZMM27 = default;

        public const RegAspectKind ZMM28 = default;

        public const RegAspectKind ZMM29 = default;

        public const RegAspectKind ZMM30 = default;

        public const RegAspectKind ZMM31 = default;
    }
}