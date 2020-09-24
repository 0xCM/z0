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
        [MethodImpl(Inline)]
        public static AsciSymbol symbol(AsciCharCode src)
            => src;

        [MethodImpl(Inline)]
        public static AsciSymbol symbol(AsciLetterLo src)
            => (AsciCharCode)src;

        [MethodImpl(Inline)]
        public static AsciSymbol symbol(AsciLetterUp src)
            => (AsciCharCode)src;

        [MethodImpl(Inline), Op]
        public static Symbol<BinarySym,byte,N1> symbol(BinaryDigit src)
            => SymbolStore.symbol(src);

        [MethodImpl(Inline), Op]
        public static Symbol<OctalSym,byte,N3> symbol(OctalDigit src)
            => SymbolStore.symbol(src);

        [MethodImpl(Inline), Op]
        public static Symbol<BinarySym,byte,N1> symbol(Base2 @base, byte src)
            => SymbolStore.symbol(@base, src);

        [MethodImpl(Inline), Op]
        public static Symbol<DecimalSym,byte,N4> symbol(DecimalDigit src)
            => SymbolStore.symbol(src);

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(UpperCased @case, HexDigit src)
            => SymbolStore.symbol(@case,src);

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(LowerCased @case, HexDigit src)
            => SymbolStore.symbol(@case,src);
   }
}