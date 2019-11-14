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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Fma;        
    
    using static As;
    using static zfunc;    

    
    partial class dfp
    {
        /// <summary>
        /// _mm_round_ps:
        /// Round to nearest integer
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> vround(in Vec128<float> x)
            => RoundToNearestInteger(x);

        /// <summary>
        /// _mm_round_pd:
        /// Round to nearest integer
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vround(in Vec128<double> x)
            => RoundToNearestInteger(x);

        /// <summary>
        /// _mm_round_ss:
        /// Round towards zero
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> vroundz(in Vec128<float> x)
            => RoundToZero(x);

        /// <summary>
        /// _mm_round_sd:
        /// Round towards zero
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vroundz(in Vec128<double> x)
            => RoundToZero(x);

        /// <summary>
        /// _mm256_round_ps:
        /// Round to nearest integer
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vround(in Vec256<float> x)
            => RoundToNearestInteger(x);

        /// <summary>
        /// __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_NEAREST_INT | _MM_FROUND_NO_EXC) VROUNDPD ymm, ymm/m256, imm8(8)
        /// Round to nearest integer
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vround(in Vec256<double> x)
            => RoundToNearestInteger(x);

        /// <summary>
        /// __m256 _mm256_round_ps (__m256 a, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC)VROUNDPS ymm, ymm/m256, imm8(11)
        /// Round towards zero
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vroundz(in Vec256<float> x)
            => RoundToZero(x);

        /// <summary>
        /// __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC) VROUNDPD ymm, ymm/m256, imm8(11)
        /// Round towards zero
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vroundz(in Vec256<double> x)
            => RoundToZero(x);
    }
}