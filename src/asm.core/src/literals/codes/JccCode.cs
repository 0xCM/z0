//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static BitSeq;

    /// <summary>
    /// Defines the 16 possible jcc condition codes
    /// </summary>
    [SymbolSource]
    public enum JccCode : byte
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
        [Symbol("B", "Below, not Above or Equal")]
        B = b0010,

        /// <summary>
        /// Not Below
        /// </summary>
        [Symbol("NB", "Not Below")]
        NB = b0011,

        /// <summary>
        /// Equal; Zero
        /// </summary>
        [Symbol("E", "Equal; Zero")]
        E = b0100,

        /// <summary>
        /// Not Equal; Not Zero
        /// </summary>
        [Symbol("NE", "Not Equal; Not Zero")]
        NE = b0101,

        /// <summary>
        /// Below or equal, Not above
        /// </summary>
        [Symbol("BE", "Below or Equal; Not Above")]
        BE = b0110,

        /// <summary>
        /// Not below or equal, Above
        /// </summary>
        [Symbol("NBE", "Not Below or Equal; Above")]
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
        [Symbol("P", "Parity (even)")]
        P = b1010,

        /// <summary>
        /// Parity Odd
        /// </summary>
        [Symbol("NP", "Not Parity (odd)")]
        NP = b1011,

        /// <summary>
        /// Less than; Not greater than or equal to
        /// </summary>
        [Symbol("L", "Less Than; Not Greater Than or Equal")]
        L = b1100,

        /// <summary>
        /// Not less than, Greater than or equal to
        /// </summary>
        [Symbol("NL", "Not Less Than; Greater Than or Equal")]
        NL = b1101,

        /// <summary>
        /// Less than or equal to, Not greater than
        /// </summary>
        [Symbol("NG", "Not Greater Than; Less Than or Equal")]
        NG = b1110,

        /// <summary>
        /// Not less than or equal to, Greater than
        /// </summary>
        [Symbol("G", "Not Less Than or Equal; Greater Than")]
        G = b1111,
    }
}