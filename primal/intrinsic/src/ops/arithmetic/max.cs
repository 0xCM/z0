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
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<byte> vmax(in Vec128<byte> x, in Vec128<byte> y)
            => Max(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_max_epi8 (__m128i a, __m128i b) PMAXSB xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vmax(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => Max(x.xmm, y.xmm);

        /// <summary>
        ///  __m128i _mm_max_epi16 (__m128i a, __m128i b) PMAXSW xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<short> vmax(in Vec128<short> x, in Vec128<short> y)
            => Max(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_max_epu16 (__m128i a, __m128i b) PMAXUW xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vmax(in Vec128<ushort> x, in Vec128<ushort> y)
            => Max(x.xmm, y.xmm);

        /// <summary>
        ///  __m128i _mm_max_epi32 (__m128i a, __m128i b) PMAXSD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<int> vmax(in Vec128<int> x, in Vec128<int> y)
            => Max(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_max_epu32 (__m128i a, __m128i b) PMAXUD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vmax(in Vec128<uint> x, in Vec128<uint> y)
            => Max(x.xmm, y.xmm);

        /// <summary>
        /// __m256i _mm256_max_epu8 (__m256i a, __m256i b) VPMAXUB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vmax(in Vec256<byte> x, in Vec256<byte> y)
            => Max(x.ymm, y.ymm);

        /// <summary>
        ///  __m256i _mm256_max_epi8 (__m256i a, __m256i b)VPMAXSB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vmax(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => Max(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_max_epi16 (__m256i a, __m256i b) VPMAXSW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<short> vmax(in Vec256<short> x, in Vec256<short> y)
            => Max(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_max_epu16 (__m256i a, __m256i b) VPMAXUW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vmax(in Vec256<ushort> x, in Vec256<ushort> y)
            => Max(x.ymm, y.ymm);

        /// <summary>
        ///  __m256i _mm256_max_epi32 (__m256i a, __m256i b) VPMAXSD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<int> vmax(in Vec256<int> x, in Vec256<int> y)
            => Max(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_max_epu32 (__m256i a, __m256i b) VPMAXUD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vmax(in Vec256<uint> x, in Vec256<uint> y)
            => Max(x.ymm, y.ymm);

    }
}