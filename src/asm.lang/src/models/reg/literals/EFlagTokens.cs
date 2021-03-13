//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using K = EFlagKind;

    [ApiComplete]
    public readonly struct EFlagTokens
    {
        /// <summary>
        /// Carry Flag (Status Flag): Set if an arithmetic operation generates a carry or a borrow
        /// out of the mostsignificant bit of the result; cleared otherwise. This flag
        /// indicates an overflow condition for unsigned-integer arithmetic. It is also used
        /// in multiple-precision arithmetic
        ///</summary>
        public static SyntaxToken<EFlagKind> CF
            => (nameof(K.CF), K.CF, "Carry Flag (Status Flag)");

        /// <summary>
        /// Parity Flag (Status Flag): Set if the least-significant byte of the result contains an even number of 1 bits; cleared otherwise.
        ///</summary>
        public static SyntaxToken<EFlagKind> PF
            => (nameof(K.PF), K.PF, "Parity Flag (Status Flag)");

        /// <summary>
        /// Auxillary Carry Flag (Status Flag): Set if an arithmetic operation generates a carry or a borrow out of bit 3 of the result; cleared otherwise.
        ///</summary>
        public static SyntaxToken<EFlagKind> AF
            => (nameof(K.AF), K.AF, "Auxillary Carry Flag (Status Flag)");

        /// <summary>
        /// Zero Flag (Status Flag): Set if the result is zero; cleared otherwise
        ///</summary>
        public static SyntaxToken<EFlagKind> ZF
            => (nameof(K.ZF), K.ZF, "Zero Flag (Status Flag)");

        /// <summary>
        /// Sign Flag (Status Flag): Set equal to the most-significant bit of the result, which is the sign bit of a signed
        /// integer. (0 indicates a positive value and 1 indicates a negative value.)
        ///</summary>
        public static SyntaxToken<EFlagKind> SF
            => (nameof(K.SF), K.SF, "Sign Flag (Status Flag)");

        /// <summary>
        ///  Trap Flag (System Flag): Set to enable single-step mode for debugging; clear to disable single-step mode.
        ///</summary>
        public static SyntaxToken<EFlagKind> TF
            => (nameof(K.TF), K.TF, "Trap Flag (System Flag)");

        /// <summary>
        /// Interupt Flag (System Flag)
        ///</summary>
        public static SyntaxToken<EFlagKind> IF
            => (nameof(K.IF), K.IF, "Interupt Flag (System Flag)");

        /// <summary>
        /// Direction Flag
        ///</summary>
        public static SyntaxToken<EFlagKind> DF => (nameof(K.DF), K.DF, "Direction Flag");

        /// <summary>
        /// Overflow Flag (Status Flag): Set if the integer result is too large a positive number
        /// or too small a negative number (excluding the sign-bit) to fit in the destination
        /// operand; cleared otherwise. This flag indicates an overflow condition for signed-integer
        /// (two’s complement) arithmetic.
        ///</summary>
        public static SyntaxToken<EFlagKind> OF
            => (nameof(K.OF), K.OF, "Overflow Flag (Status Flag)");

        /// <summary>
        /// Resume Flag
        ///</summary>
        public static SyntaxToken<EFlagKind> RF
            => (nameof(K.RF), K.RF, "Resume Flag");

        /// <summary>
        /// Virtual 8086 Mode
        ///</summary>
        public static SyntaxToken<EFlagKind> VM
            =>  (nameof(K.VM), K.VM, "Virtual 8086 Mode");

        /// <summary>
        /// Alignment Check
        ///</summary>
        public static SyntaxToken<EFlagKind> AC
            => (nameof(K.AC), K.AC, "Alignment Check");

        /// <summary>
        /// Virtual Interrupt Flag
        ///</summary>
        public static SyntaxToken<EFlagKind> VIF
            => (nameof(K.VIF), K.VIF, "Virtual Interrupt Flag");

        /// <summary>
        /// Virtual Interrupt Pending
        ///</summary>
        public static SyntaxToken<EFlagKind> VIP
            => (nameof(K.VIP), K.VIP, "Virtual Interrupt Pending");

        /// <summary>
        /// CPUID-capability
        ///</summary>
        public static SyntaxToken<EFlagKind> ID
            => (nameof(K.ID), K.ID, "CPUID-capability");
    }
}