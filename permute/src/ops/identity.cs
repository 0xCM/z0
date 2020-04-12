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
        /// Defines an untyped identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static Perm identity(int n)
            => new Perm(Numeric.range(0, n-1));

        /// <summary>
        /// Defines an identity permutation on n symbols
        /// </summary>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Perm<T> identity<T>(T n)
            where T : unmanaged
                => new Perm<T>(Numeric.range(default, gmath.dec(n)));

        /// <summary>
        /// Defines the identity permutation on 4 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline)]
        public static Perm4L identity(N4 n)
            => Perm4L.ABCD;

        /// <summary>
        /// Defines the identity permutation on 8 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline)]
        public static Perm8L identity(N8 n)
            => assemble(
                Perm8L.A, Perm8L.B, Perm8L.C, Perm8L.D,
                Perm8L.E, Perm8L.F, Perm8L.G, Perm8L.H);

        /// <summary>
        /// Defines the identity permutation on 16 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline)]
        public static Perm16L identity(N16 n)
            => assemble(
                Perm16L.X0, Perm16L.X1, Perm16L.X2, Perm16L.X3,
                Perm16L.X4, Perm16L.X5, Perm16L.X6, Perm16L.X7,
                Perm16L.X8, Perm16L.X9, Perm16L.XA, Perm16L.XB,
                Perm16L.XC, Perm16L.XD, Perm16L.XE, Perm16L.XF);
    }
}