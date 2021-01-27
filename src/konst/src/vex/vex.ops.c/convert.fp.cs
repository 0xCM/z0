//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// int _mm_cvtss_si32 (__m128 a) CVTSS2SI r32, xmm/m32
        /// src[0..31] -> r32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static int convert32i(Vector128<float> src, W32 w)
            => ConvertToInt32(src);

        /// <summary>
        /// __m128i _mm_cvttps_epi32 (__m128 a) CVTTPS2DQ xmm, xmm/m128
        /// Converts a floating-point source vector to an 32-bit integer target vector with a loss of precision
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vconvert32i(Vector128<float> src, W128 w)
            => ConvertToVector128Int32(src);

        /// <summary>
        /// __m128 _mm_cvtepi32_ps (__m128i a) CVTDQ2PS xmm, xmm/m128
        /// Converts an integer source vector to a floating-point target vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vconvert32f(Vector128<int> src, W128 w)
            => ConvertToVector128Single(src);

        /// <summary>
        /// __m256d _mm256_cvtepi32_pd (__m128i a) VCVTDQ2PD ymm, xmm/m128
        /// 4x32i -> 4x64f
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vconvert64f(Vector128<int> src, W256 w)
            => ConvertToVector256Double(src);

        /// <summary>
        /// __m128 _mm_cvtpd_ps (__m128d a) CVTPD2PS xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vconvert32f(Vector128<double> src, W128 w)
            => ConvertToVector128Single(src);

        /// <summary>
        /// __m256 _mm256_cvtepi32_ps (__m256i a) VCVTDQ2PS ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vconvert32f(Vector256<int> src, W256 w)
            => ConvertToVector256Single(src);

        /// <summary>
        ///  __m128i _mm_cvttpd_epi32 (__m128d a) CVTTPD2DQ xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> convert32i(Vector128<double> src, W128 w)
            => ConvertToVector128Int32(src);

        /// <summary>
        /// __m256i _mm256_cvtps_epi32 (__m256 a) VCVTPS2DQ ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> convert32i(Vector256<float> src, W256 w)
            =>  ConvertToVector256Int32(src);

        /// <summary>
        ///  __m128i _mm256_cvtpd_epi32 (__m256d a) VCVTPD2DQ xmm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> convert32i(Vector256<double> src, W128 w)
            => ConvertToVector128Int32(src);

        /// <summary>
        /// __m128 _mm256_cvtpd_ps (__m256d a) VCVTPD2PS xmm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> convert32f(Vector256<double> src, W128 w)
            => ConvertToVector128Single(src);
    }

}