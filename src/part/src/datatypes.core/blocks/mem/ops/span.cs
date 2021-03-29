//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class MemBlocks
    {
        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref Block4 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 4));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref Block8 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 8));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block10 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 10));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block11 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 11));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block12 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 12));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block13 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 13));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block14 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 14));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block15 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 15));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block16 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 16));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block32 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 32));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref Block64 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 64));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref Block128 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 128));
    }
}