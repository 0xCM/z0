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

    public static class RngSingle
    {        
        /// <summary>
        /// Produces a single random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Single<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => random.Next<T>();

        /// <summary>
        /// Produces a single random value within a range
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Single<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => random.Next<T>(min,max);
    }
}