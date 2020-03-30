//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Core;

    partial class mkl
    {
        /// <summary>
        /// Computes the sum of the absolute value of each component
        /// </summary>
        /// <param name="X">A span containing the vector components</param>
        [MethodImpl(Inline)]
        public static double asum(RowVector256<float> X)        
            => CBLAS.cblas_sasum(X.Length, ref head(X), 1);
        
        /// <summary>
        /// Computes the sum of the absolute value of each component
        /// </summary>
        /// <param name="X">A span containing the vector components</param>
        [MethodImpl(Inline)]
        public static double asum(RowVector256<double> X)        
            => CBLAS.cblas_dasum(X.Length, ref head(X), 1);

        [MethodImpl(Inline)]
        static float asum(Span<ComplexF32> X)        
            => CBLAS.cblas_scasum(X.Length, ref X[0], 1);

        [MethodImpl(Inline)]
        static double asum(Span<ComplexF64> X)        
            => CBLAS.cblas_dzasum(X.Length, ref X[0], 1);
    }
}