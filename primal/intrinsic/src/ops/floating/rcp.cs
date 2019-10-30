//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m128 _mm_rcp_ps (__m128 a) RCPPS xmm, xmm/m128
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> rcp(in Vec128<float> x)
            => Reciprocal(x);

        /// <summary>
        /// __m256 _mm256_rcp_ps (__m256 a) VRCPPS ymm, ymm/m256
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> rcp(in Vec256<float> x)
            => Reciprocal(x.ymm);
    }

}