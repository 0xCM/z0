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
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m128 _mm_dp_ps (__m128 a, __m128 b, const int imm8) DPPS xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<float> dot(in Vec128<float> x, in Vec128<float> y, byte? control = null)
            => DotProduct(x.xmm, y.xmm, control ?? 0xFF);
        
        /// <summary>
        /// __m128d _mm_dp_pd (__m128d a, __m128d b, const int imm8) DPPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<double> dot(in Vec128<double> x, in Vec128<double> y, byte? control = null)
            => DotProduct(x.xmm, y.xmm, control ?? 0xFF);

        /// <summary>
        /// __m256 _mm256_dp_ps (__m256 a, __m256 b, const int imm8) VDPPS ymm, ymm, ymm/m256,
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<float> dot(in Vec256<float> x, in Vec256<float> y, byte? control = null)
            => DotProduct(x.ymm, y.ymm, control ?? 0xFF);
    }

}