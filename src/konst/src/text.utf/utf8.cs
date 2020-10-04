//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct utf8 : ITextual
    {
        static Utf8 Kind => Utf8Encoding;

        readonly byte[] Data;

        [MethodImpl(Inline)]
        public utf8(byte[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public utf8(string src)
            => Data = TextEncoders.encode(Kind, src, out byte[] _);

        [MethodImpl(Inline)]
        public static implicit operator utf8(string src)
            => new utf8(src);

        [MethodImpl(Inline)]
        public static implicit operator utf8(byte[] src)
            => new utf8(src);

        [MethodImpl(Inline)]
        public static implicit operator utf8(BinaryCode src)
            => new utf8(src);

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextEncoders.decode(Kind, Data, out string _);

        public override string ToString()
            => Format();
    }
}