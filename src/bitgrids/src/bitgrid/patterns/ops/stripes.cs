//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class GridPatterns
    {
        [MethodImpl(Inline)]
        public static SubGrid256<M,N,T> stripes<M,N,T>(N256 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => z.vbroadcast(w, BitMasks.lsb(n64, n2, n1, t));
    }
}