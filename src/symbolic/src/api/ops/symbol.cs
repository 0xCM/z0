//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Seed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static Symbol<OctalDigit,byte,N3> symbol(in OctalDigit value)
            => symbol<OctalDigit,byte,N3>(value);

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte,N8> symbol(in AsciChar value)
            => symbol<AsciChar,byte,N8>(value);

        [MethodImpl(Inline), Op]   
        public static Symbol<BinarySymbol,byte,N1> symbol(BinaryDigit src)
            => symbol<BinarySymbol,byte,N1>((BinarySymbol)((byte)src + (byte)BinarySymbol.First));

        [MethodImpl(Inline), Op]   
        public static Symbol<BinarySymbol,byte,N1> symbol(Base2 @base, byte src)
            => symbol<BinarySymbol,byte,N1>((BinarySymbol)(src + (byte)BinarySymbol.First));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSymbol,byte,N4> symbol(Base16 @base, UpperCased @case, byte index)
            => symbol<HexSymbol,byte,N4>(((HexSymbol)code(@base, @case, index)));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSymbol,byte,N4> symbol(Base16 @base, LowerCased @case, byte index)
            => symbol<HexSymbol,byte,N4>(((HexSymbol)code(@base, @case, index)));

        [MethodImpl(Inline), Op]
        public static Symbol<DecimalSymbol,byte,N4> symbol(DecimalDigit src)
            => symbol<DecimalSymbol,byte,N4>((DecimalSymbol)((byte)src + (byte)DecimalSymbol.First));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSymbol,byte,N4> symbol(UpperCased @case, HexDigit src)
            => symbol<HexSymbol,byte,N4>(hex(@case,src));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSymbol,byte,N4> symbol(LowerCased @case, HexDigit src)
            => symbol<HexSymbol,byte,N4>(hex(@case,src));

        [MethodImpl(Inline), Op]   
        static HexSymbol hex(UpperCased @case, HexDigit src)
            => src <= HexDigit.x9 
                ? (HexSymbol)((byte)src + (byte)HexSymbol.FirstNumeral) 
                : (HexSymbol)((byte)src + (byte)HexSymbol.FirstLetterUp);

        [MethodImpl(Inline), Op]   
        static HexSymbol hex(LowerCased @case, HexDigit src)
            => src <= HexDigit.x9 
                ? (HexSymbol)((byte)src + (byte)HexSymbol.FirstNumeral) 
                : (HexSymbol)((byte)src + (byte)HexSymbol.FirstLetterLo);
   }
}