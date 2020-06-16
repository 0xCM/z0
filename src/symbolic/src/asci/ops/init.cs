//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;
    using static SymBits;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static asci16 init(N16 n, AsciCharCode fill = AsciCharCode.Space)
            => new asci16(vbroadcast(w128, (byte)fill));

        [MethodImpl(Inline), Op]
        public static asci32 init(N32 n, AsciCharCode fill = AsciCharCode.Space)
            => new asci32(vbroadcast(w256, (byte)fill));

        [MethodImpl(Inline), Op]
        public static asci64 init(N64 n, AsciCharCode fill = AsciCharCode.Space)
            => new asci64(vbroadcast(w512, (byte)fill));
    }
}