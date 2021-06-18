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
    using static TextEncodings;

    partial class XText
    {
        [MethodImpl(Inline), Op]
        public static Encoding SystemEncoding(this AsciEncoding src)
            => Encoding.ASCII;

        [MethodImpl(Inline), Op]
        public static Encoding SystemEncoding(this Utf8Encoding src)
            => Encoding.UTF8;

        [MethodImpl(Inline), Op]
        public static Encoding SystemEncoding(this Utf16Encoding src)
            => Encoding.Unicode;

        [MethodImpl(Inline), Op]
        public static Encoding SystemEncoding(this TextEncodingKind kind)
            =>  kind == TextEncodingKind.Asci ? Encoding.ASCII
              : kind == TextEncodingKind.Utf8 ? Encoding.UTF8
              : Encoding.Unicode;
    }
}