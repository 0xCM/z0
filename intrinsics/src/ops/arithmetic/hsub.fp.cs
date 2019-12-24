//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    

    partial class dinxfp
    {
        /// <summary>
        /// __m128 _mm_hsub_ps (__m128 a, __m128 b) HSUBPS xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<float> vhsub(Vector128<float> x, Vector128<float> y)
            => HorizontalSubtract(x, y);

        /// <summary>
        /// __m128d _mm_hsub_pd (__m128d a, __m128d b) HSUBPD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vhsub(Vector128<double> x, Vector128<double> y)
            => HorizontalSubtract(x, y);

        /// <summary>
        /// __m256 _mm256_hsub_ps (__m256 a, __m256 b) VHSUBPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vhsub(Vector256<float> x, Vector256<float> y)
            => HorizontalSubtract(x, y);

        /// <summary>
        /// __m256d _mm256_hsub_pd (__m256d a, __m256d b) VHSUBPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vhsub(Vector256<double> x, Vector256<double> y)
            => HorizontalSubtract(x, y);
    }

}