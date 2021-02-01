//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsciCharCode;
    using static root;

    [ApiType]
    public readonly struct EFlagSymbols
    {
        /// <summary>
        /// Carry Flag (Status Flag): Set if an arithmetic operation generates a carry or a borrow
        /// out of the mostsignificant bit of the result; cleared otherwise. This flag
        /// indicates an overflow condition for unsigned-integer arithmetic. It is also used
        /// in multiple-precision arithmetic
        ///</summary>
        public static EFlagSymbol CF => (C,F);

        /// <summary>
        /// Parity Flag (Status Flag): Set if the least-significant byte of the result contains an even number of 1 bits; cleared otherwise.
        ///</summary>
        public static EFlagSymbol PF => (P,F);

        /// <summary>
        /// Auxillary Carry Flag (Status Flag): Set if an arithmetic operation generates a carry or a borrow out of bit 3 of the result; cleared otherwise.
        ///</summary>
        public static EFlagSymbol AF => (A,F);

        /// <summary>
        /// Zero Flag (Status Flag): Set if the result is zero; cleared otherwise
        ///</summary>
        public static EFlagSymbol ZF => (Z,F);

        /// <summary>
        /// Sign Flag (Status Flag): Set equal to the most-significant bit of the result, which is the sign bit of a signed
        /// integer. (0 indicates a positive value and 1 indicates a negative value.)
        ///</summary>
        public static EFlagSymbol SF => (S,F);

        /// <summary>
        ///  Trap Flag (System Flag): Set to enable single-step mode for debugging; clear to disable single-step mode.
        ///</summary>
        public static EFlagSymbol TF => (T,F);

        /// <summary>
        /// Interupt Flag (System Flag)
        ///</summary>
        public static EFlagSymbol IF => (I,F);

        /// <summary>
        /// Direction Flag
        ///</summary>
        public static EFlagSymbol DF => (D,F);

        /// <summary>
        /// Overflow Flag (Status Flag): Set if the integer result is too large a positive number
        /// or too small a negative number (excluding the sign-bit) to fit in the destination
        /// operand; cleared otherwise. This flag indicates an overflow condition for signed-integer
        /// (two’s complement) arithmetic.
        ///</summary>
        public static EFlagSymbol OF => (O,F);

        /// <summary>
        /// Resume Flag
        ///</summary>
        public static EFlagSymbol RF => (R,F);

        /// <summary>
        /// Virtual 8086 Mode
        ///</summary>
        public static EFlagSymbol VM => (V,M);

        /// <summary>
        /// Alignment Check
        ///</summary>
        public static EFlagSymbol AC => (A,C);

        /// <summary>
        /// Virtual Interrupt Flag
        ///</summary>
        public static EFlagSymbol VIF => triple(V,I,F);

        /// <summary>
        /// Virtual Interrupt Pending
        ///</summary>
        public static EFlagSymbol VIP => triple(V,I,P);

        /// <summary>
        /// CPUID-capability
        ///</summary>
        public static EFlagSymbol ID => (I,D);
    }
}