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

    partial class GridPatterns
    {
        [MethodImpl(Inline)]
        public static SubGrid256<M,N,T> stripes<M,N,T>(N256 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Vectors.vbroadcast(w, BitMask.lsb(n64, n2, n1, t));
    }
}