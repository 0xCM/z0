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
        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Eq<T> eq<T>()
            where T : unmanaged
                => default(Eq<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Eq128<T> eq<T>(W128 w)
            where T : unmanaged
                => default(Eq128<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Eq256<T> eq<T>(W256 w)
            where T : unmanaged
                => default(Eq256<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static VEq128<T> veq<T>(W128 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static VEq256<T> veq<T>(W256 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Eq, Closures(Integers)]
        public static Span<bit> eq<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<bit> dst)
            where T : unmanaged
                => apply(eq<T>(), a, b, dst);

        [MethodImpl(Inline), Eq, Closures(Integers)]
        public static ref readonly SpanBlock128<T> eq<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref eq<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Eq, Closures(Integers)]
        public static ref readonly SpanBlock256<T> eq<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref eq<T>(w256).Invoke(a, b, dst);
    }
}