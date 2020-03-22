//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static partial class FixedRngOps
    {
        /// <summary>
        /// Produces an homogenous point index of dimension 2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static Points<N2,F> FixedPoints<F>(this IPolyrand random, int count, N2 n, F t = default)
            where F : unmanaged, IFixed
        {
            var s1 = random.FixedStream<F>().Take(count);
            var s2 = random.FixedStream<F>().Take(count);
            return s1.Zip(s2).Select(a =>  Points.point(a.First, a.Second)).ToArray();
        }

        /// <summary>
        /// Produces an homogenous point index of dimension 2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static Pairs<F> FixedPairs<F>(this IPolyrand random, int count, N2 n, F t = default)
            where F : unmanaged, IFixed
        {
            var s1 = random.FixedStream<F>().Take(count);
            var s2 = random.FixedStream<F>().Take(count);
            return s1.Zip(s2).Select(a =>  Tuples.pair(a.First, a.Second)).ToArray();
        }

        /// <summary>
        /// Produces an homogenous point index of dimension 2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static Triples<F> FixedTriples<F>(this IPolyrand random, int count, N2 n, F t = default)
            where F : unmanaged, IFixed
        {
            var s1 = random.FixedStream<F>().Take(count);
            var s2 = random.FixedStream<F>().Take(count);
            return s1.Zip(s2).Select(a =>  Tuples.triple(a.First, a.Second)).ToArray();
        }
    }
}