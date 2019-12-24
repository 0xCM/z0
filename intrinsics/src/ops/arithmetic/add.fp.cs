//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    
    using static zfunc;    

    partial class dinxfp
    {
        /// <summary>
        /// __m128 _mm_add_ps (__m128 a, __m128 b)ADDPS xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector128<float> vadd(Vector128<float> x, Vector128<float> y)
            => Add(x, x);

        /// <summary>
        /// __m128d _mm_add_pd (__m128d a, __m128d b)ADDPD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector128<double> vadd(Vector128<double> x, Vector128<double> y)
            => Add(x, y);

        /// <summary>
        /// __m256 _mm256_add_ps (__m256 a, __m256 b)VADDPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<float> vadd(Vector256<float> x, Vector256<float> y)
            => Add(x, y);

        /// <summary>
        /// __m256d _mm256_add_pd (__m256d a, __m256d b)VADDPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<double> vadd(Vector256<double> x, Vector256<double> y)
            => Add(x, y);             

    }
}