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
        /// <summary>
        /// Presents the histogram state as a sequence of buckets
        /// </summary>
        /// <param name="src">The histogram to query</param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<Bin<T>> buckets<T>(in Histogram<T> src)            
            where T : unmanaged
        {
            var segments = src.Partitions.Length;
            var buckets = z.span<Bin<T>>(segments - 1);
            for(var i = 1u; i<segments; i++)
                z.seek(buckets,i-1) = bin(segment(src, i), count(src, i));
            return buckets;
        }                
    }
}