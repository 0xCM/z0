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
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> square<T>(N16 w, int n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> square<T>(N32 w, int n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 64-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> square<T>(N64 w, int n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 128-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> square<T>(N128 w, int n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> square<T>(N256 w, int n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));
    }
}