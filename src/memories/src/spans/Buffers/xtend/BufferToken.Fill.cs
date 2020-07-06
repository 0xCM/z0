//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;

    partial class XTend
    {
        /// <summary>
        /// Fills a token-identified buffer with data from a source span and returns the target memory to the caller as a span
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static unsafe Span<T> Fill<T>(this IBufferToken dst, ReadOnlySpan<T> src)
            where T : unmanaged
                => Buffers.fill<T>(src, dst);

        /// <summary>
        /// Fills a token-identified buffer with data from an array and returns the target memory to the caller as a span
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static unsafe Span<T> Fill<T>(this IBufferToken dst, T[] src)
            where T : unmanaged
                => Buffers.fill<T>(src, dst);                
    }
}