//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Root;
    using static Nats;

    using B = Blocks;

    public static class BlockRngOps
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
        /// <summary>
        /// Allocates and fills specified number of 16-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block16<T> Blocks<T>(this IPolyrand random, N16 w, int count, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 16-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block16<T> Blocks<T>(this IPolyrand random, N16 w, int count, T min, T max)
            where T : unmanaged
                => random.Stream<T>((min,max)).ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills a specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static Block16<T> Blocks<T>(this IPolyrand random, N16 w, int count, T t = default)
            where T : unmanaged
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block32<T> Blocks<T>(this IPolyrand random, N32 w, int count)
            where T : unmanaged
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block32<T> Blocks<T>(this IPolyrand random, N32 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
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
        public static Block64<T> Blocks<T>(this IPolyrand random, N64 w, int count)
            where T : unmanaged
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block64<T> Blocks<T>(this IPolyrand random, N64 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
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
        public static Block128<T> Blocks<T>(this IPolyrand random, N128 w, int count = 1)
            where T : unmanaged
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block128<T> Blocks<T>(this IPolyrand random, N128 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
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
        public static Block256<T> Blocks<T>(this IPolyrand random, N256 w, int count = 1)
            where T : unmanaged       
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w);       

        /// <summary>
        /// Allocates and fills specified number of 256-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block256<T> Blocks<T>(this IPolyrand random, N256 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 256-bit blocks 
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
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
        public static Block512<T> Blocks<T>(this IPolyrand random, N512 w, int count = 1)
            where T : unmanaged       
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,count)).Blocked(w);       

        /// <summary>
        /// Allocates and fills specified number of 512-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block512<T> Blocks<T>(this IPolyrand random, N512 w, Interval<T> domain, int count = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,count)).Blocked(w); 

        /// <summary>
        /// Allocates and fills specified number of 512-bit blocks 
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The number of blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
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
        public static Block16<T> Block<T>(this IPolyrand random, N16 w, T t = default)
            where T : unmanaged
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,1)).Blocked(w); 

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block16<T> Block<T>(this IPolyrand random, N16 w)
            where T : unmanaged
                => random.Stream<T>().ToSpan(B.cellblocks<T>(w,1)).Blocked(w); 

        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The block cell type</typeparam>
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
        public static Block16<T> Block<T>(this IPolyrand random, N16 w, T min, T max)
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
        public static Block32<T> Block<T>(this IPolyrand random, N32 w, T min, T max)
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
        public static Block64<T> Block<T>(this IPolyrand random, N64 w, T min, T max)
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
        public static Block128<T> Block<T>(this IPolyrand random, N128 w, T min, T max)
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
        public static Block256<T> Block<T>(this IPolyrand random, N256 w, T min, T max)
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
        public static Block512<T> Block<T>(this IPolyrand random, N512 w, T min, T max)
            where T : unmanaged
                => random.Blocks<T>(w,min,max,1);

        /// <summary>
        /// Fills a single caller-allocated 16-bit block with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The block cell type</typeparam>
        public static ref readonly Block16<T> Block<T>(this IPolyrand random, in Block16<T> dst, int block)
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
        public static ref readonly Block32<T> Block<T>(this IPolyrand random, in Block32<T> dst, int block)
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
        public static ref readonly Block64<T> Block<T>(this IPolyrand random, in Block64<T> dst, int block)
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
        public static ref readonly Block128<T> Block<T>(this IPolyrand random, in Block128<T> dst, int block)
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
        public static ref readonly Block256<T> Block<T>(this IPolyrand random, in Block256<T> dst, int block)
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
        public static ref readonly Block512<T> Block<T>(this IPolyrand random, in Block512<T> dst, int block)
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
        public static ref readonly Block16<T> Block<T>(this IPolyrand random, T min, T max, in Block16<T> dst, int block)
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
        public static ref readonly Block32<T> Block<T>(this IPolyrand random, T min, T max, in Block32<T> dst, int block)
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
        public static ref readonly Block64<T> Block<T>(this IPolyrand random, T min, T max, in Block64<T> dst, int block)
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
        public static ref readonly Block128<T> Block<T>(this IPolyrand random, T min, T max, in Block128<T> dst, int block)
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
        public static ref readonly Block256<T> Block<T>(this IPolyrand random, T min, T max, in Block256<T> dst, int block)
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
        public static ref readonly Block512<T> Block<T>(this IPolyrand random, T min, T max, in Block512<T> dst, int block)
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
        public static Block16<T> Block<T>(this IPolyrand random, N16 w, Interval<T> domain, Func<T,bool> filter)
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
        public static Block32<T> Block<T>(this IPolyrand random, N32 w, Interval<T> domain, Func<T,bool> filter)
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
        public static Block64<T> Block<T>(this IPolyrand random, N64 w, Interval<T> domain, Func<T,bool> filter)
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
        public static Block128<T> Block<T>(this IPolyrand random, N128 w, Interval<T> domain, Func<T,bool> filter)
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
        public static Block256<T> Block<T>(this IPolyrand random, N256 w, Interval<T> domain, Func<T,bool> filter)
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
        public static Block512<T> Block<T>(this IPolyrand random, N512 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(B.cellblocks<T>(w,1)).Blocked(w); 

        /// <summary>
        /// Allocates and fills a single 16-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block16<T> Block<T>(this IPolyrand random, N16 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w); 
 
        /// <summary>
        /// Allocates and fills a single 32-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block32<T> Block<T>(this IPolyrand random, N32 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w); 
  
        /// <summary>
        /// Allocates and fills a single 64-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block64<T> Block<T>(this IPolyrand random, N64 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w); 

        /// <summary>
        /// Allocates and fills a single 128-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block128<T> Block<T>(this IPolyrand random, N128 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w); 

        /// <summary>
        /// Allocates and fills a single 256-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block256<T> Block<T>(this IPolyrand random, N256 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w); 

        /// <summary>
        /// Allocates and fills a single 512-bit block
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The block width selector</param>
        /// <param name="domain">A domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Block512<T> Block<T>(this IPolyrand random, N512 w, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).ToSpan(B.cellblocks<T>(w,1)).Blocked(w);
    }
}