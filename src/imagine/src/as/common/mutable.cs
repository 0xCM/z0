//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> mutable<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => cover(first(src), src.Length);
    }
}