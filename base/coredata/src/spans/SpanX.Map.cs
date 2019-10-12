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

    partial class SpanExtensions
    {
        /// <summary>
        /// Projects a source span to target span via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> Map<S,T>(this ReadOnlySpan<S> src, Func<S, T> f)
        {
            Span<T> dst = new T[src.Length];
            for(var i= 0; i<src.Length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        /// <summary>
        /// Projects a source span to target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Map<S,T>(this Span<S> src, Func<S, T> f)
            => src.ReadOnly().Map(f);

        /// <summary>
        /// Projects a range of elements from a source span to a target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The length of the segment to project</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> MapRange<S,T>(this ReadOnlySpan<S> src, int offset, int length, Func<S, T> f)
        {
            Span<T> dst = new T[length];
            for (int i = offset; i < length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        /// <summary>
        /// Projects a range of elements from a source span to a target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The length of the segment to project</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> MapRange<S,T>(this Span<S> src, int offset, int length, Func<S, T> f)
            => src.ReadOnly().MapRange(offset,length, f);

        public static Span<T> Map<M,N,S,T>(this Span<M,N,S> src, Func<S, T> f)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where S : unmanaged
            where T : unmanaged
        {
            var dst = NatSpan.Alloc<M,N,T>();
            var m = nfunc.nati<M>();
            var n = nfunc.nati<N>();
            for(var i=0; i < m; i++)
            for(var j=0; j < n; j++)
                dst[i,j] = f(src[i,j]);
            return dst;
        }


    }

}