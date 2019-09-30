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
        /// __m128 _mm_and_ps (__m128 a, __m128 b)ANDPS xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> vand(in Vec128<float> x, in Vec128<float> y)
            => And(x.xmm, y.xmm);
        
        /// <summary>
        /// __m128d _mm_and_pd (__m128d a, __m128d b)ANDPD xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vand(in Vec128<double> x, in Vec128<double> y)
            => And(x.xmm, y.xmm);

        /// <summary>
        /// __m128 _mm_and_ps (__m128 a, __m128 b)ANDPS xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vand(in Vec256<float> x, in Vec256<float> y)
            => And(x.ymm, y.ymm);
        
        /// <summary>
        /// __m128d _mm_and_pd (__m128d a, __m128d b) ANDPD xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vand(in Vec256<double> x, in Vec256<double> y)
            => And(x.ymm, y.ymm);
    }

}