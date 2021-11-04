//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public static class PolyStreams
    {
        /// <summary>
        /// Produces a random stream of unfiltered/unbounded points from a source
        /// </summary>
        /// <param name="src">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        public static ISourceStream<T> Stream<T>(this IPolySource src)
            where T : unmanaged
                => SourceStreams.create<T>(src);

        /// <summary>
        /// Produces a stream values from the source subject to a specified range and optional filter
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static ISourceStream<T> Stream<T>(this IPolySource src, T min, T max)
            where T : unmanaged
                => SourceStreams.create<T>(src, (min,max));

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static ISourceStream<T> Stream<T>(this IBoundSource src, Interval<T> domain)
            where T : unmanaged
                => SourceStreams.create(src, domain);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static ISourceStream<T> Stream<T>(this IPolySource src, Interval<T> domain)
            where T : unmanaged
                => SourceStreams.create(src, domain);

        public static IEnumerable<T> Stream<T>(this IBoundSource src, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
        {
            while(true)
            {
                var candidate = src.Next(domain);
                if(filter != null && filter(candidate))
                    yield return candidate;
                else
                    yield return candidate;
            }
        }

        public static IEnumerable<T> Stream<T>(this ISource src)
        {
            while(true)
                yield return src.Next<T>();
        }

        /// <summary>
        /// Produces a stream values from the source subject to a specified range and optional filter
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static ISourceStream<T> DataStream<T>(this ISource src)
            where T : unmanaged
                => SourceStreams.create(src.Stream<T>());

        /// <summary>
        /// Produces a stream values from the source subject to a specified range and optional filter
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static ISourceStream<T> DataStream<T>(this IBoundSource src, T min, T max)
            where T : unmanaged
                => SourceStreams.create(src.Stream<T>((min,max)));

        /// <summary>
        /// Produces a stream values from the source subject to a specified range and optional filter
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static ISourceStream<T> DataStream<T>(this IBoundSource src, Interval<T> domain)
            where T : unmanaged
                => src.DataStream<T>(domain.Left, domain.Right);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static ISourceStream<T> DataStream<T>(this IBoundSource src, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => SourceStreams.create(src.Stream(domain, filter));
    }
}