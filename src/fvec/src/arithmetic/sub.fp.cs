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
    using static Part;

    partial class dinxfp
    {
        /// <summary>
        /// __m128d _mm_sub_ps (__m128d a, __m128d b) SUBPS xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vsub(Vector128<float> x, Vector128<float> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128d _mm_sub_pd (__m128d a, __m128d b) SUBPD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vsub(Vector128<double> x, Vector128<double> y)
            => Subtract(x,y);

        /// <summary>
        /// __m256 _mm256_sub_ps (__m256 a, __m256 b) VSUBPS ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vsub(Vector256<float> x, Vector256<float> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256d _mm256_sub_pd (__m256d a, __m256d b) VSUBPD ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vsub(Vector256<double> x, Vector256<double> y)
            => Subtract(x, y);
    }
}