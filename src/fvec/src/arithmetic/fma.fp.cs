//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Fma;
    using static Part;

    partial class dinxfp
    {
        /// <summary>
        /// __m128 _mm_fnmadd_ps (__m128 a, __m128 b, __m128 c) VFNMADDPS xmm, xmm, xmm/m128
        /// dst = -(x*y + c)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vfnmadd(Vector128<float> x, Vector128<float> y, Vector128<float> z)
            => MultiplyAddNegated(x,y,z);

        /// <summary>
        /// __m128d _mm_fnmadd_pd (__m128d a, __m128d b, __m128d c) VFNMADDPD xmm, xmm, xmm/m128
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vfnmadd(Vector128<double> x, Vector128<double> y, Vector128<double> z)
            => MultiplyAddNegated(x,y,z);

        /// <summary>
        /// __m128 _mm_fmaddsub_ps (__m128 a, __m128 b, __m128 c) VFMADDSUBPS xmm, xmm, xmm/m128
        /// dst = x*y - z
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vfmaddsub(Vector128<float> x, Vector128<float> y, Vector128<float> z)
            => MultiplyAddSubtract(x,y,z);

        /// <summary>
        /// __m128d _mm_fmaddsub_pd (__m128d a, __m128d b, __m128d c) VFMADDSUBPD xmm, xmm, xmm/m128
        /// dst[i] = x[i]*y[i] + z (i is even?)
        /// dst[i] = x[i]*y[i] - z (i is odd?)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vfmaddsub(Vector128<double> x, Vector128<double> y, Vector128<double> z)
            => MultiplyAddSubtract(x,y,z);

        /// <summary>
        /// __m256 _mm256_fnmadd_ps (__m256 a, __m256 b, __m256 c) VFNMADDPS ymm, ymm, ymm/m256
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vfnmadd(Vector256<float> x, Vector256<float> y, Vector256<float> z)
            => MultiplyAddNegated(x,y,z);

        /// <summary>
        /// __m256d _mm256_fnmadd_pd (__m256d a, __m256d b, __m256d c) VFNMADDPD ymm, ymm,ymm/m256
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vfnmadd(Vector256<double> x, Vector256<double> y, Vector256<double> z)
            => MultiplyAddNegated(x,y,z);

        /// <summary>
        /// __m256 _mm256_fmaddsub_ps (__m256 a, __m256 b, __m256 c) VFMADDSUBPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vfmaddsub(Vector256<float> x, Vector256<float> y, Vector256<float> z)
            => MultiplyAddSubtract(x,y,z);

        /// <summary>
        /// __m256d _mm256_fmaddsub_pd (__m256d a, __m256d b, __m256d c) VFMADDSUBPD ymm, ymm, ymm/m256
        /// dst[i] = x[i]*y[i] + z (i is even?)
        /// dst[i] = x[i]*y[i] - z (i is odd?)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vfmaddsub(Vector256<double> x, Vector256<double> y, Vector256<double> z)
            => MultiplyAddSubtract(x,y,z);
    }
}