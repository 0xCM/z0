//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class mkl
    {
        /// <summary>
        /// Computes the scalar product between two vectors of natural length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static float dot<N>(Block256<N,float> x, Block256<N,float> y)
            where N : unmanaged, ITypeNat
                => dot(x.Unsized, y.Unsized);

        /// <summary>
        /// Computes the scalar product between two vectors of natural length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static double dot<N>(Block256<N,double> x, Block256<N,double> y)
            where N : unmanaged, ITypeNat
                => dot(x.Unsized, y.Unsized);

        /// <summary>
        /// Computes the scalar product between two vectors that are hopefully of the same length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static float dot(RowVector256<float> x, RowVector256<float> y)
            => dot(x.Unblocked, y.Unblocked);

        /// <summary>
        /// Computes the scalar product between two vectors that are hopefully of the same length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static double dot(RowVector256<double> x, RowVector256<double> y)
            => dot(x.Unblocked, y.Unblocked);

        /// <summary>
        /// Computes the scalar product of the left and right operands
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        static float dot(Span<float> X, Span<float> Y)
            => CBLAS.cblas_sdot(X.Length, ref head(X), 1, ref head(Y), 1);

        /// <summary>
        /// Computes the scalar product of the left and right operands
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        static double dot(Span<double> X, Span<double> Y)
            => CBLAS.cblas_ddot(X.Length, ref head(X), 1, ref head(Y), 1);
    }
}