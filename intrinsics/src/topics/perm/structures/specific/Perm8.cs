//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum Perm8Sym : uint
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

    }

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 8 symbols
    /// </summary>
    public enum Perm8L : uint
    {
        /// <summary>
        /// Identifies the first permutation symbol
        /// </summary>
        A = Perm8Sym.A,

        /// <summary>
        /// Identifies the second permutation symbol
        /// </summary>
        B = Perm8Sym.B,

        /// <summary>
        /// Identifies the third permutation symbol
        /// </summary>
        C = Perm8Sym.C,

        /// <summary>
        /// Identifies the fourth permutation symbol
        /// </summary>
        D = Perm8Sym.D, 

        /// <summary>
        /// Identifies the fifth permutation symbol
        /// </summary>
        E = Perm8Sym.E, 

        /// <summary>
        /// Identifies the sixth permutation symbol
        /// </summary>
        F = Perm8Sym.F, 

        /// <summary>
        /// Identifies the seventh permutation symbol
        /// </summary>
        G = Perm8Sym.G, 

        /// <summary>
        /// Identifies the eighth permutation symbol
        /// </summary>
        H = Perm8Sym.H, 

        /// <summary>
        /// Represents the 8 symbol identity permutation
        /// </summary>
        Identity = A | B << 3 | C << 6 | D << 9 | E << 12 | F << 15 | G << 18 | H << 21,

        /// <summary>
        /// Represents the reversed 8 symbol identity permutation
        /// </summary>
        Reversed =  H | G << 3 | F << 6 | E << 9 | D << 12 | C << 15 | B << 18 | A << 21,
    }
}