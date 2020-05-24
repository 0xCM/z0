//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

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
    }
}