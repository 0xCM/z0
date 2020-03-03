//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    partial class BitGrid
    {
        /// <summary>
        /// Creates a populated 16-bit generic bitgrid 
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<T> init<T>(N16 w, int m, int n, T d = default)
            where T : unmanaged
                => new BitGrid16<T>(ginx.broadcast<T,ushort>(d), m, n);

        /// <summary>
        /// Creates a populated 32-bit generic bitgrid 
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> init<T>(N32 w, int m, int n, T d = default)
            where T : unmanaged
                => new BitGrid32<T>(ginx.broadcast<T,uint>(d), m, n);

        /// <summary>
        /// Creates a populated 64-bit generic bitgrid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> init<T>(N64 w, int m, int n, T d = default)
            where T : unmanaged
                => new BitGrid64<T>(ginx.broadcast<T,ulong>(d), m, n);

        /// <summary>
        /// Creates a populated 1x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N1,N16,T> init<T>(N16 w, N1 m = default, N16 n = default, T d = default)
            where T : unmanaged            
                => init16(m,n,d);

        /// <summary>
        /// Creates a populated 16x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N16,N1,T> init<T>(N16 w, N16 m = default, N1 n = default, T d = default)
            where T : unmanaged            
                => init16(m,n,d);

        /// <summary>
        /// Creates a populated 2x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N2,N8,T> init<T>(N16 w, N2 m = default, N8 n = default, T d = default)
            where T : unmanaged            
                => init16(m,n,d);

        /// <summary>
        /// Creates a populated 8x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N8,N2,T> init<T>(N16 w, N8 m = default, N2 n = default, T d = default)
            where T : unmanaged            
                => init16(m,n,d);

        /// <summary>
        /// Creates a populated 4x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<N4,N4,T> init<T>(N16 w, N4 m = default, N4 n = default, T d = default)
            where T : unmanaged            
                => init16(m,n,d);

        /// <summary>
        /// Creates a populated 1x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,T> init<T>(N32 w, N1 m = default, N32 n = default, T d = default)
            where T : unmanaged            
                => init32(m,n,d);

        /// <summary>
        /// Creates a populated 32x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,T> init<T>(N32 w, N32 m = default, N1 n = default, T d = default)
            where T : unmanaged            
                => init32(m,n,d);

        /// <summary>
        /// Creates a populated 16x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,T> init<T>(N32 w, N16 m = default, N2 n = default, T d = default)
            where T : unmanaged            
                => init32(m,n,d);

        /// Creates a populated 2x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,T> init<T>(N32 w, N2 m = default, N16 n = default, T d = default)
            where T : unmanaged            
                => init32(m,n,d);

        /// <summary>
        /// Creates a populated 8x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,T> init<T>(N32 w, N8 m = default, N4 n = default, T d = default)
            where T : unmanaged            
                => init32(m,n,d);

        /// <summary>
        /// Creates a populated 4x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,T> init<T>(N32 w, N4 m = default, N8 n = default, T d = default)
            where T : unmanaged            
                => init32(m,n,d);

        /// <summary>
        /// Creates a populated 1x64 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,T> init<T>(N64 w, N1 m = default, N64 n = default, T d = default)
            where T : unmanaged            
                => init64(m,n,d);

        /// <summary>
        /// Creates a populated 64x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,T> init<T>(N64 w, N64 m = default, N1 n = default, T d = default)
            where T : unmanaged            
                => init64(m,n,d);

        /// <summary>
        /// Creates a populated 2x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,T> init<T>(N64 w, N2 m = default, N32 n = default, T d = default)
            where T : unmanaged            
                => init64(m,n,d);

        /// <summary>
        /// Creates a populated 32x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,T> init<T>(N64 w, N32 m = default, N2 n = default, T d = default)
            where T : unmanaged            
                => init64(m,n,d);

        /// <summary>
        /// Creates a populated 4x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,T> init<T>(N64 w, N4 m = default, N16 n = default, T d = default)
            where T : unmanaged            
                => init64(m,n,d);

        /// <summary>
        /// Creates a populated 16x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The  cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,T> init<T>(N64 w, N16 m = default, N4 n = default, T d = default)
            where T : unmanaged            
                => init64(m,n,d);

        /// <summary>
        /// Creates a populated 8x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> init<T>(N64 w, N8 m = default, N8 n = default, T d = default)
            where T : unmanaged            
                => init64(m,n,d);

        /// <summary>
        /// Creates a populated 1x128 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N1,N128,T> init<T>(N128 w, N1 m = default, N128 n = default, T d = default)
            where T : unmanaged            
                => init128(m,n,d);

        /// <summary>
        /// Creates a populated 128x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N128,N1,T> init<T>(N128 w, N128 m = default, N1 n = default, T d = default)
            where T : unmanaged            
                => init128(m,n,d);

        /// <summary>
        /// Creates a populated 2x64 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,T> init<T>(N128 w, N2 m = default, N64 n = default,T d = default)
            where T : unmanaged            
                => init128(m,n,d);

        /// <summary>
        /// Creates a populated 64x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N64,N2,T> init<T>(N128 w, N64 m = default, N2 n = default, T d = default)
            where T : unmanaged            
                => init128(m,n,d);

        /// <summary>
        /// Creates a populated 4x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,T> init<T>(N128 w, N4 m = default, N32 n = default, T d = default)
            where T : unmanaged            
                => init128(m,n,d);

        /// <summary>
        /// Creates a populated 32x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N32,N4,T> init<T>(N128 w, N32 m = default, N4 n = default, T d = default)
            where T : unmanaged            
                => init128(m,n,d);

        /// <summary>
        /// Creates a populated 8x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,T> init<T>(N128 w, N8 m = default, N16 n = default, T d = default)
            where T : unmanaged            
                => init128(m,n,d);

        /// <summary>
        /// Creates a populated 16x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,T> init<T>(N128 w, N16 m = default, N8 n = default, T d = default)
            where T : unmanaged            
                => init128(m,n,d);

        /// <summary>
        /// Creates a populated 1x256 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N1,N256,T> init<T>(N256 w, N1 m = default, N256 n = default, T d = default)
            where T : unmanaged            
                => init256(m,n,d);

        /// <summary>
        /// Creates a populated 256x1 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> init<T>(N256 w, N256 m = default, N1 n = default, T d = default)
            where T : unmanaged            
                => init256(m,n,d);

        /// <summary>
        /// Creates a populated 2x128 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static BitGrid256<N2,N128,T> init<T>(N256 w, N2 m = default, N128 n = default, T d = default)
            where T : unmanaged            
                => init256(m,n,d);

        /// <summary>
        /// Creates a populated 128x2 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> init<T>(N256 w, N128 m = default, N2 n = default, T d = default)
            where T : unmanaged            
                => init256(m,n,d);

        /// <summary>
        /// Creates a populated 4x64 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N4,N64,T> init<T>(N256 w, N4 m = default, N64 n = default,T d = default)
            where T : unmanaged            
                => init256(m,n,d);

        /// <summary>
        /// Creates a populated 64x4 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N64,N4,T> init<T>(N256 w, N64 m = default, N4 n = default, T d = default)
            where T : unmanaged            
                => init256(m,n,d);

        /// <summary>
        /// Creates a populated 8x32 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> init<T>(N256 w, N8 m = default, N32 n = default, T d = default)
            where T : unmanaged            
                => init256(m,n,d);

        /// <summary>
        /// Creates a populated 32x8 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> init<T>(N256 w, N32 m = default, N8 n = default, T d = default)
            where T : unmanaged            
                => init256(m,n,d);

        /// <summary>
        /// Creates a populated 16x16 grid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> init<T>(N256 w, N16 m = default, N16 n = default, T d = default)
            where T : unmanaged            
                => init256(m,n,d);

        /// <summary>
        /// Creates a dynamically-sized grid of soft dimensions filled with specified data
        /// </summary>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The segment type</typeparam>
        public static BitGrid<T> init<T>(int m, int n, T d = default)
            where T : unmanaged
        {            
            var w = n256;
            var blocks = Z0.Blocks.alloc<T>(w, BitCalcs.tableblocks<T>(w, m, n));
            Z0.Blocks.broadcast(d, blocks);
            return new BitGrid<T>(blocks,m,n);            
        }

        /// <summary>
        /// Creates a dynamically-sized grid of natural dimensions filled with specified data
        /// </summary>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> init<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var blocksize = n256;
            var blocks = Z0.Blocks.alloc<T>(blocksize, BitCalcs.tableblocks<T>(blocksize, natval(m), natval(n)));
            Z0.Blocks.broadcast(d, blocks);
            return new BitGrid<M, N, T>(blocks);
        }

        /// <summary>
        /// Initializes 16-bit grid of soft dimensions
        /// </summary>
        /// <param name="m">The number of rows</param>
        /// <param name="m">The number of columns</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid16<T> init16<T>(int m, int n, ushort d)
            where T : unmanaged
                => new BitGrid16<T>(d, m, n);

        /// <summary>
        /// Initializes 32-bit grid of soft dimensions
        /// </summary>
        /// <param name="m">The number of rows</param>
        /// <param name="m">The number of columns</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid32<T> init32<T>(int m, int n, uint d)
            where T : unmanaged
                => new BitGrid32<T>(d, m, n);

        /// <summary>
        /// Initializes 64-bit grid of soft dimensions
        /// </summary>
        /// <param name="m">The number of rows</param>
        /// <param name="m">The number of columns</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid64<T> init64<T>(int m, int n, ulong d)
            where T : unmanaged
                => new BitGrid64<T>(d, m, n);

        /// <summary>
        /// Initializes a 128-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid16<M,N,T> init16<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged  
                => new BitGrid16<M, N, T>(ginx.broadcast<T,ushort>(d));

        /// <summary>
        /// Initializes a 32-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid32<M,N,T> init32<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid32<M, N, T>(ginx.broadcast<T,uint>(d));

        /// <summary>
        /// Initializes a 64-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid64<M,N,T> init64<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid64<M, N, T>(ginx.broadcast<T,ulong>(d));

        /// <summary>
        /// Initializes a 128-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid128<M,N,T> init128<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid128<M, N, T>(CpuVector.vbroadcast(n128, d));

        /// <summary>
        /// Initializes a 256-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid256<M,N,T> init256<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid256<M, N, T>(CpuVector.vbroadcast(n256, d)); 
    }
}