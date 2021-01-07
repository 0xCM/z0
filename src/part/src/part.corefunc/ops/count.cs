//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    partial struct corefunc
    {
        /// <summary>
        /// Returns the number of cells in an array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint count<T>(T[] src)
            => (uint)(src?.Length ?? 0);

        /// <summary>
        /// Returns the number of cells in a span
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint count<T>(ReadOnlySpan<T> src)
            => (uint)src.Length;

        /// <summary>
        /// Returns the number of cells in a span
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint count<T>(Span<T> src)
            => (uint)src.Length;
    }
}