//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;

    partial class mkl
    {
        /// <summary>
        /// Returns the index of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamax(RowVector256<float> X)        
            => (int)CBLAS.cblas_isamax(X.Length, ref head(X), 1);

        /// <summary>
        /// Returns the value of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static float amax(RowVector256<float> X)        
            => X[iamax(X)];

        /// <summary>
        /// Returns the index of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamax(RowVector256<double> X)        
            => (int)CBLAS.cblas_idamax(X.Length, ref head(X), 1);

        /// <summary>
        /// Returns the value of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static double amax(RowVector256<double> X)        
            => X[iamax(X)];
    }
}