//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    
    partial class Registers
    {
        /// <summary>
        /// Stack segment register - pointer to stack
        /// </summary>
        public struct EFLAGS : ICpuReg32
        {
            public EFLAG state;            
        }

        /// <summary>
        /// Defines literals corresponding the bits in the EFLAGS register
        /// </summary>
        /// <remarks>
        /// 3-16 Vol 1 of Intel Manual
        /// </remarks>
        [Flags]
        public enum EFLAG : uint
        {
            /// <summary>
            /// Carry Flag (Status Flag): Set if an arithmetic operation generates a carry or a borrow 
            /// out of the mostsignificant bit of the result; cleared otherwise. This flag 
            /// indicates an overflow condition for unsigned-integer arithmetic. It is also used 
            /// in multiple-precision arithmetic
            ///</summary>            
            CF = Pow2.T00,

            /// <summary>
            /// Parity Flag (Status Flag): Set if the least-significant byte of the result contains an even number of 1 bits; cleared otherwise.
            ///</summary>
            PF = Pow2.T02,
            
            /// <summary>
            /// Auxillary Carry Flag (Status Flag): Set if an arithmetic operation generates a carry or a borrow out of bit 3 of the result; cleared otherwise. 
            ///</summary>
            AF = Pow2.T04,

            /// <summary>
            /// Zero Flag (Status Flag): Set if the result is zero; cleared otherwise
            ///</summary>
            ZF = Pow2.T06,

            /// <summary>
            /// Sign Flag (Status Flag): Set equal to the most-significant bit of the result, which is the sign bit of a signed
            /// integer. (0 indicates a positive value and 1 indicates a negative value.)
            ///</summary>
            SF = Pow2.T07,

            /// <summary>
            ///  Trap Flag (System Flag): Set to enable single-step mode for debugging; clear to disable single-step mode.
            ///</summary>
            TF = Pow2.T08,

            /// <summary>
            /// Interupt Flag (System Flag)
            ///</summary>
            IF = Pow2.T09,

            /// <summary>
            /// Direction Flag 
            ///</summary>
            DF = Pow2.T10,

            /// <summary>
            /// Overflow Flag (Status Flag): Set if the integer result is too large a positive number 
            /// or too small a negative number (excluding the sign-bit) to fit in the destination 
            /// operand; cleared otherwise. This flag indicates an overflow condition for signed-integer 
            /// (two’s complement) arithmetic.
            ///</summary>
            OF = Pow2.T11,
        }
    }
}