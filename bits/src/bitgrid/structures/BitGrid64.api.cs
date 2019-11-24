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

    partial class BitGrid64
    {        
        /// <summary>
        /// Allocates and fills a 1x64 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,T> alloc<T>(N1 m, N64 n,T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 1x64 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,T> alloc<T>(N1 m = default, N64 n = default)
            where T : unmanaged            
                => define<N1,N64,T>();

        /// <summary>
        /// Allocates and fills a 64x1 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,T> alloc<T>(N64 m, N1 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 64x1 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,T> alloc<T>(N64 m = default, N1 n = default)
            where T : unmanaged            
                => define<N64,N1,T>();

        /// <summary>
        /// Allocates and fills a 2x32 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,T> alloc<T>(N2 m, N32 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 2x32 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,T> alloc<T>(N2 m = default, N32 n = default)
            where T : unmanaged            
                => define<N2,N32,T>();

        /// <summary>
        /// Allocates and fills a 32x2 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,T> alloc<T>(N32 m, N2 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 32x2 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,T> alloc<T>(N32 m = default, N2 n = default)
            where T : unmanaged            
                => define<N32,N2,T>();

        /// <summary>
        /// Allocates and fills a 4x16 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,T> alloc<T>(N4 m, N16 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 4x16 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,T> alloc<T>(N4 m = default, N16 n = default)
            where T : unmanaged            
                => define<N4,N16,T>();

        /// <summary>
        /// Allocates and fills a 16x4 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,T> alloc<T>(N16 m, N4 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 16x4 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,T> alloc<T>(N16 m = default, N4 n = default)
            where T : unmanaged            
                => define<N16,N4,T>();

        /// <summary>
        /// Allocates and fills a 8x8 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> alloc<T>(N8 m, N8 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 8x8 grid to cover 64 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> alloc<T>(N8 m = default, N8 n = default)
            where T : unmanaged            
                => define<N8,N8,T>();

        [MethodImpl(Inline)]
        internal static BitGrid64<M,N,T> define<M,N,T>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid64<M, N, T>(0ul);

        [MethodImpl(Inline)]
        internal static BitGrid64<M,N,T> define<M,N,T>(M m,N n, T fill)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid64<M, N, T>(ginx.vbroadcast(n128, fill).AsUInt64().ToScalar());
    }

}