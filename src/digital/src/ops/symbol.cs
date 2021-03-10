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
        public static BinarySym symbol(BinaryDigit src)
            => (BinarySym)(src + (byte)BinarySymFacet.First);

        [MethodImpl(Inline), Op]
        public static OctalSym symbol(OctalDigit src)
            => (OctalSym)((byte)src + (byte)OctalSymFacet.First);

        [MethodImpl(Inline), Op]
        public static BinarySym symbol(Base2 @base, byte src)
            => (BinarySym)(src + (byte)BinarySymFacet.First);

        [MethodImpl(Inline), Op]
        public static DecimalSym symbol(DecimalDigit src)
            => (DecimalSym)((byte)src + DecimalSymFacet.First);

        [MethodImpl(Inline), Op]
        public static HexSym symbol(UpperCased @case, HexDigit src)
            => (HexSym)code(@case, src);

        [MethodImpl(Inline), Op]
        public static HexSym symbol(LowerCased @case, HexDigit src)
            => (HexSym)code(@case, src);
    }
}