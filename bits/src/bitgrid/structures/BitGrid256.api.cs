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

    partial class BitGrid256
    {        
        /// <summary>
        /// Allocates a 1x256 grid to cover 256 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid256<N1,N256,T> alloc<T>(N1 m = default, N256 n = default,T fill = default)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a 256x1 grid to cover 256 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> alloc<T>(N256 m = default, N1 n = default, T fill = default)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a 2x128 grid to cover 256 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N2,N128,T> alloc<T>(N2 m = default, N128 n = default,T fill = default)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a 128x2 grid to cover 256 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> alloc<T>(N128 m = default, N2 n = default, T fill = default)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a 4x64 grid to cover 256 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N4,N64,T> alloc<T>(N4 m = default, N64 n = default,T fill = default)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a 64x4 grid to cover 256 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N64,N4,T> alloc<T>(N64 m = default, N4 n = default, T fill = default)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a 8x32 grid to cover 256 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> alloc<T>(N8 m = default, N32 n = default, T fill = default)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a 32x8 grid to cover 256 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> alloc<T>(N32 m = default, N8 n = default,T fill = default)
            where T : unmanaged            
                => define(m,n,fill);

        /// <summary>
        /// Allocates a 16x16 grid to cover 256 bits
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> alloc<T>(N16 m = default, N16 n = default,T fill = default)
            where T : unmanaged            
                => define(m,n,fill);

        [MethodImpl(Inline)]
        internal static BitGrid256<M,N,T> define<M,N,T>(M m = default, N n = default, T fill = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid256<M, N, T>(ginx.vbroadcast(n256, fill));
    }
}