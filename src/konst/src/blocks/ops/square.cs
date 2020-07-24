//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;        

    partial struct Blocks
    {
        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(UInt8k)]
        public static Block8<T> square<T>(W8 w, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(UInt8k)]
        public static Block16<T> square<T>(W16 w, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(UInt8k)]
        public static Block32<T> square<T>(W32 w, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 64-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(UInt8k)]
        public static Block64<T> square<T>(W64 w, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 128-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(UInt8k)]
        public static Block128<T> square<T>(W128 w, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data of square dimension in 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="n">The square tabular order</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(UInt8k)]
        public static Block256<T> square<T>(W256 w, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  n*n));
    }
}