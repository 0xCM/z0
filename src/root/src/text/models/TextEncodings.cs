//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = TextEncodingKind;

    public readonly struct TextEncodings
    {

    }

    public readonly struct AsciPoints : ITextEncodingKind<AsciPoints>
    {
        public K Kind => K.Asci;
    }

    public readonly struct Utf8Points : ITextEncodingKind<Utf8Points>
    {
        public K Kind => K.Utf8;
    }

    public readonly struct UnicodePoints : ITextEncodingKind<UnicodePoints>
    {
        public K Kind => K.Unicode;
    }

    public readonly struct Utf16Points : ITextEncodingKind<Utf16Points>
    {
        public K Kind => K.Utf16;
    }

    public readonly struct Utf32Points : ITextEncodingKind<Utf32Points>
    {
        public K Kind => K.Utf32;
    }
}