//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Allocates a caller-disposed stream over a string
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="encoding">The text encoding</param>
        public static MemoryStream stream(string src, Encoding encoding = null)
        {
            var bytes = (encoding ?? Encoding.UTF8).GetBytes(src ?? string.Empty);            
            return new MemoryStream(bytes);
        }

        /// <summary>
        /// Procduces a possibly-empty but finite value stream
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="src">The items included in the stream</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(params T[] src)
            where T : struct
                => src;

        /// <summary>
        /// Procduces a nonempty finite value stream
        /// </summary>
        /// <param name="head">The first stream element</param>
        /// <param name="tail">The remaining stream elements</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(T head, params T[] tail)
            where T : struct
        {
            var count = tail.Length + 1;
            var buffer = alloc<T>(count);            
            var dst = span(buffer);
            var src = span(tail);
            seek(dst,0) = head;
            for(var i=1u; i<count; i++)
                seek(dst,i) = skip(src,i);
            
            ValueIndex.create(buffer);
            return ValueIndex.create(buffer);
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
        /// <param name="tail">The remaing elements of the new stream</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(T head, IEnumerable<T> tail)
            => seq(head).Concat(tail);

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
    }
}