//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class BitBlocks
    {
        /// <summary>
        /// Allocates a block and populates it with a pattern, if supplied
        /// </summary>
        /// <param name="n">The bitblock width representative</param>
        /// <param name="fill">The fill value</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static BitBlock<N,T> alloc<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var block = new BitBlock<N,T>(new T[BitBlock<N,T>.NeededCells], true);
            block.Data.Fill(t);
            return block;
        }
    }
}