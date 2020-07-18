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
        public static unsafe Span<T> span<T>(ref BitBlock64 src, T t = default)
            where T : unmanaged
                => z.cover(z.u8(src), 8).Cast<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> span<T>(ref BitBlock128 src, T t = default)
            where T : unmanaged
                => z.cover(z.u8(src), 16).Cast<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> span<T>(ref BitBlock256 src, T t = default)
            where T : unmanaged
                => z.cover(z.u8(src), 32).Cast<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> span<T>(ref BitBlock512 src, T t = default)
            where T : unmanaged
                => z.recover<T>(z.cover(z.u8(src), 64));

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> span<T>(ref BitStack1024 src, T t = default)
            where T : unmanaged
                => z.recover<T>(z.cover(z.u8(src), 128));

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack2 src)
            => z.cover(head(ref src), 2);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack4 src)
            => z.cover(head(ref src), 4);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack8 src)
            => z.cover(head(ref src), 8);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack16 src)
            => z.cover(head(ref src), 16);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack32 src)
            => z.cover(head(ref src), 32);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack64 src)
            => z.cover(head(ref src), 64); 
    }
}