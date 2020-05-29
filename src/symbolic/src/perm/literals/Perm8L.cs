//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Perm8L;

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

    partial class PermLits
    {               
        public const Perm8L Perm8Identity = (Perm8L)(
            (uint)A       | (uint)B << 3  | (uint)C << 6  | (uint)D << 9 
          | (uint)E << 12 | (uint)F << 15 | (uint)G << 18 | (uint)H << 21
              );

        public const Perm8L Perm8Reversed = (Perm8L)(
            (uint)H       | (uint)G << 3  | (uint)F << 6  | (uint)E << 9 
          | (uint)D << 12 | (uint)C << 15 | (uint)B << 18 | (uint)A << 21
            );
    }
}