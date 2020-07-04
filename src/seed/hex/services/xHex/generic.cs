//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;
 
    partial struct xHex
    {
        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex1Kind> src)
            where K : unmanaged, Enum
                => ref @as<HexText<Hex1Kind>,HexText<K>>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex2Kind> src)
            where K : unmanaged, Enum
                => ref @as<HexText<Hex2Kind>,HexText<K>>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex3Kind> src)
            where K : unmanaged, Enum
                => ref @as<HexText<Hex3Kind>,HexText<K>>(ref edit(src));
        
        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex4Kind> src)
            where K : unmanaged, Enum
                => ref @as<HexText<Hex4Kind>,HexText<K>>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref HexTextIndex<K> generic<K>(in HexTextIndex<Hex1Kind> src)
            where K : unmanaged, Enum
                => ref @as<HexTextIndex<Hex1Kind>,HexTextIndex<K>>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref HexTextIndex<K> generic<K>(in HexTextIndex<Hex2Kind> src)
            where K : unmanaged, Enum
                => ref @as<HexTextIndex<Hex2Kind>,HexTextIndex<K>>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref HexTextIndex<K> generic<K>(in HexTextIndex<Hex3Kind> src)
            where K : unmanaged, Enum
                => ref @as<HexTextIndex<Hex3Kind>,HexTextIndex<K>>(ref edit(src));
        
        [MethodImpl(Inline)]
        public static ref HexTextIndex<K> generic<K>(in HexTextIndex<Hex4Kind> src)
            where K : unmanaged, Enum
                => ref @as<HexTextIndex<Hex4Kind>,HexTextIndex<K>>(ref edit(src));                
    }
}