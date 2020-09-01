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
        /// Allocates the minimum number of blocks required to block-align tabular data in 8-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static SpanBlock8<T> rectangle<T>(W8 w, ulong m, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 16-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt16k)]
        public static SpanBlock16<T> rectangle<T>(W16 w, ulong m, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 32-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static SpanBlock32<T> rectangle<T>(W32 w, ulong m, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 64-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static SpanBlock64<T> rectangle<T>(W64 w, ulong m, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 64-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static SpanBlock128<T> rectangle<T>(W128 w, ulong m, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));

        /// <summary>
        /// Allocates the minimum number of blocks required to block-align tabular data in 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static SpanBlock256<T> rectangle<T>(W256 w, ulong m, ulong n)
            where T : unmanaged
                => alloc<T>(w, cellcover<T>(w,  m*n));
    }
}