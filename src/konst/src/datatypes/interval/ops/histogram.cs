//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    partial struct Intervals
    {
        public static Histogram<T> histogram<T>(in ClosedInterval<T> src)            
            where T : unmanaged
                => histogram(src, grain(src));

        public static Histogram<T> histogram<T>(in ClosedInterval<T> src, T grain)            
            where T : unmanaged
        {
            var parts = partition(src,grain);
            var counts = sys.alloc<uint>(parts.Length);
            return new Histogram<T>(src, grain, parts, counts);
        }
    }
}