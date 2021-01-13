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
        /// dst = x*y + z
        /// __m128 _mm_fmadd_ps (__m128 a, __m128 b, __m128 c) VFMADDPS xmm, xmm, xmm/m128
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> fmadd(Vector128<float> x, Vector128<float> y, Vector128<float> z)
            => MultiplyAdd(x, y, z);

        /// <summary>
        /// dst = x*y + z
        ///  __m128d _mm_fmadd_pd (__m128d a, __m128d b, __m128d c) VFMADDPD xmm, xmm, xmm/m128
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> fmadd(Vector128<double> x, Vector128<double> y, Vector128<double> z)
            => MultiplyAdd(x, y, z);

        /// <summary>
        /// __m256 _mm256_fmadd_ps (__m256 a, __m256 b, __m256 c) VFMADDPS ymm, ymm, ymm/m256
        /// dst = a*b + c
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> fmadd(Vector256<float> x, Vector256<float> y, Vector256<float> z)
            => MultiplyAdd(x,y,z);

        /// <summary>
        /// __m256d _mm256_fmadd_pd (__m256d a, __m256d b, __m256d c) VFMADDPS ymm, ymm, ymm/m256
        /// dst = a*b + c
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> fmadd(Vector256<double> x, Vector256<double> y, Vector256<double> z)
            => MultiplyAdd(x,y,z);
    }
}