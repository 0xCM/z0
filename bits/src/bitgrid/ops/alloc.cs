//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;


    partial class BitGrid
    {
        /// <summary>
        /// Allocates a generic bitgrid predicated on row/col count and parametric storage segment type
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<T> alloc<T>(ushort rows, ushort cols)
            where T : unmanaged
        {            
            Span<T> data = new T[BitCalcs.segcount<T>(rows, cols)];
            return new BitGrid<T>(data,rows,cols);            
        }

        /// <summary>
        /// Allocates a natural bitgrid predicated on parametric types
        /// </summary>
        /// <typeparam name="M">The number of rows in the grid</typeparam>
        /// <typeparam name="N">The number of columns in the grid</typeparam>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> alloc<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<T> data = new T[BitCalcs.segcount<T>(natval(m), natval(n))];            
            return new BitGrid<M, N, T>(data);
        }

        /// <summary>
        /// Allocates and fills a 1x32 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,T> alloc<T>(N32 block, N1 m, N32 n,T fill)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 1x32 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,T> alloc<T>(N32 block, N1 m = default, N32 n = default)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 32x1 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,T> alloc<T>(N32 block, N32 m, N1 n, T fill)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 32x1 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,T> alloc<T>(N32 block, N32 m = default, N1 n = default)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 16x2 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,T> alloc<T>(N32 block, N16 m, N2 n, T fill)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 16x2 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,T> alloc<T>(N32 block, N16 m = default, N2 n = default)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 2x16 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,T> alloc<T>(N32 block, N2 m, N16 n, T fill)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 2x16 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,T> alloc<T>(N32 block, N2 m = default, N16 n = default)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 8x4 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,T> alloc<T>(N32 block, N8 m, N4 n, T fill)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 8x4 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,T> alloc<T>(N32 block, N8 m = default, N4 n = default)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 4x8 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,T> alloc<T>(N32 block, N4 m, N8 n, T fill)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 4x8 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,T> alloc<T>(N32 block, N4 m = default, N8 n = default)
            where T : unmanaged            
                => BitGrid32.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 1x64 grid to cover 64 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,T> alloc<T>(N64 block, N1 m, N64 n,T fill)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 1x64 grid to cover 64 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,T> alloc<T>(N64 block, N1 m = default, N64 n = default)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 64x1 grid to cover 64 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,T> alloc<T>(N64 block, N64 m, N1 n, T fill)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 64x1 grid to cover 64 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,T> alloc<T>(N64 block, N64 m = default, N1 n = default)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 2x32 grid to cover 64 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,T> alloc<T>(N64 block, N2 m, N32 n, T fill)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 2x32 grid to cover 64 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,T> alloc<T>(N64 block, N2 m = default, N32 n = default)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 32x2 grid to cover 64 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,T> alloc<T>(N64 block, N32 m, N2 n, T fill)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 32x2 grid to cover 64 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,T> alloc<T>(N64 block, N32 m = default, N2 n = default)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 4x16 grid to cover 64 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,T> alloc<T>(N64 block, N4 m, N16 n, T fill)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 4x16 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,T> alloc<T>(N64 block, N4 m = default, N16 n = default)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 16x4 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,T> alloc<T>(N64 block, N16 m, N4 n, T fill)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 16x4 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,T> alloc<T>(N64 block, N16 m = default, N4 n = default)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n);

        /// <summary>
        /// Allocates and fills a 8x8 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> alloc<T>(N64 block, N8 m, N8 n, T fill)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 8x8 grid to cover 64 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> alloc<T>(N64 block, N8 m = default, N8 n = default)
            where T : unmanaged            
                => BitGrid64.alloc<T>(m,n);

        /// <summary>
        /// Allocates a 1x128 grid to cover 128 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N1,N128,T> alloc<T>(N128 block, N1 m = default, N128 n = default,T fill = default)
            where T : unmanaged            
                => BitGrid128.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 128x1 grid to cover 128 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N128,N1,T> alloc<T>(N128 block, N128 m = default, N1 n = default, T fill = default)
            where T : unmanaged            
                => BitGrid128.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 2x64 grid to cover 128 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,T> alloc<T>(N128 block, N2 m = default, N64 n = default,T fill = default)
            where T : unmanaged            
                => BitGrid128.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 64x2 grid to cover 128 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N64,N2,T> alloc<T>(N128 block, N64 m = default, N2 n = default, T fill = default)
            where T : unmanaged            
                => BitGrid128.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 4x32 grid to cover 128 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,T> alloc<T>(N128 block, N4 m = default, N32 n = default, T fill = default)
            where T : unmanaged            
                => BitGrid128.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 32x4 grid to cover 128 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N32,N4,T> alloc<T>(N128 block, N32 m = default, N4 n = default,T fill = default)
            where T : unmanaged            
                => BitGrid128.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 8x16 grid to cover 128 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,T> alloc<T>(N128 block, N8 m = default, N16 n = default,T fill = default)
            where T : unmanaged            
                => BitGrid128.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 16x8 grid to cover 128 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,T> alloc<T>(N128 block, N16 m = default, N8 n = default,T fill = default)
            where T : unmanaged            
                => BitGrid128.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 1x256 grid to cover 256 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N1,N256,T> alloc<T>(N256 block, N1 m = default, N256 n = default,T fill = default)
            where T : unmanaged            
                => BitGrid256.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 256x1 grid to cover 256 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> alloc<T>(N256 block, N256 m = default, N1 n = default, T fill = default)
            where T : unmanaged            
                => BitGrid256.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 2x128 grid to cover 256 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N2,N128,T> alloc<T>(N256 block, N2 m = default, N128 n = default,T fill = default)
            where T : unmanaged            
                => BitGrid256.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 128x2 grid to cover 256 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> alloc<T>(N256 block, N128 m = default, N2 n = default, T fill = default)
            where T : unmanaged            
                => BitGrid256.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 4x64 grid to cover 256 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N4,N64,T> alloc<T>(N256 block, N4 m = default, N64 n = default,T fill = default)
            where T : unmanaged            
                => BitGrid256.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 64x4 grid to cover 256 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N64,N4,T> alloc<T>(N256 block, N64 m = default, N4 n = default, T fill = default)
            where T : unmanaged            
                => BitGrid256.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 8x32 grid to cover 256 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> alloc<T>(N256 block, N8 m = default, N32 n = default, T fill = default)
            where T : unmanaged            
                => BitGrid256.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 32x8 grid to cover 256 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> alloc<T>(N256 block, N32 m = default, N8 n = default,T fill = default)
            where T : unmanaged            
                => BitGrid256.alloc(m,n,fill);

        /// <summary>
        /// Allocates a 16x16 grid to cover 256 bits
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> alloc<T>(N256 block, N16 m = default, N16 n = default,T fill = default)
            where T : unmanaged            
                => BitGrid256.alloc(m,n,fill);
         
    }
}