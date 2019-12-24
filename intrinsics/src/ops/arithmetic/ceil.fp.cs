//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    

    partial class dinxfp
    {
        /// <summary>
        /// __m128d _mm_ceil_sd (__m128d a) ROUNDSD xmm, xmm/m128, imm8(10) 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<float> ceil(Vector128<float> src)
            => Ceiling(src);

        /// <summary>
        /// __m128d _mm_ceil_pd (__m128d a) ROUNDPD xmm, xmm/m128, imm8(10)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<double> ceil(Vector128<double> src)
            => Ceiling(src);

        /// <summary>
        /// __m256 _mm256_ceil_ps (__m256 a) VROUNDPS ymm, ymm/m256, imm8(10)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> ceil(Vector256<float> src)
            => Ceiling(src);

        /// <summary>
        /// __m256 _mm256_ceil_pd (__m256 a) VROUNDPS ymm, ymm/m256, imm8(10)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> ceil(Vector256<double> src)
            => Ceiling(src); 
    }

}