//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;


    partial class Root
    {
        /// <summary>
        /// Fills a caller-supplied span with data produced by a T-enumerable
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The element type</typeparam>
        public static Span<T> store<T>(IEnumerable<T> src, Span<T> dst)
        {
            var i = 0;
            var e = src.GetEnumerator();
            while(e.MoveNext() && i < dst.Length)
                dst[i++] = e.Current;
            return dst;
        }


        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, int count)
            => ref Add(ref edit(in src), count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
            => ref skip(in AsDeprecated.first(src), count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, int count)
            => ref skip(in AsDeprecated.first(src), count);
    }
}