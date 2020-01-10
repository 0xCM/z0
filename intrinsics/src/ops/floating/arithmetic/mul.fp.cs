//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
    
    using static As;
    using static zfunc;    

    partial class dinxfp
    {
        /// <summary>
        /// __m128 _mm_mul_ps (__m128 a, __m128 b) MULPS xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<float> vmul(Vector128<float> x,Vector128<float> y)
            => Multiply(x, y);

        /// <summary>
        /// __m128d _mm_mul_pd (__m128d a, __m128d b) MULPD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vmul(Vector128<double> x,Vector128<double> y)
            => Multiply(x, y);
        
        /// <summary>
        /// __m256 _mm256_mul_ps (__m256 a, __m256 b) VMULPS ymm, ymm, ymm/m256
        /// Multiplies corresponding components and returns the result
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vmul(Vector256<float> x,Vector256<float> y)
            => Multiply(x, y);

        /// <summary>
        /// __m256d _mm256_mul_pd (__m256d a, __m256d b) VMULPD ymm, ymm, ymm/m256
        /// Multiplies corresponding components and returns the result
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vmul(Vector256<double> x, Vector256<double> y)
            => Multiply(x, y);
    }
}