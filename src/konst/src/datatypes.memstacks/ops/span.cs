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

    partial class MemoryStacks
    {
        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref BitBlock64 src)
            where T : unmanaged
                => cover(u8(src), 8).Recover<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref BitBlock128 src)
            where T : unmanaged
                => cover(u8(src), 16).Recover<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref BitBlock256 src)
            where T : unmanaged
                => cover(u8(src), 32).Recover<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref BitBlock512 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 64));

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> span<T>(ref BitBlock1024 src)
            where T : unmanaged
                => recover<T>(cover(u8(src), 128));
    }
}