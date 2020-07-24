//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                    
        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(Numeric8k)]
        public static ref T blockref<T>(in Block8<T> src, int index)
            where T : unmanaged
                => ref add(src.Head, index*src.BlockLength); 

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(Numeric8x16k)]
        public static ref T blockref<T>(in Block16<T> src, int index)
            where T : unmanaged
                => ref add(src.Head, index*src.BlockLength); 

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(Numeric8x16x32k)]
        public static ref T blockref<T>(in Block32<T> src, int index)
            where T : unmanaged
                => ref add(src.Head, index*src.BlockLength); 
        
        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(UnsignedInts)]
        public static ref T blockref<T>(in Block64<T> src, int index)
            where T : unmanaged
                => ref add(src.Head, index*src.BlockLength); 

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(UnsignedInts)]
        public static ref T blockref<T>(in Block128<T> src, int index)
            where T : unmanaged
                => ref add(src.Head, index*src.BlockLength); 

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(UnsignedInts)]
        public static ref T blockref<T>(in Block256<T> src, int index)
            where T : unmanaged
                => ref add(src.Head, index*src.BlockLength); 

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="src">The blocked container</param>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(UnsignedInts)]
        public static ref T blockref<T>(in Block512<T> src, int index)
            where T : unmanaged
                => ref add(src.Head, index*src.BlockLength);
    }
}