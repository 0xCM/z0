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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static As;
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m256d _mm256_permute4x64_pd (__m256d a, const int imm8)VPERMPD ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vperm4x64(Vector256<double> x, Perm4 spec)
            => Permute4x64(x, (byte)spec); 

        /// <summary>
        /// __m256d _mm256_permute4x64_pd (__m256d a, const int imm8)VPERMPD ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vperm4x64(Vector256<float> x, Perm4 spec)
            => Permute4x64(x.AsUInt64(), (byte)spec).AsSingle(); 

        /// <summary>
        /// __m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256, imm8
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vperm4x64(Vector256<double> x, byte spec)
            => Permute4x64(x,spec); 

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// __m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx)VPERMPS ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control vector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vperm8x32(Vector256<float> src, Vector256<int> spec)
            => PermuteVar8x32(src, spec);
    }
}