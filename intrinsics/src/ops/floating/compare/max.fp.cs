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

    partial class dinxfp
    {
        ///  __m128 _mm_max_ps (__m128 a, __m128 b) MAXPS xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vmax(Vector128<float> x, Vector128<float> y)
            => Max(x, y);
 
        /// <summary>
        ///  __m128d _mm_max_pd (__m128d a, __m128d b)MAXPD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vmax(Vector128<double> x, Vector128<double> y)
            => Max(x, y);

        /// <summary>
        /// __m256 _mm256_max_ps (__m256 a, __m256 b) VMAXPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vmax(Vector256<float> x, Vector256<float> y)
            => Max(x, y);

        /// <summary>
        /// __m256d _mm256_max_pd (__m256d a, __m256d b)VMAXPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vmax(Vector256<double> x, Vector256<double> y)
            => Max(x, y);

    }
}