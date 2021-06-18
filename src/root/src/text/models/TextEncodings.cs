//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    using K = TextEncodingKind;

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

    public static partial class XText
    {
        [MethodImpl(Inline), Op]
        public static Encoding System(this AsciEncoding src)
            => Encoding.ASCII;

        [MethodImpl(Inline), Op]
        public static Encoding System(this Utf8Encoding src)
            => Encoding.UTF8;

        [MethodImpl(Inline), Op]
        public static Encoding System(this Utf16Encoding src)
            => Encoding.Unicode;

        [MethodImpl(Inline), Op]
        public static Encoding System(this TextEncodingKind kind)
            =>  kind == TextEncodingKind.Asci ? Encoding.ASCII
              : kind == TextEncodingKind.Utf8 ? Encoding.UTF8
              : Encoding.Unicode;

    }
}