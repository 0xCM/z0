//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class RngX
    {
        /// <summary>
        /// Allocates and fills specified number of 16-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
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
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Blocks<T>(this IPolyrand random, N16 n, Interval<T> domain, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(n,blocks)).Blocked(n); 

        /// <summary>
        /// Allocates and fills specified number of 16-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Blocks<T>(this IPolyrand random, N16 n, T min, T max, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(n, (min,max), blocks, filter);

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Blocks<T>(this IPolyrand random, N32 n, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(n,blocks)).Blocked(n); 

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Blocks<T>(this IPolyrand random, N32 n, Interval<T> domain, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(n,blocks)).Blocked(n); 

        /// <summary>
        /// Allocates and fills specified number of 32-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Blocks<T>(this IPolyrand random, N32 n, T min, T max, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(n, (min,max), blocks, filter);


        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Blocks<T>(this IPolyrand random, N64 n, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(n,blocks)).Blocked(n); 

        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Blocks<T>(this IPolyrand random, N64 n, Interval<T> domain, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(n,blocks)).Blocked(n); 

        /// <summary>
        /// Allocates and fills specified number of 64-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Blocks<T>(this IPolyrand random, N64 n, T min, T max, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(n, (min,max), blocks, filter);

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Blocks<T>(this IPolyrand random, N128 n, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(n,blocks)).Blocked(n); 

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Blocks<T>(this IPolyrand random, N128 n, Interval<T> domain, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(n,blocks)).Blocked(n); 

        /// <summary>
        /// Allocates and fills specified number of 128-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Blocks<T>(this IPolyrand random, N128 n, T min, T max, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(n, (min,max), blocks, filter);

        /// <summary>
        /// Allocates and fills specified number of 156-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness selector</param>
        /// <param name="blocks">The number of 256-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Blocks<T>(this IPolyrand random, N256 n, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged       
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(n,blocks)).Blocked(n);       

        /// <summary>
        /// Allocates and fills specified number of 256-bit blocks
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Blocks<T>(this IPolyrand random, N256 n, Interval<T> domain, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream(domain,filter).ToSpan(DataBlocks.blockedcells<T>(n,blocks)).Blocked(n); 

        /// <summary>
        /// Allocates and fills specified number of 256-bit blocks 
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Blocks<T>(this IPolyrand random, N256 n, T min, T max, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks(n, (min,max), blocks, filter);
    }
}