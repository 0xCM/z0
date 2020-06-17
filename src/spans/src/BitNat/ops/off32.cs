//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static BitReader;

    partial struct BitWriter
    {
        [MethodImpl(Inline), Op]
        public static byte off(N0 n, byte src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static ushort off(N0 n, ushort src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static uint off(N0 n, uint src)
            => disable(n, src);

    }
}