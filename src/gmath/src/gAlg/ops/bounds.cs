//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    partial struct gAlg
    {
        /// <summary>
        /// Computes the smallest/greatest bin counts
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ClosedInterval<uint> bounds<T>(in Histogram<T> src)
            where T : unmanaged, IComparable<T>
                => (src.Counts.Min(), src.Counts.Max());
    }
}