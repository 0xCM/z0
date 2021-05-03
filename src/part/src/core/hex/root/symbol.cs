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
        public static HexSym symbol(LowerCased casing, byte index)
            => (HexSym)(index < LowerSymbolCount ? skip(LowerSymbols, index) : HexSymLo.None);

        [MethodImpl(Inline), Op]
        public static HexSym symbol(UpperCased casing, byte index)
            => (HexSym)(index < UpperSymbolCount ? skip(UpperSymbols, index) : HexSymUp.None);

        [MethodImpl(Inline), Op]
        public static HexSym symbol(UpperCased @case, HexDigit src)
            => (HexSym)code(@case, src);

        [MethodImpl(Inline), Op]
        public static HexSym symbol(LowerCased @case, HexDigit src)
            => (HexSym)code(@case, src);

        [MethodImpl(Inline)]
        public static HexSym symbol<C>(C @case, HexDigit src)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return symbol(LowerCase,src);
            else if(typeof(C) == typeof(UpperCased))
                return symbol(UpperCase,src);
            else
                throw no<C>();
        }

        [MethodImpl(Inline)]
        public static HexSym symbol<C>(C @case, byte index)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return symbol(LowerCase,index);
            else if(typeof(C) == typeof(UpperCased))
                return symbol(UpperCase,index);
            else
                throw no<C>();
        }
    }
}