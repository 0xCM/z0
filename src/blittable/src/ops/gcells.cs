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
            public static Span<T> gcells<T>(ref g2x2<T> src)
                where T : unmanaged
                    => cover(gref(ref src), src.MxN);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> gcells<T>(ref g3x3<T> src)
                where T : unmanaged
                    => cover(gref(ref src), src.MxN);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> gcells<T>(ref g4x4<T> src)
                where T : unmanaged
                    => cover(gref(ref src), src.MxN);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> gcells<T>(ref g5x5<T> src)
                where T : unmanaged
                    => cover(gref(ref src), src.MxN);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> gcells<T>(ref g8x8<T> src)
                where T : unmanaged
                    => cover(gref(ref src), src.MxN);
        }
    }
}