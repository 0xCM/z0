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
        /// Allocates and fills specified number of 16-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The block width selector</param>
        /// <param name="blocks">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Blocks<T>(this IPolyrand random, N16 n, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(n,blocks)).Blocked(n); 

        /// <summary>
        /// Allocates and fills specified number of 16-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Blocks<T>(this IPolyrand random, N16 w, Interval<T> domain, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,blocks)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 16-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Blocks<T>(this IPolyrand random, N16 w, T min, T max, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(w, (min,max), blocks, filter);

        /// <summary>
        /// Allocates and fills a specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Blocks<T>(this IPolyrand random, N16 w, int count, T t)
            where T : unmanaged
                => random.Blocks<T>(w,count);

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Blocks<T>(this IPolyrand random, N32 w, int count = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Blocks<T>(this IPolyrand random, N32 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Blocks<T>(this IPolyrand random, N32 w, T min, T max, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(w, (min,max), count, filter);

        /// <summary>
        /// Allocates and fills a specified number of 32-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Blocks<T>(this IPolyrand random, N32 w, int count, T t)
            where T : unmanaged
                => random.Blocks<T>(w,count);

        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Blocks<T>(this IPolyrand random, N64 w, int count = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Blocks<T>(this IPolyrand random, N64 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Blocks<T>(this IPolyrand random, N64 w, T min, T max, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(w, (min,max), count, filter);

        /// <summary>
        /// Allocates and fills a specified number of 64-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Blocks<T>(this IPolyrand random, N64 w, int count, T t)
            where T : unmanaged
                => random.Blocks<T>(w,count);

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Blocks<T>(this IPolyrand random, N128 w, int count = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Blocks<T>(this IPolyrand random, N128 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Blocks<T>(this IPolyrand random, N128 w, T min, T max, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(w, (min,max), count, filter);

        /// <summary>
        /// Allocates and fills a specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Blocks<T>(this IPolyrand random, N128 w, int count, T t)
            where T : unmanaged
                => random.Blocks<T>(w,count);

        /// <summary>
        /// Allocates and fills specified number of 256-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The bitness selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Blocks<T>(this IPolyrand random, N256 w, int count = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged       
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,count)).Blocked(w);       

        /// <summary>
        /// Allocates and fills specified number of 256-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Blocks<T>(this IPolyrand random, N256 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 256-bit blocks 
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Blocks<T>(this IPolyrand random, N256 w, T min, T max, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(w, (min,max), count, filter);

        /// <summary>
        /// Allocates and fills a specified number of 256-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Blocks<T>(this IPolyrand random, N256 w, int count, T t)
            where T : unmanaged
                => random.Blocks<T>(w,count);

        /// <summary>
        /// Allocates and fills specified number of 512-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The bitness selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> Blocks<T>(this IPolyrand random, N512 w, int count = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged       
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,count)).Blocked(w);       

        /// <summary>
        /// Allocates and fills specified number of 512-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> Blocks<T>(this IPolyrand random, N512 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 512-bit blocks 
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> Blocks<T>(this IPolyrand random, N512 w, T min, T max, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(w, (min,max), count, filter);

        /// <summary>
        /// Allocates and fills a specified number of 512-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> Blocks<T>(this IPolyrand random, N512 w, int count, T t)
            where T : unmanaged
                => random.Blocks<T>(w,count);

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
    }
}