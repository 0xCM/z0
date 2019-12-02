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
        public static Block32<T> Block<T>(this Block32<T> src, int block)
            where T : unmanaged
                => new Block32<T>(src.Slice(block * blocklen<T>(n32), blocklen<T>(n32)));

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Block<T>(this Block64<T> src, int block)
            where T : unmanaged
                => new Block64<T>(src.Slice(block * blocklen<T>(n64), blocklen<T>(n64)));

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Block<T>(this Block128<T> src, int block)
            where T : unmanaged
                => new Block128<T>(src.Slice(block * blocklen<T>(n128), blocklen<T>(n128)));

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Block<T>(this Block256<T> src, int block)
            where T : unmanaged
                => new Block256<T>(src.Slice(block * blocklen<T>(n256), blocklen<T>(n256)));

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock32<T> Block<T>(this ConstBlock32<T> src, int block)
            where T : unmanaged
                => new ConstBlock32<T>(src.Data.Slice(block * blocklen<T>(n32), blocklen<T>(n32)));

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock64<T> Block<T>(this ConstBlock64<T> src, int block)
            where T : unmanaged
                => new ConstBlock64<T>(src.Data.Slice(block * blocklen<T>(n64), blocklen<T>(n64)));

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock128<T> Block<T>(this ConstBlock128<T> src, int block)
            where T : unmanaged
                => new ConstBlock128<T>(src.Data.Slice(block * blocklen<T>(n128), blocklen<T>(n128)));

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock256<T> Block<T>(this ConstBlock256<T> src, int block)
            where T : unmanaged
                => new ConstBlock256<T>(src.Data.Slice(block * blocklen<T>(n256), blocklen<T>(n256)));        
    }
}