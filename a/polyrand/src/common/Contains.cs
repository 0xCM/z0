//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class XTend
    {
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
                    return Numeric.gteq(point, src.Left) && Numeric.lteq(point, src.Right);
                case IntervalKind.Open:
                    return Numeric.gt(point, src.Left) && Numeric.lt(point, src.Right);
                case IntervalKind.LeftClosed:
                    return Numeric.gteq(point, src.Left) && Numeric.lt(point, src.Right);
                default:        
                    return Numeric.gt(point, src.Left) && Numeric.lteq(point, src.Right);
            }
        }
    }
}