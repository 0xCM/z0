//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BXTend
    {
        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static ref T BlockRef<T>(this in SpanBlock8<T> src, int index)
            where T : unmanaged
                => ref z.blockref(src,index);

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8x16k)]
        public static ref T BlockRef<T>(this in SpanBlock16<T> src, int index)
            where T : unmanaged
                => ref z.blockref(src,index);

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static ref T BlockRef<T>(this in SpanBlock32<T> src, int index)
            where T : unmanaged
                => ref z.blockref(src,index);

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T BlockRef<T>(this in SpanBlock64<T> src, int index)
            where T : unmanaged
                => ref z.blockref(src,index);

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T BlockRef<T>(this in SpanBlock128<T> src, int index)
            where T : unmanaged
                => ref z.add(src.Head, index*src.BlockLength);

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T BlockRef<T>(this in SpanBlock256<T> src, int index)
            where T : unmanaged
                => ref z.add(src.Head, index*src.BlockLength);

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T BlockRef<T>(this in SpanBlock256<T> src, uint index)
            where T : unmanaged
                => ref z.add(src.Head, (int)index*src.BlockLength);

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T BlockRef<T>(this in SpanBlock512<T> src, int index)
            where T : unmanaged
                => ref z.add(src.Head, index*src.BlockLength);
    }
}