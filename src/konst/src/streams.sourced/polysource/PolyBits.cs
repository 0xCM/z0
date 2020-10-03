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

    public static class PolyBits
    {
        /// <summary>
        /// Produces an interminable stream of random bits
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<Bit32> BitStream32(this IPolySource random)
        {
            const int w = 64;
            while(true)
            {
                var data = random.Next<ulong>();
                for(var i=0; i<w; i++)
                    yield return Bit32.test(data,i);
            }
        }

        /// <summary>
        /// Produces an interminable stream of random bits from a value sequence of parametric type
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<T> BitStream<T>(this IPolySource src)
            where T : unmanaged
        {
            while(true)
            {
                var data = src.Next<ulong>();
                for(var i=0; i<64; i++)
                    yield return z.force<byte,T>((byte)BitStates.test(data,i));
            }
        }
    }
}