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

    using static Root;

    public static partial class CoreRng
    {
        /// <summary>
        /// Converts a polyrand to the pitiful System.Random
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static System.Random ToSystemRand(this IPolyrand random)
            => SysRand.From(random);

        /// <summary>
        /// Produces an interminable stream of random bytes
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<byte> Bytes(this IPolyrand random)
        {
            var cache = new byte[8];
            while(true)
            {
                var src = random.Next<ulong>();
                BitConvert.GetBytes(src,cache);   
                for(var i=0; i < cache.Length; i++)
                    yield return cache[i];
            }
        }

        /// <summary>
        /// Produces a limited stream of random bytes
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The maximum number of bytes to produce</param>
        public static IEnumerable<byte> Bytes(this IPolyrand random, int count)
        {
            var counter = 0;
            var bytes = new byte[8];
            for(var j=0; j<count; j+=8)
            {
                var src = random.Next<ulong>();
                BitConvert.GetBytes(src, bytes);   
                for(var k=0; k<8; k++, counter++)
                {
                    if(counter == count)
                        break;  

                    yield return bytes[k];
                }
            }
        }

        /// <summary>
        /// Produces a random closed interval [a,b] where a >= min and b < max
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum left endpoint value</param>
        /// <param name="max">The exclusive maximum right endpoint value</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        public static Interval<T> Interval<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
        {
            var cut = random.Next(min,max);
            return (random.Next(min, cut), random.Next(cut,max));
        }

        /// <summary>
        /// Produces a stream of random closed intervals [a,b] where a >= min and b < max
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum left endpoint value</param>
        /// <param name="max">The exclusive maximum right endpoint value</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        public static IEnumerable<Interval<T>> Intervals<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
        {
            while(true)
                yield return random.Interval(min,max);
        }
         
        /// <summary>
        /// Produces the next pair of random primal values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> NextPair<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => (random.Next<T>(), random.Next<T>());

        /// <summary>
        /// Produces the next pair of random primal values within a specified range
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> NextPair<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => (random.Next<T>(min,max), random.Next<T>(min,max));

        /// <summary>
        /// Produces the next triple of random primal values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<T> NextTriple<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => (random.Next<T>(), random.Next<T>(),random.Next<T>());

        /// <summary>
        /// Produces the next triple of random primal values within a specified range
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<T> NextTriple<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => (random.Next<T>(min,max), random.Next<T>(min,max),random.Next<T>(min,max));

        /// <summary>
        /// Produces the next triple of random primal values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstQuad<T> NextQuad<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => (random.NextPair<T>(), random.NextPair<T>());

        /// <summary>
        /// Produces the next triple of random primal values within a specified range
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstQuad<T> NextQuad<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => (random.NextPair<T>(min,max), random.NextPair<T>(min,max));         

        /// <summary>
        /// Produces a random power of 2 within the primal type domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Pow2<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => convert<ulong,T>(Z0.Pow2.pow(random.Pow2Exp(t)));

        /// <summary>
        /// Produces a random power of 2 with specified min/max exponent values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minexp">The min exponent value</param>
        /// <param name="maxexp">The max exponent value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Pow2<T>(this IPolyrand random, int minexp, int maxexp)
            where T : unmanaged
        {
            var exp = random.Next((byte)minexp, (byte)(maxexp + 1));
            return convert<ulong,T>(Z0.Pow2.pow(exp));
        }

        /// <summary>
        /// Produces a power-of-2 exponent n (i.e. log base 2) such that 2^n < maxvalue[T]; 
        /// consequently, the exponentiation of the retrieved value will be confiled to 
        /// the domain of the type (ignoring sign)
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static int Pow2Exp<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => random.Single(0, bitsize<T>());                
    }
}