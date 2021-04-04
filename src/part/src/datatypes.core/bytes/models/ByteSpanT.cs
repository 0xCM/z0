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

    public readonly struct ByteSpan<T>
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        public ByteSpan(Index<T> data)
        {
            Data = data;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => recover<T,byte>(Data.View);
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => recover<T,byte>(Data.Edit);
        }

        public ByteSpanProp Property(Identifier name)
            => ByteSpans.property(name, this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Segment(ByteSize offset, ByteSize size)
            => slice(View, offset, size);

        [MethodImpl(Inline)]
        public static implicit operator ByteSpan<T>(T[] src)
            => new ByteSpan<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSpan<T>(Index<T> src)
            => new ByteSpan<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(ByteSpan<T> src)
            => src.View;
    }
}