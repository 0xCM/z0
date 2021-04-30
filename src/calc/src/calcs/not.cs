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
        [MethodImpl(Inline), Factory(Not), Closures(Integers)]
        public static Not<T> not<T>()
            where T : unmanaged
                => default(Not<T>);

        [MethodImpl(Inline), Factory(Not), Closures(Integers)]
        public static Not128<T> not<T>(W128 w)
            where T : unmanaged
                => default(Not128<T>);

        [MethodImpl(Inline), Factory(Not), Closures(Integers)]
        public static Not256<T> not<T>(W256 w)
            where T : unmanaged
                => default(Not256<T>);

        [MethodImpl(Inline), Not, Closures(Integers)]
        public static Span<T> not<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(not<T>(), src, dst);

        [MethodImpl(Inline), Not, Closures(Closure)]
        public static ref readonly SpanBlock128<T> not<T>(in SpanBlock128<T> a, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref not<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Not, Closures(Closure)]
        public static ref readonly SpanBlock256<T> not<T>(in SpanBlock256<T> a, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref not<T>(w256).Invoke(a, dst);

    }
}