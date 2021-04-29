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
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Eq<T> eq<T>()
            where T : unmanaged
                => default(Eq<T>);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> eq<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<bit> dst)
            where T : unmanaged
                => apply(Calcs.eq<T>(), a, b, dst);


        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> gt<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<bit> dst)
            where T : unmanaged
                => apply(Calcs.gt<T>(), a, b, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> gteq<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<bit> dst)
            where T : unmanaged
                => apply(Calcs.gteq<T>(), a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly SpanBlock128<T> eq<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.eq<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly SpanBlock256<T> eq<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.eq<T>(w256).Invoke(a, b, dst);
    }
}