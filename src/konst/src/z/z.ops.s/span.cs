//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static Span<byte> span8u<T>(in T src)
            where T : struct
                => memory.span8u(src);

        [MethodImpl(Inline)]
        public static Span<char> span16c<T>(in T src)
            where T : struct
                => memory.span16c(src);

        [MethodImpl(Inline)]
        public static Span<ushort> span16u<T>(in T src)
            where T : struct
                => memory.span16u(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> span16c(ReadOnlySpan<byte> src)
            => memory.span16c(src);

        [MethodImpl(Inline)]
        public static Span<uint> span32u<T>(in T src)
            where T : struct
                => memory.span32u(src);

        [MethodImpl(Inline)]
        public static Span<ulong> span64u<T>(in T src)
            where T : struct
                => memory.span64u(src);

        [MethodImpl(Inline)]
        public static Span<T> span<S,T>(ref S src, int count)
            where T : struct
            where S : struct
                => memory.span<S,T>(ref src, count);

        [MethodImpl(Inline)]
        public static Span<T> span<S,T>(ref S src)
            where T : struct
            where S : struct
                => memory.span<S,T>(ref src);

        [MethodImpl(Inline)]
        public static Span<T> span<T>(long count)
            => memory.span<T>(count);

        [MethodImpl(Inline)]
        public static Span<T> span<T>(uint count)
            => memory.span<T>(count);

        [MethodImpl(Inline)]
        public static Span<T> span<T>(ulong count)
            => memory.span<T>((uint)count);

        [MethodImpl(Inline)]
        public static Span<T> span<T>(IEnumerable<T> src)
            => memory.span(src);

        [MethodImpl(Inline)]
        public static Span<T> span<T>(T[] src)
            => memory.span(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> span(string src)
            => memory.span(src);

        [MethodImpl(Inline)]
        public static Span<T> span<T>(ReadOnlySpan<T> src)
            => memory.span(src);
    }
}