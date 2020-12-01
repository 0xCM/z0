//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericLiterals;

    public static class PolyZero
    {
        /// <summary>
        /// Produces a stream of nonzero uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IValueStream<T> NonZStream<T>(this IDomainSource random, Interval<T> domain)
            where T : unmanaged
                => PolyStreams.create<T>(random, domain, x => gmath.nonz(x));

        /// <summary>
        /// Queries the source for the next nonzero value within a range
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
        /// <typeparam name="T">The element type</typeparam>
        public static T NonZ<T>(this IDomainSource src, T min, T max)
            where T : unmanaged
                => src.NonZStream<T>((min,max)).First();

        /// <summary>
        /// Queries the source for the next nonzero value within a range
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The range of potential values</param>
        /// <typeparam name="T">The element type</typeparam>
        public static T NonZ<T>(this IDomainSource src, Interval<T> domain)
            where T : unmanaged
                => src.NonZStream<T>(domain).First();

        /// <summary>
        /// Queries the source for the next nonzero value less than a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static T NonZ<T>(this IDomainSource src, T max)
            where T : unmanaged
                => src.NonZStream<T>((minval<T>(),max)).First();

        /// <summary>
        /// Queries the source for the next nonzero value
        /// </summary>
        /// <param name="src">The random source</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static T NonZ<T>(this IDomainSource src)
            where T : unmanaged
                => src.NonZStream<T>((minval<T>(), maxval<T>())).First();
    }
}