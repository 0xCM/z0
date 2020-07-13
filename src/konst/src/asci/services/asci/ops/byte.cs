//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
 
    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci2 src)
            => ref z.@as<asci2,byte>(src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci4 src)
            => ref z.@as<asci4,byte>(src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci8 src)
            => ref z.@as<asci8,byte>(src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci16 src)
            => ref z.@as<asci16,byte>(src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci32 src)
            => ref z.@as<asci32,byte>(src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci64 src)
            => ref z.@as<asci64,byte>(src);
    }
}