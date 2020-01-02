//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Loads a fixed-width natural bitgrid the first block in the source
        /// </summary>
        /// <param name="src">The blocked source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<M,N,T> first<M,N,T>(in Block16<T> src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid16<M, N, T>(src);

        /// <summary>
        /// Loads a fixed-width natural bitgrid the first block in the source
        /// </summary>
        /// <param name="src">The blocked source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> first<M,N,T>(in Block32<T> src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid32<M, N, T>(src);

        /// <summary>
        /// Loads a fixed-width natural bitgrid the first block in the source
        /// </summary>
        /// <param name="src">The blocked source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> first<M,N,T>(in Block64<T> src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid64<M, N, T>(src);

        /// <summary>
        /// Loads a fixed-width natural bitgrid the first block in the source
        /// </summary>
        /// <param name="src">The blocked source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> first<M,N,T>(in Block128<T> src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid128<M, N, T>(src);

        /// <summary>
        /// Loads a fixed-width natural bitgrid the first block in the source
        /// </summary>
        /// <param name="src"></param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> first<M,N,T>(in Block256<T> src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid256<M, N, T>(src);
    }

}