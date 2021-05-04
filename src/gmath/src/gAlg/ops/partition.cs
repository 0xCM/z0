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
        /// Slices an interval into manageable pieces, disjoint even
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <param name="precision">The precision with which the calculations are carried out</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        [Op, Closures(AllNumeric)]
        public static IEnumerable<T> partition<T>(Interval<T> src, T width, int? precision = null)
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