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

    public static class TupleRngOps
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
    }
}