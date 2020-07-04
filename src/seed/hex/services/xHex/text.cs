//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
 
    partial struct xHex
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
                return generic<K>(new HexText<Hex1Kind>(StringRef.sequence(Hex1Text.x00, Hex1.Count)));
            else if(typeof(K) == typeof(Hex2Kind))
                return generic<K>(new HexText<Hex2Kind>(StringRef.sequence(Hex2Text.x00, Hex2.Count)));
            else if(typeof(K) == typeof(Hex3Kind))
                return generic<K>(new HexText<Hex3Kind>(StringRef.sequence(Hex3Text.x00, Hex3.Count)));
            else if(typeof(K) == typeof(Hex4Kind))
                return generic<K>(new HexText<Hex4Kind>(StringRef.sequence(Hex4Text.x00, Hex4.Count)));
            else
                return HexText<K>.Empty;
        }
    }
}