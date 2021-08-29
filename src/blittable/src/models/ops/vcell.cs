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
            public static ref T vcell<T>(N0 n, ref v1<T> src)
                where T : unmanaged
                    => ref @as<v1<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T vcell<T>(N0 n, ref v2<T> src)
                where T : unmanaged
                    => ref @as<v2<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T vcell<T>(N0 n, ref v3<T> src)
                where T : unmanaged
                    => ref @as<v3<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T vcell<T>(N0 n, ref v4<T> src)
                where T : unmanaged
                    => ref @as<v4<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T vcell<T>(N0 n, ref v8<T> src)
                where T : unmanaged
                    => ref @as<v8<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T vcell<T>(N0 n, ref v16<T> src)
                where T : unmanaged
                    => ref @as<v16<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T vcell<T>(N0 n, ref v32<T> src)
                where T : unmanaged
                    => ref @as<v32<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref T vcell<T>(N0 n, ref v64<T> src)
                where T : unmanaged
                    => ref @as<v64<T>,T>(src);
        }
    }
}