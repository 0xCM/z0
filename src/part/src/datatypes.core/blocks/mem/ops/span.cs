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
        public static unsafe Span<T> span<T>(ref Block3 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block3.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref Block4 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block4.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref Block5 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block5.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref Block6 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block6.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref Block8 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block8.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block10 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block10.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block11 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block11.Size));

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
                => recover<T>(cover(u8(src), Block15.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block16 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block16.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block17 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 17));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block18 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block18.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block19 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block19.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block20 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block20.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block24 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block24.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref Block32 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block32.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref Block64 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), Block64.Size));

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