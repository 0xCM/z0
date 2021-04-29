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
        public static Span<bit> testz<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, Span<bit> dst)
            where T : unmanaged
                => BSvc.testz<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<bit> testz<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, Span<bit> dst)
            where T : unmanaged
                => BSvc.testz<T>(w256).Invoke(a, b, dst);
    }
}