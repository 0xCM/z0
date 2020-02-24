//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static Stacked;

    partial class Stacks
    {
        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<T> span<T>(ref MemStack64 src, T t = default)
            where T : unmanaged
                => MemoryMarshal.CreateSpan(ref head8(ref src), 8).As<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> span<T>(ref MemStack128 src, T t = default)
            where T : unmanaged
                => MemoryMarshal.CreateSpan(ref head8(ref src), 16).As<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> span<T>(ref MemStack256 src, T t = default)
            where T : unmanaged
                => MemoryMarshal.CreateSpan(ref head8(ref src), 32).As<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<T> span<T>(ref MemStack512 src, T t = default)
            where T : unmanaged
                => MemoryMarshal.CreateSpan(ref head8(ref src), 64).As<byte,T>();

        /// <summary>
        /// Fills a span with data from a stack storage block
        /// </summary>
        /// <param name="src">The stack storage source</param>
        /// <param name="t">A span cell type representative</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<T> span<T>(ref MemStack1024 src, T t = default)
            where T : unmanaged
                => MemoryMarshal.CreateSpan(ref head8(ref src), 128).As<byte,T>();
    }
}