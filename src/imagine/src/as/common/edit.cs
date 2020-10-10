//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct AsDeprecated
    {
        /// <summary>
        /// Transforms a readonly T-cell into an editable T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T edit<T>(in T src)
            => ref AsRef(src);

        /// <summary>
        /// Covers the content of a readonly span with an editable span
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="count">The number of source cells to read</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <returns>Obviously, this trick could be particularly dangerous</returns>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> edit<T>(ReadOnlySpan<T> src)
            =>  cover(edit(first(src)), src.Length);
    }
}