//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static Root;

    partial struct cpu
    {
        /// <summary>
        /// __m128 _mm_rcp_ps (__m128 a) RCPPS xmm, xmm/m128
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vrcp(Vector128<float> x)
            => Reciprocal(x);

        /// <summary>
        /// __m256 _mm256_rcp_ps (__m256 a) VRCPPS ymm, ymm/m256
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vrcp(Vector256<float> x)
            => Reciprocal(x);
    }
}