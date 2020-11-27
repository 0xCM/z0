//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using B = SpanBlocks;

    public static partial class PolyBlock
    {
        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock8<T> Block<T>(this IPolySourced random, W8 w, T t = default)
            where T : unmanaged
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock16<T> Block<T>(this IPolySourced random, W16 w, T t = default)
            where T : unmanaged
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock16<T> Block<T>(this IPolySourced random, W16 w)
            where T : unmanaged
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock32<T> Block<T>(this IPolySourced random, W32 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock64<T> Block<T>(this IPolySourced random, W64 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock128<T> Block<T>(this IPolySourced random, W128 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock256<T> Block<T>(this IPolySourced random, W256 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock512<T> Block<T>(this IPolySourced random, W512 w, T t = default)
            where T : unmanaged
                => random.Blocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock16<T> Block<T>(this IPolySourced random, W16 w, T min, T max)
            where T : unmanaged
                => random.Stream<T>((min,max)).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock32<T> Block<T>(this IPolySourced random, W32 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock64<T> Block<T>(this IPolySourced random, W64 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock128<T> Block<T>(this IPolySourced random, W128 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock256<T> Block<T>(this IPolySourced random, W256 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock512<T> Block<T>(this IPolySourced random, W512 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Fills a single caller-allocated 16-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock16<T> Block<T>(this IPolySourced random, in SpanBlock16<T> dst, int block)
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
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock32<T> Block<T>(this IPolySourced random, in SpanBlock32<T> dst, int block)
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
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock64<T> Block<T>(this IPolySourced random, in SpanBlock64<T> dst, int block)
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
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock128<T> Block<T>(this IPolySourced random, in SpanBlock128<T> dst, int block)
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
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock256<T> Block<T>(this IPolySourced random, in SpanBlock256<T> dst, int block)
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
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock512<T> Block<T>(this IPolySourced random, in SpanBlock512<T> dst, int block)
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
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The exclusive cell value upper bound</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock16<T> Block<T>(this IPolySourced random, T min, T max, in SpanBlock16<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 32-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The exclusive cell value upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock32<T> Block<T>(this IPolySourced random, T min, T max, in SpanBlock32<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 64-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The exclusive cell value upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock64<T> Block<T>(this IPolySourced random, T min, T max, in SpanBlock64<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 128-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The exclusive cell value upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock128<T> Block<T>(this IPolySourced random, T min, T max, in SpanBlock128<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 256-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock256<T> Block<T>(this IPolySourced random, T min, T max, in SpanBlock256<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 512-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock512<T> Block<T>(this IPolySourced random, T min, T max, in SpanBlock512<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock16<T> Block<T>(this IPolySourced random, W16 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock32<T> Block<T>(this IPolySourced random, W32 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock64<T> Block<T>(this IPolySourced random, W64 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock128<T> Block<T>(this IPolySourced random, W128 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock256<T> Block<T>(this IPolySourced random, W256 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 512-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock512<T> Block<T>(this IPolySourced random, W512 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock16<T> Block<T>(this IPolySourced random, W16 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock32<T> Block<T>(this IPolySourced random, W32 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock64<T> Block<T>(this IPolySourced random, W64 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock128<T> Block<T>(this IPolySourced random, W128 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock256<T> Block<T>(this IPolySourced random, W256 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 512-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock512<T> Block<T>(this IPolySourced random, W512 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);
    }
}