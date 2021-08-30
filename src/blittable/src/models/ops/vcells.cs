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
            public static Span<T> vcells<T>(ref v1<T> src)
                where T : unmanaged
                    => cover(vref(ref src), src.N);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> vcells<T>(ref v2<T> src)
                where T : unmanaged
                    => cover(vref(ref src), src.N);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> vcells<T>(ref v3<T> src)
                where T : unmanaged
                    => cover(vref(ref src), src.N);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> vcells<T>(ref v4<T> src)
                where T : unmanaged
                    => cover(vref(ref src), src.N);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> vcells<T>(ref v5<T> src)
                where T : unmanaged
                    => cover(vref(ref src), src.N);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> vcells<T>(ref v8<T> src)
                where T : unmanaged
                    => cover(vref(ref src), src.N);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> vcells<T>(ref v16<T> src)
                where T : unmanaged
                    => cover(vref(ref src), src.N);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> vcells<T>(ref v32<T> src)
                where T : unmanaged
                    => cover(vref(ref src), src.N);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Span<T> vcells<T>(ref v64<T> src)
                where T : unmanaged
                    => cover(vref(ref src), src.N);
        }
    }
}