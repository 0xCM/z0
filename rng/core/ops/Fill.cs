//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;

    partial class CoreRngOps
    {
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

        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, Span<T> dst)
            where T : unmanaged
                => random.Fill(CoreRng.domain<T>(), dst.Length, ref head(dst));

        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, T min, T max, Span<T> dst)
            where T : unmanaged
                => random.Fill((min,max), dst.Length, ref head(dst));

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block16<T> dst)
            where T : unmanaged
                => random.Fill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block32<T> dst)
            where T : unmanaged
                => random.Fill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block64<T> dst)
            where T : unmanaged
                => random.Fill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block128<T> dst)
            where T : unmanaged
                => random.Fill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block256<T> dst)
            where T : unmanaged
                => random.Fill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block512<T> dst)
            where T : unmanaged
                => random.Fill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, T min, T max, in Block16<T> dst)
            where T : unmanaged
                => random.Fill(min,max,dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, T min, T max, in Block32<T> dst)
            where T : unmanaged
                => random.Fill(min,max,dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, T min, T max, in Block64<T> dst)
            where T : unmanaged
                => random.Fill(min,max,dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, T min, T max, in Block128<T> dst)
            where T : unmanaged
                => random.Fill(min,max,dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, T min, T max, in Block256<T> dst)
            where T : unmanaged
                => random.Fill(min,max,dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random,T min, T max, in Block512<T> dst)
            where T : unmanaged
                => random.Fill(min,max,dst.Data);
    }
}