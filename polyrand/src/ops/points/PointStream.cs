//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    using PointApi = Points;

    partial class Polyfun
    {        
        /// <summary>
        /// Produces a randomized stream of points of dimenion 1 over an homogenous dommain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The dimension selector</param>
        /// <param name="t">A point domain representative</param>
        /// <typeparam name="T">The point domain</typeparam>
        public static IEnumerable<Point<N1,T>> PointStream<T>(this IPolyrand random, N1 n, T t = default)
            where T : unmanaged
        {
            while(true)
                yield return PointApi.point(random.Next<T>());
        }

        /// <summary>
        /// Produces a randomized stream of points of dimenion 2 over an homogenous dommain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The dimension selector</param>
        /// <param name="t">A point domain representative</param>
        /// <typeparam name="T">The point domain</typeparam>
        public static IEnumerable<Point<N2,T>> PointStream<T>(this IPolyrand random, N2 n, T t = default)
            where T : unmanaged
        {
            while(true)
                yield return PointApi.point(random.Next<T>(), random.Next<T>());
        }

        /// <summary>
        /// Produces a randomized stream of points of dimenion 2 over an homogenous dommain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The dimension selector</param>
        /// <param name="t">A point domain representative</param>
        /// <typeparam name="T">The point domain</typeparam>
        public static IEnumerable<Point<N3,T>> PointStream<T>(this IPolyrand random, N3 n, T t = default)
            where T : unmanaged
        {
            while(true)
                yield return PointApi.point(random.Next<T>(), random.Next<T>(), random.Next<T>());
        }
    }
}