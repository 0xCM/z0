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

    using static Konst;
    using BS = Z0.BitString;

    public static class RandomBitStrings
    {
        /// <summary>
        /// Produces a bitstring with a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitstring length</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IPolyrand random, int len)
            => BS.load(random.BitStream<byte>().Take((int)len).ToArray());

        /// <summary>
        /// Produces a bitstring with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The minimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IPolyrand random, int minlen, int maxlen)
            => random.BitString(random.Next<int>(minlen, maxlen + 1));

        /// <summary>
        /// Produces a bitstring with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The minimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IPolyrand random, Interval<int> length)
            => random.BitString(length.Left, length.Right);

        /// <summary>
        /// Produces a random bitstring with a specified natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitstring length</param>
        [MethodImpl(Inline)]
        public static BitString BitString<N>(this IPolyrand random, N n = default)
            where N : unmanaged, ITypeNat
                => random.BitString((int)n.NatValue);

        /// <summary>
        /// Produces a random sequence of bitstrings with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The minimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
        public static IRngStream<BitString> BitStrings(this IPolyrand random, int minlen, int maxlen)
        {
            IEnumerable<BitString> produce()
            {
                while(true)
                    yield return random.BitString(minlen, maxlen);
            }

            return PolyStreams.create(produce(), random.RngKind);
        }
    }
}