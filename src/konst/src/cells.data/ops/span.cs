//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Cells
    {
        /// <summary>
        /// Presents an 8-bit value as a single-celled T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8k)]
        public static Span<T> edit<T>(in Cell8 src)
            where T : unmanaged
                => span<Cell8,T>(ref z.@edit(src));

        /// <summary>
        /// Presents a 16-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static Span<T> edit<T>(in Cell16 src)
            where T : unmanaged
                => span<Cell16,T>(ref z.@edit(src));

        /// <summary>
        /// Presents a 32-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static Span<T> edit<T>(in Cell32 src)
            where T : unmanaged
                => span<Cell32,T>(ref z.@edit(src));

        /// <summary>
        /// Presents a 64-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> edit<T>(in Cell64 src)
            where T : unmanaged
                => span<Cell64,T>(ref z.@edit(src));

        /// <summary>
        /// Presents a 128-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> edit<T>(in Cell128 src)
            where T : unmanaged
                => span<Cell128,T>(ref z.@edit(src));

        /// <summary>
        /// Presents a 256-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> edit<T>(in Cell256 src)
            where T : unmanaged
                => span<Cell256,T>(ref z.@edit(src));

        /// <summary>
        /// Presents a 256-bit value as a T-parametric span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> edit<T>(in Cell512 src)
            where T : unmanaged
                => span<Cell512,T>(ref z.@edit(src));
    }
}