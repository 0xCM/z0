//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Widths;

    partial class XRng
    {
        [MethodImpl(Inline)]
        public static Fixed8 Fixed(this IPolyrand random, W8 w)
            => random.Next<byte>();

        [MethodImpl(Inline)]
        public static Fixed16 Fixed(this IPolyrand random, W16 w)
            => random.Next<ushort>();

        [MethodImpl(Inline)]
        public static Fixed32 Fixed(this IPolyrand random, W32 w)
            => random.Next<uint>();

        [MethodImpl(Inline)]
        public static Fixed64 Fixed(this IPolyrand random, W64 w)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static Fixed128 Fixed(this IPolyrand random, W128 w)
            => random.NextPair<ulong>();

        [MethodImpl(Inline)]
        public static Fixed256 Fixed(this IPolyrand random, W256 w)
            =>  (random.Fixed(w128), random.Fixed(w128));

        [MethodImpl(Inline)]
        public static Fixed512 Fixed(this IPolyrand random, W512 w)
            => (random.Fixed(w256), random.Fixed(w256));
    }
}