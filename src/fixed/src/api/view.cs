//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Fixed
    {
        /// <summary>
        /// Presents an 8-bit value as a single-celled T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8)]
        public static ReadOnlySpan<T> view<T>(in Fixed8 src)
            where T : unmanaged
                => view<Fixed8,T>(src);

        /// <summary>
        /// Presents a 32-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16)]
        public static ReadOnlySpan<T> view<T>(in Fixed16 src)
            where T : unmanaged
                => view<Fixed16,T>(src);

        /// <summary>
        /// Presents a 32-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32)]
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
        public static ReadOnlySpan<T> view<T>(in Fixed64 src)
            where T : unmanaged
                => view<Fixed64,T>(src);

        /// <summary>
        /// Presents a 128-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in Fixed128 src)
            where T : unmanaged
                => view<Fixed128,T>(src);

        /// <summary>
        /// Presents a 256-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in Fixed256 src)
            where T : unmanaged
                => view<Fixed256,T>(src);

        /// <summary>
        /// Presents a 512-bit value as a T-parametric readonly span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in Fixed512 src)
            where T : unmanaged
                => view<Fixed512,T>(src);
    }
}