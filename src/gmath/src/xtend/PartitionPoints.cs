//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        public static IEnumerable<T> PartitionPoints<T>(this Interval<T> src, T width, int? precision = null)
            where T : unmanaged
                => Partition.stream(src,width,precision);
    }
}