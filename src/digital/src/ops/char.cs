//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Digital
    {
        [MethodImpl(Inline), Op]
        public static char @char(BinaryDigitValue src)
            => (char)symbol(src);

        [MethodImpl(Inline), Op]
        public static char @char(OctalDigitValue src)
            => (char)symbol(src);

        [MethodImpl(Inline), Op]
        public static char @char(DecimalDigitValue src)
            => (char)symbol(src);

        [MethodImpl(Inline), Op]
        public static char @char(UpperCased @case, HexDigitValue src)
            => Hex.hexchar(@case,src);

        [MethodImpl(Inline), Op]
        public static char @char(LowerCased @case, HexDigitValue src)
            => Hex.hexchar(@case,src);
    }
}