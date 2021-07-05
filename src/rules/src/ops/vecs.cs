//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanVecs<T> vecs<T>(Span<T> src, uint count)
            => new SpanVecs<T>(src, count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ImmutableVecs<T> vecs<T>(ReadOnlySpan<T> src, uint count)
            => new ImmutableVecs<T>(src, count);
    }
}