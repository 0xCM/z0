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
        /// Returns 1 if the source grids have identical conent and 0 otherwise
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit same<T>(BitGrid16<T> gx, BitGrid16<T> gy)
            where T : unmanaged
                => math.eq(gx,gy);

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
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit same<T>(in BitGrid128<T> gx, in BitGrid128<T> gy)
            where T : unmanaged
                => ginx.vsame(gx.data,gy.data);

        /// <summary>
        /// Returns 1 if the source grids have identical conent and 0 otherwise
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit same<T>(in BitGrid256<T> gx, in BitGrid256<T> gy)
            where T : unmanaged
                => ginx.vsame(gx.data,gy.data);
    }

}