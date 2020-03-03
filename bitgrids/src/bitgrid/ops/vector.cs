//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;    

    partial class BitGrid
    {
        /// <summary>
        /// Loads a 256-bit cpu vector from an index-identified block
        /// </summary>
        /// <param name="src">The source grid</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vector<T>(in BitGrid<T> src, int block, N256 n = default)
            where T : unmanaged
                => Vectors.vload(n, in src.data.BlockRef(block));          

        /// <summary>
        /// Loads a 256-bit cpu vector from an index-identified block
        /// </summary>
        /// <param name="src">The source grid</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vector<M,N,T>(in BitGrid<M,N,T> src, int block, N256 n = default)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Vectors.vload(n, in src.data.BlockRef(block));          
    }
}