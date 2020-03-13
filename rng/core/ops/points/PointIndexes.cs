//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;

    partial class CoreRngOps
    {        
        /// <summary>
        /// Produces an homogenous point index of dimension 1
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static HomPoints<N1,T> HomPointIndex<T>(this IPolyrand random, int count, N1 n, T t = default)
            where T : unmanaged
                => random.HomPointArray(count,n,t);

        /// <summary>
        /// Produces an homogenous point index of dimension 2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static HomPoints<N2,T> HomPointIndex<T>(this IPolyrand random, int count, N2 n, T t = default)
            where T : unmanaged
                => random.HomPointArray(count,n,t);


        /// <summary>
        /// Produces an homogenous point index of dimension 3
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static HomPoints<N3,T> HomPointIndex<T>(this IPolyrand random, int count, N3 n, T t = default)
            where T : unmanaged
                => random.HomPointArray(count,n,t);

        /// <summary>
        /// Produces an heterogeneous point index of dimension 3
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="X0">The domain of the first coordinate</typeparam>
        /// <typeparam name="X1">The domain of the second coordinate</typeparam>
        /// <typeparam name="X2">The domain of the third coordinate</typeparam>
        public static Points<X0,X1,X2> PointIndex<X0,X1,X2>(this IPolyrand random, int count, (X0 x0, X1 x1, X2 x2) t = default)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => random.PointArray(count,t);

        /// <summary>
        /// Produces an homogenous point index of dimension 2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static HomPoints<N2,F> FixedHomPointIndex<F>(this IPolyrand random, int count, N2 n, F t = default)
            where F : unmanaged, IFixed
        {
            var s1 = random.StreamFixed<F>().Take(count);
            var s2 = random.StreamFixed<F>().Take(count);
            return s1.Zip(s2).Select(a =>  Points.hom(a.First, a.Second)).ToArray();
        }

        /// <summary>
        /// Produces an homogenous point index of dimension 2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static HomPoints<N3,F> FixedHomPointIndex<F>(this IPolyrand random, int count, N3 n, F t = default)
            where F : unmanaged, IFixed
        {
            var s1 = random.StreamFixed<F>().Take(count);
            var s2 = random.StreamFixed<F>().Take(count);
            var s3 = random.StreamFixed<F>().Take(count);
            return s1.Zip(s2).Zip(s3).Select(a =>  Points.hom(a.First.First, a.First.Second, a.Second)).ToArray();
        }

    }
}