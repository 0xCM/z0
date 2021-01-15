//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore; 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegisterAspectKind;

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

        public const RegisterAspectKind AL = default;

        public const RegisterAspectKind CL = default;

        public const RegisterAspectKind DL = default;

        public const RegisterAspectKind BL = default;

        public const RegisterAspectKind SPL = default;

        public const RegisterAspectKind BPL = default;

        public const RegisterAspectKind SIL = default;

        public const RegisterAspectKind DIL = default;

        public const RegisterAspectKind R8L = default;

        public const RegisterAspectKind R9L = default;

        public const RegisterAspectKind R10L = default;

        public const RegisterAspectKind R11L = default;

        public const RegisterAspectKind R12L = default;

        public const RegisterAspectKind R13L = default;

        public const RegisterAspectKind R14L = default;

        public const RegisterAspectKind R15L = default;

        // ~ 16-bit registers
        // ~ ------------------------------------------------------------------

        public const RegisterAspectKind AX = default;

        public const RegisterAspectKind CX = default;

        public const RegisterAspectKind DX = default;

        public const RegisterAspectKind BX = default;

        public const RegisterAspectKind SP = default;

        public const RegisterAspectKind BP = default;

        public const RegisterAspectKind SI = default;

        public const RegisterAspectKind DI = default;

        public const RegisterAspectKind R8W = default;

        public const RegisterAspectKind R9W = default;

        public const RegisterAspectKind R10W = default;

        public const RegisterAspectKind R11W = default;

        public const RegisterAspectKind R12W = default;

        public const RegisterAspectKind R13W = default;

        public const RegisterAspectKind R14W = default;

        public const RegisterAspectKind R15W = default;

        // ~ 32-bit registers
        // ~ ------------------------------------------------------------------

        public const RegisterAspectKind EAX = default;

        public const RegisterAspectKind ECX = default;

        public const RegisterAspectKind EDX = default;

        public const RegisterAspectKind EBX = default;

        public const RegisterAspectKind ESP = default;

        public const RegisterAspectKind EBP = default;

        public const RegisterAspectKind ESI = default;

        public const RegisterAspectKind EDI = default;

        public const RegisterAspectKind R8D = default;

        public const RegisterAspectKind R9D = default;

        public const RegisterAspectKind R10D = default;

        public const RegisterAspectKind R11D = default;

        public const RegisterAspectKind R12D = default;

        public const RegisterAspectKind R13D = default;

        public const RegisterAspectKind R14D = default;

        public const RegisterAspectKind R15D = default;

        // ~ 64-bit registers
        // ~ ------------------------------------------------------------------

        //  %rdi, %rsi, %rdx, %rcx, %r8, and %r9
        public const RegisterAspectKind RAX = Volatile | Return;

        public const RegisterAspectKind RCX = Volatile | RegisterAspectKind.ArgSequence;

        public const RegisterAspectKind RDX = Volatile | RegisterAspectKind.ArgSequence;

        public const RegisterAspectKind RBX = Persistent;

        public const RegisterAspectKind RSP = Volatile | StackPointer;

        public const RegisterAspectKind RBP = Persistent;

        public const RegisterAspectKind RSI = Volatile | RegisterAspectKind.ArgSequence;

        public const RegisterAspectKind RDI = Volatile | RegisterAspectKind.ArgSequence;

        public const RegisterAspectKind R8Q = Volatile | RegisterAspectKind.ArgSequence;

        public const RegisterAspectKind R9Q = Volatile | RegisterAspectKind.ArgSequence;

        public const RegisterAspectKind R10Q = Volatile;

        public const RegisterAspectKind R11Q = Volatile;

        public const RegisterAspectKind R12Q = Persistent;

        public const RegisterAspectKind R13Q = Persistent;

        public const RegisterAspectKind R14Q = Persistent;

        public const RegisterAspectKind R15Q = Persistent;

        public const RegisterAspectKind XMM0 = default;

        public const RegisterAspectKind XMM1 = default;

        public const RegisterAspectKind XMM2 = default;

        public const RegisterAspectKind XMM3 = default;

        public const RegisterAspectKind XMM4 = default;

        public const RegisterAspectKind XMM5 = default;

        public const RegisterAspectKind XMM6 = default;

        public const RegisterAspectKind XMM7 = default;

        public const RegisterAspectKind XMM8 = default;

        public const RegisterAspectKind XMM9 = default;

        public const RegisterAspectKind XMM10 = default;

        public const RegisterAspectKind XMM11 = default;

        public const RegisterAspectKind XMM12 = default;

        public const RegisterAspectKind XMM13 = default;

        public const RegisterAspectKind XMM14 = default;

        public const RegisterAspectKind XMM15 = default;

        public const RegisterAspectKind XMM16 = default;

        public const RegisterAspectKind XMM17 = default;

        public const RegisterAspectKind XMM18 = default;

        public const RegisterAspectKind XMM19 = default;

        public const RegisterAspectKind XMM20 = default;

        public const RegisterAspectKind XMM21 = default;

        public const RegisterAspectKind XMM22 = default;

        public const RegisterAspectKind XMM23 = default;

        public const RegisterAspectKind XMM24 = default;

        public const RegisterAspectKind XMM25 = default;

        public const RegisterAspectKind XMM26 = default;

        public const RegisterAspectKind XMM27 = default;

        public const RegisterAspectKind XMM28 = default;

        public const RegisterAspectKind XMM29 = default;

        public const RegisterAspectKind XMM30 = default;

        public const RegisterAspectKind XMM31 = default;

        public const RegisterAspectKind YMM0 = default;

        public const RegisterAspectKind YMM1 = default;

        public const RegisterAspectKind YMM2 = default;

        public const RegisterAspectKind YMM3 = default;

        public const RegisterAspectKind YMM4 = default;

        public const RegisterAspectKind YMM5 = default;

        public const RegisterAspectKind YMM6 = default;

        public const RegisterAspectKind YMM7 = default;

        public const RegisterAspectKind YMM8 = default;

        public const RegisterAspectKind YMM9 = default;

        public const RegisterAspectKind YMM10 = default;

        public const RegisterAspectKind YMM11 = default;

        public const RegisterAspectKind YMM12 = default;

        public const RegisterAspectKind YMM13 = default;

        public const RegisterAspectKind YMM14 = default;

        public const RegisterAspectKind YMM15 = default;

        public const RegisterAspectKind YMM16 = default;

        public const RegisterAspectKind YMM17 = default;

        public const RegisterAspectKind YMM18 = default;

        public const RegisterAspectKind YMM19 = default;

        public const RegisterAspectKind YMM20 = default;

        public const RegisterAspectKind YMM21 = default;

        public const RegisterAspectKind YMM22 = default;

        public const RegisterAspectKind YMM23 = default;

        public const RegisterAspectKind YMM24 = default;

        public const RegisterAspectKind YMM25 = default;

        public const RegisterAspectKind YMM26 = default;

        public const RegisterAspectKind YMM27 = default;

        public const RegisterAspectKind YMM28 = default;

        public const RegisterAspectKind YMM29 = default;

        public const RegisterAspectKind YMM30 = default;

        public const RegisterAspectKind YMM31 = default;

        public const RegisterAspectKind ZMM0 = default;

        public const RegisterAspectKind ZMM1 = default;

        public const RegisterAspectKind ZMM2 = default;

        public const RegisterAspectKind ZMM3 = default;

        public const RegisterAspectKind ZMM4 = default;

        public const RegisterAspectKind ZMM5 = default;

        public const RegisterAspectKind ZMM6 = default;

        public const RegisterAspectKind ZMM7 = default;

        public const RegisterAspectKind ZMM8 = default;

        public const RegisterAspectKind ZMM9 = default;

        public const RegisterAspectKind ZMM10 = default;

        public const RegisterAspectKind ZMM11 = default;

        public const RegisterAspectKind ZMM12 = default;

        public const RegisterAspectKind ZMM13 = default;

        public const RegisterAspectKind ZMM14 = default;

        public const RegisterAspectKind ZMM15 = default;

        public const RegisterAspectKind ZMM16 = default;

        public const RegisterAspectKind ZMM17 = default;

        public const RegisterAspectKind ZMM18 = default;

        public const RegisterAspectKind ZMM19 = default;

        public const RegisterAspectKind ZMM20 = default;

        public const RegisterAspectKind ZMM21 = default;

        public const RegisterAspectKind ZMM22 = default;

        public const RegisterAspectKind ZMM23 = default;

        public const RegisterAspectKind ZMM24 = default;

        public const RegisterAspectKind ZMM25 = default;

        public const RegisterAspectKind ZMM26 = default;

        public const RegisterAspectKind ZMM27 = default;

        public const RegisterAspectKind ZMM28 = default;

        public const RegisterAspectKind ZMM29 = default;

        public const RegisterAspectKind ZMM30 = default;

        public const RegisterAspectKind ZMM31 = default;
    }
}