//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx    
    {        
        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8)VPERMQ ymm, ymm/m256, imm8
        /// Permutes components in the source vector across lanes per the supplied specification
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vperm4x64(Vector256<long> x, Perm4 spec)
            => Permute4x64(x, (byte)spec);

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8)VPERMQ ymm, ymm/m256, imm8
        /// Permutes components in the source vector across lanes per the supplied specification
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vperm4x64(Vector256<ulong> x, Perm4 spec)
            => Permute4x64(x, (byte)spec); 

        /// <summary>
        /// __m256d _mm256_permute4x64_pd (__m256d a, const int imm8)VPERMPD ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vperm4x64(Vector256<double> x, Perm4 spec)
            => Permute4x64(x, (byte)spec); 

    }
}