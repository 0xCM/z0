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
    using static nfunc;

    public static class NatGridExtend    
    {

        /// <summary>
        /// Fills a tabular span of natural dimensions with streamed elements
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The column dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void StreamTo<M,N,T>(this IEnumerable<T> src, in NatGrid<M,N,T> dst)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Take(nati<M>() *nati<N>()).StreamTo(dst.Data);

        public static Span<T> Map<M,N,S,T>(this in NatGrid<M,N,S> src, Func<S, T> f)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where S : unmanaged
            where T : unmanaged
        {
            var dst = NatGrid.alloc<M,N,T>();
            var m = nfunc.nati<M>();
            var n = nfunc.nati<N>();
            for(var i=0; i < m; i++)
            for(var j=0; j < n; j++)
                dst[i,j] = f(src[i,j]);
            return dst;
        }

        [MethodImpl(Inline)]
        static T Reduce<T>(Span<T> src, Func<T,T,T> f)
            => src.ReadOnly().Reduce(f);        

        public static T Reduce<M,N,T>(this in NatGrid<M,N,T> src, Func<T,T,T> f)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Reduce(src.Data, f);
    }

}