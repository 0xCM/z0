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
        public static NatSpan<N,T> Contract<N,T>(this NatSpan<N,T> src, NatSpan<N,T> max)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = api.alloc<N, T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Numeric.contract(src[i],max[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static void CopyTo<N,T>(this in NatSpan<N,T> src,Span<T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.CopyTo(dst);
    }
}