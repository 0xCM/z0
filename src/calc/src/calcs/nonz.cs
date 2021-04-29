//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;
    using static SFx;

    partial struct Calcs
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Nonz<T> nonz<T>()
            where T : unmanaged
                => default(Nonz<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> nonz<T>(in SpanBlock128<T> a, Span<bit> dst)
            where T : unmanaged
                => BSvc.nonz<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> nonz<T>(in SpanBlock256<T> a, Span<bit> dst)
            where T : unmanaged
                => BSvc.nonz<T>(w256).Invoke(a, dst);
    }
}