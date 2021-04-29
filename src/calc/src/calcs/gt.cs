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
        public static Gt<T> gt<T>()
            where T : unmanaged
                => default(Gt<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly SpanBlock128<T> gt<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.gt<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly SpanBlock256<T> gt<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.gt<T>(w256).Invoke(a, b, dst);
    }
}