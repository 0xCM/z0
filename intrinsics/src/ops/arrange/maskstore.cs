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

    partial class dinx
    {
        /// <summary>
        /// void _mm_maskstore_epi32 (int* mem_addr, __m128i mask, __m128i a) VPMASKMOVD m128, xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<int> src, Vector128<int> mask, ref int dst)
            => MaskStore(ptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_epi32 (int* mem_addr, __m256i mask, __m256i a) VPMASKMOVD m256, ymm, ymm
        /// Conditionally stores source vector components to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<int> src, Vector256<int> mask, ref int dst)
            => MaskStore(ptr(ref dst), src, mask);

        /// <summary>
        /// void _mm256_maskstore_epi32 (int* mem_addr, __m256i mask, __m256i a) VPMASKMOVD m256, ymm, ymm
        /// Conditionally stores source vector components to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<uint> src, Vector256<uint> mask, ref uint dst)
            => MaskStore(ptr(ref dst), src, mask);

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// Conditionally stores source vector components to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<long> src, Vector256<long> mask, ref long dst)
            => MaskStore(ptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<ulong> src, Vector256<ulong> mask, ref ulong dst)
            => MaskStore(ptr(ref dst), src, mask);
    }
}