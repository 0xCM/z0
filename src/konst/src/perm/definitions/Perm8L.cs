//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Sym = Perm8Sym;

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 8 symbols
    /// </summary>
    public enum Perm8L : uint
    {
        /// <summary>
        /// Identifies the first permutation symbol
        /// </summary>
        A = Sym.A,

        /// <summary>
        /// Identifies the second permutation symbol
        /// </summary>
        B = Sym.B,

        /// <summary>
        /// Identifies the third permutation symbol
        /// </summary>
        C = Sym.C,

        /// <summary>
        /// Identifies the fourth permutation symbol
        /// </summary>
        D = Sym.D, 

        /// <summary>
        /// Identifies the fifth permutation symbol
        /// </summary>
        E = Sym.E, 

        /// <summary>
        /// Identifies the sixth permutation symbol
        /// </summary>
        F = Sym.F, 

        /// <summary>
        /// Identifies the seventh permutation symbol
        /// </summary>
        G = Sym.G, 

        /// <summary>
        /// Identifies the eighth permutation symbol
        /// </summary>
        H = Sym.H, 
    }
}