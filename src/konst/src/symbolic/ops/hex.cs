//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Symbolic
    {
        [MethodImpl(Inline), Op]
        public static Symbols<Hex2Seq,byte,N2> hex(N2 n)
            => enumerate<Hex2Seq,byte,N2>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex3Seq,byte,N3> hex(N3 n)
            => enumerate<Hex3Seq,byte,N3>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex4Seq,byte,N4> hex(N4 n)
            => enumerate<Hex4Seq,byte,N4>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex5Seq,byte,N5> hex(N5 n)
            => enumerate<Hex5Seq,byte,N5>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex8Seq,byte,N8> hex(N8 n)
            => enumerate<Hex8Seq,byte,N8>();

        [MethodImpl(Inline), Op]
        public static Symbolic<Hex8Seq,byte,N8> hex2(N8 n)
            => cover<Hex8Seq,byte,N8>();

    }
}
