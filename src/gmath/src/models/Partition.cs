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
    using static z;

    public partial class Partition
    {
        /// <summary>
        /// Slices an interval into manageable pieces, disjoint even
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <param name="precision">The precision with which the calculations are carried out</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        [Op, Closures(AllNumeric)]
        public static IEnumerable<T> stream<T>(Interval<T> src, T width, int? precision = null)
            where T : unmanaged
        {
            var scale = precision ?? 4;
            if(src.LeftClosed)
                yield return src.Left;

            var next = gfp.round(gmath.add(src.Left, width), scale);
            while(gmath.lt(next,src.Right))
            {
                yield return next;
                next = gfp.round(gmath.add(next, width), scale);
            }

            if(src.RightClosed)
                yield return src.Right;
        }

        /// <summary>
        /// Computes the points that determine a partitioning predicated on partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<T> measured<T>(Interval<T> src, T width)
            where T : unmanaged
                => NumericKinds.floating<T>() ? floating<T>(src, width) : integral<T>(src,width);

        /// <summary>
        /// Calculates the points that determine a partitioning predicated on partition count
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="count">The number of desired partitions</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<T> counted<T>(Interval<T> src, int count)
            where T : unmanaged
                => measured(src,gmath.div(gmath.sub(src.Right, src.Left), force<T>(count - 1)));

        /// <summary>
        /// Partitions an interval predicated on a specified partition count
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="count">The number of partitions</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<Interval<T>> counted<S,T>(Interval<T> src, int count)
            where T : unmanaged
                => width(src,gmath.div(gmath.sub(src.Right, src.Left), force<T>(count)));

        /// <summary>
        /// Partitions an interval predicated on a specified partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        [Op, Closures(AllNumeric)]
        public static Span<Interval<T>> width<T>(Interval<T> src, T width)
            where T : unmanaged
        {
            var points = measured(src,width);
            var dst = Spans.alloc<Interval<T>>(points.Length - 1);
            var lastIx = points.Length - 1;
            var lastCycleIx = lastIx - 1;
            var model = default(Interval<T>);

            for(var i = 0; i < lastIx; i++)
            {
                var left = points[i];
                var right = points[i + 1];
                if(i == 0)
                    if(src.Open || src.LeftOpen)
                        dst[i] =  model.New(left,right, IntervalKind.Open);
                    else
                        dst[i] = model.New(left,right, IntervalKind.LeftClosed);
                else if(i == lastCycleIx)
                    if(src.Closed || src.RightClosed)
                        dst[i] = model.New(left,right, IntervalKind.Closed);
                    else
                        dst[i] = model.New(left,right, IntervalKind.LeftClosed);
                else
                    dst[i] = model.New(left,right, IntervalKind.LeftClosed);
            }
            return dst;
        }

        /// <summary>
        /// Computes the points that determine a partitioning predicated on partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        [Op, Closures(Integers)]
        static Span<T> integral<T>(Interval<T> src, T width)
            where T : unmanaged
        {
            var len =  gmath.length(src);
            var count = z.force<T,int>(gmath.div(len, width));
            var dst = Spans.alloc<T>(count + 1);
            var point = src.Left;
            var lastix = dst.Length - 1;

            for(var i=0; i < dst.Length; i++)
            {
                if(i == 0)
                    dst[i] = src.Left;
                else if(i == dst.Length - 1)
                    dst[i] = src.Right;
                else
                    dst[i] = point;

                if(i != lastix)
                    point = gmath.add(point, width);
            }

            return dst;
        }

        [Op, Closures(Floats)]
        static Span<T> floating<T>(Interval<T> src, T width)
            where T : unmanaged
        {
            var scale = 4;
            var len =  gfp.round(gmath.length(src), scale);
            var fcount = gfp.div(len, width);
            var count = force<T,int>(gfp.ceil(fcount));
            var dst = Spans.alloc<T>(count + 1);

            var point = src.Left;
            var lastix = dst.Length - 1;
            for(var i=0; i < dst.Length; i++)
            {
                if(i > 0 && i < lastix)
                    dst[i] = point;
                else if(i == 0)
                    dst[i] = src.Left;
                else if(i == lastix)
                    dst[i] = src.Right;

                if(i != lastix)
                    point = gfp.round(gfp.add(point, width), scale);
            }

            return dst;
        }
    }
}