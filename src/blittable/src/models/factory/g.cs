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
        partial struct Factory
        {
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static g2x2<T> g2x2<T>(ReadOnlySpan<T> src)
                where T : unmanaged
                    => first(recover<T,g2x2<T>>(src));

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static g3x3<T> g3x3<T>(ReadOnlySpan<T> src)
                where T : unmanaged
                    => first(recover<T,g3x3<T>>(src));

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static g4x4<T> g4x4<T>(ReadOnlySpan<T> src)
                where T : unmanaged
                    => first(recover<T,g4x4<T>>(src));

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static g5x5<T> g5x5<T>(ReadOnlySpan<T> src)
                where T : unmanaged
                    => first(recover<T,g5x5<T>>(src));
        }
    }
}