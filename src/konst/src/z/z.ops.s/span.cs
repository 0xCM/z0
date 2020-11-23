//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static Konst;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct z
    {
        /// <summary>
        /// Creates a T-span from an S-reference
        /// </summary>
        /// <param name="src">A reference to the leading source cell</param>
        /// <param name="count">The source cell count</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> span<S,T>(ref S src, int count)
            where T : struct
            where S : struct
                => Cast<S,T>(CreateSpan(ref src, count));

        /// <summary>
        /// Creates a T-span from a single S-reference
        /// </summary>
        /// <param name="src">A reference to the source cell</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> span<S,T>(ref S src)
            where T : struct
            where S : struct
                => Cast<S,T>(CreateSpan(ref src, 1));

        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(long count)
            => sys.span<T>((uint)count);

        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(uint count)
            => sys.span<T>(count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ulong count)
            => sys.span<T>((uint)count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(IEnumerable<T> src)
            => sys.array(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(T[] src)
            => src;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> span(string src)
            => src;

        /// <summary>
        /// Constructs a span from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ReadOnlySpan<T> src)
            => src.ToArray();

        /// <summary>
        /// Constructs a span of specified length from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="length">The length of the result span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(IEnumerable<T> src, Count length)
            => src.Take(length).Array();

        /// <summary>
        /// Constructs a span of specified length from the sequence obtained by skipping a specified number of leading elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <param name="length">The length of the result span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(IEnumerable<T> src, int offset, int length)
            => src.Skip(offset).Take(length).Array();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(HashSet<T> src)
        {
            var dst = span<T>(src.Count);
            var i = 0u;
            foreach(var item in src)
                seek(dst, i++) = item;
            return dst;
        }
    }
}