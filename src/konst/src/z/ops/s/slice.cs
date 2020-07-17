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
    
    partial struct z
    {
        /// <summary>
        /// Selects a segment [offset, length(src) - 1] from a source span src:ReadOnlySpan[T]
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, uint offset)
            => cover(skip(src,offset), (uint)(src.Length - offset));

        /// <summary>
        /// Selects a segment [offset, length(src) - 1] from a source span src:ReadOnlySpan[T]
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, int offset)
            => cover(skip(src,(uint)offset), src.Length - offset);

        /// <summary>
        /// Draws a specified count of T-cells from a source span beginning at a specified offset
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <param name="length"></param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, int offset, int length)
            => cover(skip(src,(uint)offset), length);

        /// <summary>
        /// Draws a specified count of T-cells from a source span beginning at a specified offset
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <param name="length"></param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, uint offset, uint length)
            => cover(skip(src, offset), length);

        /// <summary>
        /// Selects a segment [offset, length(src) - 1] from a source span src:Span[T]
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> slice<T>(Span<T> src, int offset)
            => CreateSpan(ref seek(first(src), offset), src.Length - offset);

        /// <summary>
        /// Selects a segment [offset, length(src) - 1] from a source span src:Span[T]
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> slice<T>(Span<T> src, uint offset)
            => CreateSpan(ref seek(first(src), offset), (int)(src.Length - offset));

        /// <summary>
        /// Draws a specified count of T-cells from a source span beginning at a specified offset
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <param name="length"></param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> slice<T>(Span<T> src, int offset, int length)
            => CreateSpan(ref seek(first(src), offset), length);

        /// <summary>
        /// Draws a specified count of T-cells from a source span beginning at a specified offset
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <param name="length"></param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> slice<T>(Span<T> src, uint offset, uint length)
            => CreateSpan(ref seek(first(src), offset), (int)length);      

        /// <summary>
        /// Extracts a substring beginning at a specified offset
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline)]
        public static string slice(string src, int offset)
            => src.Substring(offset);        

        /// <summary>
        /// Extracts a substring beginning at a specified offset
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, uint offset)
            => src.Substring((int)offset);        

        /// <summary>
        /// Extracts a substring of specified length beginning at a specified offset
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, uint offset, uint length)
            => src.Substring((int)offset, (int)length);        

        /// <summary>
        /// Extracts a substring of specified length beginning at a specified offset
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline)]
        public static string slice(string src, int offset, int length)
            => src.Substring(offset, length);        
    }
}