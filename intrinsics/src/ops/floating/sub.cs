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
        /// __m128d _mm_sub_ps (__m128d a, __m128d b) SUBPS xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<float> vsub(in Vec128<float> x, in Vec128<float> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128d _mm_sub_pd (__m128d a, __m128d b) SUBPD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<double> vsub(in Vec128<double> x, in Vec128<double> y)
            => Subtract(x,y);

        /// <summary>
        /// __m256 _mm256_sub_ps (__m256 a, __m256 b) VSUBPS ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vsub(in Vec256<float> x, in Vec256<float> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256d _mm256_sub_pd (__m256d a, __m256d b) VSUBPD ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vsub(in Vec256<double> x, in Vec256<double> y)  
            => Subtract(x, y);
    }
}