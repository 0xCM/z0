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

    using static System.Runtime.Intrinsics.X86.Sse;    
    using static System.Runtime.Intrinsics.X86.Sse2;    
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    
    using static zfunc;

    public partial class dinx
    {
        /// <summary>
        /// __m128i _mm_max_epu8 (__m128i a, __m128i b) PMAXUB xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<byte> max(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m128i _mm_max_epi8 (__m128i a, __m128i b) PMAXSB xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> max(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Max(lhs, rhs);

        /// <summary>
        ///  __m128i _mm_max_epi16 (__m128i a, __m128i b) PMAXSW xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128<short> max(in Vec128<short> lhs, in Vec128<short> rhs)
            => Max(lhs, rhs);
 
        /// <summary>
        ///  __m128i _mm_max_epi32 (__m128i a, __m128i b) PMAXSD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128<int> max(in Vec128<int> lhs, in Vec128<int> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m128i _mm_max_epu32 (__m128i a, __m128i b) PMAXUD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128<uint> max(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_max_epu8 (__m256i a, __m256i b) VPMAXUB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec256<byte> max(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Max(lhs, rhs);

        /// <summary>
        ///  __m256i _mm256_max_epi8 (__m256i a, __m256i b)VPMAXSB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> max(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_max_epi16 (__m256i a, __m256i b) VPMAXSW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec256<short> max(in Vec256<short> lhs, in Vec256<short> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m128i _mm_max_epu16 (__m128i a, __m128i b) PMAXUW xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> max(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_max_epu16 (__m256i a, __m256i b) VPMAXUW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> max(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Max(lhs, rhs);

        /// <summary>
        ///  __m256i _mm256_max_epi32 (__m256i a, __m256i b) VPMAXSD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec256<int> max(in Vec256<int> lhs, in Vec256<int> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_max_epu32 (__m256i a, __m256i b) VPMAXUD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec256<uint> max(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Max(lhs, rhs);

    }
}