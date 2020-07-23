//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
        
    using static Konst;
    
    partial struct z
    {
       /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// __m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx)VPERMPS ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vperm8x32(Vector256<float> src, Vector256<int> spec)
            => PermuteVar8x32(src, spec);

        /// <summary>
        /// __m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx)VPERMPS ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vperm8x32(Vector256<float> src, Vector256<uint> spec)
            => PermuteVar8x32(src, spec.AsInt32());
    }
}