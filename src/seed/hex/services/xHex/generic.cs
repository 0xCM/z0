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

        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex1Kind> src)
            where K : unmanaged, Enum
                => ref As.@as<HexText<Hex1Kind>,HexText<K>>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex2Kind> src)
            where K : unmanaged, Enum
                => ref As.@as<HexText<Hex2Kind>,HexText<K>>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex3Kind> src)
            where K : unmanaged, Enum
                => ref As.@as<HexText<Hex3Kind>,HexText<K>>(ref As.edit(src));
        
        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex4Kind> src)
            where K : unmanaged, Enum
                => ref As.@as<HexText<Hex4Kind>,HexText<K>>(ref As.edit(src));
    }
}