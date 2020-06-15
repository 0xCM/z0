//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct SpanReader
    {
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<byte> src, int offset, int length)
            => Spans.cover(skip(src,offset), length);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<byte> src, int offset)
            => Spans.cover(skip(src,offset), src.Length - offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, int offset)
            => Spans.cover(skip(src,offset), src.Length - offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, int offset, int length)
            => Spans.cover(skip(src,offset), length);
    }
}