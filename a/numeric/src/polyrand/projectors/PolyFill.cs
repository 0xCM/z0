//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    public static class PolyFill
    {
        /// <summary>
        /// Fills a caller-allocated target with a specified number of values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Fill<T>(this IPolyrand random, Interval<T> domain, int count, ref T dst, Func<T,bool> filter = null)
            where T : unmanaged
        {
            var it = random.Stream<T>(domain,filter).Take(count).GetEnumerator();
            var counter = 0;
            while(it.MoveNext())
                Unsafe.Add(ref dst, counter++) = it.Current;
        }

        /// <summary>
        /// Fills a caller-allocated target with a specified number of values from a source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Fill<T>(this IRngPointSource<T> src, int count, ref T dst)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)
                Unsafe.Add(ref dst, i) = src.Next();
        }
                
        /// <summary>
        /// Fills a caller-allocated target with a specified number of values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Fill<T>(this IPolyrand random, int count, ref T dst)
            where T : unmanaged
        {
            var it = random.Stream<T>().Take(count).GetEnumerator();
            var counter = 0;
            while(it.MoveNext())
                Unsafe.Add(ref dst, counter++) = it.Current;
        }
    }
}