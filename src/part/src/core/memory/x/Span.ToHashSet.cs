//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    partial class XMem
    {
        public static HashSet<T> ToHashSet<T>(this ReadOnlySpan<T> src)
        {
            var dst = root.hashset<T>();
            root.iter(src, x => dst.Add(x));
            return dst;
        }

        public static HashSet<T> ToHashSet<T>(this Span<T> src)
            => src.ReadOnly().ToHashSet();
    }
}