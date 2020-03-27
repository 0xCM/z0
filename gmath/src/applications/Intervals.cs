//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
       
    using static Root;

    public static class IntervalOps
    {
        /// <summary>
        /// Computes the length of the interval by finding the magnituded of the difference 
        /// between its left/right endpoints
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline)]
        public static T Length<T>(this IInterval<T> src)
            where T : unmanaged
                => gmath.abs(gmath.sub(src.Right, src.Left));

        /// <summary>
        /// Determines whether an interval contains a specified point
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="point">The point to test</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this Interval<T> src, T point)
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
        /// Slices an interval into manageable pieces, disjoint even
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <param name="precision">The precision with which the calculations are carried out</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> PartitionPoints<T>(this Interval<T> src, T width, int? precision = null)
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

        public static T[] Increments<T>(this Interval<T> src, T t = default)
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