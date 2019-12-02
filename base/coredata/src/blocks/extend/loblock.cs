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
        /// Extracts the lower half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 64-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> LoBlock<T>(this Block32<T> src, int block)
            where T : unmanaged
                => new Block16<T>(src.Slice(block * blocklen<T>(n32), blocklen<T>(n16)));

        /// <summary>
        /// Extracts the lower half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 64-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> LoBlock<T>(this Block64<T> src, int block)
            where T : unmanaged
                => new Block32<T>(src.Slice(block * src.BlockLength, blocklen<T>(n32)));

        /// <summary>
        /// Extracts the lower half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 64-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> LoBlock<T>(this Block128<T> src, int block)
            where T : unmanaged
                => new Block64<T>(src.Slice(block * src.BlockLength, blocklen<T>(n64)));
        
        /// <summary>
        /// Extracts the lower half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 64-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> LoBlock<T>(this Block256<T> src, int block)
            where T : unmanaged
                => new Block128<T>(src.Slice(block * src.BlockLength, blocklen<T>(n128)));

        /// <summary>
        /// Extracts the lower half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 64-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock16<T> LoBlock<T>(this ConstBlock32<T> src, int block)
            where T : unmanaged
                => new ConstBlock16<T>(src.Slice(block * src.BlockLength, blocklen<T>(n16)));

        /// <summary>
        /// Extracts the lower half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 64-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock32<T> LoBlock<T>(this ConstBlock64<T> src, int block)
            where T : unmanaged
                => new ConstBlock32<T>(src.Slice(block * src.BlockLength, blocklen<T>(n32)));

        /// <summary>
        /// Extracts the lower half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 64-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock64<T> LoBlock<T>(this ConstBlock128<T> src, int block)
            where T : unmanaged
                => new ConstBlock64<T>(src.Slice(block * src.BlockLength, blocklen<T>(n64)));

        /// <summary>
        /// Extracts the lower half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 256-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock128<T> LoBlock<T>(this ConstBlock256<T> src, int block)
            where T : unmanaged
            => new ConstBlock128<T>(src.Slice(block*src.BlockLength, blocklen<T>(n128)));


    }

}