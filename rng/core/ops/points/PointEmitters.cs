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
        public static PointSpanEmitter<X0,X1,X2> PointSpanEmitter<X0,X1,X2>(this IPolyrand random, int count, (X0 x0, X1 x1, X2 r) rep = default)
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
    }
}