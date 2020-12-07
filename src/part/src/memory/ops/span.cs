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
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct memory
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
            => new T[count];

        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(uint count)
            => sys.alloc<T>(count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ulong count)
            => sys.alloc<T>(count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(IEnumerable<T> src)
            => src.ToArray();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(params T[] src)
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

    }
}