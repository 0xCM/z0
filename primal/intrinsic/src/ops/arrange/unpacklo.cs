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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_unpacklo_epi8 (__m128i a, __m128i b) PUNPCKLBW xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vunpacklo(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => UnpackLow(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_unpacklo_epi8 (__m128i a, __m128i b) PUNPCKLBW xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vunpacklo(in Vec128<byte> x, in Vec128<byte> y)
            => UnpackLow(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_unpacklo_epi16 (__m128i a, __m128i b) PUNPCKLWD xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vunpacklo(in Vec128<short> x, in Vec128<short> y)
            => UnpackLow(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_unpacklo_epi16 (__m128i a, __m128i b) PUNPCKLWD xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vunpacklo(in Vec128<ushort> x, in Vec128<ushort> y)
            => UnpackLow(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_unpacklo_epi32 (__m128i a, __m128i b) PUNPCKLDQ xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vunpacklo(in Vec128<int> x, in Vec128<int> y)
            => UnpackLow(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_unpacklo_epi32 (__m128i a, __m128i b) PUNPCKLDQ xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vunpacklo(in Vec128<uint> x, in Vec128<uint> y)
            => UnpackLow(x.xmm, y.xmm);

        /// <summary>
        ///  __m128i _mm_unpacklo_epi64 (__m128i a, __m128i b) PUNPCKLQDQ xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vunpacklo(in Vec128<long> x, in Vec128<long> y)
            => UnpackLow(x.xmm, y.xmm);

        /// <summary>
        ///  __m128i _mm_unpacklo_epi64 (__m128i a, __m128i b) PUNPCKLQDQ xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vunpacklo(in Vec128<ulong> x, in Vec128<ulong> y)
            => UnpackLow(x.xmm, y.xmm);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vunpacklo(in Vec256<byte> x, in Vec256<byte> y)
            => UnpackLow(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vunpacklo(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => UnpackLow(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vunpacklo(in Vec256<short> x, in Vec256<short> y)
            => UnpackLow(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vunpacklo(in Vec256<ushort> x, in Vec256<ushort> y)
            => UnpackLow(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vunpacklo(in Vec256<int> x, in Vec256<int> y)
            => UnpackLow(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vunpacklo(in Vec256<uint> x, in Vec256<uint> y)
            => UnpackLow(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vunpacklo(in Vec256<long> x, in Vec256<long> y)
            => UnpackLow(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256
        /// </summary>
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vunpacklo(in Vec256<ulong> x, in Vec256<ulong> y)
            => UnpackLow(x.ymm, y.ymm);
   }

}