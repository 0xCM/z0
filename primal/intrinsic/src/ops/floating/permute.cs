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
    
    using static As;
    using static zfunc;    

    partial class dfp
    {
        ///<summary>
        /// __m128 _mm_permute_ps (__m128 a, int imm8) VPERMILPS xmm, xmm, imm8
        ///</summary>
        /// <param name="x"></param>
        /// <param name="imm8"></param>
        [MethodImpl(Inline)]
        public static Vec128<float> vpermute(in Vec128<float> x, byte imm8)
            => Permute(x.xmm, imm8);

        /// <summary>
        /// __m128d _mm_permute_pd (__m128d a, int imm8) VPERMILPD xmm, xmm, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="imm8"></param>
        [MethodImpl(Inline)]
        public static Vec128<double> vpermute(in Vec128<double> x, byte imm8)
            => Permute(x.xmm, imm8);

        /// <summary>
        /// __m256 _mm256_permute_ps (__m256 a, int imm8) VPERMILPS ymm, ymm, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="imm8"></param>
        [MethodImpl(Inline)]
        public static Vec256<float> vpermute(in Vec256<float> x, byte imm8)
            => Permute(x.ymm, imm8);

        /// <summary>
        /// __m256d _mm256_permute_pd (__m256d a, int imm8) VPERMILPD ymm, ymm, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="imm8"></param>
        [MethodImpl(Inline)]
        public static Vec256<double> vpermute(in Vec256<double> x, byte imm8)
            => Permute(x.ymm, imm8);
    
            /// <summary>
        /// __m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256, imm8
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control byte</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vperm4x64(in Vec256<double> x, byte control)
            => Permute4x64(x,control); 


    }

}