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
    using api = ByteSpans;

    public readonly struct ByteSpanProp : ITextual
    {
        public Identifier Name {get;}

        public BinaryCode Data {get;}

        public bool IsStatic {get;}

        [MethodImpl(Inline)]
        public ByteSpanProp(string name, byte[] data, bool isStatic = true)
        {
            Name = name;
            Data = data;
            IsStatic = isStatic;
        }

        public ref byte FirstByte
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ByteSize DataSize
        {
            [MethodImpl(Inline)]
            get => Data.Size;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Segment(ByteSize offset, ByteSize size)
            => slice(Data.View, offset, size);
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}