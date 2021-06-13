//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct DataStreams
    {
        const NumericKind Closure = NumericKind.U64;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IDataStream<T> create<T>(IEnumerable<T> src, ulong classifier = 0)
            where T : struct
                => new DataStream<T>(src, classifier);

        /// <summary>
        /// Produces a random stream of unfiltered/unbounded points from a source
        /// </summary>
        /// <param name="src">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        [Op, Closures(Closure)]
        public static IDataStream<T> create<T>(IDomainSource src)
            where T : unmanaged
                => create(forever<T>(src));

        [Op, Closures(Closure)]
        public static IDataStream<T> create<T>(IDomainSource src, T min, T max)
            where T : unmanaged
                => create(forever(src,min,max));

        [Op, Closures(Closure)]
        public static IDataStream<T> create<T>(IDomainSource src, ClosedInterval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
                => create(forever(src, domain, filter));

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        [Op, Closures(Closure)]
        public static IDataStream<T> create<T>(IDomainSource src, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
                => create(forever(src, domain, filter));

        [Op, Closures(Closure)]
        static IEnumerable<T> forever<T>(IDomainSource src, ClosedInterval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => filter != null
                ? some(src, Interval.closed(domain.Min, domain.Max), filter)
                : forever(src, domain);

        [Op, Closures(Closure)]
        static IEnumerable<T> forever<T>(IDomainSource src, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => filter != null
                ? some(src, domain, filter)
                : forever(src, domain);

        [Op, Closures(Closure)]
        static IEnumerable<T> forever<T>(IDomainSource src, T min, T max)
            where T : unmanaged
        {
            while(true)
                yield return src.Next<T>(min, max);
        }

        [Op, Closures(Closure)]
        static IEnumerable<T> forever<T>(IDomainSource src)
            where T : unmanaged
        {
            while(true)
                yield return src.Next<T>();
        }

        [Op, Closures(Closure)]
        static IEnumerable<T> forever<T>(IDomainSource src, Interval<T> domain)
            where T : unmanaged
                => domain.IsEmpty ? forever<T>(src) : forever(src, domain.Left, domain.Right);

        [Op, Closures(Closure)]
        static IEnumerable<T> forever<T>(IDomainSource src, ClosedInterval<T> domain)
            where T : unmanaged
                => domain.IsEmpty ? forever<T>(src) : forever(src, domain.Min, domain.Max);

        /// <summary>
        /// Creates a stream predicated on a specified source over which a filter is applied
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The source domain</param>
        /// <param name="filter">The filter predicate</param>
        /// <typeparam name="T">The production type</typeparam>
        [Op, Closures(Closure)]
        static IEnumerable<T> some<T>(IDomainSource src, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
        {
            var next = default(T);
            var tries = 0;
            var tryMax = 10;

            while(true)
            {
                next = src.Next<T>(domain);
                if(filter(next))
                {
                    tries = 0;
                    yield return next;
                }
                else
                {
                    ++tries;
                    if(tries > tryMax)
                        throw new Exception($"Filter too rigid over {domain}; last failed value: {next}");
                }
            }
        }
    }
}