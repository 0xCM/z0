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

    partial class XRng
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
                => PolyStream.create(random,min,max); //PolyStream.create(random.CreateStream(min,max), random.RngKind);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> Stream<T>(this IPolyrand random, Interval<T> domain)
            where T : unmanaged
                => PolyStream.create(random,domain);   //PolyStream.create(random.CreateStream(domain), random.RngKind);

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

        // static IEnumerable<T> CreateStream<T>(this IPolyrand src, Interval<T> domain, Func<T,bool> filter)
        //     where T : unmanaged
        // {
        //     if(filter != null)
        //         return PolyStream.filtered(src,domain, filter);
        //     else
        //         return PolyStream.unfiltered(src,domain);
        // }

        // static IEnumerable<T> CreateStream<T>(this IPolyrand src, T min, T max)
        //     where T : unmanaged
        // {
        //     while(true)
        //         yield return src.Next<T>(min, max);
        // }

        // static IEnumerable<T> CreateStream<T>(this IPolyrand src, Interval<T> domain)
        //     where T : unmanaged
        // {
        //     if(domain.Empty)
        //     {
        //         while(true)
        //             yield return src.Next<T>();    
        //     }
        //     else
        //     {
        //         while(true)
        //             yield return src.Next<T>(domain.Left, domain.Right);
        //     }
        // }
    }
}