//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
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
        public static Vec128<float> vnegate(in Vec128<float> x)
            =>  vsub(Vec128<float>.Zero, x);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vnegate(in Vec128<double> x)
            =>  vsub(Vec128<double>.Zero, x);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vnegate(in Vec256<float> x)
            =>  vsub(Vec256<float>.Zero, x);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vnegate(in Vec256<double> x)
            =>  vsub(Vec256<double>.Zero, x);
    }

}