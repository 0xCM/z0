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
        /// Shuffles span content in-place
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The input/output span</param>
        /// <typeparam name="T">The element type</typeparam>
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
        /// <typeparam name="T">The element type</typeparam>
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
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Shuffle<T>(this IPolyrand random, ReadOnlySpan<T> src)
            => random.Shuffle(src.Replicate());    

        /// <summary>
        /// Shuffles a copy of the source permutation, leaving the original intact.
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        [MethodImpl(Inline)]
        public static Perm Shuffle(this IPolyrand random, in Perm src)
        {
            var copy = src.Replicate();
            copy.Shuffle(random);
            return copy;
        }

        /// <summary>
        /// Shuffles a copy of the source permutatiion, leaving the original intact.
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        /// <typeparam name="N">The permutation length</typeparam>
        [MethodImpl(Inline)]
        public static Perm<N> Shuffle<N>(this IPolyrand random, in Perm<N> src)
            where N : ITypeNat, new()
        {
            var copy = src.Replicate();
            copy.Shuffle(random);
            return copy;
        }

        /// <summary>
        /// Returns the next pair of random primal values
        /// </summary>
        /// <param name="a">The first element in the pair</param>
        /// <param name="b">The second element in the pair</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static (T a, T b) NextPair<T>(this IPolyrand random)
            where T : unmanaged
                => (random.Next<T>(), random.Next<T>());

        /// <summary>
        /// Returns the next pair of random primal values within a specified range
        /// </summary>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="b">The second element in the pair</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static (T a, T b) NextPair<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => (random.Next<T>(min,max), random.Next<T>(min,max));

        /// <summary>
        /// A random power of 2 within the primal type domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Pow2<T>(this IPolyrand random)
            where T : unmanaged
        {
            var exp = random.Next<byte>(0,(byte)bitsize<T>());
            return convert<ulong,T>(Z0.Pow2.pow(exp));
        }

        /// <summary>
        /// A random power of 2 with specified min/max exponent values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The min exponent value</param>
        /// <param name="min">The max exponent value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Pow2<T>(this IPolyrand random, int minexp, int maxexp)
            where T : unmanaged
        {
            var exp = random.Next((byte)minexp, (byte)(maxexp + 1));
            return convert<ulong,T>(Z0.Pow2.pow(exp));
        }

        /// <summary>
        /// A stream of random powers of 2 within the primal type domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<T> Pow2Stream<T>(this IPolyrand random)
            where T : unmanaged
        {
            var width = (byte)bitsize<T>();
            while(true)
            {
                var exp = random.Next<byte>(0,width);
                yield return convert<ulong,T>(Z0.Pow2.pow(exp));
            }
        }

        [MethodImpl(Inline)]
        public static T Pow2Cut<T>(this IPolyrand random)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(random.Pow2<byte>(0, 7));
            else if (typeof(T) == typeof(ushort))
                return convert<T>(random.Pow2<ushort>(8, 15));
            else if (typeof(T) == typeof(uint))
                return convert<T>(random.Pow2<uint>(16, 31));
            else if (typeof(T) == typeof(ulong))
                return convert<T>(random.Pow2<ulong>(32, 63));                
            else
                return default;
        }

    }
}
