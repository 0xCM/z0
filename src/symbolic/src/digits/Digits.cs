//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Digits
    {
        [MethodImpl(Inline), Op]
        public static Symbols<Hex2,byte,N2> Hex(N2 n)         
            => Symbolic.enumerate<Hex2,byte,N2>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex3,byte,N3> Hex(N3 n)         
            => Symbolic.enumerate<Hex3,byte,N3>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex4,byte,N4> Hex(N4 n)         
            => Symbolic.enumerate<Hex4,byte,N4>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex5,byte,N5> Hex(N5 n)         
            => Symbolic.enumerate<Hex5,byte,N5>();

        [MethodImpl(Inline), Op]
        public static Symbols<HexKind,byte,N8> Hex(N8 n)         
            => Symbolic.enumerate<HexKind,byte,N8>();
    }
}