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
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    
    using static As;
    using static zfunc;    

    partial class dfp
    {

        /// <summary>
        /// __m128 _mm_permutevar_ps (__m128 a, __m128i b)VPERMILPS xmm, xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="control"></param>
        [MethodImpl(Inline)]
        public static Vec128<float> vpermvar(Vec128<float> x, Vec128<int> control)
            => PermuteVar(x, control);

        /// <summary>
        /// __m128d _mm_permutevar_pd (__m128d a, __m128i b) VPERMILPD xmm, xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline)]
        public static Vec128<double> vpermvar(Vec128<double> x, Vec128<long> control)
            => PermuteVar(x, control);

        /// <summary>
        /// __m256 _mm256_permutevar_ps (__m256 a, __m256i b) VPERMILPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="control"></param>
        [MethodImpl(Inline)]
        public static Vec256<float> vpermvar(in Vec256<float> x, in Vec256<int> control)
            => PermuteVar(x, control);

        /// <summary>
        /// __m256d _mm256_permutevar_pd (__m256d a, __m256i b) VPERMILPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="control"></param>
        [MethodImpl(Inline)]
        public static Vec256<double> vpermvar(in Vec256<double> x, in Vec256<long> control)
            => PermuteVar(x, control);

    }

}