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

    using static root;
 
    public static class BitSpanRng
    {
        /// <summary>
        /// Produces a random bitspan of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitSpan BitSpan(this IPolyrand random, int length)
            => Z0.BitSpan.load(random.BitStream().Take(length).ToArray());

        /// <summary>
        /// Produces a bitspan with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The mininimum bitspan length</param>
        /// <param name="maxlen">The maximum bitspan length</param>
        [MethodImpl(Inline)]
        public static BitSpan BitSpan(this IPolyrand random, int minlen, int maxlen)
            => random.BitSpan(random.Next<int>(minlen, maxlen + 1));

        /// <summary>
        /// Fills a caller-supplied bitspan with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static ref readonly BitSpan BitSpan(this IPolyrand random, in BitSpan dst)
        {
            random.BitStream().Take(dst.Length).ToArray().CopyTo(dst.Bits);
            return ref dst;
        }
    }
}