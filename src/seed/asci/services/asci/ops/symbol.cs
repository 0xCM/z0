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
        [MethodImpl(Inline), Op]   
        public static Symbol<BinarySym,byte,N1> symbol(BinaryDigit src)
            => symbol<BinarySym,byte,N1>((BinarySym)((byte)src + (byte)BinarySym.First));

        [MethodImpl(Inline), Op]
        public static Symbol<OctalSym,byte,N3> symbol(OctalDigit src)
            => symbol<OctalSym,byte,N3>((OctalSym)((byte)src + (byte)OctalSym.First));

        [MethodImpl(Inline), Op]   
        public static Symbol<BinarySym,byte,N1> symbol(Base2 @base, byte src)
            => symbol<BinarySym,byte,N1>((BinarySym)(src + (byte)BinarySym.First));

        [MethodImpl(Inline), Op]
        public static Symbol<DeciSym,byte,N4> symbol(DeciDigit src)
            => symbol<DeciSym,byte,N4>((DeciSym)((byte)src + (byte)DeciSym.First));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(UpperCased @case, HexDigit src)
            => symbol<HexSym,byte,N4>(((HexSym)asci.code(@case, src)));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(LowerCased @case, HexDigit src)
            => symbol<HexSym,byte,N4>(((HexSym)asci.code(@case, src)));
   }
}