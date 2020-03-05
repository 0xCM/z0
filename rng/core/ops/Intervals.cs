//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    partial class CoreRngOps
    {
        /// <summary>
        /// Produces a random closed interval [a,b] where a >= min and b < max
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum left endpoint value</param>
        /// <param name="max">The exclusive maximum right endpoint value</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        public static Interval<T> Interval<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
        {
            var cut = random.Next(min,max);
            return (random.Next(min, cut), random.Next(cut,max));
        }

        /// <summary>
        /// Produces a stream of random closed intervals [a,b] where a >= min and b < max
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum left endpoint value</param>
        /// <param name="max">The exclusive maximum right endpoint value</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        public static IEnumerable<Interval<T>> Intervals<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
        {
            while(true)
                yield return random.Interval(min,max);
        }

    }
}