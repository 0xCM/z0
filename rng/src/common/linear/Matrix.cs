//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class RngX
    {
        /// <summary>
        /// Allocates and fills a matrix of natural dimensions with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The range of potiential random values</param>
        /// <param name="m">The natural number of rows</param>
        /// <param name="n">The natural number of columns</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The column Type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,T> Matrix<M,N,T>(this IPolyrand random, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => Z0.Matrix.load<M,N,T>(random.Array<T>(Z0.Matrix<M,N,T>.CellCount));                    

        /// <summary>
        /// Allocates and fills a matrix of natural dimensions with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The range of potiential random values</param>
        /// <param name="m">The natural number of rows</param>
        /// <param name="n">The natural number of columns</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The column Type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,T> Matrix<M,N,T>(this IPolyrand random, Interval<T> domain, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => Z0.Matrix.load<M,N,T>(random.Array<T>(Z0.Matrix<M,N,T>.CellCount, domain));                    
               
        /// <summary>
        /// Samples a square matrix of natural order
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The min random value</param>
        /// <param name="max">The max random value</param>
        /// <param name="transformer">The max random value</param>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<N,T> Matrix<N,T>(this IPolyrand random, N n, T min, T max)
            where N : unmanaged, ITypeNat
            where T : unmanaged   
                => Z0.Matrix.load(n, random.Array<T>(Z0.Matrix<N,T>.CellCount, (min,max)));                    


    }
}