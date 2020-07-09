//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;

    using static Konst;

    partial struct core
    {
        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(int count)
            => sys.span<T>(count);

        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(uint count)
            => sys.span<T>(count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(IEnumerable<T> src)
            => sys.array(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(params T[] src)
            => src;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> span(string src)
            => src;
    }
}