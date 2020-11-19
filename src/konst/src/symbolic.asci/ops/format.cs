//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using F = AsciFormatter;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static string format(in asci2 src)
            => F.format(src);

        [MethodImpl(Inline), Op]
        public static string format(in asci4 src)
            => F.format(src);

        [MethodImpl(Inline), Op]
        public static string format(in asci8 src)
            => F.format(src);

        [MethodImpl(Inline), Op]
        public static string format(in asci16 src)
            => F.format(src);

        [MethodImpl(Inline), Op]
        public static string format(in asci32 src)
            => F.format(src);

        [MethodImpl(Inline), Op]
        public static string format(in asci64 src)
            => F.format(src);
    }
}