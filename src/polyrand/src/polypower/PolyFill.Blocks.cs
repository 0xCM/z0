//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class PolyFill
    {
        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IPolyrand random, in SpanBlock8<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IPolyrand random, in SpanBlock16<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IPolyrand random, in SpanBlock32<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IPolyrand random, in SpanBlock64<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IPolyrand random, in SpanBlock128<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in SpanBlock256<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in SpanBlock512<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static void Fill<T>(this IPolyrand random, T min, T max, in SpanBlock16<T> dst)
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
        public static void Fill<T>(this IPolyrand random, T min, T max, in SpanBlock32<T> dst)
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
        public static void Fill<T>(this IPolyrand random, T min, T max, in SpanBlock64<T> dst)
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
        public static void Fill<T>(this IPolyrand random, T min, T max, in SpanBlock128<T> dst)
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
        public static void Fill<T>(this IPolyrand random, T min, T max, in SpanBlock256<T> dst)
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
        public static void Fill<T>(this IPolyrand random,T min, T max, in SpanBlock512<T> dst)
            where T : unmanaged
                => random.Fill(min,max,dst.Data);
    }
}