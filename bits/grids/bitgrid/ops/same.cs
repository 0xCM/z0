//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class BitGrid
    {
        /// <summary>
        /// Returns 1 if the source grids have identical conent and 0 otherwise
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit same<T>(BitGrid32<T> gx, BitGrid32<T> gy)
            where T : unmanaged
                => math.eq(gx,gy);

        /// <summary>
        /// Returns 1 if the source grids have identical conent and 0 otherwise
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit same<T>(BitGrid64<T> gx, BitGrid64<T> gy)
            where T : unmanaged
                => math.eq(gx,gy);
        
        /// <summary>
        /// Returns 1 if the source grids have identical conent and 0 otherwise
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="N"></typeparam>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit same<M,N,T>(in BitGrid128<M,N,T> gx, in BitGrid128<M,N,T> gy)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => gvec.vsame<T>(gx,gy);    

        /// <summary>
        /// Returns 1 if the source grids have identical conent and 0 otherwise
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="N"></typeparam>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit same<M,N,T>(in BitGrid256<M,N,T> gx, in BitGrid256<M,N,T> gy)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => gvec.vsame<T>(gx,gy);    
 
        [MethodImpl(Inline)]
        public static bit same<T>(in BitGrid<T> gx, in BitGrid<T> gy)
            where T : unmanaged
        {
            var blocks = gx.BlockCount;
            for(var i=0; i<blocks; i++)
                if(!gvec.vsame(gx[i],gy[i]))
                       return false;
            return true;        
        }

        /// <summary>
        /// Returns 1 if the source grids have identical conent and 0 otherwise
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="N"></typeparam>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit same<M,N,T>(in BitGrid<M,N,T> gx, in BitGrid<M,N,T> gy)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            var blocks = gx.BlockCount;
            for(var i=0; i<blocks; i++)
                if(!gvec.vsame(gx[i],gy[i]))
                       return false;
            return true;        
        }
    }
}