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
    
    public static class PolyStream
    {
        [MethodImpl(Inline)]
        public static IRngStream<T> create<T>(IEnumerable<T> src, RngKind rng)
            where T : struct
                => new RngStream<T>(rng,src);

        public static IRngStream<T> create<T>(IPolyrand src, T min, T max)
            where T : unmanaged
                => create(unfiltered(src,min,max), src.RngKind);

        public static IRngStream<T> create<T>(IPolyrand src, Interval<T> domain)
            where T : unmanaged
                => create(unfiltered(src,domain), src.RngKind);

        public static IEnumerable<T> points<T>(IPolyrand src, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
        {
            if(filter != null)
                return filtered(src,domain, filter);
            else
                return unfiltered(src,domain);
        }

        /// <summary>
        /// Creates a stream predicated on a specified source over which a filter is applied
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The source domain</param>
        /// <param name="filter">The filter predicate</param>
        /// <typeparam name="T">The production type</typeparam>
        static IEnumerable<T> filtered<T>(IPolyrand src, Interval<T> domain, Func<T,bool> filter)
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

        static IEnumerable<T> unfiltered<T>(IPolyrand src, Interval<T> domain)
            where T : unmanaged
        {
            if(domain.IsEmpty)
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

        static IEnumerable<T> unfiltered<T>(IPolyrand src, T min, T max)
            where T : unmanaged
        {
            while(true)
                yield return src.Next<T>(min, max);
        }

        /// <summary>
        /// Captures a random stream along with the generator classification
        /// </summary>
        readonly struct RngStream<T> : IRngStream<T>
            where T : struct
        {
            [MethodImpl(Inline)]
            public RngStream(RngKind rng, IEnumerable<T> src)
            {
                this.src = src;
                this.RngKind = rng;
            }

            readonly IEnumerable<T> src;

            public RngKind RngKind {get;}

            [MethodImpl(Inline)]
            public IEnumerator<T> GetEnumerator()
                => src.GetEnumerator();

            public IEnumerable<T> Next(int count)
                => src.Take(count);

            [MethodImpl(Inline)]
            public T Next()
                => src.First();
                
            IEnumerator IEnumerable.GetEnumerator()
                => src.GetEnumerator();
        }
    }

    public static class XStream
    {
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
            
            return PolyStream.create(produce(), random.RngKind);
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
                => PolyStream.create(random,min,max);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> Stream<T>(this IPolyrand random, Interval<T> domain)
            where T : unmanaged
                => PolyStream.create(random,domain);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> Stream<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => PolyStream.create(PolyStream.points(random,domain,filter), random.RngKind);
    }
}