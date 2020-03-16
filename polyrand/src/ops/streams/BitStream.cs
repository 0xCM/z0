//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Polyfun
    {        
        /// <summary>
        /// Produces an interminable stream of random bits
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<bit> BitStream(this IPolyrand random)
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

        /// <summary>
        /// Fills a caller-supplied target with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static void Fill(this IPolyrand random, Span<bit> dst)
        {
            const int w = 64;
            var pos = -1;
            var last = dst.Length - 1;

            while(pos <= last)
            {
                var data = random.Next<ulong>();
                
                var i = -1;
                while(++pos <= last && ++i < w)
                    dst[pos] = bit.test(data,i);
            }
        }
    }
}