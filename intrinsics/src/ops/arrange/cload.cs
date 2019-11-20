//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_maskload_epi32 (int const* mem_addr, __m128i mask) VPMASKMOVD xmm, xmm, m128
        /// Vectorized Conditional Load
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vcload(ref int src, Vector128<int> mask)
            => MaskLoad(ptr(ref src), mask);

        /// <summary>
        /// __m128i _mm_maskload_epi32 (int const* mem_addr, __m128i mask) VPMASKMOVD xmm, xmm, m128
        /// Vectorized Conditional Load
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vcload(ref uint src, Vector128<uint> mask)
            => MaskLoad(ptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, m256
        /// Vectorized Conditional Load
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vcload(ref int src, Vector256<int> mask)
            => MaskLoad(ptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, m256
        /// Vectorized Conditional Load
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vcload(ref uint src, Vector256<uint> mask)
            => MaskLoad(ptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, m256
        /// Vectorized Conditional Load
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vcload(ref long src, Vector256<long> mask)
            => MaskLoad(ptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, m256
        /// Vectorized Conditional Load
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vcload(ref ulong src, Vector256<ulong> mask)
            => MaskLoad(ptr(ref src), mask); 
    }

}