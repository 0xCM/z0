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

    partial class Polyfun
    {        

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static Point<X0,X1,X2>[] PointArray<X0,X1,X2>(this IPolyrand random, int count, (X0 x0, X1 x1, X2 x2) t = default)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => random.PointStream<X0,X1,X2>().Take(count).ToArray();

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static HomPoint<N1,T>[] HomPointArray<T>(this IPolyrand random, int count, N1 n, T t = default)
            where T : unmanaged
                => random.HomPointStream(n,t).Take(count).ToArray();

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static HomPoint<N2,T>[] HomPointArray<T>(this IPolyrand random, int count, N2 n, T t = default)
            where T : unmanaged
                => random.HomPointStream(n,t).Take(count).ToArray();

        /// <summary>
        /// Loads a point span emitter with specified number of points
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the emitter</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static HomPoint<N3,T>[] HomPointArray<T>(this IPolyrand random, int count, N3 n, T t = default)
            where T : unmanaged
                => random.HomPointStream(n,t).Take(count).ToArray();
 
    }
}