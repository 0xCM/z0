//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Delegates;

    [ApiHost]
    public readonly struct RefOrder
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int index<T>(ReadOnlySpan<T> src, in T match, RefComparer<T> comparer)
            => new RefSearch<T>(comparer).Search(src,match);
    }
}