//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using BG = Z0.BitGrid;

    public static class BitGridRandX
    {   
        /// <summary>
        /// Allocates and populates a naturally-sized bitgrid from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> BitGrid<M,N,T>(this IPolyrand random, M m = default, N n = default, T t = default)
            where M : unmanaged,ITypeNat
            where N : unmanaged,ITypeNat
            where T : unmanaged
        {
            var grid = BG.alloc(m,n,t);
            var segments = BitCalcs.cellcount(m,n,t);
            random.Fill(segments, ref grid.Head);
            return grid;
        }

        /// <summary>
        /// Fills a caller-supplied naturally-sized bitgrid from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid<M,N,T> Fill<M,N,T>(this IPolyrand random, in BitGrid<M,N,T> dst)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            random.Fill(dst.CellCount, ref dst.Head);
            return ref dst;
        }

        /// <summary>
        /// Allocates and fills a generic bitgrid from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The grid row count</param>
        /// <param name="n">The grid col count</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<T> BitGrid<T>(this IPolyrand random, int m, int n, T t = default)
            where T : unmanaged
                => random.Fill(Z0.BitGrid.alloc<T>(m,n));

        /// <summary>
        /// Fills a caller-supplied generic bitgrid from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The grid row count</param>
        /// <param name="n">The grid col count</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid<T> Fill<T>(this IPolyrand random, in BitGrid<T> dst)
            where T : unmanaged
        {
            random.Fill(dst.CellCount, ref dst.Head);
            return ref dst;            
        }

        /// <summary>
        /// Creates a 32-bit fixed-size dimensionless bitgrid
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="bitcount">The bitness selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> BitGrid<T>(this IPolyrand random, N32 bitcount, T t = default)
            where T : unmanaged
                => random.Next<uint>();

        /// <summary>
        /// Creates a 64-bit fixed-size dimensionless bitgrid
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="bitcount">The bitness selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> BitGrid<T>(this IPolyrand random, N64 bitcount, T t = default)
            where T : unmanaged
                => random.Next<ulong>();

        /// <summary>
        /// Creates a 128-bit fixed-size dimensionless bitgrid
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="bitcount">The bitness selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<T> BitGrid<T>(this IPolyrand random, N128 bitcount, T t = default)
            where T : unmanaged
                => random.CpuVector<T>(bitcount);

        /// <summary>
        /// Creates a 256-bit fixed-size dimensionless bitgrid
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<T> BitGrid<T>(this IPolyrand random, N256 n, T t = default)
            where T : unmanaged
                => random.CpuVector<T>(n);

        /// <summary>
        /// Creates a 32-bit fixed-size bitgrid of dimension 1x32
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,T> BitGrid<T>(this IPolyrand random, N1 m, N32 n)
            where T : unmanaged
                => random.Next<uint>();

        /// <summary>
        /// Creates a 32-bit fixed-size bitgrid of dimension 32x1
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,T> BitGrid<T>(this IPolyrand random, N32 m, N1 n, T t = default)
            where T : unmanaged
                => random.Next<uint>();

        /// <summary>
        /// Creates a 32-bit fixed-size bitgrid of dimension 2x16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,T> BitGrid<T>(this IPolyrand random, N2 m, N16 n, T t = default)
            where T : unmanaged
                => random.Next<uint>();

        /// <summary>
        /// Creates a 32-bit fixed-size bitgrid of dimension 16x2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,T> BitGrid<T>(this IPolyrand random, N16 m, N2 n, T t = default)
            where T : unmanaged
                => random.Next<uint>();

        /// <summary>
        /// Creates a fixed-size 32-bit grid of dimension 8x4
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,T> BitGrid<T>(this IPolyrand random, N8 m, N4 n, T t = default)
            where T : unmanaged
                => random.Next<uint>();

        /// <summary>
        /// Creates a fixed-size 32-bit grid of dimension 4x8
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,T> BitGrid<T>(this IPolyrand random, N4 m, N8 n, T t = default)
            where T : unmanaged
                => random.Next<uint>();

        /// <summary>
        /// Creates a fixed-size 64-bit grid of dimension 1x64
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,T> BitGrid<T>(this IPolyrand random, N1 m, N64 n, T t = default)
            where T : unmanaged
                => random.Next<ulong>();

        /// <summary>
        /// Creates a fixed-size 64-bit grid of dimension 64x1
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,T> BitGrid<T>(this IPolyrand random, N64 m, N1 n, T t = default)
            where T : unmanaged
                => random.Next<ulong>();

        /// <summary>
        /// Creates a fixed-size 64-bit grid of dimension 32x2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,T> BitGrid<T>(this IPolyrand random, N32 m, N2 n, T t = default)
            where T : unmanaged
                => random.Next<ulong>();

        /// <summary>
        /// Creates a fixed-size 64-bit grid of dimension 2x32
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,T> BitGrid<T>(this IPolyrand random, N2 m, N32 n, T t = default)
            where T : unmanaged
                => random.Next<ulong>();

        /// <summary>
        /// Creates a fixed-size 64-bit grid of dimension 16x4
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,T> BitGrid<T>(this IPolyrand random, N16 m, N4 n, T t = default)
            where T : unmanaged
                => random.Next<ulong>();

        /// <summary>
        /// Creates a fixed-size 64-bit grid of dimension 4x16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,T> BitGrid<T>(this IPolyrand random, N4 m, N16 n, T t = default)
            where T : unmanaged
                => random.Next<ulong>();

        /// <summary>
        /// Creates a 64-bit fixed-size bitgrid of dimension 8x8 over generic cells
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> BitGrid<T>(this IPolyrand random, N8 m, N8 n, T t = default)
            where T : unmanaged
                => random.Next<ulong>();

        /// <summary>
        /// Creates a 128-bit fixed-size bitgrid of dimension 1x128
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N1,N128,T> BitGrid<T>(this IPolyrand random, N1 m, N128 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-size bitgrid of dimension 128x1
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N128,N1,T> BitGrid<T>(this IPolyrand random, N128 m, N1 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-size bitgrid of dimension 2x64
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,T> BitGrid<T>(this IPolyrand random, N2 m, N64 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-size bitgrid of dimension 64x2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N64,N2,T> BitGrid<T>(this IPolyrand random, N64 m, N2 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-size bitgrid of dimension 4x32
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,T> BitGrid<T>(this IPolyrand random, N4 m, N32 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-size bitgrid of dimension 32x4
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N32,N4,T> BitGrid<T>(this IPolyrand random, N32 m, N4 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-size bitgrid of dimension 8x16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,T> BitGrid<T>(this IPolyrand random, N8 m, N16 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-size bitgrid of dimension 16x8
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,T> BitGrid<T>(this IPolyrand random, N16 m, N8 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 256-bit fixed-size bitgrid of dimension 1x256
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N1,N256,T> BitGrid<T>(this IPolyrand random, N1 m, N256 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-size bitgrid of dimension 256x1
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> BitGrid<T>(this IPolyrand random, N256 m, N1 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-size bitgrid of dimension 2x128
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N2,N128,T> BitGrid<T>(this IPolyrand random, N2 m, N128 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-size bitgrid of dimension 128x2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> BitGrid<T>(this IPolyrand random, N128 m, N2 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-size bitgrid of dimension 8x32
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> BitGrid<T>(this IPolyrand random, N8 m, N32 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-size bitgrid of dimension 32x8
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> BitGrid<T>(this IPolyrand random, N32 m, N8 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-size bitgrid of dimension 16x16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> BitGrid<T>(this IPolyrand random, N16 m, N16 n, T t = default)
            where T : unmanaged            
                => random.CpuVector<T>(n256);
    }

}