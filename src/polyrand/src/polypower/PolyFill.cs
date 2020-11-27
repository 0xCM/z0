//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static z;

    public static partial class PolyFill
    {
        /// <summary>
        /// Fills a caller-allocated target with a specified number of values from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Fill<T>(this IPolySourced random, Interval<T> domain, int count, ref T dst, Func<T,bool> filter = null)
            where T : unmanaged
        {
            var points = @readonly(random.Stream<T>(domain, filter).Take(count).Array());
            for(var i=0; i<count; i++)
                seek(dst, i) = skip(points, i);
        }

        /// <summary>
        /// Fills a caller-allocated buffer with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IPolySourced random, Span<T> dst)
            where T : unmanaged
                => random.Fill(random.Domain<T>(), dst.Length, ref z.first(dst));

        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Span<T> Fill<T>(this IPolySourced random, T min, T max, Span<T> dst, Func<T,bool> filter = null)
            where T : unmanaged
        {
            random.Fill((min,max), dst.Length, ref first(dst), filter);
            return dst;
        }

        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Span<T> Fill<T>(this IPolySourced random, Interval<T> domain, Span<T> dst, Func<T,bool> filter = null)
            where T : unmanaged
        {
            random.Fill(domain, dst.Length, ref first(dst), filter);
            return dst;
        }

        /// <summary>
        /// Fills a caller-allocated target with a specified number of values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Fill<T>(this IPolySourced random, int count, ref T dst)
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
        public static void Fill(this IPolySourced random, Span<bit> dst)
        {
            const int w = 64;
            var pos = -1;
            var last = dst.Length - 1;

            while(pos <= last)
            {
                var data = random.Next<ulong>();

                var i = -1;
                while(++pos <= last && ++i < w)
                    dst[pos] = BitStates.test(data,(byte)i);
            }
        }
    }
}