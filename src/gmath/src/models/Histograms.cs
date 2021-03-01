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

    [ApiHost]
    public readonly struct Histograms
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Findes the number of items in an index-identified bucket
        /// </summary>
        /// <param name="src">The histogram to query</param>
        /// <param name="index">THe bucket index</param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint count<T>(in Histogram<T> src, uint index)
            where T : unmanaged
                => (uint)src.Counts[index-1];

        /// <summary>
        /// Creates a bin over a closed interval partitioned into a specified number of segments
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="count">The partition count</param>
        /// <typeparam name="T">The interval domain</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bin<T> bin<T>(in ClosedInterval<T> src, uint count)
            where T : unmanaged
                => new Bin<T>(src, count);

        /// <summary>
        /// Presents the histogram state as a sequence of bins
        /// </summary>
        /// <param name="src">The histogram to query</param>
        /// <typeparam name="T">The point domain</typeparam>
        [Op, Closures(Closure)]
        public static Span<Bin<T>> bins<T>(in Histogram<T> src)
            where T : unmanaged
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
            where T : unmanaged
        {
            var segments = src.Partitions.Length;
            for(var i = 1u; i<segments; i++)
                seek(dst,i-1) = bin(segment(src, i), count(src, i));
            return dst;
        }

        /// <summary>
        /// Computes the smallest/greatest bin counts
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ClosedInterval<uint> bounds<T>(in Histogram<T> src)
            where T : unmanaged
                => (src.Counts.Min(), src.Counts.Max());

        /// <summary>
        /// Presents an index-identifeid histogram bucket as an interval
        /// </summary>
        /// <param name="src">The histogram to search</param>
        /// <param name="index">THe bucket index</param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ClosedInterval<T> segment<T>(in Histogram<T> src, uint index)
            where T : unmanaged
                => Intervals.closed(point(src, index-1), point(src, index));

        /// <summary>
        /// Creates a histogram over the T-domain and allocates a bin count commensurate with the number of points in T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static Histogram<T> create<T>()
            where T : unmanaged
        {
            var domain = Intervals.closed(Numeric.minval<T>(), Numeric.maxval<T>());
            var grain = domain.Width;
            return create<T>(domain, generic<T>(domain.Width));
        }

        public static Histogram<T> create<T>(in ClosedInterval<T> src, T grain)
            where T : unmanaged
        {
            var parts = Intervals.partition(src,grain);
            var counts = sys.alloc<uint>(parts.Length);
            return new Histogram<T>(src, grain, parts, counts);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Bin<T> next<T>(in Bin<T> bin)
            where T : unmanaged
        {
            root.atomic(ref edit(bin.Counter));
            return ref bin;
        }

        /// <summary>
        /// Searches for the bucket containing the point; if found, returns the bucket index; otherwise returns a failure code
        /// </summary>
        /// <param name="src">The histogram to search</param>
        /// <param name="point">A point contained in some bucket, hopefully </param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static uint index<T>(in Histogram<T> src, T point)
            where T : unmanaged
        {
            var partitions = src.Partitions.Length;
            for(var i = 1u; i<partitions; i++)
                if(Intervals.contains(segment(src, i),point))
                    return i;
            return uint.MaxValue;
        }

        /// <summary>
        /// Deposits each source point, when possible, into some histogram bucket
        /// </summary>
        /// <param name="src">The point source</param>
        /// <param name="dst">The target histogram</param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static void deposit<T>(ReadOnlySpan<T> src, in Histogram<T> dst)
            where T : unmanaged
        {
            ref var counts = ref first(span(dst.Counts));
            ref readonly var points = ref first(src);

            for(var i=0u; i<src.Length; i++)
            {
                ref readonly var point = ref skip(points,i);
                var index = Histograms.index<T>(dst, point);
                if(index != uint.MaxValue)
                    ++seek(counts, index - 1);
            }
        }

        /// <summary>
        /// Deposits a point, if possible, into a histogram bucket
        /// </summary>
        /// <param name="src">The point one would like to deposit</param>
        /// <param name="dst">The target histogram</param>
        /// <param name="undeposited">If specified, invoked whenever a bucket can't be found</param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void deposit<T>(T src, in Histogram<T> dst, Action<T> undeposited = null)
            where T : unmanaged
        {
            var deposited = false;
            var segments = dst.Partitions.Length;
            for(var i = 1u; i<segments; i++)
            {
                if(segment(dst, i).Contains(src))
                {
                    dst.Counts[i-1] = ++dst.Counts[i-1];
                    deposited = true;
                    break;
                }
            }

            if(!deposited && undeposited != null)
                undeposited(src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static ref readonly T point<T>(in T src, uint ix)
            where T : unmanaged
                => ref skip(src,ix);

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static ref readonly T point<T>(in Histogram<T> src, uint ix)
            where T : unmanaged
                => ref src.Partitions[ix];

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong sum<T>(ReadOnlySpan<Bin<T>> bins)
            where T : unmanaged
        {
            var sum = 0ul;
            var count = bins.Length;
            for(var i=0u; i<count; i++)
                sum += skip(bins,i).Count;
            return sum;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T grain<T>(in ClosedInterval<T> src, ulong width = 100ul)
            where T : unmanaged
                => generic<T>(src.Width/root.min(src.Width, 100ul));
    }
}