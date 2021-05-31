//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class ByteBlocks
    {
        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref ByteBlock3 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock3.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref ByteBlock4 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock4.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref ByteBlock5 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock5.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref ByteBlock6 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock6.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref ByteBlock8 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock8.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock10 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock10.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock11 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock11.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock12 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 12));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock13 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 13));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock14 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 14));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock15 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock15.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock16 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock16.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock17 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 17));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock18 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock18.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock19 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock19.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock20 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock20.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock24 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock24.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref ByteBlock32 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock32.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref ByteBlock64 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock64.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref ByteBlock80 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock80.Size));

        /// <summary>
        /// Fills a span with data from a memory block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref ByteBlock128 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), ByteBlock128.Size));
    }
}