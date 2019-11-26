//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using BC = Z0.BitCells;

    partial class BitRng
    {

        /// <summary>
        /// Produces a natural bitcell container
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The number of bits to cover</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<N,T> BitCells<N,T>(this IPolyrand random)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => Z0.BitCells.load<N,T>(random.Stream<T>().ToSpan(BitCalcs.segcount<N,N1,T>()));

        /// <summary>
        /// Produces a generic bitcell container over a specified number of bits
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="bitcount">The number of bits to cover</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> BitCells<T>(this IPolyrand random, int bitcount)
            where T : unmanaged
                => BC.load<T>(random.Stream<T>().ToSpan(BC.cellcount<T>(bitcount)), bitcount);

        /// <summary>
        /// Produces a generic bitcell container over a random number of bits
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minbits">The minimum bit count</param>
        /// <param name="maxbits">The maximum bit count</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> BitCells<T>(this IPolyrand random, int minbits, int maxbits)
            where T : unmanaged
        {
            var len = random.Next<int>(minbits,++maxbits);
            return BC.literals<T>(random.Stream<T>().TakeArray(BC.cellcount<T>(len),len));
        }

        /// <summary>
        /// Produces a generic bitcell container over a random number of bits
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="range">The range of potential bitvector lengths</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> BitCells<T>(this IPolyrand random, Interval<int> range)
            where T : unmanaged
                => random.BitCells<T>(range.Left, range.Right);                    
    }
}