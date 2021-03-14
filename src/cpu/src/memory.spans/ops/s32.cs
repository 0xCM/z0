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
        /// Presents a span of generic values as a span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<int> s32i<T>(Span<T> src)
            where T : unmanaged
                => recover<T,int>(src);

        /// <summary>
        /// Presents a span of generic values as a span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<uint> s32u<T>(Span<T> src)
            where T : unmanaged
                => recover<T,uint>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<float> s32f<T>(Span<T> src)
            where T : unmanaged
                => recover<T,float>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<int> s32i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => recover<T,int>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<uint> s32u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => recover<T,uint>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<float> s32f<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => recover<T,float>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<int> s32i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => recover<T,int>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<uint> s32u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => recover<T,uint>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<float> s32f<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => recover<T,float>(src.Span);
    }
}