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
        /// Presents a readonly span of generic values as a span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<sbyte> s8i<T>(Span<T> src)
            where T : unmanaged
                => recover<T,sbyte>(src);

        /// <summary>
        /// Presents a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<byte> s8u<T>(Span<T> src)
            where T : unmanaged
                => recover<T,byte>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<sbyte> s8i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => recover<T,sbyte>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<byte> s8u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => recover<T,byte>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<sbyte> s8i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => recover<T,sbyte>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<byte> s8u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => recover<T,byte>(src.Span);
    }
}