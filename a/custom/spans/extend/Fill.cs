//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    using api = Z0.NatSpan;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static void Fill<N,T>(this in NatSpan<N,T> dst, T data)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => api.broadcast(data, dst);
    }
}