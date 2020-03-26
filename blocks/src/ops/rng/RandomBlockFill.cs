//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Blocks;

    partial class RandomBlocks
    {
        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block16<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block32<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block64<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block128<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block256<T> dst)
            where T : unmanaged
                => random.SpanFill(dst.Data);

        /// <summary>
        /// Fills caller-allocated block storage with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, in Block512<T> dst)
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
        [MethodImpl(Inline)]
        public static void Fill<T>(this IPolyrand random, T min, T max, in Block16<T> dst)
            where T : unmanaged
                => random.SpanFill(min,max,dst.Data);

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
                => random.SpanFill(min,max,dst.Data);

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
                => random.SpanFill(min,max,dst.Data);

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
                => random.SpanFill(min,max,dst.Data);

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
                => random.SpanFill(min,max,dst.Data);

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
                => random.SpanFill(min,max,dst.Data); 
    }
}