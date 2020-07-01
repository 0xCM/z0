//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    public static partial class PolySpan
    {
        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void SpanFill<T>(this IPolyrand random, Span<T> dst)
            where T : unmanaged
                => random.Fill(random.Domain<T>(), dst.Length, ref head(dst));

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
                => random.Fill((min,max), dst.Length, ref head(dst));

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