//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    public static class PolyTuples
    {
        /// <summary>
        /// Yields a source-provided heterogenous pairs
        /// </summary>
        /// <param name="src">The value source</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static Paired<S,T> Paired<S,T>(this ISource src)
            where S : struct
            where T : struct
                => Sources.paired<S,T>(src);

        public static Pair<T> Pair<T>(this ISource src)
            where T : struct
                => Sources.pair<T>(src);

        public static Pairs<T> Pairs<T>(this ISource src, int count)
            where T : struct
                => Sources.pairs<T>(src, count);

        public static Pairs<T> Pairs<T>(this ISource src, uint count)
            where T : struct
                => Sources.pairs<T>(src, (int)count);

        /// <summary>
        /// Yields the next source-provided pair
        /// </summary>
        /// <param name="src">The value source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> ConstPair<T>(this ISource src)
            where T : struct
                => Sources.kpair<T>(src);

        /// <summary>
        /// Yields the next source-provided pair over a specified domain
        /// </summary>
        /// <param name="src">The value source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static ConstPair<T> ConstPair<T>(this IDomainSource src, T min, T max)
            where T : unmanaged
                => Sources.kpair(src, min, max);

        /// <summary>
        /// Fills the target with parings taken from the source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The receiver</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static Pairings<S,T> Pairings<S,T>(this ISource src, uint count)
            where S : struct
            where T : struct
        {
            var dst = new Pairings<S,T>(new Paired<S,T>[count]);
            src.Pairings(dst);
            return dst;
        }

        /// <summary>
        /// Fills the target with parings taken from the source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The receiver</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static void Pairings<S,T>(this ISource src, Pairings<S,T> dst)
            where S : struct
            where T : struct
                => Sources.pairings(src, dst);

        /// <summary>
        /// Yields a stream of source-provided heterogenous pairs
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static IEnumerable<Paired<S,T>> Pairings<S,T>(this ISource src)
            where S : struct
            where T : struct
                => Sources.pairings<S,T>(src);

        public static Triple<T> Triple<T>(this ISource src)
            where T : struct
                => Sources.triple<T>(src);

        /// <summary>
        /// Produces the next source-provided triple
        /// </summary>
        /// <param name="src">The value source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static ConstTriple<T> ConstTriple<T>(this ISource src)
            where T : struct
                => Sources.ktriple<T>(src);

        /// <summary>
        /// Produces the next source-provided triple over a specified domain
        /// </summary>
        /// <param name="src">The value source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static ConstTriple<T> ConstTriple<T>(this IDomainSource src, T min, T max)
            where T : unmanaged
                => Sources.ktriple<T>(src, min, max);

        public static Triples<T> Triples<T>(this ISource src, int count, T t = default)
            where T : struct
                => Sources.triples(src, count, t);

        public static Triples<T> Triples<T>(this ISource src, Span<Triple<T>> dst)
            where T : struct
                => Sources.triples(src, dst);

        public static Deferred<Pair<T>> PairStream<T>(this ISource src)
            where T : struct
                => Seq.defer(Sources.pairstream<T>(src));

        public static IEnumerable<Triple<T>> TripleStream<T>(this ISource src)
            where T : struct
                => Sources.triplestream<T>(src);

    }
}