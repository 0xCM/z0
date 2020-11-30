//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        public static Span<T> Increments<T>(this Interval<T> src, T t = default)
            where T : unmanaged
                => Algorithmic.increments(src.ToClosed());
    }
}