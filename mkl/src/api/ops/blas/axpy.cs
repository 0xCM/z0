//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;

    partial class mkl
    {
        /// <summary>
        /// Computes the vector Z = aX + Y
        /// </summary>
        /// <param name="a">A scalar by which the components of X are multiplied</param>
        /// <param name="X">The vector to be scaled</param>
        /// <param name="Y">The vector to be added</param>
        /// <param name="Z">The target vector</param>        
        [MethodImpl(Inline)]
        public static void axpy<N>(float a, RowVector256<N,float> X, RowVector256<N,float> Y, ref RowVector256<N,float> Z)
            where N : unmanaged, ITypeNat
        {
            Y.CopyTo(ref Z);        
            CBLAS.cblas_saxpy(nati<N>(), a, ref head(X), 1, ref head(Z), 1);
        }

        /// <summary>
        /// Computes the vector Z = aX + Y
        /// </summary>
        /// <param name="a">A scalar by which the components of X are multiplied</param>
        /// <param name="X">The vector to be scaled</param>
        /// <param name="Y">The vector to be added</param>
        /// <param name="Z">The target vector</param>        
        [MethodImpl(Inline)]
        public static void axpy(float a, RowVector256<float> X, RowVector256<float> Y, ref RowVector256<float> Z)
        {
            Y.CopyTo(ref Z);        
            CBLAS.cblas_saxpy(length(X,Y), a, ref head(X), 1, ref head(Z), 1);
        }

        /// <summary>
        /// Computes the vector Z = aX + Y
        /// </summary>
        /// <param name="a">A scalar by which the components of X are multiplied</param>
        /// <param name="X">The vector to be scaled</param>
        /// <param name="Y">The vector to be added</param>
        /// <param name="Z">The target vector</param>        
        [MethodImpl(Inline)]
        public static void axpy(double a, RowVector256<double> X, RowVector256<double> Y, ref RowVector256<double> Z)
        {
            Y.CopyTo(ref Z);        
            CBLAS.cblas_daxpy(length(X,Y), a, ref head(X), 1, ref head(Z), 1);
        }
    }
}