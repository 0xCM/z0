//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    

    partial class dfp
    {

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<float> vnegate(Vector128<float> x)
            =>  vsub(default, x);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vnegate(Vector128<double> x)
            =>  vsub(default, x);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vnegate(Vector256<float> x)
            =>  vsub(default, x);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vnegate(Vector256<double> x)
            =>  vsub(default, x);
    }

}