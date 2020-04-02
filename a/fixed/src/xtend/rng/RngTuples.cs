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

    using static Seed;

    partial class XRng
    {
       public static Pair<T> Pair<T>(this IPolyrand random)
            where T : unmanaged
                => Tuples.pair(random.Next<T>(), random.Next<T>());

        public static IEnumerable<Pair<T>> PairStream<T>(this IPolyrand random)
            where T : unmanaged
        {
            while(true)
                yield return random.Pair<T>();
        }

        public static Pairs<T> Pairs<T>(this IPolyrand random, int count)
            where T : unmanaged
                => random.PairStream<T>().Take(count).ToArray();

        public static Pairs<T> Pairs<T>(this IPolyrand random, Span<Pair<T>> dst)
            where T : unmanaged
                => random.PairStream<T>().Take(dst.Length).StreamTo(dst);

        public static Pairs<T> Pairs<T>(this IPolyrand random, Pair<T>[] dst)
            where T : unmanaged
                => random.PairStream<T>().Take(dst.Length).StreamTo(dst);

        public static Triple<T> Triple<T>(this IPolyrand random)
            where T : unmanaged
                => Tuples.triple(random.Next<T>(), random.Next<T>(), random.Next<T>());

        public static IEnumerable<Triple<T>> TripleStream<T>(this IPolyrand random)
            where T : unmanaged
        {
            while(true)
                yield return random.Triple<T>();
        }

        public static Triples<T> Triples<T>(this IPolyrand random, int count)
            where T : unmanaged
                => random.TripleStream<T>().Take(count).ToArray();

        public static Triples<T> Triples<T>(this IPolyrand random, Span<Triple<T>> dst)
            where T : unmanaged
                => random.TripleStream<T>().Take(dst.Length).StreamTo(dst);

        public static Triples<T> Triples<T>(this IPolyrand random, Triple<T>[] dst)
            where T : unmanaged
                => random.TripleStream<T>().Take(dst.Length).StreamTo(dst);

        public static Paired<S,T> Paired<S,T>(this IPolyrand random)
            where S : unmanaged
            where T : unmanaged
                => Tuples.paired(random.Next<S>(), random.Next<T>());
        
        public static IEnumerable<Paired<S,T>> Pairings<S,T>(this IPolyrand random)
            where S : unmanaged
            where T : unmanaged
        {
            while(true)
                yield return random.Paired<S,T>();
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
    }
}