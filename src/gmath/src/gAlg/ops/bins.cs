//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct gAlg
    {
        /// <summary>
        /// Creates a bin over a closed interval partitioned into a specified number of segments
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="count">The partition count</param>
        /// <typeparam name="T">The interval domain</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bin<T> bin<T>(in ClosedInterval<T> src, uint count)
            where T : unmanaged, IComparable<T>
                => new Bin<T>(src, count);

        /// <summary>
        /// Presents the histogram state as a sequence of bins
        /// </summary>
        /// <param name="src">The histogram to query</param>
        /// <typeparam name="T">The point domain</typeparam>
        [Op, Closures(Closure)]
        public static Span<Bin<T>> bins<T>(in Histogram<T> src)
            where T : unmanaged, IComparable<T>
        {
            var segments = src.Partitions.Length;
            var dst = span<Bin<T>>(src.Partitions.Length - 1);
            bins(src,dst);
            return dst;
        }

        /// <summary>
        /// Presents the histogram state as a sequence of bins
        /// </summary>
        /// <param name="src">The histogram to query</param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<Bin<T>> bins<T>(in Histogram<T> src, Span<Bin<T>> dst)
            where T : unmanaged, IComparable<T>
        {
            var segments = src.Partitions.Length;
            for(var i = 1u; i<segments; i++)
                seek(dst,i-1) = bin(segment(src, i), count(src, i));
            return dst;
        }
    }
}