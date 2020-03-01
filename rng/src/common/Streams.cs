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

    using static Root;
    
    partial class RngX
    {
        [MethodImpl(Inline)]
        static IRngStream<T> stream<T>(IEnumerable<T> src, RngKind rng)
            where T : struct
                =>  RandomStream.From(src,rng);

        /// <summary>
        /// Produces a random stream of bytes
        /// </summary>
        /// <param name="random">The random source</param>
        public static IRngStream<byte> Bytes(this IPolyrand random)
        {
            IEnumerable<byte> produce()
            {
                while(true)
                {
                    var bytes = BitConverter.GetBytes(random.Next<ulong>());
                    for(var i = 0; i< bytes.Length; i++)
                        if(i == 0)
                            yield return bytes[i];
                }
            }
            return stream(produce(), random.RngKind);
        }

        /// <summary>
        /// Produces a random stream of unfiltered/unbounded points from a source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <typeparam name="T">The point type</typeparam>
        public static IRngStream<T> Stream<T>(this IRngPointSource<T> src)
            where T : unmanaged
        {
            IEnumerable<T> produce()
            {
                while(true)
                    yield return src.Next();
            }

            return stream(produce(), src.RngKind);            
        }
        
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
            
            return stream(produce(), random.RngKind);
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
                => stream(random.UniformStream(min,max), random.RngKind);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> Stream<T>(this IPolyrand random, Interval<T> domain)
            where T : unmanaged
                => stream(random.UniformStream(domain), random.RngKind);


        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> Stream<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => stream(random.UniformStream(domain,filter), random.RngKind);

        /// <summary>
        /// Produces a stream of nonzero uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> NonZeroStream<T>(this IPolyrand random, Interval<T> domain)
            where T : unmanaged
                => stream(random.UniformStream(domain, x => gmath.nonz(x)), random.RngKind);


        static IEnumerable<T> UniformStream<T>(this IPolyrand src, T min, T max)
            where T : unmanaged
                => src.UnfilteredStream(min,max);

        static IEnumerable<T> UniformStream<T>(this IPolyrand src, Interval<T> domain)
            where T : unmanaged
                => src.UnfilteredStream(domain);

        static IEnumerable<T> UniformStream<T>(this IPolyrand src, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
        {
            if(filter != null)
                return src.FilteredStream(domain,filter);
            else
                return src.UnfilteredStream(domain);
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