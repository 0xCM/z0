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

    partial class Spans
    {
        /// <summary>
        /// Covers a memory segment with a generic span
        /// </summary>
        /// <param name="pSrc">The memory source</param>
        /// <param name="size">The number of bytes to cover</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> cover<T>(T* pSrc, int size)
            where T : unmanaged
                => new Span<T>(pSrc, size);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> cover<T>(in T src, int length)
            => MemoryMarshal.CreateReadOnlySpan(ref edit(src), length);

    }
}