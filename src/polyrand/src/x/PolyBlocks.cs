//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using B = CellCalcs;

    partial class XSource
    {
        /// <summary>
        /// Allocates and fills specified number of 8-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock8<T> SpanBlocks<T>(this IBoundSource src, W8 w, int count, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => src.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 8-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock8<T> SpanBlocks<T>(this IBoundSource src, W8 w, int count, T min, T max)
            where T : unmanaged
                => src.Stream<T>((min,max)).ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills a specified number of 16-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock8<T> SpanBlocks<T>(this ISource src, W8 w, int count, T t = default)
            where T : unmanaged
                => src.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 16-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock16<T> SpanBlocks<T>(this IBoundSource src, W16 w, int count, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => src.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 16-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock16<T> SpanBlocks<T>(this IBoundSource src, W16 w, int count, T min, T max)
            where T : unmanaged
                => src.Stream<T>((min,max)).ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills a specified number of 16-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock16<T> SpanBlocks<T>(this ISource src, W16 w, int count, T t = default)
            where T : unmanaged
                => src.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock32<T> SpanBlocks<T>(this ISource src, W32 w, int count)
            where T : unmanaged
                => src.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock32<T> SpanBlocks<T>(this IBoundSource src, W32 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => src.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock32<T> SpanBlocks<T>(this IBoundSource src, W32 w, T min, T max, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => src.SpanBlocks(w, (min,max), count, filter);

        /// <summary>
        /// Allocates and fills a specified number of 32-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock32<T> SpanBlocks<T>(this IBoundSource src, W32 w, int count, T t)
            where T : unmanaged
                => src.SpanBlocks<T>(w, count);

        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock64<T> SpanBlocks<T>(this ISource src, W64 w, int count)
            where T : unmanaged
                => src.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock64<T> SpanBlocks<T>(this IBoundSource src, W64 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => src.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock64<T> SpanBlocks<T>(this IBoundSource src, W64 w, T min, T max, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => src.SpanBlocks(w, (min,max), count, filter);

        /// <summary>
        /// Allocates and fills a specified number of 64-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock64<T> SpanBlocks<T>(this ISource src, W64 w, int count, T t)
            where T : unmanaged
                => src.SpanBlocks<T>(w,count);

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock128<T> SpanBlocks<T>(this ISource src, W128 w, int count = 1)
            where T : unmanaged
                => src.Stream<T>().ToSpan(B.cellblocks<T>(w, count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock128<T> SpanBlocks<T>(this IBoundSource src, W128 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => src.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock128<T> SpanBlocks<T>(this IBoundSource src, W128 w, T min, T max, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => src.SpanBlocks(w, (min,max), count, filter);

        /// <summary>
        /// Allocates and fills a specified number of 128-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock128<T> SpanBlocks<T>(this ISource src, W128 w, int count, T t)
            where T : unmanaged
                => src.SpanBlocks<T>(w,count);

        /// <summary>
        /// Allocates and fills specified number of 256-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The bitness selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock256<T> SpanBlocks<T>(this ISource src, W256 w, int count = 1)
            where T : unmanaged
                => src.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 256-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock256<T> SpanBlocks<T>(this IBoundSource src, W256 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => src.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 256-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock256<T> SpanBlocks<T>(this IBoundSource src, W256 w, T min, T max, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => src.SpanBlocks(w, (min,max), count, filter);

        /// <summary>
        /// Allocates and fills a specified number of 256-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock256<T> SpanBlocks<T>(this ISource src, W256 w, int count, T t)
            where T : unmanaged
                => src.SpanBlocks<T>(w,count);

        /// <summary>
        /// Allocates and fills specified number of 512-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The bitness selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock512<T> SpanBlocks<T>(this ISource src, W512 w, int count = 1)
            where T : unmanaged
                => src.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 512-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock512<T> SpanBlocks<T>(this IBoundSource src, W512 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => src.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w);

        /// <summary>
        /// Allocates and fills specified number of 512-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static SpanBlock512<T> SpanBlocks<T>(this IBoundSource src, W512 w, T min, T max, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => src.SpanBlocks(w, (min,max), count, filter);

        /// <summary>
        /// Allocates and fills a specified number of 512-bit blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static SpanBlock512<T> SpanBlocks<T>(this ISource src, W512 w, int count, T t)
            where T : unmanaged
                => src.SpanBlocks<T>(w,count);
    }
}