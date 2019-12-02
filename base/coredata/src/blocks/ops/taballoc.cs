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

    partial class DataBlocks
    {
        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> taballoc<T>(N16 w, int m, int n)
            where T : unmanaged
                => alloc<T>(w, blockalign<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> taballoc<T>(N16 w, int n)
            where T : unmanaged
                => alloc<T>(w, blockalign<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> taballoc<T>(N32 w, int m, int n)
            where T : unmanaged
                => alloc<T>(w, blockalign<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> taballoc<T>(N32 w, int n)
            where T : unmanaged
                => alloc<T>(w, blockalign<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 64-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> taballoc<T>(N64 w, int m, int n)
            where T : unmanaged
                => alloc<T>(w, blockalign<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 64-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> taballoc<T>(N64 w, int n)
            where T : unmanaged
                => alloc<T>(w, blockalign<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 128-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> taballoc<T>(N128 w, int m, int n)
            where T : unmanaged
                => alloc<T>(w, blockalign<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 128-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> taballoc<T>(N128 w, int n)
            where T : unmanaged
                => alloc<T>(w, blockalign<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> taballoc<T>(N256 w, int m, int n)
            where T : unmanaged
                => alloc<T>(w, blockalign<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> taballoc<T>(N256 w, int n)
            where T : unmanaged
                => alloc<T>(w, blockalign<T>(w,  n*n));
    }

}

