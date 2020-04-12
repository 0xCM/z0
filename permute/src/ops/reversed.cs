//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class Permute
    {
        /// <summary>
        /// Defines the canonical literal representation of the reversal of the identity permutation on 4 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        public static Perm4L reversed(N4 n)
            => Perm4L.DCBA;

        /// <summary>
        /// Defines the canonical literal representation of the reversal of the identity permutation on 8 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline)]
        public static Perm8L reversed(N8 n)
            => assemble(
                Perm8L.H, Perm8L.G, Perm8L.F, Perm8L.E,
                Perm8L.D, Perm8L.C, Perm8L.B, Perm8L.A);

        /// <summary>
        /// Returns the canonical literal representation of the reversal of the identity permutation on 16 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        public static Perm16L reversed(N16 n)
            => assemble(
                Perm16L.XF,Perm16L.XE,Perm16L.XD,Perm16L.XC,
                Perm16L.XB,Perm16L.XA,Perm16L.X9,Perm16L.X8,
                Perm16L.X7,Perm16L.X6,Perm16L.X5,Perm16L.X4,
                Perm16L.X3,Perm16L.X2,Perm16L.X1,Perm16L.X0);
    }
}