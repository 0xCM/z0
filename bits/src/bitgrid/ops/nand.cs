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
        /// Computes the bitwise nand between generic bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<T> nand<T>(BitGrid16<T> gx, BitGrid16<T> gy)
            where T : unmanaged
                => bg16<T>(gx.RowCount, gx.ColCount, math.nand(gx,gy));

        /// <summary>
        /// Computes the bitwise nand between generic bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> nand<T>(BitGrid32<T> gx, BitGrid32<T> gy)
            where T : unmanaged
                => bg32<T>(gx.RowCount, gx.ColCount, math.nand(gx,gy));

        /// <summary>
        /// Computes the bitwise nand between generic bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> nand<T>(BitGrid64<T> gx, BitGrid64<T> gy)
            where T : unmanaged
                => bg64<T>(gx.RowCount, gx.ColCount, math.nand(gx,gy));
         
        /// <summary>
        /// Computes the bitwise nand between natural bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<M,N,T> nand<M,N,T>(BitGrid16<M,N,T> gx, BitGrid16<M,N,T> gy)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => math.nand(gx,gy);

        /// <summary>
        /// Computes the bitwise nand between natural bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> nand<M,N,T>(BitGrid32<M,N,T> gx, BitGrid32<M,N,T> gy)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => math.nand(gx,gy);

        /// <summary>
        /// Computes the bitwise nand between natural bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> nand<M,N,T>(BitGrid64<M,N,T> gx, BitGrid64<M,N,T> gy)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => math.nand(gx,gy);

        /// <summary>
        /// Computes the bitwise nand between natural bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> nand<M,N,T>(in BitGrid128<M,N,T> gx, in BitGrid128<M,N,T> gy)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vnand<T>(gx,gy);    

        /// <summary>
        /// Computes the bitwise nand between natural bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> nand<M,N,T>(in BitGrid256<M,N,T> gx, in BitGrid256<M,N,T> gy)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vnand<T>(gx,gy);    

        /// <summary>
        /// Computes the bitwise NAND between generic bitgrids and stores the result to a caller-supplied target
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <param name="gz">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid<T> nand<T>(in BitGrid<T> gx, in BitGrid<T> gy, in BitGrid<T> gz)
            where T : unmanaged
        {
            var blocks = gz.BlockCount;
            for(var i=0; i<blocks; i++)
                gz[i] = ginx.vnand(gx[i],gy[i]);
            return ref gz;
        }

        /// <summary>
        /// Computes the bitwise NAND between generic bitgrids and returns the allocated result
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<T> nand<T>(in BitGrid<T> gx, in BitGrid<T> gy)
            where T : unmanaged
        {
            var gz = alloc<T>(gx.RowCount, gx.ColCount);
            nand(gx,gy,gz);
            return gz;
        }

        /// <summary>
        /// Computes the bitwise NAND between natural bitgrids and stores the result to a caller-supplied target
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <param name="gz">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid<M,N,T> nand<M,N,T>(in BitGrid<M,N,T> gx, in BitGrid<M,N,T> gy, in BitGrid<M,N,T> gz)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var blocks = BitCalcs.blockcount<M,N,T>(n256);
            for(var i=0; i<blocks; i++)
                gz[i] = ginx.vnand(gx[i],gy[i]);
            return ref gz;
        }

        /// <summary>
        /// Computes the bitwise NAND between generic bitgrids and returns the allocated result
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> nand<M,N,T>(in BitGrid<M,N,T> gx, in BitGrid<M,N,T> gy)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var gz = alloc<M,N,T>();    
            nand(gx,gy,gz);
            return gz;
        }
    }
}