//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static Widths;

    partial class XBlocks    
    {
        /// <summary>
        /// Extracts the upper half of an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The 64-bit block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> HiBlock<T>(this in Block128<T> src, int block)
            where T : unmanaged
                => src.Slice(block * src.BlockLength + Blocks.length<T>(w64), Blocks.length<T>(w64));
    }
}