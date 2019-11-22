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
        /// Allocates a 128-bit blocked span and populates it with random values
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
                => random.Stream(domain,filter).ToSpan(DataBlocks.blocklen<T>(n,blocks)).ToSpan128(); 

        /// <summary>
        /// Allocates a 128-bit blocked span and populates it with random values
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
                => random.Stream(domain,filter).ToSpan(DataBlocks.blocklen<T>(n,blocks)).ToSpan128(); 

        /// <summary>
        /// Allocates a 128-bit blocked span and populates it with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitness source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Blocks<T>(this IPolyrand random, N128 n, T min, T max, int blocks = 1, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Stream((min,max),filter).ToSpan(DataBlocks.blocklen<T>(n,blocks)).ToSpan128(); 

        /// <summary>
        /// Allocates a 128-bit blocked span and populates it with random values and returns a readonly view to the caller
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock128<T> ConstBlocks<T>(this IPolyrand random, N128 n, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks<T>(n, blocks, domain, filter);

        /// <summary>
        /// Allocates a punctured 128-bit blocked span and populates it with nonzero random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> NonZeroBlocks<T>(this IPolyrand random, N128 n, int blocks = 1, Interval<T>? domain = null)        
            where T : unmanaged  
                => random.Blocks(n, blocks, domain, x => gmath.nonzero(x));

        /// <summary>
        /// Allocates a 256-bit blocked span and populates it with random values
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
                => random.Stream(domain,filter).ToSpan(DataBlocks.blocklen<T>(n,blocks)).ToSpan256();       

        /// <summary>
        /// Allocates and populates 256-bit readonly data blocks with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="blocks">The number of 256-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ConstBlock256<T> ConstBlocks<T>(this IPolyrand random, N256 n, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Blocks<T>(n, blocks, domain, filter);

        /// <summary>
        /// Allocates a punctured 256-bit blocked span and populates it with nonzero random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="blocks">The number of 256-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> NonZeroBlocks<T>(this IPolyrand random, N256 n, int blocks = 1, Interval<T>? domain = null)        
            where T : unmanaged  
                => random.Blocks(n,blocks, domain, x => gmath.nonzero(x)); 
    }

}