//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static z;

    public static class PolyFill
    {
        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void SpanFill<T>(this IPolyrand random, Span<T> dst)
            where T : unmanaged
                => random.Fill(random.Domain<T>(), dst.Length, ref z.first(dst));
                        
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
            var it = random.Stream<T>(domain, filter).Take(count).GetEnumerator();
            var counter = 0;
            while(it.MoveNext())
                seek(dst, counter++) = it.Current;
        }

        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IPolyrand random, T min, T max, Span<T> dst)
            where T : unmanaged
                => random.Fill((min,max), dst.Length, ref first(dst));

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
                seek(dst, counter++) = it.Current;
        }

        /// <summary>
        /// Fills a caller-supplied target with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        public static void Fill(this IPolyrand random, Span<bit> dst)
        {
            const int w = 64;
            var pos = -1;
            var last = dst.Length - 1;

            while(pos <= last)
            {
                var data = random.Next<ulong>();
                
                var i = -1;
                while(++pos <= last && ++i < w)
                    dst[pos] = bit.test(data,i);
            }
        }        
    }
}