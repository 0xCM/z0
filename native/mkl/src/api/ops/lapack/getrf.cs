//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    using static Part;
    using static memory;

    partial class mkl
    {
        /// <summary>
        /// Computes an LU factorization of a general M-by-N matrix A using partial pivoting with row interchanges.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="X"></param>
        /// <param name="P"></param>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="N"></typeparam>
        public static ref Matrix256<M,N,double> getrf<M,N>(Matrix256<M,N,double> A, Span<int> P, ref Matrix256<M,N,double> X)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nat32i<M>();
            var n = nat32i<N>();
            var lda = n;

            A.CopyTo(ref X);
            checkx(LAPACK.LAPACKE_dgetrf(RowMajor, m, n, ref head(X), lda, ref head(P)));

            return ref X;
        }

        /// <summary>
        /// Computes an LU factorization of an N-square matrix A using partial pivoting with row interchanges.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="X"></param>
        /// <param name="P"></param>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="N"></typeparam>
        public static ref Matrix256<N,double> getrf<N>(Matrix256<N,double> A, Span<int> P, ref Matrix256<N,double> X)
            where N : unmanaged, ITypeNat
        {
            var n = nat32i<N>();
            var lda = n;

            A.CopyTo(ref X);
            var exit = LAPACK.LAPACKE_dgetrf(RowMajor, n, n, ref head(X), lda, ref head(P));
            checkx(exit);

            return ref X;
        }
    }
}