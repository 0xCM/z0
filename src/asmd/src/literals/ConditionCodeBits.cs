//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using static BitSets;

    /// <summary>
    /// Defines the 16 possible jcc condition codes
    /// </summary>
    public enum ConditionCodeBits : byte
    {
        /// <summary>
        /// Overflow
        /// </summary>
        O = b0000,
        
        /// <summary>
        /// Not Overflow
        /// </summary>
        NO = b0001,

        /// <summary>
        /// Below, not above or equl
        /// </summary>
        B = b0010,

        /// <summary>
        /// Not Below
        /// </summary>
        NB = b0011,

        /// <summary>
        /// Equal; Zero
        /// </summary>
        E = b0100,

        /// <summary>
        /// Not Equal; Not Zero
        /// </summary>
        NE = b0101,

        /// <summary>
        /// Below or equal, Not above 
        /// </summary>
        BE = b0110,

        /// <summary>
        /// Not below or equal, Above
        /// </summary>
        NBE = b0111,

        /// <summary>
        /// Sign
        /// </summary>
        S = b1000,

        /// <summary>
        /// Not sign
        /// </summary>
        NS = b1001,

        /// <summary>
        /// Parity Even
        /// </summary>
        P = b1010,

        /// <summary>
        /// Parity Odd
        /// </summary>
        NP = b1011,

        /// <summary>
        /// Less than; Not greater than or equal to 
        /// </summary>
        L = b1100,

        /// <summary>
        /// Not less than, Greater than or equal to
        /// </summary>
        NL = b1101,       

        /// <summary>
        /// Less than or equal to, Not greater than 
        /// </summary>
        LE = b1110,
        
        /// <summary>
        /// Not less than or equal to, Greater than
        /// </summary>
        NLE = b1111,        
    }
}