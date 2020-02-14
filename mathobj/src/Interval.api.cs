//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using static zfunc;

    public static class Interval
    {
        /// <summary>
        /// Computes the length of the interval by finding the magnituded of the difference 
        /// between its left/right endpoints
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        [MethodImpl(Inline)]
        public static T length<T>(IInterval<T> src)
            where T : unmanaged
                => gmath.abs(gmath.sub(src.Right, src.Left));
        
        /// <summary>
        /// Determines whether an interval contains a specified point
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="point">The point to test</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        [MethodImpl(Inline)]
        public static bit contains<T>(IInterval<T> src, T point)
            where T : unmanaged
        {
            switch(src.Kind)
            {
                case IntervalKind.Closed:
                    return gmath.gteq(point, src.Left) && gmath.lteq(point, src.Right);
                case IntervalKind.Open:
                    return gmath.gt(point, src.Left) && gmath.lt(point, src.Right);
                case IntervalKind.LeftClosed:
                    return gmath.gteq(point, src.Left) && gmath.lt(point, src.Right);
                default:        
                    return gmath.gt(point, src.Left) && gmath.lteq(point, src.Right);
            }
        }

        /// <summary>
        /// Partitions an interval predicated on partition count
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="count">The number of partitions</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<Interval<T>> partitionc<T>(Interval<T> src, int count)
            where T : unmanaged
        {
            var width = gmath.div(gmath.sub(src.Right, src.Left), convert<T>(count));
            return partition(src,width);
        }
   
        /// <summary>
        /// Partiions an invterval predicated on partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<Interval<T>> partition<T>(Interval<T> src, T width)
            where T : unmanaged
        {
            var points = partpoints(src,width);
            var dst = span<Interval<T>>(points.Length - 1);
            var lastIx = points.Length - 1;
            var lastCycleIx = lastIx - 1;
            
            for(var i = 0; i < lastIx; i++)
            {
                var left = points[i];
                var right = points[i + 1];
                if(i == 0)
                    if(src.Open || src.LeftOpen)
                        dst[i] = open(left,right);
                    else
                        dst[i] = ldomain(left,right);
                else if(i == lastCycleIx)
                    if(src.Closed || src.RightClosed)
                        dst[i] = domain(left, right);
                    else
                        dst[i] = ldomain(left,right);
                else
                    dst[i] = ldomain(left, right);
            }
            return dst;            
        }

        /// <summary>
        /// Computes the points that determine a partitioning predicated on partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<T> partpoints<T>(Interval<T> src, T width)
            where T : unmanaged
                => Numeric.floating<T>() ? partpointsf(src,width) : partpointsi(src,width);

        /// <summary>
        /// Computes the points that determine a partitioning predicated on partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        static Span<T> partpointsi<T>(Interval<T> src, T width)
            where T : unmanaged
        {
            var len =  length(src);
            convert<T,int>(gmath.div(len, width), out int count);
            
            var dst = span<T>(count + 1);
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

        static Span<T> partpointsf<T>(Interval<T> src, T width)
            where T : unmanaged
        {
            var scale = 4;
            var len =  gfp.round(length(src), scale);
            var fcount = gfp.div(len, width);
            var count = convert<T,int>(gfp.ceil(fcount));            
            var dst = span<T>(count + 1);

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


        [MethodImpl(Inline)]
        public static IEnumerable<T> partstream<T>(Interval<T> src, T width, int? precision = null)
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
        /// Calculates the points that determine a partitioning predicated on partition count
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="count">The number of desired partitions</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<T> partpointsc<T>(Interval<T> src, int count)
            where T : unmanaged
        {            
            var width = gmath.div(gmath.sub(src.Right, src.Left), convert<T>(count - 1));
            return partpoints(src,width);            
        }

        public static Interval<T> add<T>(Interval<T> lhs, Interval<T> rhs)
            where T : unmanaged
            => lhs.WithEndpoints(gmath.add(lhs.Left, rhs.Left), gmath.add(lhs.Right, rhs.Right));

        public static Interval<T> sub<T>(Interval<T> lhs, Interval<T> rhs)
            where T : unmanaged
                => lhs.WithEndpoints(gmath.sub(lhs.Left, rhs.Left), gmath.sub(lhs.Right, rhs.Right));

        /// <summary>
        /// Creates a monotonic sequence of equidistant points (of unit width) that is left/right bouned 
        /// by an interval's endpoints
        /// </summary>
        /// <param name="src">The source interval</param>
         /// <typeparam name="T">The interval primal type</typeparam>
        public static T[] increments<T>(Interval<T> src)
            where T : unmanaged
        {
            var min = src.Left;
            var max = src.Right;
            var current = min;
            var increments = new List<T>(convert<T,int>(src.Length()) + 1);
            
            while(gmath.lteq(current,max))
            {
                increments.Add(current);
                
                if(gmath.lt(current, max))
                    current = gmath.inc(current);
                else
                    break;

            }
            
            return increments.ToArray();
        }
    }
}