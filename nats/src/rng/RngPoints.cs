//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using PointApi = Points;

    public static class RngPoints
    {        
        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static PointSpanEmitter<N3,T> PointSpan<T>(this IPolyrand random, int count, N3 n, T t = default)
            where T : unmanaged
                => random.PointArray(count,n,t);

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static Point<N3,T>[] PointArray<T>(this IPolyrand random, int count, N3 n, T t = default)
            where T : unmanaged
                => random.PointStream(n,t).Take(count).ToArray(); 

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