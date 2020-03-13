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
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static HomPoints<N2,T> HomPointIndex<T>(this IPolyrand random, int count, N2 n, T t = default)
            where T : unmanaged
                => random.HomPointArray(count,n,t);

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static HomPoints<N3,T> HomPointIndex<T>(this IPolyrand random, int count, N3 n, T t = default)
            where T : unmanaged
                => random.HomPointArray(count,n,t);

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

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        static HetPoints.Point<X0,X1,X2>[] PointArray<X0,X1,X2>(this IPolyrand random, int count, (X0 x0, X1 x1, X2 x2) t = default)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => random.PointStream<X0,X1,X2>().Take(count).ToArray();

        public static Points<X0,X1,X2> PointIndex<X0,X1,X2>(this IPolyrand random, int count, (X0 x0, X1 x1, X2 x2) t = default)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => random.PointArray(count,t);

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static PointSpanEmitter<X0,X1,X2> LoadPointSpanEmitter<X0,X1,X2>(this IPolyrand random, int count, (X0 x0, X1 x1, X2 r) rep = default)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => random.PointStream(rep).Take(count).ToArray();

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        static HomPoint<N2,T>[] HomPointArray<T>(this IPolyrand random, int count, N2 n, T t = default)
            where T : unmanaged
        {
            var total = 2*count;
            var src = random.Span<T>(total);
            var dst = new HomPoint<N2,T>[count];
            for(var i=0; i<count; i++)
                dst[i] = PointApi.hom(random.Next<T>(),random.Next<T>());
            return dst;            
        }

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static HomPointSpanEmitter<N2,T> HomPointSpanEmitter<T>(this IPolyrand random, int count, N2 n, T t = default)
            where T : unmanaged
                => random.HomPointArray(count,n,t);

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static HomPointSpanEmitter<N3,T> HomPointSpanEmitter<T>(this IPolyrand random, int count, N3 n, T t = default)
            where T : unmanaged
                => random.HomPointArray(count,n,t);

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        static HomPoint<N3,T>[] HomPointArray<T>(this IPolyrand random, int count, N3 n, T t = default)
            where T : unmanaged
        {
            var total = 3*count;
            var src = random.Span<T>(total);
            var dst = new HomPoint<N3,T>[count];
            for(var i=0; i<count; i++)
                dst[i] = PointApi.hom(random.Next<T>(),random.Next<T>(), random.Next<T>());
            return dst;            
        }
    }
}