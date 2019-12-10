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
        /// Allocates and fills a dynamically-sized generic grid
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        /// <param name="cell">The data to replicate across all grid cells</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<T> broadcast<T>(int rows, int cols, T cell)            
            where T : unmanaged
        {
            var g = alloc<T>(rows,cols);
            g.Data.Fill(cell);
            return g;
        }

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
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<T> broadcast<T>(N16 w, int rows, int cols, T cell)    
            where T : unmanaged
                => define<T>(w,rows, cols, ginxs.broadcast<T,ushort>(cell));

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> broadcast<T>(N32 w, int rows, int cols, T cell)    
            where T : unmanaged
                => define<T>(w,rows, cols, ginxs.broadcast<T,uint>(cell));

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> broadcast<T>(N64 w, int rows, int cols, T cell)    
            where T : unmanaged
                => define<T>(w,rows, cols, ginxs.broadcast<T,ulong>(cell));

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> broadcast<M,N,T>(N32 w, T cell,  M m = default, N n = default)    
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
        public static BitGrid64<M,N,T> broadcast<M,N,T>(N64 w, T cell,  M m = default, N n = default)    
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
        public static BitGrid128<M,N,T> broadcast<M,N,T>(N128 w, T cell,  M m = default, N n = default)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => ginx.vbroadcast(w,cell);

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> broadcast<M,N,T>(N256 w, T cell,  M m = default, N n = default)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => ginx.vbroadcast(w,cell);

        /// <summary>
        /// Allocates and fills a dymanically-sized natural grid
        /// </summary>
        /// <param name="cell">The data to replicate across all grid cells</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> broadcast<M,N,T>(T cell, M m = default, N n = default)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var grid = alloc<M,N,T>();
            grid.Data.Fill(cell);
            return grid;
        }

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