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
            => ref Imagine.@as<asci2,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci4 src)
            => ref Imagine.@as<asci4,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci8 src)
            => ref Imagine.@as<asci8,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci16 src)
            => ref Imagine.@as<asci16,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci32 src)
            => ref Imagine.@as<asci32,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci64 src)
            => ref Imagine.@as<asci64,byte>(ref src);
    }
}