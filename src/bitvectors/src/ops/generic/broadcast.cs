//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitVector
    {
        [MethodImpl(Inline)]
        public static BitVector128<N,T> broadcast<N,T>(N128 w, T a, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => z.vbroadcast(w,a);
    }
}