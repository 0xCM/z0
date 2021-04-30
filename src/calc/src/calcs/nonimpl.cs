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
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static NonImpl<T> nonimpl<T>()
            where T : unmanaged
                => default(NonImpl<T>);

        [MethodImpl(Inline), NonImpl, Closures(Integers)]
        public static Span<T> nonimpl<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(nonimpl<T>(), a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> nonimpl<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref nonimpl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> nonimpl<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref nonimpl<T>(w256).Invoke(a, b, dst);
    }
}