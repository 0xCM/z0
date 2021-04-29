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
        public static LtEq<T> lteq<T>()
            where T : unmanaged
                => default(LtEq<T>);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> lteq<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<bit> dst)
            where T : unmanaged
                => apply(Calcs.lteq<T>(), a, b, dst);
    }
}