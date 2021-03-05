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
        public static Symbol<BinarySym,byte,N1> symbol(BinaryDigit src)
            => Symbolic.symbol(src);


        [MethodImpl(Inline), Op]
        public static Symbol<OctalSym,byte,N3> symbol(OctalDigit src)
            => Symbolic.symbol(src);

        [MethodImpl(Inline), Op]
        public static Symbol<BinarySym,byte,N1> symbol(Base2 @base, byte src)
            => Symbolic.symbol(@base, src);

        [MethodImpl(Inline), Op]
        public static Symbol<DecimalSym,byte,N4> symbol(DecimalDigit src)
            => Symbolic.symbol(src);

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(UpperCased @case, HexDigit src)
            => Symbolic.symbol(@case,src);

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(LowerCased @case, HexDigit src)
            => Symbolic.symbol(@case,src);

        [MethodImpl(Inline), Op]
        public static char @char(BinaryDigit src)
            => (char)symbol(src).Value;

        [MethodImpl(Inline), Op]
        public static char @char(OctalDigit src)
            => (char)symbol(src).Value;

        [MethodImpl(Inline), Op]
        public static char @char(DecimalDigit src)
            => (char)symbol(src).Value;

        [MethodImpl(Inline), Op]
        public static char @char(UpperCased @case, HexDigit src)
            => (char)symbol(@case, src).Value;

        [MethodImpl(Inline), Op]
        public static char @char(LowerCased @case, HexDigit src)
            => (char)symbol(@case, src).Value;

    }
}