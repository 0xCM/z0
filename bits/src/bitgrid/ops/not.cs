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
        /// Computes the bitwise complement of the source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<T> not<T>(BitGrid16<T> gx)
            where T : unmanaged
                => init16<T>(gx.RowCount, gx.ColCount, math.not(gx));

        /// <summary>
        /// Computes the bitwise complement of the source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> not<T>(BitGrid32<T> gx)
            where T : unmanaged
                => init32<T>(gx.RowCount, gx.ColCount, math.not(gx));

        /// <summary>
        /// Computes the bitwise complement of the source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> not<T>(BitGrid64<T> gx)
            where T : unmanaged
                => init64<T>(gx.RowCount, gx.ColCount, math.not(gx));
                         
        /// <summary>
        /// Computes the bitwise complement of the source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<M,N,T> not<M,N,T>(BitGrid16<M,N,T> gx)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => math.not(gx);

        /// <summary>
        /// Computes the bitwise complement of the source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> not<M,N,T>(BitGrid32<M,N,T> gx)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => math.not(gx);

        /// <summary>
        /// Computes the bitwise complement of the source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> not<M,N,T>(BitGrid64<M,N,T> gx)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => math.not(gx);

        /// <summary>
        /// Computes the bitwise complement of the source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> not<M,N,T>(in BitGrid128<M,N,T> gx)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vnot<T>(gx);    

        /// <summary>
        /// Computes the bitwise complement of the source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> not<M,N,T>(in BitGrid256<M,N,T> gx)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vnot<T>(gx);    

        /// <summary>
        /// Computes the bitwise complement of the source grid and stores the result to a caller-supplied target
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid<M,N,T> not<M,N,T>(in BitGrid<M,N,T> gx, in BitGrid<M,N,T> gz)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var blocks = gz.BlockCount;
            for(var i=0; i<blocks; i++)
                gz[i] = ginx.vnot(gx[i]);
            return ref gz;
        }

        /// <summary>
        /// Computes the bitwise complement of the source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> not<M,N,T>(in BitGrid<M,N,T> gx)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => not(gx, alloc<M,N,T>());

        /// <summary>
        /// Computes the bitwise complement of the source grid and deposits the result int a caller-supplied target
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <param name="gz">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid<T> not<T>(in BitGrid<T> gx, in BitGrid<T> gz)
            where T : unmanaged
        {
            var blocks = gz.BlockCount;
            for(var i=0; i<blocks; i++)
                gz[i] = ginx.vnot(gx[i]);
            return ref gz;
        }

        /// <summary>
        /// Computes the bitwise complement of the source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<T> not<T>(in BitGrid<T> gx)
            where T : unmanaged
                => not(gx, alloc<T>(gx.RowCount, gx.ColCount));

    }
}