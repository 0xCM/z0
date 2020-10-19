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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static Konst;

    partial struct z
    {
       /// <summary>
        /// __m128 _mm_unpacklo_ps (__m128 a, __m128 b) UNPCKLPS xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vunpacklo(Vector128<float> x, Vector128<float> y)
            => UnpackLow(x,y);

        /// <summary>
        /// __m128d _mm_unpacklo_pd (__m128d a, __m128d b) UNPCKLPD xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vunpacklo(Vector128<double> x, Vector128<double> y)
            => UnpackLow(x,y);

        /// <summary>
        /// __m256 _mm256_unpacklo_ps (__m256 a, __m256 b) VUNPCKLPS ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vunpacklo(Vector256<float> x, Vector256<float> y)
            => UnpackLow(x,y);

        /// <summary>
        /// __m256d _mm256_unpacklo_pd (__m256d a, __m256d b) VUNPCKLPD ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vunpacklo(Vector256<double> x, Vector256<double> y)
            => UnpackLow(x,y);
    }
}