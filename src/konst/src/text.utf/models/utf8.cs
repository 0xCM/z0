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
        static TextEncoder Encoder => TextEncoders.utf8();

        readonly byte[] Data;

        [MethodImpl(Inline)]
        public utf8(byte[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public utf8(string src)
            => Data = Encoder.GetBytes(src);

        [MethodImpl(Inline)]
        public utf8(char[] src)
            => Data = Encoder.GetBytes(src);

        [MethodImpl(Inline)]
        public static implicit operator utf8(string src)
            => new utf8(src);

        [MethodImpl(Inline)]
        public static implicit operator utf8(byte[] src)
            => new utf8(src);

        [MethodImpl(Inline)]
        public static implicit operator utf8(char[] src)
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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == null || Data.Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Encoder.Decode(Data, out string _);

        public override string ToString()
            => Format();

        public static utf8 Empty
        {
            [MethodImpl(Inline)]
            get => new utf8(Array.Empty<byte>());
        }
    }
}