//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    readonly partial struct Imagine
    {
        /// <summary>
        /// Creates a readonly span over a specified count of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> span<T>(in T src, int count)
            => CreateReadOnlySpan(ref edit<T>(src), count); 

        /// <summary>
        /// Creates a readonly span of T-counted T-cells from a swath of S-cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The cell count</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> span<S,T>(in S src, int tCount)
            => CreateReadOnlySpan(ref edit<S,T>(src), tCount);

        [MethodImpl(Inline)]
        public static Span<T> cover<S,T>(ref S src, int tCount)
            => CreateSpan(ref edit<S,T>(src), tCount);

    }
}