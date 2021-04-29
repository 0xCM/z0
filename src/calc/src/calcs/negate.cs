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
        [MethodImpl(Inline), Factory, Closures(AllNumeric)]
        public static Negate<T> negate<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Negate128<T> negate<T>(W128 w)
            where T : unmanaged
                => default(Negate128<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Negate256<T> negate<T>(W256 w)
            where T : unmanaged
                => default(Negate256<T>);
        [MethodImpl(Inline), Negate, Closures(Integers)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(negate<T>(), src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> negate<T>(in SpanBlock128<T> a, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref negate<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> negate<T>(in SpanBlock256<T> a, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref negate<T>(w256).Invoke(a, dst);
    }
}