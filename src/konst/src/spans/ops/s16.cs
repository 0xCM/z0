//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Spans
    {
        /// <summary>
        /// Presents a span of generic values as a span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<short> s16i<T>(Span<T> src)
            where T : unmanaged
                => recover<T,short>(src);

        /// <summary>
        /// Presents a span of generic values as a span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ushort> s16u<T>(Span<T> src)
            where T : unmanaged
                => recover<T,ushort>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<short> s16i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => recover<T,short>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ushort> s16u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => recover<T,ushort>(src);


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<short> s16i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => recover<T,short>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ushort> s16u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => recover<T,ushort>(src.Span);
    }
}