//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public static class PolyBits
    {
        /// <summary>
        /// Produces an interminable stream of random bits
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<bit> BitStream32(this IPolyrand random)
        {
            const int w = 64;
            while(true)
            {
                var data = random.Next<ulong>();
                for(var i=0; i<w; i++)
                    yield return bit.test(data,i);
            }
        }

        /// <summary>
        /// Produces an interminable stream of random bits from a value sequence of parametric type
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<bit> BitStream<T>(this IPolyrand random)
            where T : unmanaged
                => Z0.BitStream.from(random.Stream<T>());      

    }
}