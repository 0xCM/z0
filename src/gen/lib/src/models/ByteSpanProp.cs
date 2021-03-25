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
        {
            var dst = text.build();
            dst.Append("public");
            dst.Append(Chars.Space);
            dst.Append(IsStatic ? text.rspace("static") : EmptyString);
            dst.Append("ReadOnlySpan<byte>");
            dst.Append(Chars.Space);
            dst.Append(Name);
            dst.Append(" => ");
            dst.Append(string.Concat("new byte", text.bracket(Data.Length), text.embrace(TextFormatter.hexarray<byte>(Data))));
            dst.Append(Chars.Semicolon);
            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}