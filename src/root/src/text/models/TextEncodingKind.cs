//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using K = TextEncodingKind;

    public enum TextEncodingKind : byte
    {
        None = 0,

        Asci = 7,

        Utf8 = 8,

        Utf16 = 16,

        Utf32 = 32
    }

    public interface ITextEncodingKind
    {
        TextEncodingKind Kind {get;}
    }

    public interface ITextEncodingKind<T> : ITextEncodingKind
        where T : unmanaged, ITextEncodingKind<T>
    {

    }

    public readonly struct TextEncodingKind<T> : ITextEncodingKind<T>
        where T : unmanaged, ITextEncodingKind<T>
    {
        public TextEncodingKind Kind
        {
            [MethodImpl(Inline)]
            get => default(T).Kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator TextEncodingKind<T>(T src)
            => default;
    }

    public readonly struct TextEncodings
    {
        public readonly struct AsciEncoding : ITextEncodingKind<AsciEncoding>
        {
            public TextEncodingKind Kind => K.Asci;

        }

        public readonly struct Utf8Encoding : ITextEncodingKind<Utf8Encoding>
        {
            public TextEncodingKind Kind => K.Utf8;
        }

        public readonly struct Utf16Encoding : ITextEncodingKind<Utf16Encoding>
        {
            public TextEncodingKind Kind => K.Utf16;
        }

        public readonly struct Utf32Encoding : ITextEncodingKind<Utf32Encoding>
        {
            public TextEncodingKind Kind => K.Utf32;
        }
    }
}