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
        /// Computes the two's complement negation of source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> negate<T>(BitGrid32<T> gx)
            where T : unmanaged
                => math.negate(gx);

        /// <summary>
        /// Computes the two's complement negation of source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> negate<T>(BitGrid64<T> gx)
            where T : unmanaged
                => math.negate(gx);

        /// <summary>
        /// Computes the two's complement negation of source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<T> negate<T>(in BitGrid128<T> gx)
            where T : unmanaged
                => ginx.vnegate<T>(gx);


        /// <summary>
        /// Computes the two's complement negation of source grid
        /// </summary>
        /// <param name="gx">The source grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<T> negate<T>(in BitGrid256<T> gx)
            where T : unmanaged
                => ginx.vnegate<T>(gx);
    }
}