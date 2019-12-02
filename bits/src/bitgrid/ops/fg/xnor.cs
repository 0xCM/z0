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
        /// Computes the bitwise XNOR between fixed-width bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<T> xnor<T>(BitGrid16<T> gx, BitGrid16<T> gy)
            where T : unmanaged
                => math.xnor(gx,gy);

        /// <summary>
        /// Computes the bitwise XNOR between fixed-width bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> xnor<T>(BitGrid32<T> gx, BitGrid32<T> gy)
            where T : unmanaged
                => math.xnor(gx,gy);

        /// <summary>
        /// Computes the bitwise XNOR between fixed-width bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> xnor<T>(BitGrid64<T> gx, BitGrid64<T> gy)
            where T : unmanaged
                => math.xnor(gx,gy);

        /// <summary>
        /// Computes the bitwise XNOR between fixed-width bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<T> xnor<T>(in BitGrid128<T> gx, in BitGrid128<T> gy)
            where T : unmanaged
                => ginx.vxnor<T>(gx,gy);
    
        /// <summary>
        /// Computes the bitwise XNOR between fixed-width bitgrids
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<T> xnor<T>(in BitGrid256<T> gx, in BitGrid256<T> gy)
            where T : unmanaged
                => ginx.vxnor<T>(gx,gy);    
    }

}