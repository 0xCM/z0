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
        /// Creates a readonly character span from a string
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> span(string src)
            => src;

        /// <summary>
        /// Creates a span from an array
        /// </summary>
        /// <param name="src">A reference to the leading cell</param>
        /// <param name="count">The source cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> span<T>(T[] src)
            => src;

        /// <summary>
        /// Creates a single-cell T-span from a supplied reference
        /// </summary>
        /// <param name="src">A reference to the cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> span<T>(ref T src)
            => CreateSpan(ref src, 1);

        /// <summary>
        /// Creates a bytespan from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<byte> span8u<T>(ref T src)
            where T : struct
                => AsBytes(CreateSpan(ref src, 1));

        /// <summary>
        /// Creates a u16 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<ushort> span16u<T>(ref T src)
            where T : struct
                => cast<ushort>(AsBytes(CreateSpan(ref src, 1)));

        /// <summary>
        /// Creates a u32 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<uint> span32u<T>(ref T src)
            where T : struct
                => cast<uint>(AsBytes(CreateSpan(ref src, 1)));

        /// <summary>
        /// Creates a u64 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<ulong> span64u<T>(ref T src)
            where T : struct            
                => cast<ulong>(AsBytes(CreateSpan(ref src, 1)));

        /// <summary>
        /// Creates a u16 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<char> span16c<T>(ref T src)
            where T : struct
                => cast<char>(AsBytes(CreateSpan(ref src, 1)));
    
        [Op, Closures(UnsignedInts)]
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