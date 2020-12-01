//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public static class BitSpan32Src
    {
        /// <summary>
        /// Produces a random bitspan of specified length
        /// </summary>
        /// <param name="source">The random source</param>
        [Op]
        public static BitSpan32 BitSpan32(this ISource source, int length)
            => BitSpans.load32(source.BitStream32().Take(length).ToArray());


        /// <summary>
        /// Produces a random bitspan of specified length
        /// </summary>
        /// <param name="source">The random source</param>
        [Op]
        public static BitSpan32 BitSpan32(this ISource source, uint length)
            => BitSpans.load32(source.BitStream32().Take(length).ToArray());

    }
}