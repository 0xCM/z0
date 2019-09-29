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
        /// __m128 _mm_add_ps (__m128 a, __m128 b)ADDPS xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<float> vadd(in Vec128<float> x, in Vec128<float> y)
            => Add(x.xmm, x.xmm);

        /// <summary>
        /// __m128d _mm_add_pd (__m128d a, __m128d b)ADDPD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<double> vadd(in Vec128<double> x, in Vec128<double> y)
            => Add(x.xmm, y.xmm);

        /// <summary>
        /// __m256 _mm256_add_ps (__m256 a, __m256 b)VADDPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<float> vadd(in Vec256<float> x, in Vec256<float> y)
            => Add(x.ymm, y.ymm);

        /// <summary>
        /// __m256d _mm256_add_pd (__m256d a, __m256d b)VADDPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<double> vadd(in Vec256<double> x, in Vec256<double> y)
            => Add(x.ymm, y.ymm);             

    }
}