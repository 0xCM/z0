//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    partial struct zfunc
    {
        /// <summary>
        /// Projects a sequence of <typeparamref name='S'/> cells into an allocated <typeparamref name='T'/> indexed cell receiver
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static T[] mapi<S,T>(IEnumerable<S> seq, Func<int,S,T> f)
        {
            var src = @readonly(seq.Array());
            var count = src.Length;
            var buffer = new T[count];
            var dst = span(buffer);
            for (var i=0; i<count; i++)
                seek(dst,i) = f(i, skip(src,i));
            return buffer;
        }

        /// <summary>
        /// Projects a sequence of <typeparamref name='S'/> cells into a caller-supplied <typeparamref name='T'/> cell receiver
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> mapi<S,T>(ReadOnlySpan<S> src, Func<int,S,T> f, Span<T> dst)
        {
            ref readonly var input = ref first(src);
            ref var output = ref first(dst);
            var count = Math.Min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                seek(output, i)= f((int)i, skip(in input, i));
            return dst;
        }
    }
}