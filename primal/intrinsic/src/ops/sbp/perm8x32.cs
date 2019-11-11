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
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control vector</param>
        /// <summary>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</summary>
        [MethodImpl(Inline)]
        public static Vector256<int> vperm8x32(Vector256<int> src, Vector256<int> spec)
            => PermuteVar8x32(src, spec);

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control vector</param>
        /// <summary>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</summary>
        [MethodImpl(Inline)]
        public static Vector256<uint> vperm8x32(Vector256<uint> src, Vector256<uint> spec)
            => PermuteVar8x32(src, spec);

    }
}