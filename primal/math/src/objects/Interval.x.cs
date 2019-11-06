//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
       
    using static As;
    using static zfunc;

    public static class IntervalX
    {
        /// <summary>
        /// Computes the length of the interval by finding the magnituded of the difference 
        /// between its left/right endpoints
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static T Length<T>(this IInterval<T> src)
            where T : unmanaged
                => Interval.length(src);

        /// <summary>
        /// Determines whether an interval contains a specified point
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="point">The point to test</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this IInterval<T> src, T point)
            where T : unmanaged
                => Interval.contains(src,point);

        [MethodImpl(Inline)]
        public static IEnumerable<T> PartPointStream<T>(this Interval<T> src, T width, int? precision = null)
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

        public static string Format<T>(this Span<Interval<T>> parts, char? sep = null)
            where T : unmanaged
                => parts.Map(x => x.Format()).Concat($" {sep ?? AsciSym.Plus} ");            
        // {
        //     var negOne = gmath.dec(gmath.zero<T>());
        //     var step = stepWidth ?? gmath.one<T>();
        //     var width =  gmath.sub(src.Right, src.Left);            
        //     convert<T,int>(gmath.div(width, step), out int count);
            
        //     var dst = span<T>(count + 1);
        //     var point = src.Left;
        //     for(var i=0; i < dst.Length; i++)
        //     {
        //         if(i == 0)            
        //         {        
        //             dst[i] = src.Left;
        //             point = gmath.add(point, step);
        //         }
        //         else if(i == dst.Length - 1)
        //         {
        //             dst[i] = src.Right;                        
        //         }
        //         else
        //         {
        //             dst[i] = point;                            
        //             point = gmath.add(point, step);
        //         }
                        
        //     }
        //     return dst;
        // }

        // {
        //     var points = src.StepwisePartitionPoints(width);
        //     var dst = span<Interval<T>>(points.Length - 1);
        //     var lastIx = points.Length - 1;
        //     var lastCycleIx = lastIx - 1;
            
        //     for(var i = 0; i < lastIx; i++)
        //     {
        //         var left = points[i];
        //         var right = points[i + 1];
        //         if(i == 0)
        //             if(src.Open || src.LeftOpen)
        //                 dst[i] = open(left,right);
        //             else
        //                 dst[i] = leftclosed(left,right);
        //         else if(i == lastCycleIx)
        //             if(src.Closed || src.RightClosed)
        //                 dst[i] = closed(left, right);
        //             else
        //                 dst[i] = leftclosed(left,right);
        //         else
        //             dst[i] = leftclosed(left, right);
        //     }
        //     return dst;
            
        // }


        /// <summary>
        /// Computes the points that determine a partitioning predicated on partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The interval primal type</typeparam>
         public static Span<T> PartPoints<T>(this Interval<T> src, T width)
            where T : unmanaged
                => Interval.partpoints(src, width);

        /// <summary>
        /// Computes the points that determine a partitioning predicated a unit partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<T> PartPoints<T>(this Interval<T> src)
            where T : unmanaged
                => Interval.partpoints(src, gmath.one<T>());

        /// <summary>
        /// Calculates the partition points in an interval
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        public static Span<T> PartPointByCount<T>(this Interval<T> src, int count)
            where T : unmanaged
                => Interval.partpointsc(src,count);

        /// <summary>
        /// Partitions an interval predicated on partitions of unit width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <typeparam name="T">The interval prmal type</typeparam>
        public static Span<Interval<T>> Partition<T>(this Interval<T> src)
            where T : unmanaged
                => Interval.partition(src,gmath.one<T>());

        public static Span<Interval<T>> Partition<T>(this Interval<T> src, T width)
            where T : unmanaged
                => Interval.partition(src,width);

        public static Span<Interval<T>> PartitionByCount<T>(this Interval<T> src, int count)
            where T : unmanaged
                => Interval.partitionc(src,count);
        
        public static T[] Increments<T>(this Interval<T> src)
            where T : unmanaged
                => Interval.increments(src);

    }
}