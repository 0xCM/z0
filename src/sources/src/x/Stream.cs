//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class XSource
    {
        public static IEnumerable<T> Stream<T>(this IDomainSource src, Interval<T> domain, Func<T,bool> filter = null)
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
        public static IDataStream<T> DataStream<T>(this ISource src)
            where T : unmanaged
                => new DataStream<T>(src.Stream<T>());

        /// <summary>
        /// Produces a stream values from the source subject to a specified range and optional filter
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IDataStream<T> DataStream<T>(this IDomainSource src, T min, T max)
            where T : unmanaged
                => new DataStream<T>(src.Stream<T>((min,max)));

        /// <summary>
        /// Produces a stream values from the source subject to a specified range and optional filter
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IDataStream<T> DataStream<T>(this IDomainSource src, Interval<T> domain)
            where T : unmanaged
                => src.DataStream<T>(domain.Left, domain.Right);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IDataStream<T> DataStream<T>(this IDomainSource src, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => new DataStream<T>(src.Stream(domain, filter));
    }
}