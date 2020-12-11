//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
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
            => src;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> span(string src)
            => memory.span(src);

        [MethodImpl(Inline)]
        public static Span<T> span<T>(ReadOnlySpan<T> src)
            => memory.span(src);
    }
}