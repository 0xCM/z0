//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;

    partial class Root
    {        
        /// <summary>
        /// Creates a T-span from an S-reference
        /// </summary>
        /// <param name="src">A reference to the leading source cell</param>
        /// <param name="count">The source cell count</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> span<S,T>(ref S src, int count)
            where T : struct
            where S : struct
                => Cast<S,T>(CreateSpan(ref src, count));

        /// <summary>
        /// Creates a T-span from a single S-reference
        /// </summary>
        /// <param name="src">A reference to the source cell</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> span<S,T>(ref S src)
            where T : struct
            where S : struct
                => Cast<S,T>(CreateSpan(ref src, 1));        
                
        /// <summary>
        /// Creates a span from an array
        /// </summary>
        /// <param name="src">A reference to the leading cell</param>
        /// <param name="count">The source cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(T[] src)
            => src;

        /// <summary>
        /// Creates a single-cell T-span from a supplied reference
        /// </summary>
        /// <param name="src">A reference to the cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(ref T src)
            => CreateSpan(ref src, 1);

        /// <summary>
        /// Creates a bytespan from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<byte> span8u<T>(ref T src)
            where T : struct
                => AsBytes(CreateSpan(ref src, 1));

        /// <summary>
        /// Creates a u16 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ushort> span16u<T>(ref T src)
            where T : struct
                => cast<ushort>(AsBytes(CreateSpan(ref src, 1)));

        /// <summary>
        /// Creates a u32 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<uint> span32u<T>(ref T src)
            where T : struct
                => cast<uint>(AsBytes(CreateSpan(ref src, 1)));

        /// <summary>
        /// Creates a u64 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ulong> span64u<T>(ref T src)
            where T : struct            
                => cast<ulong>(AsBytes(CreateSpan(ref src, 1)));

        /// <summary>
        /// Creates a u16 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<char> span16c<T>(ref T src)
            where T : struct
                => cast<char>(AsBytes(CreateSpan(ref src, 1)));
    
        [Op, Closures(Closure)]
        public static Span<T> span<T>(IEnumerable<T> src)
            => src.ToArray();

        /// <summary>
        /// Creates a u16 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> span16c(ReadOnlySpan<byte> src)
            => cast<char>(src);
    }
}