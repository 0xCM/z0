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
        /// Presents an 8-bit value as a single-celled T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8k)]
        public static Span<T> span<T>(ref FixedCell8 src)
            where T : unmanaged
                => span<FixedCell8,T>(ref src);

        /// <summary>
        /// Presents a 16-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static Span<T> span<T>(ref FixedCell16 src)
            where T : unmanaged
                => span<FixedCell16,T>(ref src);

        /// <summary>
        /// Presents a 32-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static Span<T> span<T>(ref Fixed32 src)
            where T : unmanaged
                => span<Fixed32,T>(ref src);

        /// <summary>
        /// Presents a 64-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> span<T>(ref FixedCell64 src)
            where T : unmanaged
                => span<FixedCell64,T>(ref src);

        /// <summary>
        /// Presents a 128-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> span<T>(ref FixedCell128 src)
            where T : unmanaged
                => span<FixedCell128,T>(ref src);

        /// <summary>
        /// Presents a 256-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> span<T>(ref FixedCell256 src)
            where T : unmanaged
                => span<FixedCell256,T>(ref src);

        /// <summary>
        /// Presents a 256-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> span<T>(ref FixedCell512 src)
            where T : unmanaged
                => span<FixedCell512,T>(ref src);
    }
}