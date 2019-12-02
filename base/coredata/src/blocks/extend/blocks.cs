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
        /// Extracts a contiguous sequence of blocks beginning at a specified block index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="firstblock">The block-relative index of the first block</param>
        /// <param name="blockCount">The number of blocks to extract</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Blocks<T>(this Block16<T> src, int firstblock, int blockCount)
            where T : unmanaged
                => new Block16<T>(src.Slice(firstblock * blocklen<T>(n32), blockCount * blocklen<T>(n32)));

        /// <summary>
        /// Extracts a contiguous sequence of blocks beginning at a specified block index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="firstblock">The block-relative index of the first block</param>
        /// <param name="blockCount">The number of blocks to extract</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Blocks<T>(this Block32<T> src, int firstblock, int blockCount)
            where T : unmanaged
                => new Block32<T>(src.Slice(firstblock * blocklen<T>(n32), blockCount * blocklen<T>(n32)));

        /// <summary>
        /// Extracts a contiguous sequence of blocks beginning at a specified block index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="firstblock">The block-relative index of the first block</param>
        /// <param name="blockCount">The number of blocks to extract</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Blocks<T>(this Block64<T> src, int firstblock, int blockCount)
            where T : unmanaged
                => new Block64<T>(src.Slice(firstblock * blocklen<T>(n64), blockCount * blocklen<T>(n64)));
        
        /// <summary>
        /// Extracts a contiguous sequence of blocks beginning at a specified block index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="firstblock">The block-relative index of the first block</param>
        /// <param name="blockCount">The number of blocks to extract</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Blocks<T>(this Block128<T> src, int firstblock, int blockCount)
            where T : unmanaged
                => new Block128<T>(src.Slice(firstblock * blocklen<T>(n128), blockCount * blocklen<T>(n128)));

        /// <summary>
        /// Extracts a contiguous sequence of blocks beginning at a specified block index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="firstblock">The block-relative index of the first block</param>
        /// <param name="blockCount">The number of blocks to extract</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Blocks<T>(this Block256<T> src, int firstblock, int blockCount)
            where T : unmanaged
                => new Block256<T>(src.Slice(firstblock *  blocklen<T>(n256) , blockCount * blocklen<T>(n256)));

        /// <summary>
        /// Extracts a contiguous sequence of blocks beginning at a specified block index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="firstblock">The block-relative index of the first block</param>
        /// <param name="blockCount">The number of blocks to extract</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock16<T> Blocks<T>(this ConstBlock16<T> src,int firstblock, int blockCount)
            where T : unmanaged
                => new ConstBlock16<T>(src.Data.Slice(firstblock * blocklen<T>(n32), blockCount * blocklen<T>(n32)));

        /// <summary>
        /// Extracts a contiguous sequence of blocks beginning at a specified block index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="firstblock">The block-relative index of the first block</param>
        /// <param name="blockCount">The number of blocks to extract</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock32<T> Blocks<T>(this ConstBlock32<T> src,int firstblock, int blockCount)
            where T : unmanaged
                => new ConstBlock32<T>(src.Data.Slice(firstblock * blocklen<T>(n32), blockCount * blocklen<T>(n32)));

        /// <summary>
        /// Extracts a contiguous sequence of blocks beginning at a specified block index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="firstblock">The block-relative index of the first block</param>
        /// <param name="blockCount">The number of blocks to extract</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock64<T> Blocks<T>(this ConstBlock64<T> src,int firstblock, int blockCount)
            where T : unmanaged
                => new ConstBlock64<T>(src.Data.Slice(firstblock * blocklen<T>(n64), blockCount * blocklen<T>(n64)));

        /// <summary>
        /// Extracts a contiguous sequence of blocks beginning at a specified block index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="firstblock">The block-relative index of the first block</param>
        /// <param name="blockCount">The number of blocks to extract</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock128<T> Blocks<T>(this ConstBlock128<T> src,int firstblock, int blockCount)
            where T : unmanaged
                => new ConstBlock128<T>(src.Data.Slice(firstblock * blocklen<T>(n128), blockCount * blocklen<T>(n128)));
            
        /// <summary>
        /// Extracts a contiguous sequence of blocks beginning at a specified block index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="firstblock">The block-relative index of the first block</param>
        /// <param name="blockCount">The number of blocks to extract</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock256<T> Blocks<T>(this ConstBlock256<T> src,int firstblock, int blockCount)
            where T : unmanaged
                => new ConstBlock256<T>(src.Data.Slice(firstblock * blocklen<T>(n256), blockCount * blocklen<T>(n256)));
    }

}