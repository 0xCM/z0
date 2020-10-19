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
   }
}