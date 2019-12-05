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
        /// Allocates a 0-filled subgrid
        /// </summary>
        /// <param name="w">The total bit-width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SubGrid16<M,N,T> subgrid<M,N,T>(N16 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new SubGrid16<M, N, T>(z16);

        /// <summary>
        /// Allocates a populated subgrid
        /// </summary>
        /// <param name="w">The total bit-width selector</param>
        /// <param name="data">The data with which to populate the grid</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SubGrid16<M,N,T> subgrid<M,N,T>(N16 w, T data, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new SubGrid16<M, N, T>(convert<T,ushort>(data));

        /// <summary>
        /// Allocates a 0-filled subgrid
        /// </summary>
        /// <param name="w">The total bit-width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SubGrid32<M,N,T> subgrid<M,N,T>(N32 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new SubGrid32<M, N, T>(z32);

        /// <summary>
        /// Allocates a populated subgrid
        /// </summary>
        /// <param name="w">The total bit-width selector</param>
        /// <param name="data">The data with which to populate the grid</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SubGrid32<M,N,T> subgrid<M,N,T>(N32 w, T data, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new SubGrid32<M, N, T>(convert<T,uint>(data));

        /// <summary>
        /// Allocates a 0-filled subgrid
        /// </summary>
        /// <param name="w">The total bit-width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SubGrid64<M,N,T> subgrid<M,N,T>(N64 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new SubGrid64<M, N, T>(z64);

        /// <summary>
        /// Allocates a populated subgrid
        /// </summary>
        /// <param name="w">The total bit-width selector</param>
        /// <param name="data">The data with which to populate the grid</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SubGrid64<M,N,T> subgrid<M,N,T>(N64 w, T data, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new SubGrid64<M, N, T>(convert<T,ulong>(data));
    }

}