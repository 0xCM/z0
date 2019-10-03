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
        [MethodImpl(Inline)]
        public static Vec128<byte> vmin(in Vec128<byte> x, in Vec128<byte> y)
            => Min(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_min_epi8 (__m128i a, __m128i b)PMINSB xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vmin(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => Min(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<short> vmin(in Vec128<short> x, in Vec128<short> y)
            => Min(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_min_epu16 (__m128i a, __m128i b) PMINUW xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vmin(in Vec128<ushort> x, in Vec128<ushort> y)
            => Min(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_min_epu32 (__m128i a, __m128i b) PMINUD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<int> vmin(in Vec128<int> x, in Vec128<int> y)
            => Min(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_min_epu32 (__m128i a, __m128i b) PMINUD xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vmin(in Vec128<uint> x, in Vec128<uint> y)
            => Min(x.xmm, y.xmm);

        /// <summary>
        /// __m256i _mm256_min_epu8 (__m256i a, __m256i b) VPMINUB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vmin(in Vec256<byte> x, in Vec256<byte> y)
            => Min(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_min_epi8 (__m256i a, __m256i b)VPMINSB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vmin(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => Min(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_min_epi16 (__m256i a, __m256i b)VPMINSW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<short> vmin(in Vec256<short> x, in Vec256<short> y)
            => Min(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_min_epu16 (__m256i a, __m256i b)VPMINUW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vmin(in Vec256<ushort> x, in Vec256<ushort> y)
            => Min(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_min_epi32 (__m256i a, __m256i b)VPMINSD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<int> vmin(in Vec256<int> x, in Vec256<int> y)
            => Min(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_min_epu32 (__m256i a, __m256i b) VPMINUD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vmin(in Vec256<uint> x, in Vec256<uint> y)
            => Min(x.ymm, y.ymm);


    }
}