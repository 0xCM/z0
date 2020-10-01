//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static BitMasks.Literals;
    using static z;

    partial class Permute
    {
        /// <summary>
        /// Creates a fixed 16-bit permutation over a generic permutation over 16 elements
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm16 vinit(W128 w, Perm<byte> spec)
            => new Perm16(z.vload(w128, spec.Terms));

        /// <summary>
        /// Creates a fixed 32-bit permutation over a generic permutation over 32 elements
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm32 vinit(W256 w, Perm<byte> src)
            => new Perm32(z.vload(w, src.Terms));

        [MethodImpl(Inline), Op]
        public static Perm16 vspec(Vector128<byte> data)
            => new Perm16(z.vand(data, z.vbroadcast(w128, Msb8x8x3)));

        [MethodImpl(Inline), Op]
        public static Perm32 vspec(Vector256<byte> data)
            => new Perm32(z.vand(data, z.vbroadcast(w256, Msb8x8x3)));
    }
}