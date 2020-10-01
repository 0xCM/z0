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
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// __m128 _mm_blendv_ps (__m128 a, __m128 b, __m128 mask) BLENDVPS xmm, xmm/m128,xmm0
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vblend4x32(Vector128<float> x, Vector128<float> y, Vector128<float> spec)
            =>  BlendVariable(x, y, spec);

        /// <summary>
        /// __m128d _mm_blendv_pd (__m128d a, __m128d b, __m128d mask) BLENDVPD xmm, xmm/m128,xmm0
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vblend2x64(Vector128<double> x, Vector128<double> y, Vector128<double> spec)
            =>  BlendVariable(x, y, spec);

        /// <summary>
        /// __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask) VBLENDVPS ymm, ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vblend8x32(Vector256<float> x, Vector256<float> y, Vector256<float> spec)
            => BlendVariable(x, y, spec);

        /// <summary>
        /// __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask) VBLENDVPS ymm, ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vblend4x64(Vector256<double> x, Vector256<double> y, Vector256<double> spec)
            => BlendVariable(x, y, spec);
    }
}