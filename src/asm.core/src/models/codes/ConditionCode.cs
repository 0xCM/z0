//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static BitSeq;

    partial struct AsmCodes
    {
        /// <summary>
        /// Defines the condition codes as the bitfield [tttn] where ttt indicates
        /// the condition being tested and n indicates where to use the condition (n=0)
        /// or its negation (n=1). For 1-byte primary opcodes, the tttn field is located
        /// in bits 3, 2, 1, and 0 of the opcode byte. For 2-byte primary opcodes, the tttn
        /// field is located in bits 3, 2, 1, and 0 of the second opcode byte
        /// </summary>
        /// <remarks>
        /// From Vol2D, appendix B.1.4.7
        /// </remarks>
        [SymSource]
        public enum ConditionCode : byte
        {
            /// <summary>
            /// Overflow
            /// </summary>
            [Symbol("O", "Overflow")]
            O = b0000,

            /// <summary>
            /// Not Overflow
            /// </summary>
            [Symbol("NO", "Not Overflow")]
            NO = b0001,

            /// <summary>
            /// Below, not above or equal
            /// </summary>
            [Symbol("B|NAE", "Below, not Above or Equal")]
            B = b0010,

            /// <summary>
            /// Not Below
            /// </summary>
            [Symbol("NB|AE", "Not Below")]
            NB = b0011,

            /// <summary>
            /// Equal; Zero
            /// </summary>
            [Symbol("E|Z", "Equal; Zero")]
            E = b0100,

            /// <summary>
            /// Not Equal; Not Zero
            /// </summary>
            [Symbol("NE|NZ", "Not Equal; Not Zero")]
            NE = b0101,

            /// <summary>
            /// Below or equal, Not above
            /// </summary>
            [Symbol("BE|NA", "Below or Equal; Not Above")]
            BE = b0110,

            /// <summary>
            /// Not below or equal, Above
            /// </summary>
            [Symbol("NBE|A", "Not Below or Equal; Above")]
            NBE = b0111,

            /// <summary>
            /// Sign
            /// </summary>
            [Symbol("S", "Sign")]
            S = b1000,

            /// <summary>
            /// Not sign
            /// </summary>
            [Symbol("NS", "Not Signed")]
            NS = b1001,

            /// <summary>
            /// Parity Even
            /// </summary>
            [Symbol("P|PE", "Parity (even)")]
            P = b1010,

            /// <summary>
            /// Parity Odd
            /// </summary>
            [Symbol("NP|PO", "Not Parity (odd)")]
            NP = b1011,

            /// <summary>
            /// Less than; Not greater than or equal to
            /// </summary>
            [Symbol("L|NGE", "Less Than; Not Greater Than or Equal")]
            L = b1100,

            /// <summary>
            /// Not less than, Greater than or equal to
            /// </summary>
            [Symbol("NL|GE", "Not Less Than; Greater Than or Equal")]
            NL = b1101,

            /// <summary>
            /// Less than or equal to, Not greater than
            /// </summary>
            [Symbol("LE|NG", "Less Than or Equal|Not Greater Than")]
            LE = b1110,

            /// <summary>
            /// Not less than or equal to, Greater than
            /// </summary>
            [Symbol("NLE|G", "Not Less Than or Equal; Greater Than")]
            NLE = b1111,
        }
    }
}