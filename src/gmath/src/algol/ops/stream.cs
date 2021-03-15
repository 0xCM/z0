//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    partial struct gAlg
    {
        /// <summary>
        /// Defines a scalar sequence {0,1,...,count-1}
        /// </summary>
        /// <param name="count">The number of elements in the sequence</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<T> stream<T>(T count)
            where T : unmanaged
                => stream(default(T), count);

        /// <summary>
        /// Creates an enumerable sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<T> stream<T>(T x0, T x1)
            where T : unmanaged
                => range_1(x0, x1, null);

        /// <summary>
        /// Creates a numeric sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <param name="step">The step size</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static IEnumerable<T> stream<T>(T x0, T x1, T step)
            where T : unmanaged
                => range_1(x0, x1, step);


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
    }
}