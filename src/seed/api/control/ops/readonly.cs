// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        /// <summary>
        /// Reflects the immutable self
        /// </summary>
        /// <param name="src">The self</param>
        /// <typeparam name="T">The self cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> @readonly<T>(Span<T> src)
            => src;

        /// <summary>
        /// Reflects the content of an array as a readonly span
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> @readonly<T>(T[] src)
            => src;
    }
}