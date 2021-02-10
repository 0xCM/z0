//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Part;
    using static SpanBlocks;
    using static memory;

    partial struct cpu
    {
        /// <summary>
        /// __m128 _mm_maskload_ps (float const * mem_addr, __m128i mask) VMASKMOVPS xmm,xmm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<float> vmaskload(ref float src, Vector128<float> mask)
            => MaskLoad(gptr(src), mask);

        /// <summary>
        /// __m128 _mm_maskload_ps (float const * mem_addr, __m128i mask) VMASKMOVPS xmm,xmm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<double> vmaskload(ref double src, Vector128<double> mask)
            => MaskLoad(gptr(src), mask);

        /// <summary>
        /// __m256d _mm256_maskload_pd (double const * mem_addr, __m256i mask) VMASKMOVPD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<float> vmaskload(ref float src, Vector256<float> mask)
            => MaskLoad(gptr(src), mask);

        /// <summary>
        /// __m256d _mm256_maskload_pd (double const * mem_addr, __m256i mask) VMASKMOVPD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<double> vmaskload(ref double src, Vector256<double> mask)
            => MaskLoad(gptr(src), mask);

        /// <summary>
        /// __m128i _mm_maskload_epi32 (int const* mem_addr, __m128i mask) VPMASKMOVD xmm, xmm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vmaskload(in SpanBlock128<int> src, Vector128<int> mask)
            => MaskLoad(ptr(src), mask);

        /// <summary>
        /// __m128i _mm_maskload_epi32 (int const* mem_addr, __m128i mask) VPMASKMOVD xmm, xmm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vmaskload(in SpanBlock128<uint> src, Vector128<uint> mask)
            => MaskLoad(ptr(src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<int> vmaskload(in SpanBlock256<int> src, Vector256<int> mask)
            => MaskLoad(ptr(src), mask);

        /// <summary>
        /// Conditionally loads source cells per a specified mask
        /// __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vmaskload(in SpanBlock256<uint> src, Vector256<uint> mask)
            => MaskLoad(ptr(src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vmaskload(in SpanBlock256<long> src, Vector256<long> mask)
            => MaskLoad(ptr(src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vmaskload(in SpanBlock256<ulong> src, Vector256<ulong> mask)
            => MaskLoad(ptr(src), mask);
    }
}