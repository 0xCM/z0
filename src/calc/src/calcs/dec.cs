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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Dec<T> dec<T>()
            where T : unmanaged
                => default;


        [MethodImpl(Inline), Dec, Closures(Integers)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(Calcs.dec<T>(), src, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly SpanBlock128<T> dec<T>(in SpanBlock128<T> a, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.dec<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly SpanBlock256<T> dec<T>(in SpanBlock256<T> a, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.dec<T>(w256).Invoke(a, dst);

    }
}