//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        partial struct Operate
        {
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T gref<T>(ref g2x2<T> src)
                where T : unmanaged
                    => ref @as<g2x2<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T gref<T>(ref g3x3<T> src)
                where T : unmanaged
                    => ref @as<g3x3<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T gref<T>(ref g4x4<T> src)
                where T : unmanaged
                    => ref @as<g4x4<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T gref<T>(ref g5x5<T> src)
                where T : unmanaged
                    => ref @as<g5x5<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T gref<T>(ref g8x8<T> src)
                where T : unmanaged
                    => ref @as<g8x8<T>,T>(src);
        }
    }
}