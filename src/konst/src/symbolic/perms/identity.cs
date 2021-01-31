//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct PermSymbolic
    {
        /// <summary>
        /// Defines the identity permutation on 4 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline), Op]
        public static Perm4L identity(N4 n)
            => Perm4L.ABCD;

        /// <summary>
        /// Defines the identity permutation on 8 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline), Op]
        public static Perm8L identity(N8 n)
            => assemble(
                Perm8L.A, Perm8L.B, Perm8L.C, Perm8L.D,
                Perm8L.E, Perm8L.F, Perm8L.G, Perm8L.H);

        /// <summary>
        /// Defines the identity permutation on 16 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline), Op]
        public static Perm16L identity(N16 n)
            => assemble(
                Perm16L.X0, Perm16L.X1, Perm16L.X2, Perm16L.X3,
                Perm16L.X4, Perm16L.X5, Perm16L.X6, Perm16L.X7,
                Perm16L.X8, Perm16L.X9, Perm16L.XA, Perm16L.XB,
                Perm16L.XC, Perm16L.XD, Perm16L.XE, Perm16L.XF);

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Perm16 identity(W128 w)
            => new Perm16(gcpu.vinc<byte>(w));

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Perm32 identity(W256 w)
            => new Perm32(gcpu.vinc<byte>(w));
    }
}