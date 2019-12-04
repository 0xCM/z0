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
    
    using static As;
    using static zfunc;    

    partial class fpinx
    {
        /// <summary>
        /// __m128 _mm_min_ps (__m128 a, __m128 b) MINPS xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<float> vmin(Vector128<float> x, Vector128<float> y)
            => Min(x, y);

        /// <summary>
        /// __m128d _mm_min_pd (__m128d a, __m128d b) MINPD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vmin(Vector128<double> x, Vector128<double> y)
            => Min(x, y);

        /// <summary>
        /// __m256 _mm256_min_ps (__m256 a, __m256 b) VMINPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vmin(Vector256<float> x, Vector256<float> y)
            => Min(x, y);

        /// <summary>
        /// __m256d _mm256_min_pd (__m256d a, __m256d b) VMINPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vmin(Vector256<double> x, Vector256<double> y)
            => Min(x, y);
    }
}