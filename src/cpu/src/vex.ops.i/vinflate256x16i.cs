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
    using static Part;
    using static memory;

    partial struct cpu
    {
        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) vpmovzxbw ymm, xmm
        /// 16x8u -> 16x16i
        /// src[i] -> dst[i], i = 0,...,15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate256x16i(Vector128<byte> src)
            => ConvertToVector256Int16(src);

        /// <summary>
        /// 16x8i -> 16x16i
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate256x16i(Vector128<sbyte> src)
            => vconcat(vmaplo128x16i(src), vmaphi128x16i(src));

        /// <summary>
        /// VPMOVSXBW ymm, m128
        /// 16x8i -> 16x16i
        /// </summary>
        /// <param name="src">The memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<short> vinflate256x16i(in SpanBlock128<sbyte> src, uint offset)
            => ConvertToVector256Int16(gptr(src[offset]));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<short> vinflate256x16i(in SpanBlock128<byte> src, uint offset)
            => ConvertToVector256Int16(gptr(src[offset]));
    }
}