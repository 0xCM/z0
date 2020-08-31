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
        public static ReadOnlySpan<T> view<T>(in FixedCell8 src)
            where T : unmanaged
                => view<FixedCell8,T>(src);

        /// <summary>
        /// Presents a 32-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static ReadOnlySpan<T> view<T>(in FixedCell16 src)
            where T : unmanaged
                => view<FixedCell16,T>(src);

        /// <summary>
        /// Presents a 32-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static ReadOnlySpan<T> view<T>(in Fixed32 src)
            where T : unmanaged
                => view<Fixed32,T>(src);

        /// <summary>
        /// Presents a 64-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in FixedCell64 src)
            where T : unmanaged
                => view<FixedCell64,T>(src);

        /// <summary>
        /// Presents a 128-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in FixedCell128 src)
            where T : unmanaged
                => view<FixedCell128,T>(src);

        /// <summary>
        /// Presents a 256-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in FixedCell256 src)
            where T : unmanaged
                => view<FixedCell256,T>(src);

        /// <summary>
        /// Presents a 512-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in FixedCell512 src)
            where T : unmanaged
                => view<FixedCell512,T>(src);
    }
}