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
        public static GtEq<T> gteq<T>()
            where T : unmanaged
                => default(GtEq<T>);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> gteq<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<bit> dst)
            where T : unmanaged
                => apply(gteq<T>(), a, b, dst);
    }
}