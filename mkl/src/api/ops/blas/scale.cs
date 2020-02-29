//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;

    partial class mkl
    {
        /// <summary>
        /// Computes x = ax, in-place
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static void scale(float a, RowVector256<float> X)        
            => CBLAS.cblas_sscal(X.Length, a, ref head(X), 1);

        /// <summary>
        /// Computes y = ax, leaving x unmodified
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="x">The source vector</param>
        /// <param name="y">The target vector</param>
        /// <remarks>This adds the overhead of a copy operation on the vector</remarks>
        [MethodImpl(Inline)]
        public static ref RowVector256<float> scale(float a, in RowVector256<float> x, ref RowVector256<float> y)        
        {
            CBLAS.cblas_sscal(x.Length, a, ref head(x.CopyTo(ref y)), 1);
            return ref y;
        }

        /// <summary>
        /// Computes x = ax, in-place
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static void scale(double a, RowVector256<double> x)        
            => CBLAS.cblas_dscal(x.Length, a, ref head(x), 1);

        /// <summary>
        /// Computes y = ax, leaving x unmodified
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="x">The source vector</param>
        /// <param name="y">The target vector</param>
        /// <remarks>This adds the overhead of a copy operation on the vector</remarks>
        [MethodImpl(Inline)]
        public static ref RowVector256<double> scale(double a, in RowVector256<double> x, ref RowVector256<double> y)        
        {
            CBLAS.cblas_dscal(x.Length, a, ref head(x.CopyTo(ref y)), 1);
            return ref y;
        }
    }
}