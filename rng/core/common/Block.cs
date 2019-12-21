//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class RngX
    {
        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Block<T>(this IPolyrand random, N16 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Block<T>(this IPolyrand random, N32 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Block<T>(this IPolyrand random, N64 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Block<T>(this IPolyrand random, N128 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Block<T>(this IPolyrand random, N256 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> Block<T>(this IPolyrand random, N512 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Block<T>(this IPolyrand random, N16 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Block<T>(this IPolyrand random, N32 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Block<T>(this IPolyrand random, N64 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Block<T>(this IPolyrand random, N128 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Block<T>(this IPolyrand random, N256 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> Block<T>(this IPolyrand random, N512 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Fills a single caller-allocated 16-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block16<T> Block<T>(this IPolyrand random, in Block16<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 32-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block32<T> Block<T>(this IPolyrand random, in Block32<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 64-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block64<T> Block<T>(this IPolyrand random, in Block64<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 128-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block128<T> Block<T>(this IPolyrand random, in Block128<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 256-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block256<T> Block<T>(this IPolyrand random, in Block256<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 512-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block512<T> Block<T>(this IPolyrand random, in Block512<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 16-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block16<T> Block<T>(this IPolyrand random, T min, T max, in Block16<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 32-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block32<T> Block<T>(this IPolyrand random, T min, T max, in Block32<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 64-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block64<T> Block<T>(this IPolyrand random, T min, T max, in Block64<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 128-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block128<T> Block<T>(this IPolyrand random, T min, T max, in Block128<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 256-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block256<T> Block<T>(this IPolyrand random, T min, T max, in Block256<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 512-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block512<T> Block<T>(this IPolyrand random, T min, T max, in Block512<T> dst, int block = 0)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }
         
    }
}