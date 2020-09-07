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
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;

    using static Konst;
    using static z;

    partial struct z
    {
        // ~ Scalar conversions

        /// <summary>
        /// int _mm_cvtsi128_si32 (__m128i a)MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static int convert(Vector128<int> src, N32 w, int t = default)
            => ConvertToInt32(src);

        /// <summary>
        /// int _mm_cvtsi128_si32 (__m128i a)MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static uint convert(Vector128<uint> src, N32 w, uint t = default)
            => ConvertToUInt32(src);

        /// <summary>
        /// __int64 _mm_cvtsi128_si64 (__m128i a)MOVQ reg/m64, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static long convert(Vector128<long> src, N64 w, long t = default)
            => ConvertToInt64(src);

        /// <summary>
        /// __int64 _mm_cvtsi128_si64 (__m128i a)MOVQ reg/m64, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong convert(Vector128<ulong> src, N64 w, ulong t = default)
            => ConvertToUInt64(src);
    }
}