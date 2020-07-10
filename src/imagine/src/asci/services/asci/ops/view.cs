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
        public static ref readonly asci2 view(N2 n, in ushort src)
            => ref z.view<ushort,asci2>(src);

        [MethodImpl(Inline), Op]
        public static ref readonly asci4 view(N4 n, in uint src)
            => ref z.view<uint,asci4>(src);

        [MethodImpl(Inline), Op]
        public static ref readonly asci8 view(N8 n, in ulong src)
            => ref z.view<ulong,asci8>(src);
    }
}