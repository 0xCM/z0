//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using B = CellCalcs;

    partial class XSource
    {
        /// <summary>
        /// Fills a single caller-allocated 16-bit block with random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The exclusive cell value upper bound</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock16<T> SpanBlock<T>(this IDomainSource src, T min, T max, in SpanBlock16<T> dst, int block)
            where T : unmanaged
        {
            src.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 32-bit block with random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The exclusive cell value upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock32<T> SpanBlock<T>(this IDomainSource src, T min, T max, in SpanBlock32<T> dst, int block)
            where T : unmanaged
        {
            src.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 64-bit block with random values
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The exclusive cell value upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock64<T> SpanBlock<T>(this IDomainSource random, T min, T max, in SpanBlock64<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 128-bit block with random values
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The exclusive cell value upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock128<T> SpanBlock<T>(this IDomainSource random, T min, T max, in SpanBlock128<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 256-bit block with random values
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock256<T> SpanBlock<T>(this IDomainSource random, T min, T max, in SpanBlock256<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 512-bit block with random values
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock512<T> SpanBlock<T>(this IDomainSource random, T min, T max, in SpanBlock512<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(min,max,dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock8<T> SpanBlock<T>(this IDomainSource source, W8 w, T t = default)
            where T : unmanaged
                => source.Stream<T>().ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock16<T> SpanBlock<T>(this IDomainSource source, W16 w, T t = default)
            where T : unmanaged
                => source.Stream<T>().ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The primal source value type</typeparam>
        public static SpanBlock16<T> SpanBlock<T>(this IDomainSource source, W16 w)
            where T : unmanaged
                => source.Stream<T>().ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock32<T> SpanBlock<T>(this ISource source, W32 w, T t = default)
            where T : unmanaged
                => source.SpanBlocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock64<T> SpanBlock<T>(this ISource source, W64 w, T t = default)
            where T : unmanaged
                => source.SpanBlocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock128<T> SpanBlock<T>(this ISource source, W128 w, T t = default)
            where T : unmanaged
                => source.SpanBlocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock256<T> SpanBlock<T>(this ISource source, W256 w, T t = default)
            where T : unmanaged
                => source.SpanBlocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock512<T> SpanBlock<T>(this ISource source, W512 w, T t = default)
            where T : unmanaged
                => source.SpanBlocks<T>(w,1);

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock16<T> SpanBlock<T>(this IDomainSource source, W16 w, T min, T max)
            where T : unmanaged
                => source.Stream<T>((min,max)).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock32<T> SpanBlock<T>(this IDomainSource source, W32 w, T min, T max)
            where T : unmanaged
                => source.SpanBlocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock64<T> SpanBlock<T>(this IDomainSource source, W64 w, T min, T max)
            where T : unmanaged
                => source.SpanBlocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock128<T> SpanBlock<T>(this IDomainSource source, W128 w, T min, T max)
            where T : unmanaged
                => source.SpanBlocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock256<T> SpanBlock<T>(this IDomainSource source, W256 w, T min, T max)
            where T : unmanaged
                => source.SpanBlocks<T>(w,min,max,1);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="min">The inclusive cell value lower bound</param>
        /// <param name="max">The inclusive cell value upper bound</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock512<T> SpanBlock<T>(this IDomainSource source, W512 w, T min, T max)
            where T : unmanaged
                => source.SpanBlocks<T>(w,min,max,1);

        /// <summary>
        /// Fills a single caller-allocated 16-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock16<T> SpanBlock<T>(this ISource source, in SpanBlock16<T> dst, int block)
            where T : unmanaged
        {
            source.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 32-bit block with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock32<T> SpanBlock<T>(this ISource source, in SpanBlock32<T> dst, int block)
            where T : unmanaged
        {
            source.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 64-bit block with random values
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock64<T> SpanBlock<T>(this ISource source, in SpanBlock64<T> dst, int block)
            where T : unmanaged
        {
            source.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 128-bit block with random values
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock128<T> SpanBlock<T>(this ISource random, in SpanBlock128<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 256-bit block with random values
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock256<T> SpanBlock<T>(this ISource random, in SpanBlock256<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Fills a single caller-allocated 512-bit block with random values
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly SpanBlock512<T> SpanBlock<T>(this ISource random, in SpanBlock512<T> dst, int block)
            where T : unmanaged
        {
            random.Fill(dst.Block(block));
            return ref dst;
        }


        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock16<T> SpanBlock<T>(this IDomainSource random, W16 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock32<T> SpanBlock<T>(this IDomainSource random, W32 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock64<T> SpanBlock<T>(this IDomainSource random, W64 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock128<T> SpanBlock<T>(this IDomainSource random, W128 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock256<T> SpanBlock<T>(this IDomainSource random, W256 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 512-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <param name="filter">An domain refinement filter</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock512<T> SpanBlock<T>(this IDomainSource source, W512 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => source.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock16<T> SpanBlock<T>(this IDomainSource source, W16 w, Interval<T> domain)
            where T : unmanaged
                => source.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock32<T> SpanBlock<T>(this IDomainSource random, W32 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock64<T> SpanBlock<T>(this IDomainSource random, W64 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock128<T> SpanBlock<T>(this IDomainSource random, W128 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock256<T> SpanBlock<T>(this IDomainSource random, W256 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);

        /// <summary>
        /// Allocates and fills a single 512-bit block
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock512<T> SpanBlock<T>(this IDomainSource random, W512 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);
    }
}
