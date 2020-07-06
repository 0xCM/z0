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
            => ref As.@as<asci2,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci4 src)
            => ref As.@as<asci4,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci8 src)
            => ref As.@as<asci8,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci16 src)
            => ref As.@as<asci16,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci32 src)
            => ref As.@as<asci32,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static ref byte @byte(ref asci64 src)
            => ref As.@as<asci64,byte>(ref src);
    }
}