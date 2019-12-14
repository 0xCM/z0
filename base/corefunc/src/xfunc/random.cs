//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Collections.Generic;

    using static zfunc;
    
    partial class xfunc
    {
        /// <summary>
        /// Produces a single random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Single<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => random.Next<T>();

        /// <summary>
        /// Produces a single random value within a range
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Single<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => random.Next<T>(min,max);

        /// <summary>
        /// Shuffles span content in-place
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The input/output span</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static Span<T> Shuffle<T>(this IPolyrand random, Span<T> src)
        {
            for (int i = 0; i < src.Length; i++)
                swap(ref src[i], ref src[i + random.Next(0, src.Length - i)]);
            return src;
        }

        /// <summary>
        /// Shuffles array content in-place
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The input/output array</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static T[] Shuffle<T>(this IPolyrand random, T[] src)
        {
            for (int i = 0; i < src.Length; i++)
                swap(ref src[i], ref src[i + random.Next(0,src.Length - i)]);
            return src;
        }

        /// <summary>
        /// Replicates and shuffles a source span
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Shuffle<T>(this IPolyrand random, ReadOnlySpan<T> src)
            => random.Shuffle(src.Replicate());    

        /// <summary>
        /// Provides a stream of random bytes
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<byte> Bytes(this IPolyrand random)
        {
            byte[] cache = new byte[8];
            while(true)
            {
                var src = random.Next<ulong>();
                BitConvert.GetBytes(src,cache);   
                for(var i=0; i < cache.Length; i++)
                    yield return cache[i];
            }
        }

        /// <summary>
        /// Produces the next pair of random primal values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<T> NextPair<T>(this IPolyrand random, T t = default)
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
        public static Pair<T> NextPair<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => (random.Next<T>(min,max), random.Next<T>(min,max));

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

        [MethodImpl(Inline)]
        public static System.Random ToSystemRand(this IPolyrand random)
            => SysRand.From(random);


    }
}
