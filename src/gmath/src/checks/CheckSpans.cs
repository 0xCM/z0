//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = CheckGeneric;

    [ApiHost(ApiNames.CheckSpans, true)]
    public readonly struct CheckSpans : TCheckSpans
    {
        [Op, Closures(UnsignedInts)]
        public static void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => iter(lhs, rhs, (a,b) => api.eq(a,b));

        [Op, Closures(UnsignedInts)]
        public static void eq<T>(Span<T> lhs, Span<T> rhs)
            where T : unmanaged
                => iter(lhs,rhs, (a,b) => api.eq(a,b));
    }
}