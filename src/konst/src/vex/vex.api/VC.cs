//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    public readonly partial struct VC
    {
        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// </summary>
        /// <param name="a">The source vector</param>
        /// <param name="imm8">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> _mm256_slli_epi32(Vector256<uint> a, [Imm] byte imm8)
            => cpu.vsll(a, (byte)imm8);

        /// <summary>
        ///  __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> _mm256_lddqu_si256(in uint src)
            => cpu.vload(w256, src);

        /// <summary>
        ///  __m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m25
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Or]
        public static Vector256<uint> _mm256_or_si256(Vector256<uint> a, Vector256<uint> b)
            => cpu.vor(a, b);

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> _mm256_lddqu_si256(in SpanBlock256<uint> src, int block)
            => cpu.vload(src, block);

    }
}