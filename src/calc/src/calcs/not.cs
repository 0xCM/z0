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
        public static Not<T> not<T>()
            where T : unmanaged
                => default(Not<T>);

       [MethodImpl(Inline), Not, Closures(Integers)]
        public static Span<T> not<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(not<T>(), src, dst);

        [MethodImpl(Inline), Not, Closures(Closure)]
        public static ref readonly SpanBlock128<T> not<T>(in SpanBlock128<T> a, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.not<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Not, Closures(Closure)]
        public static ref readonly SpanBlock256<T> not<T>(in SpanBlock256<T> a, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.not<T>(w256).Invoke(a, dst);

    }
}