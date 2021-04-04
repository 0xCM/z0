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

    public readonly struct ByteSpan
    {
        readonly Index<byte> Data;

        [MethodImpl(Inline)]
        public ByteSpan(Index<byte> data)
        {
            Data = data;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Segment(ByteSize offset, ByteSize size)
            => slice(View, offset, size);

        [MethodImpl(Inline)]
        public static implicit operator ByteSpan(byte[] src)
            => new ByteSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSpan(Index<byte> src)
            => new ByteSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(ByteSpan src)
            => src.View;
    }

}