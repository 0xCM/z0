//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;
    using PointApi = Points;

    partial class CoreRngOps
    {
        /// <summary>
        /// Produces a randomized stream of points of dimenion 1 over an homogenous dommain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The dimension selector</param>
        /// <param name="t">A point domain representative</param>
        /// <typeparam name="T">The point domain</typeparam>
        public static IEnumerable<HomPoint<N1,T>> HomPointStream<T>(this IPolyrand random, N1 n, T t = default)
            where T : unmanaged
        {
            while(true)
                yield return PointApi.hom(random.Next<T>());
        }

        /// <summary>
        /// Produces a randomized stream of points of dimenion 2 over an homogenous dommain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The dimension selector</param>
        /// <param name="t">A point domain representative</param>
        /// <typeparam name="T">The point domain</typeparam>
        public static IEnumerable<HomPoint<N2,T>> HomPointStream<T>(this IPolyrand random, N2 n, T t = default)
            where T : unmanaged
        {
            while(true)
                yield return PointApi.hom(random.Next<T>(), random.Next<T>());
        }

        /// <summary>
        /// Produces a randomized stream of points of dimenion 2 over an homogenous dommain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The dimension selector</param>
        /// <param name="t">A point domain representative</param>
        /// <typeparam name="T">The point domain</typeparam>
        public static IEnumerable<HomPoint<N3,T>> HomPointStream<T>(this IPolyrand random, N3 n, T t = default)
            where T : unmanaged
        {
            while(true)
                yield return PointApi.hom(random.Next<T>(), random.Next<T>(), random.Next<T>());
        }

        /// <summary>
        /// Produces a randomized stream of points of dimenion 2 over a possibly heterogenous dommain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        public static IEnumerable<HetPoints.Point<X0,X1>> PointStream<X0,X1>(this IPolyrand random,  (X0 x0, X1 x1) t = default)
            where X0 : unmanaged
            where X1 : unmanaged
        {
            while(true)
                yield return PointApi.point(random.Next<X0>(), random.Next<X1>());
        }

        /// <summary>
        /// Produces a randomized stream of points of dimenion 3 over a (possibly) heterogenous dommain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static IEnumerable<HetPoints.Point<X0,X1,X2>> PointStream<X0,X1,X2>(this IPolyrand random,  (X0 x0, X1 x1, X2 x2) t = default)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
        {
            while(true)
                yield return PointApi.point(random.Next<X0>(), random.Next<X1>(), random.Next<X2>());
        }
    }
}