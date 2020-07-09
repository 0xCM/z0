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
    using static Stacked;

    partial class Stacks
    {
        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> span<T>(ref MemStack64 src, T t = default)
            where T : unmanaged
                => core.cover(head8(ref src), 8).Cast<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> span<T>(ref MemStack128 src, T t = default)
            where T : unmanaged
                => core.cover(head8(ref src), 16).Cast<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> span<T>(ref MemStack256 src, T t = default)
            where T : unmanaged
                => core.cover(head8(ref src), 32).Cast<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> span<T>(ref MemStack512 src, T t = default)
            where T : unmanaged
                => core.recover<T>(core.cover(head8(ref src), 64));

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> span<T>(ref MemStack1024 src, T t = default)
            where T : unmanaged
                => core.recover<T>(core.cover(head8(ref src), 128));

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack2 src)
            => core.cover(head(ref src), 2);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack4 src)
            => core.cover(head(ref src), 4);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack8 src)
            => core.cover(head(ref src), 8);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack16 src)
            => core.cover(head(ref src), 16);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack32 src)
            => core.cover(head(ref src), 32);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack64 src)
            => core.cover(head(ref src), 64); 
    }
}