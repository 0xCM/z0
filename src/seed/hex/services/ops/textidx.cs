//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;
    using static As;

    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static HexTextIndex<Hex1Kind> textidx(N1 n)
            => new HexTextIndex<Hex1Kind>(core.array(
                    @ref(Hex1Text.x00), @ref(Hex1Text.x01)
                    ));

        [MethodImpl(Inline), Op]
        public static HexTextIndex<Hex2Kind> textidx(N2 n)
            => new HexTextIndex<Hex2Kind>(core.array(
                    @ref(Hex2Text.x00), @ref(Hex2Text.x01), @ref(Hex2Text.x02), @ref(Hex2Text.x03)
                        ));

        [Op]
        public static HexTextIndex<Hex3Kind> textidx(N3 n)
            => new HexTextIndex<Hex3Kind>(core.array(
                    @ref(Hex3Text.x00), @ref(Hex3Text.x01), @ref(Hex3Text.x02), @ref(Hex3Text.x03),
                    @ref(Hex3Text.x04), @ref(Hex3Text.x05), @ref(Hex3Text.x06), @ref(Hex3Text.x07)
                        ));

        [Op]
        public static HexTextIndex<Hex4Kind> textidx(N4 n)
            => new HexTextIndex<Hex4Kind>(core.array(
                    @ref(Hex4Text.x00), @ref(Hex4Text.x01), @ref(Hex4Text.x02), @ref(Hex4Text.x03),
                    @ref(Hex4Text.x04), @ref(Hex4Text.x05), @ref(Hex4Text.x06), @ref(Hex4Text.x07),
                    @ref(Hex4Text.x08), @ref(Hex4Text.x09), @ref(Hex4Text.x0A), @ref(Hex4Text.x0B),
                    @ref(Hex4Text.x0C), @ref(Hex4Text.x0D), @ref(Hex4Text.x0E), @ref(Hex4Text.x0F)
                    ));        

        [MethodImpl(Inline)]
        public static HexTextIndex<K> textidx<K>()
            where K : unmanaged, Enum
        {
            if(typeof(K) == typeof(Hex1Kind))
                return generic<K>(textidx(n1));
            else if(typeof(K) == typeof(Hex2Kind))
                return generic<K>(textidx(n2));
            else if(typeof(K) == typeof(Hex3Kind))
                return generic<K>(textidx(n3));
            else if(typeof(K) == typeof(Hex4Kind))
                return generic<K>(textidx(n4));
            else
                return HexTextIndex<K>.Empty;
        }
    }
}