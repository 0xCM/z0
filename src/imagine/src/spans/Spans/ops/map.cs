//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Spans
    {
        /// <summary>
        /// Maps the elements of a source span to a target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The mapping function</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> map<S,T>(ReadOnlySpan<S> src, Func<S,T> f, Span<T> dst)
        {
            ref readonly var input = ref As.first(src);
            ref var output = ref As.first(dst);
            int count = src.Length;
            
            for(var i=0u; i<count; i++)
                As.seek(output, i)= f(As.skip(in input, i));
            
            return dst;
        }

        /// <summary>
        /// Maps the elements of a source span to a target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The mapping function</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> mapi<S,T>(ReadOnlySpan<S> src, Func<int,S,T> f, Span<T> dst)
        {
            ref readonly var input = ref As.first(src);
            ref var output = ref As.first(dst);
            int count = src.Length;
            
            for(var i=0u; i<count; i++)
                As.seek(output, i)= f((int)i,As.skip(in input, i));
            
            return dst;
        }
    }
}