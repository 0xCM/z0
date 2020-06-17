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
    using static Memories;

    partial class Permute
    {
        [MethodImpl(Inline), Op]
        public static NatPerm<N> natidentity<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatPerm<N>.Identity;

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Perm16 videntity(W128 w)
            => new Perm16(Data.vincrements<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Perm16 vreversed(W128 w)
            => new Perm16(Data.decrements<byte>(w));

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Perm32 videntity(W256 w)
            => new Perm32(Data.vincrements<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Perm32 vreversed(W256 w)
            => new Perm32(Data.decrements<byte>(w));
    }
}