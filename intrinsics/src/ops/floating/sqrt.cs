//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m128 _mm_sqrt_ps (__m128 a) SQRTPS xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> sqrt(in Vec128<float> src)
            => Sqrt(src);

        /// <summary>
        /// __m128d _mm_sqrt_pd (__m128d a) SQRTPD xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> sqrt(in Vec128<double> src)
            => Sqrt(src);
 
        /// <summary>
        /// __m256 _mm256_sqrt_ps (__m256 a) VSQRTPS ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> sqrt(in Vec256<float> src)
            => Sqrt(src.ymm);

        /// <summary>
        /// __m256d _mm256_sqrt_pd (__m256d a) VSQRTPD ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> sqrt(in Vec256<double> src)
            => Sqrt(src.ymm);
 
        /// <summary>
        /// __m128 _mm_rsqrt_ps (__m128 a) RSQRTPS xmm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Vec128<float> rsqrt(in Vec128<float> src)
            => ReciprocalSqrt(src);         
    }
}