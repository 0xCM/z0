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
        /// __m128 _mm_mul_ps (__m128 a, __m128 b) MULPS xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> vmul(in Vec128<float> x,in Vec128<float> y)
            => Multiply(x.xmm, y.xmm);

        /// <summary>
        /// __m128d _mm_mul_pd (__m128d a, __m128d b) MULPD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vmul(in Vec128<double> x,in Vec128<double> y)
            => Multiply(x.xmm, y.xmm);
        
        /// <summary>
        /// __m256 _mm256_mul_ps (__m256 a, __m256 b) VMULPS ymm, ymm, ymm/m256
        /// Multiplies corresponding components and returns the result
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vmul(in Vec256<float> x,in Vec256<float> y)
            => Multiply(x.ymm, y.ymm);

        /// <summary>
        /// __m256d _mm256_mul_pd (__m256d a, __m256d b) VMULPD ymm, ymm, ymm/m256
        /// Multiplies corresponding components and returns the result
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vmul(in Vec256<double> x, in Vec256<double> y)
            => Multiply(x.ymm, y.ymm);
    }
}