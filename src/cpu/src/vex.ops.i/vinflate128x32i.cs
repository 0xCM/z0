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

    using static Part;
    using static memory;

    partial struct cpu
    {
        /// <summary>
        /// __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vinflate128x32i(Vector128<sbyte> src)
            => ConvertToVector128Int32(src);

        /// <summary>
        /// PMOVSXBD xmm, m32
        /// 4x8i -> 4x32i
        /// </summary>
        /// <param name="src">The memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vinflate128x32i(in SpanBlock32<sbyte> src, uint offset)
            => ConvertToVector128Int32(gptr(src[offset]));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32i
        /// </summary>
        /// <param name="src">The memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vinflate128x32i(in SpanBlock32<byte> src, uint offset)
            => ConvertToVector128Int32(gptr(src[offset]));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16i -> 4x32i
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vinflate128x32i(in SpanBlock64<short> src, uint offset)
            => ConvertToVector128Int32(gptr(src[offset]));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16i -> 4x32i
        /// Projects 4 16-bit signed integers onto 4 32-bit signed integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vmove4x32i(in short src)
            => ConvertToVector128Int32(gptr(src));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32i
        /// Projects four unsigned 8-bit integers onto 4 signed 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vmove2x32i(in byte src)
            => ConvertToVector128Int32(gptr(src));
    }
}