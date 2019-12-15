//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class Perm
    {
        /// <summary>
        /// Defines an untyped identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static PermSpec identity(int n)
            => new PermSpec(range(0, n-1));

        /// <summary>
        /// Defines an identity permutation on n symbols
        /// </summary>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static PermSpec<T> identity<T>(T n)
            where T : unmanaged
                => PermSpec<T>.identity(n);

        /// <summary>
        /// Defines the identity permutation on 4 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline)]
        public static Perm4 identity(N4 n)
            => Perm4.ABCD;

        /// <summary>
        /// Defines the identity permutation on 8 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline)]
        public static Perm8 identity(N8 n)
            => assemble(
                Perm8.A, Perm8.B, Perm8.C, Perm8.D,
                Perm8.E, Perm8.F, Perm8.G, Perm8.H);

        /// <summary>
        /// Defines the identity permutation on 16 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline)]
        public static Perm16 identity(N16 n)
            => assemble(
                Perm16.X0, Perm16.X1, Perm16.X2, Perm16.X3,
                Perm16.X4, Perm16.X5, Perm16.X6, Perm16.X7,
                Perm16.X8, Perm16.X9, Perm16.XA, Perm16.XB,
                Perm16.XC, Perm16.XD, Perm16.XE, Perm16.XF);
    }
}