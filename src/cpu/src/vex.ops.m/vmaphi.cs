//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// __m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vhi128x16i(Vector128<short> src)
            => ConvertToVector128Int32(vshi(src));

        /// <summary>
        /// __m128i _mm_cvtepu16_epi32 (__m128i a) PMOVZXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vhi128x32u(Vector128<ushort> src)
            => v32u(ConvertToVector128Int32(vshi(src)));

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// 2x32u -> 2x64i
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vhi128x64i(Vector128<uint> src)
            => ConvertToVector128Int64(vshi(src));
    }
}