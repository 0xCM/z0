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
    public enum JccCode : byte
    {
        /// <summary>
        /// Overflow
        /// </summary>
        [Meaning("Overflow")]
        O = b0000,

        /// <summary>
        /// Not Overflow
        /// </summary>
        [Meaning("Not Overflow")]
        NO = b0001,

        /// <summary>
        /// Below, not above or equal
        /// </summary>
        [Meaning("Below, not Above or Equal")]
        B = b0010,

        /// <summary>
        /// Not Below
        /// </summary>
        [Meaning("Not Below")]
        NB = b0011,

        /// <summary>
        /// Equal; Zero
        /// </summary>
        [Meaning("Equal; Zero")]
        E = b0100,

        /// <summary>
        /// Not Equal; Not Zero
        /// </summary>
        [Meaning("Not Equal; Not Zero")]
        NE = b0101,

        /// <summary>
        /// Below or equal, Not above
        /// </summary>
        [Meaning("Below or Equal; Not Above")]
        BE = b0110,

        /// <summary>
        /// Not below or equal, Above
        /// </summary>
        [Meaning("Not Below or Equal; Above")]
        NBE = b0111,

        /// <summary>
        /// Sign
        /// </summary>
        [Meaning("Sign")]
        S = b1000,

        /// <summary>
        /// Not sign
        /// </summary>
        [Meaning("Not Signed")]
        NS = b1001,

        /// <summary>
        /// Parity Even
        /// </summary>
        [Meaning("Parity (even)")]
        P = b1010,

        /// <summary>
        /// Parity Odd
        /// </summary>
        [Meaning("Not Parity (odd)")]
        NP = b1011,

        /// <summary>
        /// Less than; Not greater than or equal to
        /// </summary>
        [Meaning("Less Than; Not Greater Than or Equal")]
        L = b1100,

        /// <summary>
        /// Not less than, Greater than or equal to
        /// </summary>
        [Meaning("Not Less Than; Greater Than or Equal")]
        NL = b1101,

        /// <summary>
        /// Less than or equal to, Not greater than
        /// </summary>
        [Meaning("Not Greater Than; Less Than or Equal")]
        NG = b1110,

        /// <summary>
        /// Not less than or equal to, Greater than
        /// </summary>
        [Meaning("Not Less Than or Equal; Greater Than")]
        G = b1111,
    }
}