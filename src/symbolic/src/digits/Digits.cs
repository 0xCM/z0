//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Digits
    {

        [MethodImpl(Inline), Op]
        public static Symbols<HexKind3,byte,N3> Hex(N3 n)         
            => Symbolic.enumerate<HexKind3,byte,N3>();

        [MethodImpl(Inline), Op]
        public static Symbols<HexKind4,byte,N4> Hex(N4 n)         
            => Symbolic.enumerate<HexKind4,byte,N4>();

        [MethodImpl(Inline), Op]
        public static Symbols<HexKind,byte,N8> Hex(N8 n)         
            => Symbolic.enumerate<HexKind,byte,N8>();
    }
}