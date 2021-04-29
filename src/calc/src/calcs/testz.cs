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
    using static memory;
    using static SFx;

    partial struct Calcs
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TestZ128<T> testz<T>(W128 w)
            where T : unmanaged
                => default(TestZ128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TestZ256<T> testz<T>(W256 w)
            where T : unmanaged
                => default(TestZ256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<bit> testz<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, Span<bit> dst)
            where T : unmanaged
                => testz<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<bit> testz<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, Span<bit> dst)
            where T : unmanaged
                => testz<T>(w256).Invoke(a, b, dst);
    }
}