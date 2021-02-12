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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// __m128i _mm_cvttps_epi32 (__m128 a) CVTTPS2DQ xmm, xmm/m128
        /// Converts a floating-point source vector to an 32-bit integer target vector with a loss of precision
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vconvert128x32i(Vector128<float> src)
            => ConvertToVector128Int32(src);

        /// <summary>
        ///  __m128i _mm256_cvtpd_epi32 (__m256d a) VCVTPD2DQ xmm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vconvert128x32i(Vector256<double> src)
            => ConvertToVector128Int32(src);

        /// <summary>
        ///  __m128i _mm_cvttpd_epi32 (__m128d a) CVTTPD2DQ xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vconvert128x32i(Vector128<double> src)
            => ConvertToVector128Int32(src);
    }
}