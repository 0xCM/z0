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

    using static Memories;

    partial class MemoryOps
    {
        /// <summary>
        /// Constructs a span of specified length from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="length">The length of the result span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this IEnumerable<T> src, int length)
            => src.Take(length).ToArray();            

        /// <summary>
        /// Constructs a span of specified length from the sequence obtained by skipping a specified number of leading elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <param name="length">The length of the result span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static Span<T> ToSpan<T>(this IEnumerable<T> src, int offset, int length)
            => src.Skip(offset).Take(length).ToArray();            

        public static Span<T> ToSpan<T>(this ISet<T> src)
        {
            var dst = Spans.alloc<T>(src.Count);
            var i = 0;
            foreach(var item in src)
                dst[i++] = item;
            return dst;
        }


        /// <summary>
        /// Constructs a span of specified length from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="length">The length of the result span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this IEnumerable<T> src, int length)
            => src.ToSpan(length);

        /// <summary>
        /// Constructs a span of specified length from the sequence obtained by skipping a specified number of leading elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="skip">The number of elements to skip</param>
        /// <param name="length">The length of the result span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this IEnumerable<T> src, int skip, int length)
            => src.ToSpan(skip,length);

        /// <summary>
        /// Constructs a span from a (presumeably finite) sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="offset">The number of elements to skip from the head of the sequence</param>
        /// <param name="length">The number of elements to take from the sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this IEnumerable<T> src)            
            => src.ToSpan();

        /// <summary>
        /// Constructs a span from an aray
        /// </summary>
        /// <param name="src">The source aray</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this T[] src)
            => src;
    }
}