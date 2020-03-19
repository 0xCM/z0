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
        /// Produces an homogenous point index of dimension 1
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static Points<N1,T> Points<T>(this IPolyrand random, int count, N1 n, T t = default)
            where T : unmanaged
                => random.PointArray(count,n,t);

        /// <summary>
        /// Produces an homogenous point index of dimension 2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static Points<N2,T> Points<T>(this IPolyrand random, int count, N2 n, T t = default)
            where T : unmanaged
                => random.PointArray(count,n,t);

        /// <summary>
        /// Produces an homogenous point index of dimension 3
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static Points<N3,T> Points<T>(this IPolyrand random, int count, N3 n, T t = default)
            where T : unmanaged
                => random.PointArray(count,n,t);
    }
}