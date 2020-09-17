//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct SpanBlocks
    {
        /// <summary>
        /// Allocates a single 8-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SpanBlock8<T> single<T>(W8 w)
            where T : unmanaged
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 16-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SpanBlock16<T> single<T>(W16 w)
            where T : unmanaged
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 32-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SpanBlock32<T> single<T>(W32 w)
            where T : unmanaged
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 64-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SpanBlock64<T> single<T>(W64 w)
            where T : unmanaged
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 128-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SpanBlock128<T> single<T>(W128 w)
            where T : unmanaged
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 256-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SpanBlock256<T> single<T>(W256 w)
            where T : unmanaged
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 512-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static SpanBlock512<T> single<T>(W512 w)
            where T : unmanaged
                => alloc<T>(w,1);
    }
}