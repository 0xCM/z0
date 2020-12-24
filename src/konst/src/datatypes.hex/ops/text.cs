//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static HexString<Hex1Seq> text(N1 n)
            => text<Hex1Seq>();

        [MethodImpl(Inline), Op]
        public static HexString<Hex2Seq> text(N2 n)
            => text<Hex2Seq>();

        [MethodImpl(Inline), Op]
        public static HexString<Hex3Seq> text(N3 n)
            => text<Hex3Seq>();

        [MethodImpl(Inline), Op]
        public static HexString<Hex4Seq> text(N4 n)
            => text<Hex4Seq>();

        [MethodImpl(Inline)]
        public static HexString<K> text<K>()
            where K : unmanaged, Enum
        {
            if(typeof(K) == typeof(Hex1Seq))
                return generic<K>(new HexString<Hex1Seq>(@ref(Hex1Text.x00)));
            else if(typeof(K) == typeof(Hex2Seq))
                return generic<K>(new HexString<Hex2Seq>(@ref(Hex2Text.x00)));
            else if(typeof(K) == typeof(Hex3Seq))
                return generic<K>(new HexString<Hex3Seq>(@ref(Hex3Text.x00)));
            else if(typeof(K) == typeof(Hex4Seq))
                return generic<K>(new HexString<Hex4Seq>(@ref(Hex4Text.x00)));
            else
                return HexString<K>.Empty;
        }
    }
}