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

    partial class Symbolic     
    {
        [MethodImpl(Inline), Op]
        public static Symbols<Hex2,byte,N2> hex(N2 n)         
            => enumerate<Hex2,byte,N2>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex3,byte,N3> hex(N3 n)         
            => enumerate<Hex3,byte,N3>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex4,byte,N4> hex(N4 n)         
            => enumerate<Hex4,byte,N4>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex5,byte,N5> hex(N5 n)         
            => enumerate<Hex5,byte,N5>();

        [MethodImpl(Inline), Op]
        public static Symbols<HexKind,byte,N8> hex(N8 n)                     
            => enumerate<HexKind,byte,N8>();
    }
}
