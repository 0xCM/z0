//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static memory;

    partial struct root
    {
        /// <summary>
        /// Procduces a possibly-empty but finite value stream
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="src">The items included in the stream</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(params T[] src)
            => src;

        /// <summary>
        /// Procduces a nonempty finite value stream
        /// </summary>
        /// <param name="head">The first stream element</param>
        /// <param name="tail">The remaining stream elements</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(T head, params T[] tail)
        {
            var count = tail.Length + 1;
            var buffer = sys.alloc<T>(count);
            var dst = span(buffer);
            var src = span(tail);
            seek(dst, 0) = head;
            for(var i=1u; i<count; i++)
                seek(dst, i) = skip(src, i);

            return buffer;
        }

        /// <summary>
        /// Procduces an output stream by concatenating two input streams
        /// </summary>
        /// <param name="head">The first stream</param>
        /// <param name="tail">The second stream</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(IEnumerable<T> head, IEnumerable<T> tail)
            => head.Concat(tail);

        /// <summary>
        /// Produces a nonempty stream
        /// </summary>
        /// <param name="head">The first element of the new stream</param>
        /// <param name="tail">The remaining elements of the new stream</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(T head, IEnumerable<T> tail)
            => stream(head).Concat(tail);

        /// <summary>
        /// Procduces an output stream by concatenating three input streams
        /// </summary>
        /// <param name="s1">The first stream</param>
        /// <param name="s2">The second stream</param>
        /// <param name="s3">The third stream</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(IEnumerable<T> s1, IEnumerable<T> s2, IEnumerable<T> s3)
            => s1.Concat(s2).Concat(s3);

        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static IEnumerable<T> stream<T>(T min, T max)
            where T : unmanaged
        {
            var _min = memory.bw64(min);
            var _max = memory.bw64(max);
            var current = _min;
            var storage = z64;
            var dst = default(T);

            while(current < _max)
            {
                storage = current++;
                dst = memory.@as<ulong,T>(storage);
                yield return dst;
            }
        }
    }
}