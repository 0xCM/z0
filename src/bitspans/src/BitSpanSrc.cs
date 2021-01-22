//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    public static class BitSpanSource
    {
        /// <summary>
        /// Produces a bitspan with randomized length
        /// </summary>
        /// <param name="source">The random source</param>
        /// <param name="minlen">The minimum bitspan length</param>
        /// <param name="maxlen">The maximum bitspan length</param>
        [Op]
        public static BitSpan BitSpan(this IDomainSource source, int minlen, int maxlen)
            => source.BitSpan(source.Next<int>(minlen, maxlen + 1));

        /// <summary>
        /// Produces a random bitspan of specified length
        /// </summary>
        /// <param name="source">The random source</param>
        [Op]
        public static BitSpan BitSpan(this IDataSource source, int length)
            => BitSpans.load(source.BitStream().Take(length).ToArray());

        /// <summary>
        /// Produces a random bitspan of specified length
        /// </summary>
        /// <param name="source">The random source</param>
        [Op]
        public static BitSpan BitSpan(this IDataSource source, uint length)
            => BitSpans.load(source.BitStream().Take(length).ToArray());

        /// <summary>
        /// Fills a caller-supplied bitspan with random bits
        /// </summary>
        /// <param name="source">The random source</param>
        [Op]
        public static ref readonly BitSpan BitSpan(this IDataSource source, in BitSpan dst)
        {
            source.BitStream().Take(dst.Length).ToArray().CopyTo(dst.Storage);
            return ref dst;
        }
    }
}