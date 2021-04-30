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
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory(Impl), Closures(Integers)]
        public static Impl<T> impl<T>()
            where T : unmanaged
                => default(Impl<T>);

        [MethodImpl(Inline), Impl, Closures(Integers)]
        public static Span<T> impl<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(impl<T>(), a, b, dst);

        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static ref readonly SpanBlock128<T> impl<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref impl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static ref readonly SpanBlock256<T> impl<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref impl<T>(w256).Invoke(a, b, dst);
    }
}