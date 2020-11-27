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

    public static class BitSpanRng
    {
        /// <summary>
        /// Produces a random bitspan of specified length
        /// </summary>
        /// <param name="source">The random source</param>
        [MethodImpl(Inline)]
        public static BitSpan32 BitSpan(this IValueSource source, int length)
            => Z0.BitSpans.load(source.BitStream32().Take(length).ToArray());

        /// <summary>
        /// Produces a random bitspan of specified length
        /// </summary>
        /// <param name="source">The random source</param>
        [MethodImpl(Inline)]
        public static BitSpan32 BitSpan(this IValueSource source, uint length)
            => Z0.BitSpans.load(source.BitStream32().Take(length).ToArray());

        /// <summary>
        /// Produces a bitspan with randomized length
        /// </summary>
        /// <param name="source">The random source</param>
        /// <param name="minlen">The minimum bitspan length</param>
        /// <param name="maxlen">The maximum bitspan length</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 BitSpan(this IPolySourced source, int minlen, int maxlen)
            => source.BitSpan(source.Next<int>(minlen, maxlen + 1));

        /// <summary>
        /// Fills a caller-supplied bitspan with random bits
        /// </summary>
        /// <param name="source">The random source</param>
        [MethodImpl(Inline)]
        public static ref readonly BitSpan BitSpan(this IValueSource source, in BitSpan dst)
        {
            source.BitStream().Take(dst.Length).ToArray().CopyTo(dst.Storage);
            return ref dst;
        }
    }
}