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


        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(in AsciCodeCover src)
            => AsciCodeCover.symbol(src);

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(in AsciCode2 src, byte index)
            => AC2.symbol(src, index);

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(in AsciCode4 src, byte index)
            => AC4.symbol(src, index);

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(in AsciCode5 src, byte index)
            => AC5.symbol(src, index);

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(in AsciCode8 src, byte index)
            => AC8.symbol(src, index);

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(in AsciCode16 src, byte index)
            => AC16.symbol(src, index);

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(in AsciCode32 src, byte index)
            => AC32.symbol(src, index);
    }
}