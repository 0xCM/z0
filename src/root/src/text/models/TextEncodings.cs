//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = TextEncodingKind;

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