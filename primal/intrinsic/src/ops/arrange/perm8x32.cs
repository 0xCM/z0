//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx    
    {        
       /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        /// <summary>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</summary>
        [MethodImpl(Inline)]
        public static Vec256<int> perm8x32(in Vec256<int> src, in Vec256<int> control)
            => PermuteVar8x32(src.ymm, control.ymm);

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        /// <summary>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</summary>
        [MethodImpl(Inline)]
        public static Vec256<uint> perm8x32(in Vec256<uint> src, in Vec256<uint> control)
            => PermuteVar8x32(src.ymm, control.ymm);

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// __m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx)VPERMPS ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> perm8x32(in Vec256<float> src, in Vec256<int> control)
            => PermuteVar8x32(src.ymm, control.ymm);


    }

}