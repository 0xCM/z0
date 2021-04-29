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
        public static Abs<T> abs<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Abs, Closures(Integers)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(Calcs.abs<T>(), src, dst);

        [MethodImpl(Inline), Op, Closures(SignedInts)]
        public static ref readonly SpanBlock128<T> abs<T>(in SpanBlock128<T> a, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.abs<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(SignedInts)]
        public static ref readonly SpanBlock256<T> abs<T>(in SpanBlock256<T> a, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.abs<T>(w256).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> add<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.add<T>(w128).Invoke(a, b, dst);

    }
}