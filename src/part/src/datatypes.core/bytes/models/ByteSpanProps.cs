//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = ByteSpans;

    public readonly struct ByteSpanProps
    {
        readonly Index<ByteSpanProp> Data;

        [MethodImpl(Inline)]
        public ByteSpanProps(ByteSpanProp[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<ByteSpanProp> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<ByteSpanProp> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref ByteSpanProp First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ByteSize TotalSize
        {
            [MethodImpl(Inline)]
            get => api.size(Data);

        }

        public ByteSpanProp Merge(Identifier name)
            => api.merge(name, this);

        [MethodImpl(Inline)]
        public static implicit operator ByteSpanProps(ByteSpanProp[] src)
            => new ByteSpanProps(src);
    }
}