//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Pow2x32;

    /// <summary>
    /// Defines literals corresponding the bits in the EFLAGS register
    /// </summary>
    /// <remarks>
    /// 3-16 Vol 1 of Intel Manual
    /// </remarks>
    [Flags]
    public enum FlagRegSlot : uint
    {
        /// <summary>
        /// Carry Flag (Status Flag): Set if an arithmetic operation generates a carry or a borrow
        /// out of the mostsignificant bit of the result; cleared otherwise. This flag
        /// indicates an overflow condition for unsigned-integer arithmetic. It is also used
        /// in multiple-precision arithmetic
        ///</summary>
        CF = P2ᐞ00,

        /// <summary>
        /// Parity Flag (Status Flag): Set if the least-significant byte of the result contains an even number of 1 bits; cleared otherwise.
        ///</summary>
        PF = P2ᐞ02,

        /// <summary>
        /// Adjust/Carry Flag (Status Flag): Set if an arithmetic operation generates a carry or a borrow out of bit 3 of the result; cleared otherwise.
        ///</summary>
        AF = P2ᐞ04,

        /// <summary>
        /// Zero Flag (Status Flag): Set if the result is zero; cleared otherwise
        ///</summary>
        ZF = P2ᐞ06,

        /// <summary>
        /// Sign Flag (Status Flag): Set equal to the most-significant bit of the result, which is the sign bit of a signed
        /// integer. (0 indicates a positive value and 1 indicates a negative value.)
        ///</summary>
        SF = P2ᐞ07,

        /// <summary>
        ///  Trap Flag (System Flag): Set to enable single-step mode for debugging; clear to disable single-step mode.
        ///</summary>
        TF = P2ᐞ08,

        /// <summary>
        /// Interupt Flag (System Flag)
        ///</summary>
        IF = P2ᐞ09,

        /// <summary>
        /// Direction Flag
        ///</summary>
        DF = P2ᐞ10,

        /// <summary>
        /// Overflow Flag (Status Flag): Set if the integer result is too large a positive number
        /// or too small a negative number (excluding the sign-bit) to fit in the destination
        /// operand; cleared otherwise. This flag indicates an overflow condition for signed-integer
        /// (two’s complement) arithmetic.
        ///</summary>
        OF = P2ᐞ11,

        /// <summary>
        /// Resume Flag
        ///</summary>
        RF = P2ᐞ16,

        /// <summary>
        /// Virtual 8086 Mode
        ///</summary>
        VM = P2ᐞ17,

        /// <summary>
        /// Alignment Check
        ///</summary>
        AC = P2ᐞ18,

        /// <summary>
        /// Virtual Interrupt Flag
        ///</summary>
        VIF = P2ᐞ19,

        /// <summary>
        /// Virtual Interrupt Pending
        ///</summary>
        VIP = P2ᐞ20,

        /// <summary>
        /// CPUID-capability
        ///</summary>
        ID = P2ᐞ21,
    }
}