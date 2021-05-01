//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static HexCharData;

    partial struct Hex
    {
        [MethodImpl(Inline), Op]
        public static HexSymLo symbol(LowerCased casing, byte index)
            => index < LowerSymbolCount ? skip(LowerSymbols, index) : HexSymLo.None;

        [MethodImpl(Inline), Op]
        public static HexSymUp symbol(UpperCased casing, byte index)
            => index < UpperSymbolCount ? skip(UpperSymbols, index) : HexSymUp.None;

        [MethodImpl(Inline), Op]
        public static HexSym symbol(UpperCased @case, HexDigit src)
            => (HexSym)code(@case, src);

        [MethodImpl(Inline), Op]
        public static HexSym symbol(LowerCased @case, HexDigit src)
            => (HexSym)code(@case, src);
    }
}