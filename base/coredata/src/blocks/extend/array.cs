//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static DataBlocks;

    partial class BlockExtend    
    {

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in Block32<T> src, int block)
            where T : unmanaged
                => src.SpanBlock(block).ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in Block64<T> src, int block)
            where T : unmanaged
                => src.SpanBlock(block).ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in Block128<T> src, int block)
            where T : unmanaged
                => src.SpanBlock(block).ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in Block256<T> src, int block)
            where T : unmanaged
                => src.SpanBlock(block).ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in ConstBlock32<T> src, int block)
            where T : unmanaged
                => src.SpanBlock(block).ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in ConstBlock64<T> src, int block)
            where T : unmanaged
                => src.SpanBlock(block).ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in ConstBlock128<T> src, int block)
            where T : unmanaged
                => src.SpanBlock(block).ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in ConstBlock256<T> src, int block)
            where T : unmanaged
                => src.SpanBlock(block).ToArray();
 
        /// <summary>
        /// Extracts all container blocks to a contiguous array
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in Block32<T> src)
            where T : unmanaged
                => src.data.ToArray();

        /// <summary>
        /// Extracts all container blocks to a contiguous array
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in Block64<T> src)
            where T : unmanaged
                => src.data.ToArray();

        /// <summary>
        /// Extracts all container blocks to a contiguous array
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in Block128<T> src)
            where T : unmanaged
                => src.data.ToArray();

        /// <summary>
        /// Extracts all container blocks to a contiguous array
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in Block256<T> src)
            where T : unmanaged
                => src.data.ToArray();

        /// <summary>
        /// Extracts all container blocks to a contiguous array
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in ConstBlock32<T> src)
            where T : unmanaged
                => src.data.ToArray();

        /// <summary>
        /// Extracts all container blocks to a contiguous array
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in ConstBlock64<T> src)
            where T : unmanaged
                => src.data.ToArray();

        /// <summary>
        /// Extracts all container blocks to a contiguous array
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in ConstBlock128<T> src)
            where T : unmanaged
                => src.data.ToArray();

        /// <summary>
        /// Extracts all container blocks to a contiguous array
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this in ConstBlock256<T> src)
            where T : unmanaged
                => src.data.ToArray();

        [MethodImpl(Inline)]
        public static T[] ToArray<N,T>(this in NatBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.data.ToArray(); 
 
    }

}