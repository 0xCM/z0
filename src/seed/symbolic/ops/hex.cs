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

    partial struct Symbolic
    {
        [MethodImpl(Inline), Op]
        public static Symbols<Hex2Kind,byte,N2> hex(N2 n)         
            => enumerate<Hex2Kind,byte,N2>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex3Kind,byte,N3> hex(N3 n)         
            => enumerate<Hex3Kind,byte,N3>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex4Kind,byte,N4> hex(N4 n)         
            => enumerate<Hex4Kind,byte,N4>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex5Kind,byte,N5> hex(N5 n)         
            => enumerate<Hex5Kind,byte,N5>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex8Kind,byte,N8> hex(N8 n)                     
            => enumerate<Hex8Kind,byte,N8>();
    }
}
