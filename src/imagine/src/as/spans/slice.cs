//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.InteropServices.MemoryMarshal;

    using static AsInternal;
    
    partial struct As
    {
        /// <summary>
        /// Selects a segment [offset, length(src) - 1] from a source span src:ReadOnlySpan[T]
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, int offset)
            => cover(skip(src,offset), src.Length - offset);

        /// <summary>
        /// Draws a specified count of T-cells from a source span beginning at a specified offset
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <param name="length"></param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, int offset, int length)
            => cover(skip(src,offset), length);

        /// <summary>
        /// Selects a segment [offset, length(src) - 1] from a source span src:Span[T]
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> slice<T>(Span<T> src, int offset)
            => CreateSpan(ref seek(src,offset), src.Length - offset);

        /// <summary>
        /// Draws a specified count of T-cells from a source span beginning at a specified offset
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <param name="length"></param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> slice<T>(Span<T> src, int offset, int length)
            => CreateSpan(ref seek(src,offset), length);

    }
}