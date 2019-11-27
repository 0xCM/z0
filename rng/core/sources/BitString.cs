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
        /// Defines a point source that produces bitstring with varying lengths
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The potential bitstring lengths</param>
        [MethodImpl(Inline)]
        public static IPointSource<BitString> BitStringSource(this IPolyrand random, Interval<int> length)        
            => new BitStringSource(random, length);

        [MethodImpl(Inline)]
        public static IRandomStream<bit> ToBitStream<T>(this IPointSource<T> src)
            where T : unmanaged
                => BitSource<T>.From(src);    
        
        /// <summary>
        /// Produces an interminable stream of random bits
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<bit> Bits(this IPolyrand random)
        {
            while(true)
            {
                var scalar = random.Next<ulong>();
                var bs = Z0.BitString.scalar(scalar);
                for(var i=0; i<bs.Length; i++)
                {
                    yield return bs[i];
                }
            }
        }

        /// <summary>
        /// Produces a specified number of random bits
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IEnumerable<bit> Bits(this IPolyrand random, int count)
            => random.Bits().Take(count);

        /// <summary>
        /// Produces a span populated with a specified number of random bits
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static Span<bit> BitSpan(this IPolyrand random, int length)
            => random.Bits(length).ToArray();

        /// <summary>
        /// Produces a span populated with a specified number of random bits
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static NatSpan<N,bit> BitSpan<N>(this IPolyrand random, N len = default)
            where N : unmanaged, ITypeNat
                => random.BitSpan((int)len.NatValue);

        /// <summary>
        /// Produces a span populated with a specified number of random bits
        /// </summary>
        /// <param name="random">The random source</param>
        public static void BitSpan(this IPolyrand random, Span<bit> dst)
        {
            var src = random.Bits(dst.Length);
            var it = src.GetEnumerator();
            var index = 0;
            while(it.MoveNext())
                dst[index++] = it.Current;            
        }

        /// <summary>
        /// Produces a bitstring with a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitstring length</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IPolyrand random, BitSize len)
        {
            var bytes = random.Span<byte>(len.MaxByteCount);
            return Z0.BitString.from(bytes, len);        
        }

        /// <summary>
        /// Produces a bitstring with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The mininimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IPolyrand random, int minlen, int maxlen)
            => random.BitString(random.Next<int>(minlen, maxlen + 1));

        /// <summary>
        /// Produces a bitstring with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The mininimum length of the bitstring</param>
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
        /// Produces sequences of random bitstrings with specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The length of the produced bitstrings</param>
        public static IRandomStream<BitString> BitStrings(this IPolyrand random, int len)
        {
            IEnumerable<BitString> produce()
            {
                while(true)
                    yield return random.BitString(len);
            }

            return stream(produce(), random.RngKind);
        }

        /// <summary>
        /// Produces a random sequence of bitstrings with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The mininimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
        public static IRandomStream<BitString> BitStrings(this IPolyrand random, int minlen, int maxlen)
        {
            IEnumerable<BitString> produce()
            {
                while(true)
                    yield return random.BitString(minlen, maxlen);
            }
            
            return stream(produce(), random.RngKind);
        }
    }
}