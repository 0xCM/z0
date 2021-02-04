//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// int _mm_cvtsi128_si32 (__m128i a) MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="wDst">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static int vint32i(Vector128<int> src)
            => ConvertToInt32(src);

        /// <summary>
        /// int _mm_cvtsi128_si32 (__m128i a) MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="wDst">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint vint32u(Vector128<uint> src)
            => ConvertToUInt32(src);
    }
}