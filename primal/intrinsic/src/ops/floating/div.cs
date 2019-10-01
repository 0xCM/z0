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

        /// <summary>
        /// __m128 _mm_div_ps (__m128 a, __m128 b)DIVPS xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<float> vdiv(in Vec128<float> x, in Vec128<float> y)
            => Divide(x.xmm, y.xmm);

        /// <summary>
        ///  __m128d _mm_div_pd (__m128d a, __m128d b)DIVPD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<double> vdiv(in Vec128<double> x, in Vec128<double> y)
            => Divide(x.xmm, y.xmm);

        /// <summary>
        /// __m256 _mm256_div_ps (__m256 a, __m256 b)VDIVPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec256<float> vdiv(in Vec256<float> x, in Vec256<float> y)
            => Divide(x.ymm, y.ymm);

        /// <summary>
        /// __m256d _mm256_div_pd (__m256d a, __m256d b)VDIVPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<double> vdiv(in Vec256<double> x, in Vec256<double> y)
            => Divide(x.ymm, y.ymm);

    }
}