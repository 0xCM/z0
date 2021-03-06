//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class mkl
    {
        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static float norm(RowVector256<float> X)
            => CBLAS.cblas_snrm2(X.Length, ref head(X), 1);

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static double norm(RowVector256<double> X)
            => CBLAS.cblas_dnrm2(X.Length, ref head(X), 1);

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        static float norm(Span<ComplexF32> X)
            => CBLAS.cblas_scnrm2(X.Length, ref head(X), 1);

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        static double norm(Span<ComplexF64> X)
            => CBLAS.cblas_dznrm2(X.Length, ref head(X), 1);
    }
}