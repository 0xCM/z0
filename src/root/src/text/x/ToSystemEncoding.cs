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
        public static Encoding ToSystemEncoding(this K kind)
            =>  kind == K.Asci ? Encoding.ASCII
              : kind == K.Utf8 ? Encoding.UTF8
              : kind == K.Utf16 ? Encoding.BigEndianUnicode
              : kind == K.Unicode ? Encoding.Unicode
              : kind == K.Utf32 ? Encoding.UTF32
              : Encoding.Unicode;
    }
}