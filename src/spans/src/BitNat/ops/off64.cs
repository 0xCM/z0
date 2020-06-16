//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static BitReader;

    partial struct BitWriter
    {
        [MethodImpl(Inline), Op]
        public static ulong off(N0 n, ulong src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static ulong off(N1 n, ulong src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static ulong off(N2 n, ulong src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static ulong off(N3 n, ulong src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static ulong off(N4 n, ulong src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static ulong off(N5 n, ulong src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static ulong off(N6 n, ulong src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static ulong off(N7 n, ulong src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static ulong off(N8 n, ulong src)
            => disable(n, src);

        [MethodImpl(Inline), Op]
        public static ulong off(N9 n, ulong src)
            => disable(n, src);
    }
}