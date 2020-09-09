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
        public static Span<T> span<T>(ref Cell8 src)
            where T : unmanaged
                => span<Cell8,T>(ref src);

        /// <summary>
        /// Presents a 16-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static Span<T> span<T>(ref Cell16 src)
            where T : unmanaged
                => span<Cell16,T>(ref src);

        /// <summary>
        /// Presents a 32-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static Span<T> span<T>(ref Cell32 src)
            where T : unmanaged
                => span<Cell32,T>(ref src);

        /// <summary>
        /// Presents a 64-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> span<T>(ref Cell64 src)
            where T : unmanaged
                => span<Cell64,T>(ref src);

        /// <summary>
        /// Presents a 128-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> span<T>(ref Cell128 src)
            where T : unmanaged
                => span<Cell128,T>(ref src);

        /// <summary>
        /// Presents a 256-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> span<T>(ref Cell256 src)
            where T : unmanaged
                => span<Cell256,T>(ref src);

        /// <summary>
        /// Presents a 256-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> span<T>(ref Cell512 src)
            where T : unmanaged
                => span<Cell512,T>(ref src);
    }
}