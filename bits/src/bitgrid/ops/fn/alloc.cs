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
        /// Allocates a zero-filled 1x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N1,N16,T> alloc<T>(N16 w, N1 m = default, N16 n = default, T t = default)
            where T : unmanaged            
                => alloc16<N1,N16,T>();

        /// <summary>
        /// Allocates a zero-filled 16x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N16,N1,T> alloc<T>(N16 w, N16 m = default, N1 n = default, T t = default)
            where T : unmanaged            
                => alloc16<N16,N1,T>();

        /// <summary>
        /// Allocates a zero-filled 2x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N2,N8,T> alloc<T>(N16 w, N2 m = default, N8 n = default, T t = default)
            where T : unmanaged            
                => alloc16<N2,N8,T>();

        /// <summary>
        /// Allocates a zero-filled 8x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N8,N2,T> alloc<T>(N16 w, N8 m = default, N2 n = default, T t = default)
            where T : unmanaged            
                => alloc16<N8,N2,T>();

        /// <summary>
        /// Allocates a zero-filled 4x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N4,N4,T> alloc<T>(N16 w, N4 m = default, N4 n = default, T t = default)
            where T : unmanaged            
                => alloc16<N4,N4,T>();

        /// <summary>
        /// Allocates a zero-filled 1x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,T> alloc<T>(N32 w, N1 m = default, N32 n = default, T t = default)
            where T : unmanaged            
                => alloc32<N1,N32,T>();

        /// <summary>
        /// Allocates a zero-filled 32x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,T> alloc<T>(N32 w, N32 m = default, N1 n = default, T t = default)
            where T : unmanaged            
                => alloc32<N32,N1,T>();

        /// <summary>
        /// Allocates a zero-filled 16x2 grid
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,T> alloc<T>(N32 w, N16 m = default, N2 n = default)
            where T : unmanaged            
                => alloc32<N16,N2,T>();

        /// Allocates a zero-filled 2x16 grid
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,T> alloc<T>(N32 w, N2 m = default, N16 n = default)
            where T : unmanaged            
                => alloc32<N2,N16,T>();

        /// <summary>
        /// Allocates a zero-filled 8x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,T> alloc<T>(N32 w, N8 m = default, N4 n = default)
            where T : unmanaged            
                => alloc32<N8,N4,T>();

        /// <summary>
        /// Allocates a zero-filled 4x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,T> alloc<T>(N32 w, N4 m = default, N8 n = default)
            where T : unmanaged            
                => alloc32<N4,N8,T>();

        /// <summary>
        /// Allocates a zero-filled 1x64 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,T> alloc<T>(N64 w, N1 m = default, N64 n = default)
            where T : unmanaged            
                => alloc64<N1,N64,T>();

        /// <summary>
        /// Allocates a zero-filled 64x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,T> alloc<T>(N64 w, N64 m = default, N1 n = default)
            where T : unmanaged            
                => alloc64<N64,N1,T>();

        /// <summary>
        /// Allocates a zero-filled 2x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,T> alloc<T>(N64 w, N2 m = default, N32 n = default)
            where T : unmanaged            
                => alloc64<N2,N32,T>();

        /// <summary>
        /// Allocates a zero-filled 32x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,T> alloc<T>(N64 w, N32 m = default, N2 n = default)
            where T : unmanaged            
                => alloc64<N32,N2,T>();

        /// <summary>
        /// Allocates a zero-filled 4x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,T> alloc<T>(N64 w, N4 m = default, N16 n = default)
            where T : unmanaged            
                => alloc64<N4,N16,T>();

        /// <summary>
        /// Allocates a zero-filled 16x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,T> alloc<T>(N64 w, N16 m = default, N4 n = default)
            where T : unmanaged            
                => alloc64<N16,N4,T>();

        /// <summary>
        /// Allocates a zero-filled 8x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> alloc<T>(N64 w, N8 m = default, N8 n = default)
            where T : unmanaged            
                => alloc64<N8,N8,T>();

        /// <summary>
        /// Allocates a 1x128 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N1,N128,T> alloc<T>(N128 w, N1 m = default, N128 n = default,T fill = default)
            where T : unmanaged            
                => alloc128(m,n,fill);

        /// <summary>
        /// Allocates a 128x1 grid
        /// </summary>
        /// <param name="w">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N128,N1,T> alloc<T>(N128 w, N128 m = default, N1 n = default, T fill = default)
            where T : unmanaged            
                => alloc128(m,n,fill);

        /// <summary>
        /// Allocates a 2x64 grid
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,T> alloc<T>(N128 block, N2 m = default, N64 n = default,T fill = default)
            where T : unmanaged            
                => alloc128(m,n,fill);

        /// <summary>
        /// Allocates a 64x2 grid
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N64,N2,T> alloc<T>(N128 block, N64 m = default, N2 n = default, T fill = default)
            where T : unmanaged            
                => alloc128(m,n,fill);

        /// <summary>
        /// Allocates a 4x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,T> alloc<T>(N128 w, N4 m = default, N32 n = default, T fill = default)
            where T : unmanaged            
                => alloc128(m,n,fill);

        /// <summary>
        /// Allocates a 32x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N32,N4,T> alloc<T>(N128 w, N32 m = default, N4 n = default,T fill = default)
            where T : unmanaged            
                => alloc128(m,n,fill);

        /// <summary>
        /// Allocates a 8x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,T> alloc<T>(N128 w, N8 m = default, N16 n = default,T fill = default)
            where T : unmanaged            
                => alloc128(m,n,fill);

        /// <summary>
        /// Allocates a 16x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,T> alloc<T>(N128 w, N16 m = default, N8 n = default,T fill = default)
            where T : unmanaged            
                => alloc128(m,n,fill);

        /// <summary>
        /// Allocates a 1x256 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N1,N256,T> alloc<T>(N256 w, N1 m = default, N256 n = default,T fill = default)
            where T : unmanaged            
                => alloc256(m,n,fill);

        /// <summary>
        /// Allocates a 256x1 grid
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> alloc<T>(N256 w, N256 m = default, N1 n = default, T fill = default)
            where T : unmanaged            
                => alloc256(m,n,fill);

        /// <summary>
        /// Allocates a 2x128 grid
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N2,N128,T> alloc<T>(N256 w, N2 m = default, N128 n = default,T fill = default)
            where T : unmanaged            
                => alloc256(m,n,fill);

        /// <summary>
        /// Allocates a 128x2 grid
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> alloc<T>(N256 w, N128 m = default, N2 n = default, T fill = default)
            where T : unmanaged            
                => alloc256(m,n,fill);

        /// <summary>
        /// Allocates a 4x64 grid
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N4,N64,T> alloc<T>(N256 w, N4 m = default, N64 n = default,T fill = default)
            where T : unmanaged            
                => alloc256(m,n,fill);

        /// <summary>
        /// Allocates a 64x4 grid
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N64,N4,T> alloc<T>(N256 w, N64 m = default, N4 n = default, T fill = default)
            where T : unmanaged            
                => alloc256(m,n,fill);

        /// <summary>
        /// Allocates a 8x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> alloc<T>(N256 w, N8 m = default, N32 n = default, T fill = default)
            where T : unmanaged            
                => alloc256(m,n,fill);

        /// <summary>
        /// Allocates a 32x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> alloc<T>(N256 w, N32 m = default, N8 n = default,T fill = default)
            where T : unmanaged            
                => alloc256(m,n,fill);

        /// <summary>
        /// Allocates a 16x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> alloc<T>(N256 w, N16 m = default, N16 n = default, T fill = default)
            where T : unmanaged            
                => alloc256(m,n,fill);

        [MethodImpl(Inline)]
        static BitGrid16<M,N,T> alloc16<M,N,T>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid16<M, N, T>(z16);


        [MethodImpl(Inline)]
        static BitGrid32<M,N,T> alloc32<M,N,T>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid32<M, N, T>(z32);

        [MethodImpl(Inline)]
        static BitGrid64<M,N,T> alloc64<M,N,T>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid64<M, N, T>(z64);

        [MethodImpl(Inline)]
        static BitGrid128<M,N,T> alloc128<M,N,T>(M m = default, N n = default, T fill = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid128<M, N, T>(ginx.vbroadcast(n128, fill));

        [MethodImpl(Inline)]
        static BitGrid256<M,N,T> alloc256<M,N,T>(M m = default, N n = default, T fill = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid256<M, N, T>(ginx.vbroadcast(n256, fill));
    }
}