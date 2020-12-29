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

    partial struct z
    {
        /// <summary>
        /// __int64 _mm_cvtss_si64 (__m128 a) CVTSS2SI r64, xmm/m32
        /// src[0..31] -> r64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static long convert(Vector128<float> src, N64 w, long t = default)
            => ConvertToInt64(src);

        /// <summary>
        /// int _mm_cvtss_si32 (__m128 a) CVTSS2SI r32, xmm/m32
        /// src[0..31] -> r32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static int convert(Vector128<float> src, N32 w, int t = default)
            => ConvertToInt32(src);

        /// <summary>
        ///  __int64 _mm_cvtsd_si64 (__m128d a) CVTSD2SI r64, xmm/m64
        /// src[0..63] -> r64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static long convert(Vector128<double> src, N64 w, long t = default)
            => ConvertToInt64(src);

        /// <summary>
        /// __m128i _mm_cvttps_epi32 (__m128 a) CVTTPS2DQ xmm, xmm/m128
        /// Converts a floating-point source vector to an 32-bit integer target vector with a loss of precision
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> convert(Vector128<float> src, N128 w, int t = default)
            => ConvertToVector128Int32(src);

        /// <summary>
        /// __m128 _mm_cvtepi32_ps (__m128i a) CVTDQ2PS xmm, xmm/m128
        /// Converts an integer source vector to a floating-point target vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> convert(Vector128<int> src, N128 w, float t = default)
            => ConvertToVector128Single(src);

        /// <summary>
        /// __m256d _mm256_cvtepi32_pd (__m128i a) VCVTDQ2PD ymm, xmm/m128
        /// 4x32i ->4x64f
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> convert(Vector128<int> src, N256 w, double t = default)
            => ConvertToVector256Double(src);

        /// <summary>
        /// __m128 _mm_cvtpd_ps (__m128d a) CVTPD2PS xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> convert(Vector128<double> src, N128 w, float t = default)
            => ConvertToVector128Single(src);

        /// <summary>
        /// __m256 _mm256_cvtepi32_ps (__m256i a) VCVTDQ2PS ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> convert(Vector256<int> src, N256 w, float t = default)
            => ConvertToVector256Single(src);

        /// <summary>
        ///  __m128i _mm_cvttpd_epi32 (__m128d a) CVTTPD2DQ xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> convert(Vector128<double> src, N128 w, int t = default)
            => ConvertToVector128Int32(src);

        /// <summary>
        /// __m256i _mm256_cvttps_epi32 (__m256 a) VCVTTPS2DQ ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> convert(Vector256<float> src, N256 w, int t = default)
            =>  ConvertToVector256Int32(src);

        /// <summary>
        /// __m128i _mm256_cvtpd_epi32 (__m256d a) VCVTPD2DQ xmm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> convert(Vector256<double> src, N128 w, int t = default)
            => ConvertToVector128Int32(src);

        /// <summary>
        /// __m128 _mm256_cvtpd_ps (__m256d a)VCVTPD2PS xmm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> convert(Vector256<double> src, N128 w, float t = default)
            => ConvertToVector128Single(src);
    }
}