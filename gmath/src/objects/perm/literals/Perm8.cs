//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;    

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 8 symbols
    /// </summary>
    public enum Perm8 : uint
    {
        /// <summary>
        /// Identifies the first permutation symbol
        /// </summary>
        A = 0b000,

        /// <summary>
        /// Identifies the second permutation symbol
        /// </summary>
        B = 0b001,

        /// <summary>
        /// Identifies the third permutation symbol
        /// </summary>
        C = 0b010,

        /// <summary>
        /// Identifies the fourth permutation symbol
        /// </summary>
        D = 0b011, 

        /// <summary>
        /// Identifies the fifth permutation symbol
        /// </summary>
        E = 0b100, 

        /// <summary>
        /// Identifies the sixth permutation symbol
        /// </summary>
        F = 0b101, 

        /// <summary>
        /// Identifies the seventh permutation symbol
        /// </summary>
        G = 0b110, 

        /// <summary>
        /// Identifies the eighth permutation symbol
        /// </summary>
        H = 0b111, 

        /// <summary>
        /// Represents the 8 symbol identity permutation
        /// </summary>
        Identity = A | B << 3 | C << 6 | D << 9 | E << 12 | F << 15 | G << 18 | H << 21,

        /// <summary>
        /// Represents the reversed 8 symbol identity permutation
        /// </summary>
        Reverse =  H | G << 3 | F << 6 | E << 9 | D << 12 | C << 15 | B << 18 | A << 21,
    }
}