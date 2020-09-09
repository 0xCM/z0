//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Fixed
    {
        /// <summary>
        /// Presents an 8-bit value as a single-celled T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8k)]
        public static ReadOnlySpan<T> view<T>(in Cell8 src)
            where T : unmanaged
                => view<Cell8,T>(src);

        /// <summary>
        /// Presents a 32-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static ReadOnlySpan<T> view<T>(in Cell16 src)
            where T : unmanaged
                => view<Cell16,T>(src);

        /// <summary>
        /// Presents a 32-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static ReadOnlySpan<T> view<T>(in Cell32 src)
            where T : unmanaged
                => view<Cell32,T>(src);

        /// <summary>
        /// Presents a 64-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in Cell64 src)
            where T : unmanaged
                => view<Cell64,T>(src);

        /// <summary>
        /// Presents a 128-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in Cell128 src)
            where T : unmanaged
                => view<Cell128,T>(src);

        /// <summary>
        /// Presents a 256-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in Cell256 src)
            where T : unmanaged
                => view<Cell256,T>(src);

        /// <summary>
        /// Presents a 512-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in Cell512 src)
            where T : unmanaged
                => view<Cell512,T>(src);
    }
}