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
        /// Presents a span of generic values as a span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<long> s64i<T>(Span<T> src)
            where T : unmanaged
                => recover<T,long>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ulong> s64u<T>(Span<T> src)
            where T : unmanaged
                => recover<T,ulong>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<double> s64f<T>(Span<T> src)
            where T : unmanaged
                => recover<T,double>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<long> s64i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => recover<T,long>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ulong> s64u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => recover<T,ulong>(src);

        /// <summary>
        /// Presents a readonly readonly span of generic values as a readonly readonly span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<double> s64f<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => recover<T,double>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<long> s64i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => recover<T,long>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ulong> s64u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => recover<T,ulong>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<double> s64f<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => recover<T,double>(src.Span);
    }
}