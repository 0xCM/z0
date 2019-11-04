//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;
    using static nfunc;

    partial class RngX
    {
        /// <summary>
        /// Allocates a matrix of natural dimensions and populates it with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The column Type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
         public static BlockMatrix<M,N,T> BlockMatrix<M,N,T>(this IPolyrand random)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => Z0.BlockMatrix.Load<M,N,T>(random.Span256<T>(Z0.Span256.MinBlocks<M,N,T>()));                    

         public static BlockMatrix<M,N,T> BlockMatrix<M,N,T>(this IPolyrand random, Interval<T> domain, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => Z0.BlockMatrix.Load<M,N,T>(random.Span256<T>(Z0.Span256.MinBlocks<M,N,T>(), domain));                    
               
        /// <summary>
        /// Samples a square matrix of natural order
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
         public static BlockMatrix<N,T> BlockMatrix<N,T>(this IPolyrand random, Interval<T>? domain = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => Z0.BlockMatrix.Load<N,T>(random.Span256<T>(Z0.Span256.MinBlocks<N,N,T>(), domain));                    

         /// <summary>
         /// Samples values over an S-domain, transforms the sample into a T-domain and from this transformed
         /// sample constructs a matrix of natural dimensions
         /// </summary>
         /// <param name="random">The random source</param>
         /// <param name="domain">The sample domain</param>
         /// <param name="m">The row count</param>
         /// <param name="n">The column count</param>
         /// <param name="rep">A scalar representative</param>
         /// <typeparam name="M">The row type</typeparam>
         /// <typeparam name="N">The column type</typeparam>
         /// <typeparam name="S">The sample type</typeparam>
         /// <typeparam name="T">The matrix element type</typeparam>
          public static BlockMatrix<M,N,T> BlockMatrix<M,N,S,T>(this IPolyrand random, M m = default, N n = default,  T rep = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
            where S : unmanaged
                => random.BlockMatrix<M,N,S>().Convert<T>();
 
         /// <summary>
         /// Samples values over an S-domain, transforms the sample into a T-domain and from this transformed
         /// sample constructs a square matrix of natural order
         /// </summary>
         /// <param name="random">The random source</param>
         /// <param name="domain">The sample domain</param>
         /// <param name="m">The row count</param>
         /// <param name="n">The column count</param>
         /// <param name="rep">A scalar representative</param>
         /// <typeparam name="N">The order type type</typeparam>
         /// <typeparam name="S">The sample type</typeparam>
         /// <typeparam name="T">The matrix element type</typeparam>
          public static BlockMatrix<N,T> BlockMatrix<N,S,T>(this IPolyrand random, Interval<S>? domain = null, N n = default,  T rep = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
            where S : unmanaged
                => random.BlockMatrix<N,S>(domain).Convert<T>();

         /// <summary>
         /// Samples 32-bit integers that are converted to 32-bit floats to populate a square matrix
         /// </summary>
         /// <param name="random">The random source</param>
         /// <param name="n">The matrix order</param>
         /// <param name="min">The minimum entry value</param>
         /// <param name="min">The maximum entry value</param>
         /// <typeparam name="N">The matrix order type</typeparam>
         /// <typeparam name="S">The sample type</typeparam>
         /// <typeparam name="T">The matrix element type</typeparam>
         [MethodImpl(Inline)]
         public static BlockMatrix<N,float> BlockMatrixF32<N,S,T>(this IPolyrand random, int? min = null, int? max = null, N n = default)
            where T : unmanaged
            where S : unmanaged
            where N : unmanaged, ITypeNat
                => random.BlockMatrix<N,int, float>(closed(min ?? -25, max ?? 25));

        /// <summary>
        /// Samples 64-bit integers that are converted to 64-bit floats to populate a square matrix
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The matrix order</param>
        /// <param name="min">The minimum entry value</param>
        /// <param name="min">The maximum entry value</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="S">The sample type</typeparam>
        /// <typeparam name="T">The matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static  BlockMatrix<N,double> BlockMatrixF64<N,S,T>(this IPolyrand random, long? min = null, long? max = null, N n = default)
            where T : unmanaged
            where S : unmanaged
            where N : unmanaged, ITypeNat
                => random.BlockMatrix<N,long, double>(closed(min ?? -25L, max ?? 25L));


    }
}