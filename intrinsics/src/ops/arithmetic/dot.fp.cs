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

    partial class dinxfp
    {
        /// <summary>
        /// __m128 _mm_dp_ps (__m128 a, __m128 b, const int imm8) DPPS xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector128<float> vdot(Vector128<float> x, Vector128<float> y, byte? control = null)
            => DotProduct(x, y, control ?? 0xFF);
        
        /// <summary>
        /// __m128d _mm_dp_pd (__m128d a, __m128d b, const int imm8) DPPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector128<double> vdot(Vector128<double> x, Vector128<double> y, byte? control = null)
            => DotProduct(x, y, control ?? 0xFF);

        /// <summary>
        /// __m256 _mm256_dp_ps (__m256 a, __m256 b, const int imm8) VDPPS ymm, ymm, ymm/m256,
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<float> vdot(Vector256<float> x, Vector256<float> y, byte? control = null)
            => DotProduct(x, y, control ?? 0xFF);
    }

}