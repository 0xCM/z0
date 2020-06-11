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
        public static Symbol<BinarySym,byte,N1> symbol(BinaryDigit src)
            => symbol<BinarySym,byte,N1>((BinarySym)((byte)src + (byte)BinarySym.First));

        [MethodImpl(Inline), Op]   
        public static Symbol<BinarySym,byte,N1> symbol(Base2 @base, byte src)
            => symbol<BinarySym,byte,N1>((BinarySym)(src + (byte)BinarySym.First));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(Base16 @base, UpperCased @case, byte index)
            => symbol<HexSym,byte,N4>(((HexSym)code(@base, @case, index)));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(Base16 @base, LowerCased @case, byte index)
            => symbol<HexSym,byte,N4>(((HexSym)code(@base, @case, index)));

        [MethodImpl(Inline), Op]
        public static Symbol<DeciSym,byte,N4> symbol(DeciDigit src)
            => symbol<DeciSym,byte,N4>((DeciSym)((byte)src + (byte)DeciSym.First));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(UpperCased @case, HexDigit src)
            => symbol<HexSym,byte,N4>(hex(@case,src));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(LowerCased @case, HexDigit src)
            => symbol<HexSym,byte,N4>(hex(@case,src));

        [MethodImpl(Inline), Op]   
        static HexSym hex(UpperCased @case, HexDigit src)
            => src <= HexDigit.x9 
                ? (HexSym)((byte)src + (byte)HexSym.FirstNumeral) 
                : (HexSym)((byte)src + (byte)HexSym.FirstLetterUp);

        [MethodImpl(Inline), Op]   
        static HexSym hex(LowerCased @case, HexDigit src)
            => src <= HexDigit.x9 
                ? (HexSym)((byte)src + (byte)HexSym.FirstNumeral) 
                : (HexSym)((byte)src + (byte)HexSym.FirstLetterLo);
   }
}