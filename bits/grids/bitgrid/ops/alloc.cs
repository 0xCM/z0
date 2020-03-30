//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class BitGrid
    {
        /// <summary>
        /// Creates a zero-filled 16-bit grid of soft dimensions
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<T> alloc<T>(N16 w, int m, int n, T t = default)
            where T : unmanaged
                => new BitGrid16<T>(z16, m, n);

        /// <summary>
        /// Creates a zero-filled 32-bit grid of soft dimensions
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> alloc<T>(N32 w, int m, int n, T t = default)
            where T : unmanaged
               => new BitGrid32<T>(z32, m, n);

        /// <summary>
        /// Creates a zero-filled 64-bit grid of soft dimensions
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> alloc<T>(N64 w, int m, int n, T t = default)
            where T : unmanaged
               => new BitGrid64<T>(z64, m, n);
 
        /// <summary>
        /// Allocates a zero-filled 1x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N1,N16,T> alloc<T>(N16 w, N1 m = default, N16 n = default, T t = default)
            where T : unmanaged            
                => alloc16<N1,N16,T>();

        /// <summary>
        /// Allocates a zero-filled 16x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N16,N1,T> alloc<T>(N16 w, N16 m = default, N1 n = default, T t = default)
            where T : unmanaged            
                => alloc16<N16,N1,T>();

        /// <summary>
        /// Allocates a zero-filled 2x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N2,N8,T> alloc<T>(N16 w, N2 m = default, N8 n = default, T t = default)
            where T : unmanaged            
                => alloc16<N2,N8,T>();

        /// <summary>
        /// Allocates a zero-filled 8x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N8,N2,T> alloc<T>(N16 w, N8 m = default, N2 n = default, T t = default)
            where T : unmanaged            
                => alloc16<N8,N2,T>();

        /// <summary>
        /// Allocates a zero-filled 4x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N4,N4,T> alloc<T>(N16 w, N4 m = default, N4 n = default, T t = default)
            where T : unmanaged            
                => alloc16<N4,N4,T>();

        /// <summary>
        /// Allocates a zero-filled 1x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,T> alloc<T>(N32 w, N1 m = default, N32 n = default, T t = default)
            where T : unmanaged            
                => alloc32<N1,N32,T>();

        /// <summary>
        /// Allocates a zero-filled 32x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,T> alloc<T>(N32 w, N32 m = default, N1 n = default, T t = default)
            where T : unmanaged            
                => alloc32<N32,N1,T>();

        /// <summary>
        /// Allocates a zero-filled 16x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,T> alloc<T>(N32 w, N16 m = default, N2 n = default, T t = default)
            where T : unmanaged            
                => alloc32<N16,N2,T>();

        /// Allocates a zero-filled 2x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,T> alloc<T>(N32 w, N2 m = default, N16 n = default, T t = default)
            where T : unmanaged            
                => alloc32<N2,N16,T>();

        /// <summary>
        /// Allocates a zero-filled 8x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,T> alloc<T>(N32 w, N8 m = default, N4 n = default, T t = default)
            where T : unmanaged            
                => alloc32<N8,N4,T>();

        /// <summary>
        /// Allocates a zero-filled 4x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,T> alloc<T>(N32 w, N4 m = default, N8 n = default, T t = default)
            where T : unmanaged            
                => alloc32<N4,N8,T>();

        /// <summary>
        /// Allocates a zero-filled 1x64 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,T> alloc<T>(N64 w, N1 m = default, N64 n = default, T t = default)
            where T : unmanaged            
                => alloc64<N1,N64,T>();

        /// <summary>
        /// Allocates a zero-filled 64x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,T> alloc<T>(N64 w, N64 m = default, N1 n = default, T t = default)
            where T : unmanaged            
                => alloc64<N64,N1,T>();

        /// <summary>
        /// Allocates a zero-filled 2x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,T> alloc<T>(N64 w, N2 m = default, N32 n = default, T t = default)
            where T : unmanaged            
                => alloc64<N2,N32,T>();

        /// <summary>
        /// Allocates a zero-filled 32x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,T> alloc<T>(N64 w, N32 m = default, N2 n = default, T t = default)
            where T : unmanaged            
                => alloc64<N32,N2,T>();

        /// <summary>
        /// Allocates a zero-filled 4x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,T> alloc<T>(N64 w, N4 m = default, N16 n = default, T t = default)
            where T : unmanaged            
                => alloc64<N4,N16,T>();

        /// <summary>
        /// Allocates a zero-filled 16x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,T> alloc<T>(N64 w, N16 m = default, N4 n = default, T t = default)
            where T : unmanaged            
                => alloc64<N16,N4,T>();

        /// <summary>
        /// Allocates a zero-filled 8x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> alloc<T>(N64 w, N8 m = default, N8 n = default, T t = default)
            where T : unmanaged            
                => alloc64<N8,N8,T>();

        /// <summary>
        /// Allocates a zero-filled 1x128 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N1,N128,T> alloc<T>(N128 w, N1 m = default, N128 n = default, T t = default)
            where T : unmanaged            
                => alloc128(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 128x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N128,N1,T> alloc<T>(N128 w, N128 m = default, N1 n = default, T t = default)
            where T : unmanaged            
                => alloc128(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 2x64 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,T> alloc<T>(N128 block, N2 m = default, N64 n = default,T t = default)
            where T : unmanaged            
                => alloc128(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 64x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N64,N2,T> alloc<T>(N128 block, N64 m = default, N2 n = default, T t = default)
            where T : unmanaged            
                => alloc128(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 4x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,T> alloc<T>(N128 w, N4 m = default, N32 n = default, T t = default)
            where T : unmanaged            
                => alloc128(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 32x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N32,N4,T> alloc<T>(N128 w, N32 m = default, N4 n = default, T t = default)
            where T : unmanaged            
                => alloc128(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 8x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,T> alloc<T>(N128 w, N8 m = default, N16 n = default, T t = default)
            where T : unmanaged            
                => alloc128(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 16x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,T> alloc<T>(N128 w, N16 m = default, N8 n = default, T t = default)
            where T : unmanaged            
                => alloc128(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 1x256 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N1,N256,T> alloc<T>(N256 w, N1 m = default, N256 n = default, T t = default)
            where T : unmanaged            
                => alloc256(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 256x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> alloc<T>(N256 w, N256 m = default, N1 n = default, T t = default)
            where T : unmanaged            
                => alloc256(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 2x128 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static BitGrid256<N2,N128,T> alloc<T>(N256 w, N2 m = default, N128 n = default, T t = default)
            where T : unmanaged            
                => alloc256(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 128x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> alloc<T>(N256 w, N128 m = default, N2 n = default, T t = default)
            where T : unmanaged            
                => alloc256(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 4x64 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N4,N64,T> alloc<T>(N256 w, N4 m = default, N64 n = default,T t = default)
            where T : unmanaged            
                => alloc256(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 64x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N64,N4,T> alloc<T>(N256 w, N64 m = default, N4 n = default, T t = default)
            where T : unmanaged            
                => alloc256(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 8x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> alloc<T>(N256 w, N8 m = default, N32 n = default, T t = default)
            where T : unmanaged            
                => alloc256(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 32x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> alloc<T>(N256 w, N32 m = default, N8 n = default, T t = default)
            where T : unmanaged            
                => alloc256(m,n,t);

        /// <summary>
        /// Allocates a zero-filled 16x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> alloc<T>(N256 w, N16 m = default, N16 n = default, T t = default)
            where T : unmanaged            
                => alloc256(m,n,t);

        /// <summary>
        /// Allocates a zero-filled generic bitgrid
        /// </summary>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The segment type</typeparam>
        public static BitGrid<T> alloc<T>(int m, int n, T t = default)
            where T : unmanaged
        {            
            var blocksize = n256;
            var blocks = BitCalcs.tableblocks<T>(blocksize,m,n);
            var data = Z0.Blocks.alloc<T>(blocksize, blocks); 
            return new BitGrid<T>(data,m,n);            
        }

        /// <summary>
        /// Allocates a natural bitgrid
        /// </summary>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> alloc<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var blocksize = n256;
            var blocks = BitCalcs.tableblocks<T>(blocksize, nati(m),nati(n));
            var data = Z0.Blocks.alloc<T>(blocksize, blocks);             
            return new BitGrid<M, N, T>(data);
        }
        
        /// <summary>
        /// Creates a zero-filled 16-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid16<M,N,T> alloc16<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => default;

        /// <summary>
        /// Creates a zero-filled 32-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid32<M,N,T> alloc32<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => default;

        /// <summary>
        /// Creates a zero-filled 64-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid64<M,N,T> alloc64<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => default;

        /// <summary>
        /// Creates a zero-filled 128-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid128<M,N,T> alloc128<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => default;

        /// <summary>
        /// Creates a zero-filled 256-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid256<M,N,T> alloc256<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => default;

    }
}