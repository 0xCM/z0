//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static char @char(byte src)
            => (char)src;

        [MethodImpl(Inline), Op]
        public static char @char(in asci2 src, HexKind1 index)
            => (char)code(src, index);

        [MethodImpl(Inline), Op]
        public static char @char(in asci4 src, HexKind2 index)
            => (char)code(src, index);

        [MethodImpl(Inline), Op]
        public static char @char(in asci8 src, HexKind3 index)
            => (char)code(src, index);

        [MethodImpl(Inline), Op]
        public static char @char(in asci16 src, HexKind4 index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static char @char(UpperCased @case, HexDigit digit)
            => (char)code(@case, digit);

        [MethodImpl(Inline), Op]
        public static char @char(LowerCased @case, HexDigit digit)
            => (char)code(@case, digit);
    }
}