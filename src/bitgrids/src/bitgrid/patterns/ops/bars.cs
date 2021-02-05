//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class GridPatterns
    {
        [MethodImpl(Inline)]
        public static SubGrid256<M,N,T> bars<M,N,T>(N256 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var sep = (int)TypeNats.nat64u(n);
            var pattern = BitMasks.lo(sep, z64) << sep;
            return generic<T>(cpu.vbroadcast(w, gbits.replicate(pattern)));
        }
    }
}