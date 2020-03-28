//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static Core;
    
    partial class dinxfp
    {
        /// <summary>
        /// _mm_round_ps:
        /// Round to nearest integer
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vround(Vector128<float> x)
            => RoundToNearestInteger(x);

        /// <summary>
        /// _mm_round_pd:
        /// Round to nearest integer
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vround(Vector128<double> x)
            => RoundToNearestInteger(x);

        /// <summary>
        /// _mm_round_ss:
        /// Round towards zero
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vroundz(Vector128<float> x)
            => RoundToZero(x);

        /// <summary>
        /// _mm_round_sd:
        /// Round towards zero
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vroundz(Vector128<double> x)
            => RoundToZero(x);

        /// <summary>
        /// _mm256_round_ps:
        /// Round to nearest integer
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vround(Vector256<float> x)
            => RoundToNearestInteger(x);

        /// <summary>
        /// __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_NEAREST_INT | _MM_FROUND_NO_EXC) VROUNDPD ymm, ymm/m256, imm8(8)
        /// Round to nearest integer
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vround(Vector256<double> x)
            => RoundToNearestInteger(x);

        /// <summary>
        /// __m256 _mm256_round_ps (__m256 a, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC)VROUNDPS ymm, ymm/m256, imm8(11)
        /// Round towards zero
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vroundz(Vector256<float> x)
            => RoundToZero(x);

        /// <summary>
        /// __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC) VROUNDPD ymm, ymm/m256, imm8(11)
        /// Round towards zero
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vroundz(Vector256<double> x)
            => RoundToZero(x);
    }
}