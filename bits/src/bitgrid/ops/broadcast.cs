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
        [MethodImpl(Inline)]
        public static ref readonly BitGrid<T> broadcast<T>(T cell, in BitGrid<T> dst)            
            where T : unmanaged
        {
            dst.Data.Fill(cell);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly BitGrid<T> broadcast<T>(bit state, in BitGrid<T> dst)    
            where T : unmanaged
        {
            dst.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());            
            return ref dst;
        }

        /// <summary>
        /// Transmits the source state to all bits in a target grid
        /// </summary>
        /// <param name="state">The source state</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitGrid16<T> broadcast<T>(bit state, out BitGrid16<T> dst)
            where T : unmanaged
        {
            dst = state ? maxval<ushort>() : z16;
            return ref dst;
        }

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid16<T> broadcast<T>(T cell, out BitGrid16<T> dst)    
            where T : unmanaged
        {
            dst = zbroadcast(cell, out ushort _);
            return ref dst;
        }

        /// <summary>
        /// Transmits the source state to all bits in a target grid
        /// </summary>
        /// <param name="state">The source state</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitGrid32<T> broadcast<T>(bit state, out BitGrid32<T> dst)
            where T : unmanaged
        {
            dst = state ? maxval<uint>() : z32;
            return ref dst;
        }

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid32<T> broadcast<T>(T cell, out BitGrid32<T> dst)    
            where T : unmanaged
        {
            dst = gsinx.sbroadcast(cell, out uint _);
            return ref dst;
        }

        /// <summary>
        /// Transmits the source state to all bits in a target grid
        /// </summary>
        /// <param name="state">The source state</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid64<T> broadcast<T>(bit state, out BitGrid64<T> dst)    
            where T : unmanaged
        {
            dst = state ? maxval<ulong>() : 0ul;
            return ref dst;
        }

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid64<T> broadcast<T>(T cell, out BitGrid64<T> dst)    
            where T : unmanaged
        {
            dst = gsinx.sbroadcast(cell, out ulong _);
            return ref dst;
        }

        /// <summary>
        /// Transmits the source cell value to all cells in a target grid
        /// </summary>
        /// <param name="state">The source state</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid128<T> broadcast<T>(T cell, out BitGrid128<T> dst)    
            where T : unmanaged
        {
            dst = ginx.vbroadcast(n128,cell);
            return ref dst;
        }

        /// <summary>
        /// Transmits the source cell value to all cells in a target grid
        /// </summary>
        /// <param name="state">The source state</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid256<T> broadcast<T>(T cell, out BitGrid256<T> dst)    
            where T : unmanaged
        {
            dst = ginx.vbroadcast(n256,cell);
            return ref dst;
        }
         
        [MethodImpl(Inline)]
        public static ref readonly BitGrid32<M,N,T> broadcast<M,N,T>(bit state, out BitGrid32<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            dst = state ? maxval<uint>() : 0u;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly BitGrid32<M,N,T> broadcast<M,N,T>(T cell, out BitGrid32<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            dst = gsinx.sbroadcast(cell, out uint _);
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
        public static ref readonly BitGrid64<M,N,T> broadcast<M,N,T>(T cell, out BitGrid64<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            dst = gsinx.sbroadcast(cell, out ulong _);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void broadcast<M,N,T>(bit state, out BitGrid64<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            dst = state ? maxval<ulong>() : 0ul;
        }

        [MethodImpl(Inline)]
        public static ref readonly BitGrid128<M,N,T> broadcast<M,N,T>(bit state, out BitGrid128<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
              dst = ginx.vbroadcast(n128,state ? maxval<T>() : zero<T>());
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
        public static ref readonly BitGrid128<M,N,T> broadcast<M,N,T>(T cell, out BitGrid128<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            dst = ginx.vbroadcast(n128,cell);
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
        public static ref readonly BitGrid256<M,N,T> broadcast<M,N,T>(T cell, out BitGrid256<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            dst = ginx.vbroadcast(n256,cell);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly BitGrid<M,N,T> broadcast<M,N,T>(bit state, in BitGrid<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            dst.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());
            return ref dst;
        }

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