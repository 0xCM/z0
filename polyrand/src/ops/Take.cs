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

    partial class Polyfun
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
        /// Produces an 8-bit random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static byte Single(this IPolyrand random, N8 w)
            => random.Next<byte>();

        /// <summary>
        /// Produces a 16-bit random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ushort Single(this IPolyrand random, N16 w)
            => random.Next<ushort>();

        /// <summary>
        /// Produces a 32-bit random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint Single(this IPolyrand random, N32 w)
            => random.Next<uint>();

        /// <summary>
        /// Produces a 64-bit random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ulong Single(this IPolyrand random, N64 w)
            => random.Next<ulong>();

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
        /// Selects the next sequence of values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of values to select</param>
        /// <typeparam name="T">The value type</typeparam>
        public static IEnumerable<T> Take<T>(this IRngBoundPointSource<T> random, int count)
            where T : unmanaged
                => random.Stream().Take(count);

        /// <summary>
        /// Converts a polyrand to the pitiful System.Random
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static System.Random ToSysRand(this IPolyrand random)
            => SysRand.From(random);


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
