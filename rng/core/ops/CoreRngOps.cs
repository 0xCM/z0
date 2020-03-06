//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;


    public static partial class CoreRngOps
    {        
        /// <summary>
        /// Produces a random stream predicated on a point source
        /// </summary>
        /// <param name="random">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        public static IEnumerable<T> Stream<T>(this IRngBoundPointSource<T> random)
            where T : unmanaged
        {
            while(true)
                yield return random.Next();
        }

        /// <summary>
        /// Selects the next sequence of values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of values to select</param>
        /// <typeparam name="T">The value type</typeparam>
        public static IEnumerable<T> Take<T>(this IRngBoundPointSource<T> random, int count)
            where T : unmanaged
                => random.Stream().Take(count);

        public static NatSpan<N,T> Contract<N,T>(this NatSpan<N,T> src, NatSpan<N,T> max)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = Z0.NatSpan.alloc<N, T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Scale.contract(src[i],max[i]);
            return dst;
        }

    }

}