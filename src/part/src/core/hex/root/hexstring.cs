//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Hex
    {
        [MethodImpl(Inline), Op]
        public static HexString<Hex1Seq> hexstring(N1 n)
            => gHex.hexstring<Hex1Seq>();

        [MethodImpl(Inline), Op]
        public static HexString<Hex2Seq> hexstring(N2 n)
            => gHex.hexstring<Hex2Seq>();

        [MethodImpl(Inline), Op]
        public static HexString<Hex3Seq> hexstring(N3 n)
            => gHex.hexstring<Hex3Seq>();

        [MethodImpl(Inline), Op]
        public static HexString<Hex4Seq> hexstring(N4 n)
            => gHex.hexstring<Hex4Seq>();
    }
}