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
        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex1Seq> src)
            where K : unmanaged, Enum
                => ref @as<HexText<Hex1Seq>,HexText<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex2Seq> src)
            where K : unmanaged, Enum
                => ref @as<HexText<Hex2Seq>,HexText<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex3Seq> src)
            where K : unmanaged, Enum
                => ref @as<HexText<Hex3Seq>,HexText<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexText<K> generic<K>(in HexText<Hex4Seq> src)
            where K : unmanaged, Enum
                => ref @as<HexText<Hex4Seq>,HexText<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexTextIndex<K> generic<K>(in HexTextIndex<Hex1Seq> src)
            where K : unmanaged, Enum
                => ref @as<HexTextIndex<Hex1Seq>,HexTextIndex<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexTextIndex<K> generic<K>(in HexTextIndex<Hex2Seq> src)
            where K : unmanaged, Enum
                => ref @as<HexTextIndex<Hex2Seq>,HexTextIndex<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexTextIndex<K> generic<K>(in HexTextIndex<Hex3Seq> src)
            where K : unmanaged, Enum
                => ref @as<HexTextIndex<Hex3Seq>,HexTextIndex<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexTextIndex<K> generic<K>(in HexTextIndex<Hex4Seq> src)
            where K : unmanaged, Enum
                => ref @as<HexTextIndex<Hex4Seq>,HexTextIndex<K>>(edit(src));
    }
}