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
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vmaskload(ref int src, Vector128<int> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vmaskload(ref int src, Vector256<int> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vmaskload(ref uint src, Vector256<uint> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vmaskload(ref long src, Vector256<long> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmaskload(ref ulong src, Vector256<ulong> mask)
            => MaskLoad(refptr(ref src), mask); 
    }

}