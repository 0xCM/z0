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
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Neq<T> neq<T>()
            where T : unmanaged
                => default(Neq<T>);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> neq<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<bit> dst)
            where T : unmanaged
                => apply(Calcs.neq<T>(), a, b, dst);
    }
}