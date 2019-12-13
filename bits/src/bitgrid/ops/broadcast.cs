//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {
        /// <summary>
        /// Fills a caller-allocated generic grid
        /// </summary>
        /// <param name="cell">The data to replicate across all grid cells</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid<T> broadcast<T>(T cell, in BitGrid<T> dst)            
            where T : unmanaged
        {
            dst.Data.Fill(cell);
            return ref dst;
        }

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> broadcast<M,N,T>(T cell, in BitGrid32<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => ginxs.broadcast<T,uint>(cell);

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> broadcast<M,N,T>(T cell, in BitGrid64<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => ginxs.broadcast(cell, out ulong _);

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> broadcast<M,N,T>(T cell, in BitGrid128<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => vbuild.broadcast(n128,cell);
    
        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> broadcast<M,N,T>(T cell, in BitGrid256<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => vbuild.broadcast(n256,cell);

        /// <summary>
        /// Fills a caller-allocated natural grid
        /// </summary>
        /// <param name="cell">The data to replicate across all grid cells</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid<M,N,T> broadcast<M,N,T>(T cell, in BitGrid<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            dst.Data.Fill(cell);
            return ref dst;
        }
    }
}