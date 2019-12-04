//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class fpinx
    {


        /// <summary>
        ///  __m128 _mm_cmpeq_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(0)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<float> veq(Vector128<float> x, Vector128<float> y)
            => CompareEqual(x, y);

        /// <summary>
        /// __m128d _mm_cmpeq_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(0)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<double> veq(Vector128<double> x, Vector128<double> y)
            => CompareEqual(x, y);

        /// <summary>
        /// __m256 _mm256_cmp_ps (__m256 a, __m256 b, const int imm8) VCMPPS ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> veq(Vector256<float> x, Vector256<float> y)
            => Compare(x, y, FloatComparisonMode.UnorderedEqualNonSignaling);

        /// <summary>
        /// __m256d _mm256_cmp_pd (__m256d a, __m256d b, const int imm8) VCMPPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> veq(Vector256<double> x, Vector256<double> y)
            => Compare(x, y, FloatComparisonMode.UnorderedEqualNonSignaling);


    }

}