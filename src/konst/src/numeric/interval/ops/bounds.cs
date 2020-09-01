//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static Konst;
    using static z;

    partial struct Intervals
    {
        /// <summary>
        /// Computes the smallest/greatest bin counts
        /// </summary>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ClosedInterval<uint> bounds<T>(in Histogram<T> src)
            where T : unmanaged
                => (src.Counts.Min(), src.Counts.Max());
    }
}