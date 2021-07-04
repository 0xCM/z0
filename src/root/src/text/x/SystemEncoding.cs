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

    partial class XText
    {
        [MethodImpl(Inline), Op]
        public static Encoding SystemEncoding(this AsciPoints src)
            => Encoding.ASCII;

        [MethodImpl(Inline), Op]
        public static Encoding SystemEncoding(this Utf8Points src)
            => Encoding.UTF8;

        [MethodImpl(Inline), Op]
        public static Encoding SystemEncoding(this UnicodePoints src)
            => Encoding.Unicode;

        [MethodImpl(Inline), Op]
        public static Encoding SystemEncoding(this Utf16Points src)
            => Encoding.BigEndianUnicode;

        [MethodImpl(Inline), Op]
        public static Encoding SystemEncoding(this Utf32Points src)
            => Encoding.UTF32;

        [MethodImpl(Inline), Op]
        public static Encoding SystemEncoding(this K kind)
            =>  kind == K.Asci ? Encoding.ASCII
              : kind == K.Utf8 ? Encoding.UTF8
              : kind == K.Utf16 ? Encoding.BigEndianUnicode
              : kind == K.Unicode ? Encoding.Unicode
              : kind == K.Utf32 ? Encoding.UTF32
              : Encoding.Unicode;
    }
}