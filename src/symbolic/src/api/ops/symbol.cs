//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]   
        public static BinarySymbol symbol(BinaryDigit src)
            => (BinarySymbol)((byte)src + (byte)BinarySymbol.First);

        [MethodImpl(Inline), Op]   
        public static BinarySymbol symbol(Base2 @base, byte src)
            => (BinarySymbol)(src + (byte)BinarySymbol.First);

        [MethodImpl(Inline), Op]   
        public static DecimalSymbol symbol(OctalDigit src)
            => (DecimalSymbol)((byte)src + (byte)OctalSymbol.First);

        [MethodImpl(Inline), Op]   
        public static DecimalSymbol symbol(DecimalDigit src)
            => (DecimalSymbol)((byte)src + (byte)DecimalSymbol.First);

        [MethodImpl(Inline), Op]   
        public static HexSymbol symbol(UpperCased @case, HexDigit src)
            => src <= HexDigit.x9 
                ? (HexSymbol)((byte)src + (byte)HexSymbol.FirstNumeral) 
                : (HexSymbol)((byte)src + (byte)HexSymbol.FirstLetterUp);

        [MethodImpl(Inline), Op]   
        public static HexSymbol symbol(LowerCased @case, HexDigit src)
            => src <= HexDigit.x9 
                ? (HexSymbol)((byte)src + (byte)HexSymbol.FirstNumeral) 
                : (HexSymbol)((byte)src + (byte)HexSymbol.FirstLetterLo);
    }
}