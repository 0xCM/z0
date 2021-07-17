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
    using static Root;

    partial struct cpu
    {
        /// <summary>
        /// __m128 _mm_div_ps (__m128 a, __m128 b)DIVPS xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vdiv(Vector128<float> x, Vector128<float> y)
            => Divide(x, y);

        /// <summary>
        ///  __m128d _mm_div_pd (__m128d a, __m128d b)DIVPD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vdiv(Vector128<double> x, Vector128<double> y)
            => Divide(x, y);

        /// <summary>
        /// __m256 _mm256_div_ps (__m256 a, __m256 b)VDIVPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vdiv(Vector256<float> x, Vector256<float> y)
            => Divide(x, y);

        /// <summary>
        /// __m256d _mm256_div_pd (__m256d a, __m256d b)VDIVPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vdiv(Vector256<double> x, Vector256<double> y)
            => Divide(x, y);
    }
}