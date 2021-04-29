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
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Xnor<T> xnor<T>()
            where T : unmanaged
                => default(Xnor<T>);

        [MethodImpl(Inline), Xnor, Closures(Integers)]
        public static Span<T> xnor<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(xnor<T>(), a, b, dst);

        [MethodImpl(Inline), Xnor, Closures(Closure)]
        public static ref readonly SpanBlock128<T> xnor<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref xnor<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Xnor, Closures(Closure)]
        public static ref readonly SpanBlock256<T> xnor<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref xnor<T>(w256).Invoke(a, b, dst);
    }
}