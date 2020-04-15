//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
       
    using static Seed;
    using static Memories;

    partial class XTend
    {
        public static Span<T> Increments<T>(this Interval<T> src, T t = default)
            where T : unmanaged
                => Algorithms.increments(src);
    }
}