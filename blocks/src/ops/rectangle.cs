//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static Root;

    partial class Blocks
    {
        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> rectangle<T>(N16 w, int m, int n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> rectangle<T>(N32 w, int m, int n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 64-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> rectangle<T>(N64 w, int m, int n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 64-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> rectangle<T>(N128 w, int m, int n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> rectangle<T>(N256 w, int m, int n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));
    }
}

