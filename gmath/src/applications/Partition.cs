//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Root;

    public static class Partition
    {
        /// <summary>
        /// Computes the length of the interval by finding the magnituded of the difference 
        /// between its left/right endpoints
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        [MethodImpl(Inline)]
        public static T length<S,T>(S src)
            where S : struct, IInterval<S,T>
            where T : unmanaged
                => gmath.abs(gmath.sub(src.Right, src.Left));

        /// <summary>
        /// Computes the points that determine a partitioning predicated on partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<T> measuredPoints<S,T>(S src, T width)
            where S : struct, IInterval<S,T>
            where T : unmanaged
                => Numeric.floating<T>() ? points_f<S,T>(src, width) : points_i<S,T>(src,width);

        /// <summary>
        /// Calculates the points that determine a partitioning predicated on partition count
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="count">The number of desired partitions</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<T> countedPoints<S,T>(S src, int count)
            where S : struct, IInterval<S,T>
            where T : unmanaged
        {            
            var w = gmath.div(gmath.sub(src.Right, src.Left), convert<T>(count - 1));
            return measuredPoints(src,w);            
        }

        /// <summary>
        /// Partitions an interval predicated on partition count
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="count">The number of partitions</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<S> counted<S,T>(S src, int count)
            where S : struct, IInterval<S,T>
            where T : unmanaged
        {
            var delta = gmath.sub(src.Right, src.Left);
            var width = gmath.div(delta, convert<T>(count));
            return width<S,T>(src,width);
        }

        /// <summary>
        /// Partiions an invterval predicated on partition width
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The interval primal type</typeparam>
        public static Span<S> width<S,T>(S src, T width)
            where S : struct, IInterval<S,T>
            where T : unmanaged
        {
            var points = measuredPoints<S,T>(src,width);
            var dst = alloc<S>(points.Length - 1);
            var lastIx = points.Length - 1;
            var lastCycleIx = lastIx - 1;
            var model = default(S);
            
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
        static Span<T> points_i<S,T>(S src, T width)
            where S : struct, IInterval<S,T>
            where T : unmanaged
        {
            var len =  length<S,T>(src);
            var count = Cast.to<T,int>(gmath.div(len, width));            
            var dst = alloc<T>(count + 1);
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

        static Span<T> points_f<S,T>(S src, T width)
            where S : struct, IInterval<S,T>
            where T : unmanaged
        {
            var scale = 4;
            var len =  gfp.round(length<S,T>(src), scale);
            var fcount = gfp.div(len, width);
            var count = convert<T,int>(gfp.ceil(fcount));            
            var dst = alloc<T>(count + 1);

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