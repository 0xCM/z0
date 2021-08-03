//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct SortedSpans
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(SortedSpan<T> src, ulong count)
            where T : IComparable<T>
                => ref core.skip(src.View, count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(SortedSpan<T> src, long count)
            where T : IComparable<T>
                => ref core.skip(src.View, count);
    }
}