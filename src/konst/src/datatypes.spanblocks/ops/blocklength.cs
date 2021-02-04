//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct SpanBlocks
    {
        /// <summary>
        /// Computes the number of cells that comprise a single 8-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8k)]
        public static int blocklength<T>(W8 w, T t = default)
            where T : unmanaged
                => (int)size<T>();

        /// <summary>
        /// Computes the number of cells that comprise a single 16-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static int blocklength<T>(W16 w, T t = default)
            where T : unmanaged
                => 2/(int)size<T>();

        /// <summary>
        /// Computes the number of cells that comprise a single 32-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static int blocklength<T>(W32 w, T t = default)
            where T : unmanaged
                => 4/(int)size<T>();

        /// <summary>
        /// Computes the number of cells that comprise a single 64-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int blocklength<T>(W64 w, T t = default)
            where T : unmanaged
                => 8/(int)size<T>();

        /// <summary>
        /// Computes the number of cells that comprise a single 128-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int blocklength<T>(W128 w, T t = default)
            where T : unmanaged
                => 16/(int)size<T>();

        /// <summary>
        /// Computes the number of elements that comprise a 256-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int blocklength<T>(W256 w, T t = default)
            where T : unmanaged
                => 32/(int)size<T>();

        /// <summary>
        /// Computes the number of elements that comprise a 512-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int blocklength<T>(W512 w, T t = default)
            where T : unmanaged
                => 64/(int)size<T>();

        /// <summary>
        /// Computes the number of T-cells that comprise an N-block
        /// </summary>
        /// <param name="w">The block width representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklength<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => (int)((NatCalc.div(w, default(N8)))/size<T>());
    }
}