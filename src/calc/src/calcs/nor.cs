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
        [MethodImpl(Inline), Factory(Nor), Closures(Integers)]
        public static Nor<T> nor<T>()
            where T : unmanaged
                => default(Nor<T>);

        [MethodImpl(Inline), Factory(Nor), Closures(Integers)]
        public static Nor128<T> nor<T>(W128 w)
            where T : unmanaged
                => default(Nor128<T>);

        [MethodImpl(Inline), Factory(Nor), Closures(Integers)]
        public static Nor256<T> nor<T>(W256 w)
            where T : unmanaged
                => default(Nor256<T>);

        [MethodImpl(Inline), Nor, Closures(Integers)]
        public static Span<T> nor<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(nor<T>(), a, b, dst);

        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static ref readonly SpanBlock128<T> nor<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref nor<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static ref readonly SpanBlock256<T> nor<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref nor<T>(w256).Invoke(a, b, dst);
    }
}