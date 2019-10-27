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
        
    using static zfunc;    
    using static As;

    partial class gmath
    {

        /// <summary>
        /// Determines whether a primal interval contains a specified point
        /// </summary>
        /// <param name="src">The interval</param>
        /// <param name="point">The test point</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bool contains<T>(IInterval<T> src, T point)
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

        public static Interval<T> add<T>(Interval<T> lhs, Interval<T> rhs)
            where T : unmanaged
            => lhs.WithEndpoints(
                    gmath.add(lhs.Left, rhs.Left), 
                    gmath.add(lhs.Right, rhs.Right)
                    );

        public static Interval<T> Sub<T>(this ref Interval<T> lhs, Interval<T> rhs)
            where T : unmanaged
            => lhs.WithEndpoints(
                    gmath.sub(lhs.Left, rhs.Left), 
                    gmath.sub(lhs.Right, rhs.Right)
                    );


    }

}