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

    using static zfunc;
    using static As;

    partial class RngX
    {
        public static Fixed8 Fixed(this IPolyrand random, N8 w)
            => random.Next<byte>();

        public static Fixed16 Fixed(this IPolyrand random, N16 w)
            => random.Next<ushort>();

        public static Fixed32 Fixed(this IPolyrand random, N32 w)
            => random.Next<uint>();

        public static Fixed64 Fixed(this IPolyrand random, N64 w)
            => random.Next<ulong>();

        public static Fixed128 Fixed(this IPolyrand random, N128 w)
            => random.NextPair<ulong>();

        public static Fixed256 Fixed(this IPolyrand random, N256 w)
            => (random.Fixed(n128), random.Fixed(n128));

    }

}