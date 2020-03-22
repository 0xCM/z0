//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static partial class FixedRngOps
    {
        public static NatSpan<N,T> Contract<N,T>(this NatSpan<N,T> src, NatSpan<N,T> max)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = Z0.NatSpan.alloc<N, T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Scale.contract(src[i],max[i]);
            return dst;
        }
   }
}