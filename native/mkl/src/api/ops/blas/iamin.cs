//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static Memories;

    partial class mkl
    {
        /// <summary>
        /// Returns the index of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamin(RowVector256<float> X)        
            => (int)CBLAS.cblas_isamin(X.Length, ref head(X), 1);

        /// <summary>
        /// Returns the value of the component with minimal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static float amin(RowVector256<float> X)        
            => X[iamin(X)];

        /// <summary>
        /// Returns the index of the component with minimal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamin(RowVector256<double> X)        
            => (int)CBLAS.cblas_idamin(X.Length, ref head(X), 1);

        /// <summary>
        /// Returns the value of the component with minimal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static double amin(RowVector256<double> X)        
            => X[iamin(X)];


    }

}