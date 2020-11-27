//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static class PolyStreams
    {
        [MethodImpl(Inline)]
        public static IRngStream<T> create<T>(IEnumerable<T> src, RngKind kind)
            where T : struct
                => new PolyStream<T>(src,kind);

        [MethodImpl(Inline)]
        public static IPolyStream<T> create<T>(IEnumerable<T> src)
            where T : struct
                => new PolyStream<T>(src);

        /// <summary>
        /// Produces a random stream of unfiltered/unbounded points from a source
        /// </summary>
        /// <param name="src">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        public static IRngStream<T> create<T>(IPolyrand src)
            where T : unmanaged
                => create(forever<T>(src), src.RngKind);

        public static IRngStream<T> create<T>(IPolyrand src, T min, T max)
            where T : unmanaged
                => create(forever(src,min,max), src.RngKind);

        public static IRngStream<T> create<T>(IPolyrand src, ClosedInterval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
                => create(forever(src, domain, filter), src.RngKind);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IPolyStream<T> create<T>(IPolySourced src, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
                => create(forever(src, domain, filter));

        static IEnumerable<T> forever<T>(IPolyDomain src, ClosedInterval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => filter != null
                ? some(src, Interval.closed(domain.Min, domain.Max), filter)
                : forever(src, domain);

        static IEnumerable<T> forever<T>(IPolyDomain src, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => filter != null
                ? some(src, domain, filter)
                : forever(src, domain);

        static IEnumerable<T> forever<T>(IPolyDomain src, T min, T max)
            where T : unmanaged
        {
            while(true)
                yield return src.Next<T>(min, max);
        }

        static IEnumerable<T> forever<T>(IPolyDomain src)
            where T : unmanaged
        {
            while(true)
                yield return src.Next<T>();
        }

        static IEnumerable<T> forever<T>(IPolyDomain src, Interval<T> domain)
            where T : unmanaged
                => domain.IsEmpty ? forever<T>(src) : forever(src, domain.Left, domain.Right);

        static IEnumerable<T> forever<T>(IPolyDomain src, ClosedInterval<T> domain)
            where T : unmanaged
                => domain.IsEmpty ? forever<T>(src) : forever(src, domain.Min, domain.Max);

        /// <summary>
        /// Creates a stream predicated on a specified source over which a filter is applied
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The source domain</param>
        /// <param name="filter">The filter predicate</param>
        /// <typeparam name="T">The production type</typeparam>
        static IEnumerable<T> some<T>(IPolyDomain src, Interval<T> domain, Func<T,bool> filter)
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