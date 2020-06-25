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
        public static Symbols<HexKind2,byte,N2> hex(N2 n)         
            => enumerate<HexKind2,byte,N2>();

        [MethodImpl(Inline), Op]
        public static Symbols<HexKind3,byte,N3> hex(N3 n)         
            => enumerate<HexKind3,byte,N3>();

        [MethodImpl(Inline), Op]
        public static Symbols<HexKind4,byte,N4> hex(N4 n)         
            => enumerate<HexKind4,byte,N4>();

        [MethodImpl(Inline), Op]
        public static Symbols<HexKind5,byte,N5> hex(N5 n)         
            => enumerate<HexKind5,byte,N5>();

        [MethodImpl(Inline), Op]
        public static Symbols<HexKind,byte,N8> hex(N8 n)                     
            => enumerate<HexKind,byte,N8>();
    }
}
