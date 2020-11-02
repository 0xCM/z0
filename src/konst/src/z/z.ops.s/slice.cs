//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, uint offset)
            => memory.slice(src, offset);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, ulong offset)
            => memory.slice(src, offset);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, int offset)
            => memory.slice(src, offset);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, int offset, int length)
            => memory.slice(src, offset, length);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, uint offset, uint length)
            => memory.slice(src, offset, length);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, ulong offset, ulong length)
            => memory.slice(src, offset, length);

        [MethodImpl(Inline)]
        public static Span<T> slice<T>(Span<T> src, int offset)
            => memory.slice(src, offset);

        [MethodImpl(Inline)]
        public static Span<T> slice<T>(Span<T> src, uint offset)
            => memory.slice(src, offset);

        [MethodImpl(Inline)]
        public static Span<T> slice<T>(Span<T> src, int offset, int length)
            => memory.slice(src, offset, length);

        [MethodImpl(Inline)]
        public static Span<T> slice<T>(Span<T> src, uint offset, uint length)
            => memory.slice(src, offset, length);

        [MethodImpl(Inline)]
        public static Span<T> slice<T>(Span<T> src, ulong offset, ulong length)
             => memory.slice(src, offset, length);
   }
}