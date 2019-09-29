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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    
    using static As;
    using static zfunc;    

    partial class dfp
    {

        /// <summary>
        /// __m128 _mm_unpackhi_ps (__m128 a, __m128 b) UNPCKHPS xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> vunpackhi(in Vec128<float> x, in Vec128<float> y)
            => UnpackHigh(x.xmm,y.xmm);

        /// <summary>
        /// __m128d _mm_unpackhi_pd (__m128d a, __m128d b) UNPCKHPD xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vunpackhi(in Vec128<double> x, in Vec128<double> y)
            => UnpackHigh(x.xmm,y.xmm);

        /// <summary>
        /// __m256 _mm256_unpackhi_ps (__m256 a, __m256 b) VUNPCKHPS ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vunpackhi(in Vec256<float> x, in Vec256<float> y)
            => UnpackHigh(x.ymm,y.ymm);

        /// <summary>
        /// __m256d _mm256_unpackhi_pd (__m256d a, __m256d b) VUNPCKHPD ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vunpackhi(in Vec256<double> x, in Vec256<double> y)
            => UnpackHigh(x.ymm,y.ymm);



    }

}