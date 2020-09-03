//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static HexText<Hex1Kind> text(N1 n)
            => text<Hex1Kind>();

        [MethodImpl(Inline), Op]
        public static HexText<Hex2Kind> text(N2 n)
            => text<Hex2Kind>();

        [MethodImpl(Inline), Op]
        public static HexText<Hex3Kind> text(N3 n)
            => text<Hex3Kind>();

        [MethodImpl(Inline), Op]
        public static HexText<Hex4Kind> text(N4 n)
            => text<Hex4Kind>();

        [MethodImpl(Inline)]
        public static HexText<K> text<K>()
            where K : unmanaged, Enum
        {
            if(typeof(K) == typeof(Hex1Kind))
                return generic<K>(new HexText<Hex1Kind>(@ref(Hex1Text.x00)));
            else if(typeof(K) == typeof(Hex2Kind))
                return generic<K>(new HexText<Hex2Kind>(@ref(Hex2Text.x00)));
            else if(typeof(K) == typeof(Hex3Kind))
                return generic<K>(new HexText<Hex3Kind>(@ref(Hex3Text.x00)));
            else if(typeof(K) == typeof(Hex4Kind))
                return generic<K>(new HexText<Hex4Kind>(@ref(Hex4Text.x00)));
            else
                return HexText<K>.Empty;
        }
    }
}