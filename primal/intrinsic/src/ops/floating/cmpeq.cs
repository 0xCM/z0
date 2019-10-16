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

    partial class dfp
    {
        /// <summary>
        /// Returns a 128x32f vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<float> vones_128x32f()
            => CompareEqual(default(Vector128<float>), default(Vector128<float>));

        /// <summary>
        /// Returns a 128x64f vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<double> vones_128x64f()
            => CompareEqual(default(Vector128<double>), default(Vector128<double>));

        /// <summary>
        /// Returns a 256x32f vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<float> ones_256x32f()
            => Compare(default(Vector256<float>), default(Vector256<float>), FloatComparisonMode.UnorderedEqualNonSignaling);

        /// <summary>
        /// Returns a 256x64f vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<double> ones_256x64f()
            => Compare(default(Vector256<double>), default(Vector256<double>), FloatComparisonMode.UnorderedEqualNonSignaling);

        /// <summary>
        ///  __m128 _mm_cmpeq_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(0)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> cmpeq(in Vec128<float> x, in Vec128<float> y)
            => CompareEqual(x.xmm, y.xmm);

        /// <summary>
        /// __m128d _mm_cmpeq_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(0)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> cmpeq(in Vec128<double> x, in Vec128<double> y)
            => CompareEqual(x.xmm, y.xmm);

        /// <summary>
        /// __m256 _mm256_cmp_ps (__m256 a, __m256 b, const int imm8) VCMPPS ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> cmpeq(in Vec256<float> x, in Vec256<float> y)
            => Compare(x.ymm, y.ymm, FloatComparisonMode.UnorderedEqualNonSignaling);

        /// <summary>
        /// __m256d _mm256_cmp_pd (__m256d a, __m256d b, const int imm8) VCMPPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> cmpeq(in Vec256<double> x, in Vec256<double> y)
            => Compare(x.ymm, y.ymm, FloatComparisonMode.UnorderedEqualNonSignaling);


    }

}