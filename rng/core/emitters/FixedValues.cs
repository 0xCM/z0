//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    partial class CoreRngOps
    {
        [MethodImpl(Inline)]
        public static Fixed8 Fixed(this IPolyrand random, N8 w)
            => random.Next<byte>();

        [MethodImpl(Inline)]
        public static Fixed16 Fixed(this IPolyrand random, N16 w)
            => random.Next<ushort>();

        [MethodImpl(Inline)]
        public static Fixed32 Fixed(this IPolyrand random, N32 w)
            => random.Next<uint>();

        [MethodImpl(Inline)]
        public static Fixed64 Fixed(this IPolyrand random, N64 w)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static Fixed128 Fixed(this IPolyrand random, N128 w)
            => random.NextPair<ulong>();

        [MethodImpl(Inline)]
        public static Fixed256 Fixed(this IPolyrand random, N256 w)
            =>  (random.Fixed(n128), random.Fixed(n128));

        [MethodImpl(Inline)]
        public static Fixed512 Fixed(this IPolyrand random, N512 w)
            => (random.Fixed(n256), random.Fixed(n256));
    }    
}