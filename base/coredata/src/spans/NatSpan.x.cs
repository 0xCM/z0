//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static class NatSpanExtend
    {
        /// <summary>
        /// Presents an unsized span as one of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The target size</param>
        /// <typeparam name="N">The target type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static NatSpan<N,T> NatLoad<N,T>(this Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatSpan.load(src,n);

        /// <summary>
        /// Fills a tabular span of natural dimensions with streamed elements
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The column dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void StreamTo<M,N,T>(this IEnumerable<T> src, in NatSpan<M,N,T> dst)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Take(NatMath.mul<M,N>()).StreamTo(dst.Data);

        public static Span<T> Map<M,N,S,T>(this NatSpan<M,N,S> src, Func<S, T> f)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where S : unmanaged
            where T : unmanaged
        {
            var dst = NatSpan.alloc<M,N,T>();
            var m = nfunc.nati<M>();
            var n = nfunc.nati<N>();
            for(var i=0; i < m; i++)
            for(var j=0; j < n; j++)
                dst[i,j] = f(src[i,j]);
            return dst;
        }

        public static T Reduce<M,N,T>(this NatSpan<M,N,T> src, Func<T,T,T> f)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.ReadOnly().Reduce(f);
    }
}