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
    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// __m128 _mm_movehl_ps (__m128 a, __m128 b) MOVHLPS xmm, xmm
        /// z[0] = x[3]
        /// z[1] = y[3]
        /// z[2] = x[0]
        /// z[3] = y[0]
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vmovehl(Vector128<float> x, Vector128<float> y)
            => MoveHighToLow(x,y);
    }
}