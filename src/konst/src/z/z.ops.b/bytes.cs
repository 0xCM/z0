//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static Span<byte> bytes<T>(in T src)
            where T : struct
                => memory.bytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes<T>(Span<T> src)
            where T : struct
                => memory.bytes(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
            where T : struct
                => memory.bytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes<T>(Span<T> src, int offset)
            where T : struct
                => memory.bytes(src, offset);

        [MethodImpl(Inline)]
        public static Span<byte> bytes<T>(Span<T> src, int offset, int count)
            where T : struct
                => memory.bytes(src, offset, count);

        [MethodImpl(Inline)]
        public static Span<byte> bytes<T>(Span<T> src, int offset, int? length)
            where T : struct
                => memory.bytes(src, offset, length);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src, int offset, int count)
            where T : struct
                => memory.bytes(src, offset, count);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src, int offset)
            where T : struct
                => memory.bytes(src, offset);
    }
}