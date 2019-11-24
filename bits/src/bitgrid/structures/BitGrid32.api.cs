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

    public static class BitGrid32
    {                
        /// <summary>
        /// Allocates and fills a 1x32 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,T> alloc<T>(N1 m, N32 n,T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 1x32 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,T> alloc<T>(N1 m = default, N32 n = default)
            where T : unmanaged            
                => define<N1,N32,T>();

        /// <summary>
        /// Allocates and fills a 32x1 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,T> alloc<T>(N32 m, N1 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 32x1 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,T> alloc<T>(N32 m = default, N1 n = default)
            where T : unmanaged            
                => define<N32,N1,T>();

        /// <summary>
        /// Allocates and fills a 16x2 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,T> alloc<T>(N16 m, N2 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 16x2 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,T> alloc<T>(N16 m = default, N2 n = default)
            where T : unmanaged            
                => define<N16,N2,T>();

        /// <summary>
        /// Allocates and fills a 2x16 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,T> alloc<T>(N2 m, N16 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 2x16 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,T> alloc<T>(N2 m = default, N16 n = default)
            where T : unmanaged            
                => define<N2,N16,T>();

        /// <summary>
        /// Allocates and fills a 8x4 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,T> alloc<T>(N8 m, N4 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 8x4 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,T> alloc<T>(N8 m = default, N4 n = default)
            where T : unmanaged            
                => define<N8,N4,T>();

        /// <summary>
        /// Allocates and fills a 4x8 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,T> alloc<T>(N4 m, N8 n, T fill)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a zero-filled 4x8 grid to cover 32 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,T> alloc<T>(N4 m = default, N8 n = default)
            where T : unmanaged            
                => define<N4,N8,T>();

        [MethodImpl(Inline)]
        internal static BitGrid32<M,N,T> define<M,N,T>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid32<M, N, T>(0u);

        [MethodImpl(Inline)]
        internal static BitGrid32<M,N,T> define<M,N,T>(M m , N n, T fill)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid32<M, N, T>(convert<T,uint>(fill));


    }

}
