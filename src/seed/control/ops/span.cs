//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    partial class Control
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> span(string src)
            => src;

        /// <summary>
        /// Creates a T-span from a supplied reference
        /// </summary>
        /// <param name="src">A reference to the leading cell</param>
        /// <param name="count">The source cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> span<T>(ref T src, int count)
            => MemoryMarshal.CreateSpan(ref src, count);

        /// <summary>
        /// Creates a single-cell T-span from a supplied reference
        /// </summary>
        /// <param name="src">A reference to the cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> span<T>(ref T src)
            => MemoryMarshal.CreateSpan(ref src, 1);

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
                => MemoryMarshal.Cast<S,T>(MemoryMarshal.CreateSpan(ref src, count));

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
                => MemoryMarshal.Cast<S,T>(MemoryMarshal.CreateSpan(ref src, 1));
    }
}