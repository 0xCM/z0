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
    
    using static As;
    using static zfunc;    

    partial class dfp
    {
        ///  __m128 _mm_max_ps (__m128 a, __m128 b) MAXPS xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<float> vmax(in Vec128<float> x, in Vec128<float> y)
            => Max(x.xmm, y.xmm);
 
        /// <summary>
        ///  __m128d _mm_max_pd (__m128d a, __m128d b)MAXPD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<double> vmax(in Vec128<double> x, in Vec128<double> y)
            => Max(x.xmm, y.xmm);

        /// <summary>
        /// __m256 _mm256_max_ps (__m256 a, __m256 b) VMAXPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<float> vmax(in Vec256<float> x, in Vec256<float> y)
            => Max(x.ymm, y.ymm);

        /// <summary>
        /// __m256d _mm256_max_pd (__m256d a, __m256d b)VMAXPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<double> vmax(in Vec256<double> x, in Vec256<double> y)
            => Max(x.ymm, y.ymm);

    }
}