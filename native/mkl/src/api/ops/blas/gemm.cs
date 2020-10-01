//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class mkl
    {
        /// <summary>
        /// Populates a target matrix with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        [MethodImpl(Inline)]
        public static ref Matrix256<M,N,T> gemm<M,K,N,T>(Matrix256<M,K,T> A, Matrix256<K,N,T> B, ref Matrix256<M,N,T> X)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
            {
                var Z = X.As<float>();
                gemm(A.As<float>(), B.As<float>(), ref Z);
            }
            else if(typeof(T) == typeof(double))
            {
                var x = X.As<double>();
                gemm(A.As<double>(), B.As<double>(), ref x);
            }
            else if(typeof(T) == typeof(int)|| typeof(T) == typeof(uint) || typeof(T) == typeof(short) || typeof(T) == typeof(ushort))
            {
                var Z = X.Convert<double>();
                X = gemm(A.Convert<double>(), B.Convert<double>(), ref Z).Convert<T>();
            }
            else if(typeof(T) == typeof(long) || typeof(T) == typeof(ulong))
            {
                var Z = X.Convert<double>();
                X = gemm(A.Convert<double>(), B.Convert<double>(), ref Z).Convert<T>();
            }
            else if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte) )
            {
                var Z = X.Convert<float>();
                X = gemm(A.Convert<float>(), B.Convert<float>(), ref Z).Convert<T>();
            }
            return ref X;
        }

        /// <summary>
        /// Populates a target matrix with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static ref Matrix256<N,T> gemm<N,T>(Matrix256<N,T> A, Matrix256<N,T> B, ref Matrix256<N,T> X)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
            {
                var Z = X.As<float>();
                gemm(A.As<float>(), B.As<float>(), ref Z);
            }
            else if(typeof(T) == typeof(double))
            {
                var x = X.As<double>();
                gemm(A.As<double>(), B.As<double>(), ref x);
            }
            else if(typeof(T) == typeof(int)|| typeof(T) == typeof(uint) || typeof(T) == typeof(short) || typeof(T) == typeof(ushort))
            {
                var Z = X.Convert<double>();
                X = gemm(A.Convert<double>(), B.Convert<double>(), ref Z).Convert<T>();
            }
            else if(typeof(T) == typeof(long) || typeof(T) == typeof(ulong))
            {
                var Z = X.Convert<double>();
                X = gemm(A.Convert<double>(), B.Convert<double>(), ref Z).Convert<T>();
            }
            else if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte) )
            {
                var Z = X.Convert<float>();
                X = gemm(A.Convert<float>(), B.Convert<float>(), ref Z).Convert<T>();
            }
            return ref X;
        }

        /// <summary>
        /// Allocates a target matrix and populates it with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static Matrix256<M,N,float> gemm<M,K,N>(Matrix256<M,K,float> A, Matrix256<K,N,float> B)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nat32i<M>();
            var k = nat32i<K>();
            var n = nat32i<N>();
            var lda = k;
            var ldb = n;
            var ldx = n;
            var X = Matrix.blockalloc<M,N,float>();
            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1.0f, ref head(A), lda, ref head(B), ldb, 0, ref head(X), ldx);
            return X;
        }

        /// <summary>
        /// Allocates a target matrix and populates it with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static Matrix256<M,N,double> gemm<M,K,N>(Matrix256<M,K,double> A, Matrix256<K,N,double> B)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nat32i<M>();
            var k = nat32i<K>();
            var n = nat32i<N>();
            var lda = k;
            var ldb = n;
            var ldx = n;
            var X = Matrix.blockalloc<M,N,double>();
            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1.0f, ref head(A), lda, ref head(B), ldb, 0, ref head(X), ldx);
            return X;
        }

        /// <summary>
        /// Populates a target matrix with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static ref Matrix256<M,N,float> gemm<M,K,N>(Matrix256<M,K,float> A, Matrix256<K,N,float> B, ref Matrix256<M,N,float> X)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nat32i<M>();
            var k = nat32i<K>();
            var n = nat32i<N>();
            var lda = k;
            var ldb = n;
            var ldx = n;
            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1f, ref head(A), lda, ref head(B), ldb, 0, ref head(X), ldx);
            return ref X;
        }

        /// <summary>
        /// Populates a target matrix with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static ref Matrix256<M,N,double> gemm<M,K,N>(Matrix256<M,K,double> A, Matrix256<K,N,double> B, ref Matrix256<M,N,double> X)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nat32i<M>();
            var k = nat32i<K>();
            var n = nat32i<N>();
            var lda = k;
            var ldb = n;
            var ldx = n;
            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1d, ref head(A), lda, ref head(B), ldb, 0, ref head(X), ldx);
            return ref X;
        }

        /// <summary>
        /// Computes the product of square metrices X = AB
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">The target matrix</param>
		/// <param name="N">The number of columns in B and C</param>
        public static ref Matrix256<N,float> gemm<N>(Matrix256<N,float> A, Matrix256<N,float> B, ref Matrix256<N,float> X)
            where N : unmanaged, ITypeNat
        {
            var n = nat32i<N>();
            var ld = n;
            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose, n, n, n, 1, ref head(A), ld, ref head(B), ld, 0, ref head(X), ld);
            return ref X;
        }

        /// <summary>
        /// Computes the product of square metrices X = AB
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">The target matrix</param>
		/// <param name="N">The number of columns in B and C</param>
        public static ref Matrix256<N,double> gemm<N>(Matrix256<N,double> A, Matrix256<N,double> B, ref Matrix256<N,double> X)
            where N : unmanaged, ITypeNat
        {
            var n = nat32i<N>();
            var ld = n;
            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose, n, n, n, 1, ref head(A), ld, ref head(B), ld, 0, ref head(X), ld);
            return ref X;
        }
    }
}