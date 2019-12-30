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

    partial class RngX
    {
        /// <summary>
        /// Produces a random bitspan of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitSpan BitSpan(this IPolyrand random, int length)
            => Z0.BitSpan.load(random.Bits().Take(length).ToArray());

        /// <summary>
        /// Fills a caller-supplied bitspan with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static void BitSpan(this IPolyrand random, in BitSpan dst)
            => random.TakeBits(dst.Length).CopyTo(dst.Bits);

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
        /// Fills a caller-supplied target with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static void Fill(this IPolyrand random, Span<bit> dst)
            => random.TakeBits(dst.Length).CopyTo(dst);
    }
}