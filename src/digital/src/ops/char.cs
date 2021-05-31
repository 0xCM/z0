//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Digital
    {
        [MethodImpl(Inline), Op]
        public static char @char(BinaryDigit src)
            => (char)symbol(src);

        [MethodImpl(Inline), Op]
        public static char @char(OctalDigit src)
            => (char)symbol(src);

        [MethodImpl(Inline), Op]
        public static char @char(DecimalDigit src)
            => (char)symbol(src);

        [MethodImpl(Inline), Op]
        public static char @char(UpperCased @case, HexDigit src)
            => Hex.hexchar(@case,src);

        [MethodImpl(Inline), Op]
        public static char @char(LowerCased @case, HexDigit src)
            => Hex.hexchar(@case,src);
    }
}