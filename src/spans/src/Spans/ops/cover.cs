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

    partial class Spans
    {
        /// <summary>
        /// Covers a T-memory segment with a span
        /// </summary>
        /// <param name="pSrc">The memory source</param>
        /// <param name="count">The number of bytes to cover</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> cover<T>(T* pSrc, int count)
            where T : unmanaged
                => MemoryMarshal.CreateSpan(ref Unsafe.AsRef<T>(pSrc), count);

        /// <summary>
        /// Covers a T-memory segment with a readonly span
        /// </summary>
        /// <param name="src">A reference to the leading cell</param>
        /// <param name="count">The number of T-cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> cover<T>(in T src, int count)
            => MemoryMarshal.CreateReadOnlySpan(ref edit(src), count);
    }
}