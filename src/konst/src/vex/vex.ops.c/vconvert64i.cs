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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// __int64 _mm_cvtsi128_si64 (__m128i a) MOVQ reg/m64, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="wDst">The target width</param>
        [MethodImpl(Inline), Op]
        public static long vconvert64i(Vector128<long> src, W64 wDst)
            => ConvertToInt64(src);

        /// <summary>
        /// __int64 _mm_cvtss_si64 (__m128 a) CVTSS2SI r64, xmm/m32
        /// src[0..31] -> r64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="wDst">The target width</param>
        [MethodImpl(Inline), Op]
        public static long vconvert64i(Vector128<float> src, W64 wDst)
            => ConvertToInt64(src);

        /// <summary>
        ///  __int64 _mm_cvtsd_si64 (__m128d a) CVTSD2SI r64, xmm/m64
        /// src[0..63] -> r64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="wDst">The target width</param>
        [MethodImpl(Inline), Op]
        public static long vconvert64i(Vector128<double> src, W64 wDst)
            => ConvertToInt64(src);
    }
}