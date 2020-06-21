//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;
    using static Typed;

    partial struct asci
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]   
        public static Symbol<S> symbol<S>(S value)
            where S : unmanaged
                => new Symbol<S>(value);

        [MethodImpl(Inline)]   
        public static Symbol<S,T> symbol<S,T>(S value, T t = default)
            where S : unmanaged
            where T : unmanaged
                => new Symbol<S,T>(value);

        [MethodImpl(Inline)]   
        public static Symbol<S,T,N> symbol<S,T,N>(S value, T t = default, N n = default)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Symbol<S,T,N>(value);

        [MethodImpl(Inline), Op]
        public static Symbol<OctalDigit,byte,N3> symbol(OctalDigit value)
            => symbol<OctalDigit,byte,N3>(value);

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte,N8> symbol(AsciChar value)
            => symbol<AsciChar,byte,N8>(value);

        [MethodImpl(Inline), Op]   
        public static Symbol<BinarySym,byte,N1> symbol(BinaryDigit src)
            => symbol<BinarySym,byte,N1>((BinarySym)((byte)src + (byte)BinarySym.First));

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