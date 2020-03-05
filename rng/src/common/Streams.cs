//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    using static Root;
    
    partial class RngX
    {
        /// <summary>
        /// Produces a stream of nonzero uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> NonZeroStream<T>(this IPolyrand random, Interval<T> domain)
            where T : unmanaged
                => CoreRng.stream(random.UniformStream(domain, x => gmath.nonz(x)), random.RngKind);
    }
}