//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    using static root;

    using static nfunc;

    partial class mkl
    {
        /// <summary>
        /// Computes the matrix-vector product y = A*x;
        /// </summary>
        /// <param name="A">A source matrix of dimension MxN</param>
        /// <param name="x">A source vector of length N</param>
        /// <param name="y">A target vector of length M</param>
        /// <typeparam name="M">The row dimension type of A</typeparam>
        /// <typeparam name="N">The column dimension type of A</typeparam>
        public static ref RowVector256<M,double> gemv<M,N>(Matrix256<M,N,double> A, RowVector256<N,double> x, ref RowVector256<M,double> y)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nati<M>();
            var n = nati<N>();
            var lda = n;
            CBLAS.cblas_dgemv(RowMajor, NoTranspose, m, n, alpha: 1.0, ref head(A), lda, ref head(x), incX: 1, beta: 0, ref head(y), incY: 1);
            return ref y;
        }

        /// <summary>
        /// Computes the matrix-vector product y = A*x;
        /// </summary>
        /// <param name="A">A source matrix of dimension MxN</param>
        /// <param name="x">A source vector of length N</param>
        /// <param name="y">A target vector of length M</param>
        /// <typeparam name="M">The row dimension type of A</typeparam>
        /// <typeparam name="N">The column dimension type of A</typeparam>
        public static ref RowVector256<M,float> gemv<M,N>(Matrix256<M,N,float> A, RowVector256<N,float> x, ref RowVector256<M,float> y)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nati<M>();
            var n = nati<N>();
            var lda = n;
            CBLAS.cblas_sgemv(RowMajor, NoTranspose, m, n, alpha: 1f, ref head(A), lda, ref head(x), incX: 1, beta: 0, ref head(y), incY: 1);
            return ref y;
        }
    }
}