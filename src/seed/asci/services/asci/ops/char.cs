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
        public static char @char(in asci2 src, Hex1 index)
            => (char)code(src, index);

        [MethodImpl(Inline), Op]
        public static char @char(in asci4 src, Hex2 index)
            => (char)code(src, index);

        [MethodImpl(Inline), Op]
        public static char @char(in asci8 src, Hex3 index)
            => (char)code(src, index);

        [MethodImpl(Inline), Op]
        public static char @char(in asci16 src, Hex4 index)
            => (char)code(src,index);
    }
}