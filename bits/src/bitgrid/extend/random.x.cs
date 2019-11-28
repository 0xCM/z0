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

    public static class BitGridRandX
    {   
        /// <summary>
        /// Fills a generic bitgrid with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The grid row count</param>
        /// <param name="n">The grid col count</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<T> Fill<T>(this IPolyrand random, BitGrid<T> dst)
            where T : unmanaged
        {
            random.Fill(dst.CellCount, ref dst.Head);
            return dst;            
        }

        /// <summary>
        /// Allocates and fills a generic bitgrid with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The grid row count</param>
        /// <param name="n">The grid col count</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<T> BitGrid<T>(this IPolyrand random, int m, int n, T zero = default)
            where T : unmanaged
                => random.Fill(Z0.BitGrid.alloc<T>(m,n));

        /// <summary>
        /// Allocates and fills a natural bitgrid with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="zero">The zero representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> Fill<M,N,T>(this IPolyrand random, BitGrid<M,N,T> dst)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            random.Fill(dst.CellCount, ref dst.Head);
            return dst;            
        }

        /// <summary>
        /// Allocates and fills a natural bitgrid with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="zero">The zero representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> BitGrid<M,N,T>(this IPolyrand random, M m = default, M n = default, T zero = default)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat

        {
            var dst = Z0.BitGrid.alloc<M,N,T>();
            random.Fill(dst.CellCount, ref dst.Head);
            return dst;            
        }

        /// <summary>
        /// Creates a 32-bit fixed-width bitgrid of dimension 1x32
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,uint> BitGrid(this IPolyrand random, N1 m, N32 n)
            => random.Next<uint>();

        /// <summary>
        /// Creates a 32-bit fixed-width bitgrid of dimension 32x1
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,uint> BitGrid(this IPolyrand random, N32 m, N1 n)
            => random.Next<uint>();

        /// <summary>
        /// Creates a 32-bit fixed-width bitgrid of dimension 2x16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,uint> BitGrid(this IPolyrand random, N2 m, N16 n)
            => random.Next<uint>();

        /// <summary>
        /// Creates a 32-bit fixed-width bitgrid of dimension 16x2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,uint> BitGrid(this IPolyrand random, N16 m, N2 n)
            => random.Next<uint>();

        /// <summary>
        /// Creates a 32-bit fixed-width bitgrid of dimension 4x8
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,uint> BitGrid(this IPolyrand random, N4 m, N8 n)
            => random.Next<uint>();

        /// <summary>
        /// Creates a 32-bit fixed-width bitgrid of dimension 8x4
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,uint> BitGrid(this IPolyrand random, N8 m, N4 n)
            => random.Next<uint>();

        /// <summary>
        /// Creates a 64-bit fixed-width bitgrid of dimension 1x64
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,ulong> BitGrid(this IPolyrand random, N1 m, N64 n)
            => random.Next<ulong>();

        /// <summary>
        /// Creates a 64-bit fixed-width bitgrid of dimension 64x1
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,ulong> BitGrid(this IPolyrand random, N64 m, N1 n)
            => random.Next<ulong>();

        /// <summary>
        /// Creates a 64-bit fixed-width bitgrid of dimension 2x32
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,ulong> BitGrid(this IPolyrand random, N2 m, N32 n)
            => random.Next<ulong>();

        /// <summary>
        /// Creates a 64-bit fixed-width bitgrid of dimension 32x2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,ulong> BitGrid(this IPolyrand random, N32 m, N2 n)
            => random.Next<ulong>();

        /// <summary>
        /// Creates a 64-bit fixed-width bitgrid of dimension 4x16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,ulong> BitGrid(this IPolyrand random, N4 m, N16 n)
            => random.Next<ulong>();

        /// <summary>
        /// Creates a 64-bit fixed-width bitgrid of dimension 16x4
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> BitGrid(this IPolyrand random, N16 m, N4 n)
            => random.Next<ulong>();

        /// <summary>
        /// Creates a 64-bit fixed-width bitgrid of dimension 8x8
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,ulong> BitGrid(this IPolyrand random, N8 m, N8 n)
            => random.Next<ulong>();

        /// <summary>
        /// Creates a 128-bit fixed-width bitgrid of dimension 1x128
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N1,N128,T> BitGrid<T>(this IPolyrand random, N1 m, N128 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-width bitgrid of dimension 128x1
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N128,N1,T> BitGrid<T>(this IPolyrand random, N128 m, N1 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-width bitgrid of dimension 2x64
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,T> BitGrid<T>(this IPolyrand random, N2 m, N64 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-width bitgrid of dimension 64x2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N64,N2,T> BitGrid<T>(this IPolyrand random, N64 m, N2 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-width bitgrid of dimension 4x32
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,T> BitGrid<T>(this IPolyrand random, N4 m, N32 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-width bitgrid of dimension 32x4
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N32,N4,T> BitGrid<T>(this IPolyrand random, N32 m, N4 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-width bitgrid of dimension 8x16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,T> BitGrid<T>(this IPolyrand random, N8 m, N16 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 128-bit fixed-width bitgrid of dimension 16x8
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,T> BitGrid<T>(this IPolyrand random, N16 m, N8 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        /// <summary>
        /// Creates a 256-bit fixed-width bitgrid of dimension 1x256
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
         [MethodImpl(Inline)]
        public static BitGrid256<N1,N256,T> BitGrid<T>(this IPolyrand random, N1 m, N256 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-width bitgrid of dimension 256x1
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> BitGrid<T>(this IPolyrand random, N256 m, N1 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-width bitgrid of dimension 2x128
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
         [MethodImpl(Inline)]
        public static BitGrid256<N2,N128,T> BitGrid<T>(this IPolyrand random, N2 m, N128 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-width bitgrid of dimension 128x2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> BitGrid<T>(this IPolyrand random, N128 m, N2 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-width bitgrid of dimension 8x32
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> BitGrid<T>(this IPolyrand random, N8 m, N32 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-width bitgrid of dimension 32x8
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> BitGrid<T>(this IPolyrand random, N32 m, N8 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        /// <summary>
        /// Creates a 256-bit fixed-width bitgrid of dimension 16x16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> BitGrid<T>(this IPolyrand random, N16 m, N16 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

    }

}