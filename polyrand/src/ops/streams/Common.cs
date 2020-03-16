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

    using static Root;

    partial class Polyfun
    {        

        /// <summary>
        /// Creates a numeric emitter predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static NumericRngEmitter<T> NumericEmitter<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => new NumericRngEmitter<T>(random);

        /// <summary>
        /// Produces a random stream of unfiltered/unbounded points from a source
        /// </summary>
        /// <param name="random">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        public static IRngStream<T> Stream<T>(this IPolyrand random)
            where T : unmanaged
        {
            IEnumerable<T> produce()
            {
                while(true)
                    yield return random.Next<T>();
            }
            
            return PolyOps.stream(produce(), random.RngKind);
        }

        /// <summary>
        /// Produces a stream values from the source subject to a specified range and optional filter
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> Stream<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => PolyOps.stream(random.UniformStream(min,max), random.RngKind);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> Stream<T>(this IPolyrand random, Interval<T> domain)
            where T : unmanaged
                => PolyOps.stream(random.UniformStream(domain), random.RngKind);

        public static IEnumerable<T> UniformStream<T>(this IPolyrand src, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
        {
            if(filter != null)
                return src.FilteredStream(domain,filter);
            else
                return src.UnfilteredStream(domain);
        }

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> Stream<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => PolyOps.stream(random.UniformStream(domain,filter), random.RngKind);

        /// <summary>
        /// Produces a random stream predicated on a point source
        /// </summary>
        /// <param name="random">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        static IEnumerable<T> Stream<T>(this IRngBoundPointSource<T> random)
            where T : unmanaged
        {
            while(true)
                yield return random.Next();
        }

        static IEnumerable<T> UnfilteredStream<T>(this IPolyrand src, T min, T max)
            where T : unmanaged
        {
            while(true)
                yield return src.Next<T>(min, max);
        }

        static IEnumerable<T> UnfilteredStream<T>(this IPolyrand src, Interval<T> domain)
            where T : unmanaged
        {
            if(domain.Empty)
            {
                while(true)
                    yield return src.Next<T>();    
            }
            else
            {
                while(true)
                    yield return src.Next<T>(domain.Left, domain.Right);
            }
        }

        static IEnumerable<T> UniformStream<T>(this IPolyrand src, T min, T max)
            where T : unmanaged
                => src.UnfilteredStream(min,max);

        static IEnumerable<T> UniformStream<T>(this IPolyrand src, Interval<T> domain)
            where T : unmanaged
                => src.UnfilteredStream(domain);

        static IEnumerable<T> FilteredStream<T>(this IPolyrand src, Interval<T> domain, Func<T,bool> filter)
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