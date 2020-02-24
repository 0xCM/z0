//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static blocks;

    partial class BlockExtend    
    {
        /// <summary>
        /// Extracts the lower half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 64-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> LoBlock<T>(this in Block128<T> src, int block)
            where T : unmanaged
                => src.Slice(block * src.BlockLength, blocklen<T>(n64));

        /// <summary>
        /// Extracts the upper half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 64-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> HiBlock<T>(this in Block128<T> src, int block)
            where T : unmanaged
                => src.Slice(block * src.BlockLength + blocklen<T>(n64), blocklen<T>(n64));
    }

}