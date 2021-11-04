//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static core;

    partial class XSource
    {
        /// <summary>
        /// Fills a caller-allocated target with a specified number of values from a random source
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Fill<T>(this IBoundSource src, Interval<T> domain, int count, ref T dst, Func<T,bool> filter = null)
            where T : unmanaged
        {
            var counter = 0;
            while(counter < count)
            {
                var candidate = src.Next(domain);
                if(filter != null)
                {
                    if(filter(candidate))
                    {
                        seek(dst, counter) = candidate;
                        counter++;
                    }
                }
                else
                {
                    seek(dst, counter) = candidate;
                    counter++;
                }
            }
        }

        /// <summary>
        /// Fills a caller-allocated target with a specified number of values from a random source
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Fill<T>(this IPolySource random, Interval<T> domain, int count, ref T dst, Func<T,bool> filter = null)
            where T : unmanaged
        {
            var points = @readonly(random.Stream<T>(domain, filter).Take(count).Array());
            for(var i=0; i<count; i++)
                seek(dst, i) = skip(points, i);
        }

        /// <summary>
        /// Fills a caller-allocated buffer with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IBoundSource source, Span<T> dst)
            where T : unmanaged
                => source.Fill(ClosedInterval<T>.Full, dst.Length, ref first(dst));

        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target span</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Span<T> Fill<T>(this IBoundSource source, T min, T max, Span<T> dst, Func<T,bool> filter = null)
            where T : unmanaged
        {
            source.Fill((min,max), dst.Length, ref first(dst), filter);
            return dst;
        }

        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="dst">The target span</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Span<T> Fill<T>(this IBoundSource random, Interval<T> domain, Span<T> dst, Func<T,bool> filter = null)
            where T : unmanaged
        {
            random.Fill(domain, dst.Length, ref first(dst), filter);
            return dst;
        }

        /// <summary>
        /// Fills a caller-allocated target with a specified number of values from the source
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Fill<T>(this ISource source, int count, ref T dst)
            where T : unmanaged
        {
            var it = source.Stream<T>().Take(count).GetEnumerator();
            var counter = 0;
            while(it.MoveNext())
                seek(dst, counter++) = it.Current;
        }

        /// <summary>
        /// Fills a caller-supplied target with random bits
        /// </summary>
        /// <param name="source">The data source</param>
        public static void Fill(this IBoundSource source, Span<bit> dst)
        {
            const int w = 64;
            var pos = -1;
            var last = dst.Length - 1;

            while(pos <= last)
            {
                var data = source.Next<ulong>();

                var i = -1;
                while(++pos <= last && ++i < w)
                    dst[pos] = bit.test(data,(byte)i);
            }
        }

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this ISource source, in SpanBlock8<T> dst)
            where T : unmanaged
                => source.Fill(dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this ISource source, in SpanBlock16<T> dst)
            where T : unmanaged
                => source.Fill(dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this ISource source, in SpanBlock32<T> dst)
            where T : unmanaged
                => source.Fill(dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this ISource source, in SpanBlock64<T> dst)
            where T : unmanaged
                => source.Fill(dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this ISource source, in SpanBlock128<T> dst)
            where T : unmanaged
                => source.Fill(dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this ISource src, in SpanBlock256<T> dst)
            where T : unmanaged
                => src.Fill(dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this ISource src, in SpanBlock512<T> dst)
            where T : unmanaged
                => src.Fill(dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IBoundSource src, T min, T max, in SpanBlock16<T> dst)
            where T : unmanaged
                => src.Fill(min,max,dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IBoundSource src, T min, T max, in SpanBlock32<T> dst)
            where T : unmanaged
                => src.Fill(min, max, dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IBoundSource src, T min, T max, in SpanBlock64<T> dst)
            where T : unmanaged
                => src.Fill(min,max,dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IBoundSource src, T min, T max, in SpanBlock128<T> dst)
            where T : unmanaged
                => src.Fill(min,max,dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IBoundSource src, T min, T max, in SpanBlock256<T> dst)
            where T : unmanaged
                => src.Fill(min,max,dst.Storage);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IBoundSource src,T min, T max, in SpanBlock512<T> dst)
            where T : unmanaged
                => src.Fill(min,max,dst.Storage);

        /// <summary>
        /// Fills a caller-allocated buffer with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IBoundSource source, Index<T> dst)
            where T : unmanaged
                => source.Fill(ClosedInterval<T>.Full, dst.Length, ref dst.First);

        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target span</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Index<T> Fill<T>(this IBoundSource source, T min, T max, Index<T> dst, Func<T,bool> filter = null)
            where T : unmanaged
        {
            source.Fill((min,max), dst.Length, ref dst.First, filter);
            return dst;
        }
    }
}