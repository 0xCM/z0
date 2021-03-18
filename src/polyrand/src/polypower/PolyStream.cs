//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static class PolyStream
    {
        /// <summary>
        /// Produces a random stream of unfiltered/unbounded points from a source
        /// </summary>
        /// <param name="src">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        public static IDataStream<T> Stream<T>(this IPolySource src)
            where T : unmanaged
                => PolyStreams.create<T>(src);

        /// <summary>
        /// Produces a random stream of unfiltered/unbounded points from a source
        /// </summary>
        /// <param name="src">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        public static IDataStream<T> Stream<T>(this IDomainSource src)
            where T : unmanaged
                => PolyStreams.create<T>(src);

        /// <summary>
        /// Produces a stream values from the source subject to a specified range and optional filter
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IDataStream<T> Stream<T>(this IDomainSource src, T min, T max)
            where T : unmanaged
                => PolyStreams.create<T>(src, (min,max));

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IDataStream<T> Stream<T>(this IDomainSource src, Interval<T> domain)
            where T : unmanaged
                => PolyStreams.create(src, domain);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IDataStream<T> Stream<T>(this IDomainSource src, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => PolyStreams.create(src, domain, filter);
    }
}