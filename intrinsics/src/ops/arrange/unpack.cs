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
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vunpacklo(Vector128<sbyte> x, Vector128<sbyte> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m128i _mm_unpacklo_epi8 (__m128i a, __m128i b) PUNPCKLBW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vunpacklo(Vector128<byte> x, Vector128<byte> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m128i _mm_unpacklo_epi16 (__m128i a, __m128i b) PUNPCKLWD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vunpacklo(Vector128<short> x, Vector128<short> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m128i _mm_unpacklo_epi16 (__m128i a, __m128i b) PUNPCKLWD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vunpacklo(Vector128<ushort> x, Vector128<ushort> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m128i _mm_unpacklo_epi32 (__m128i a, __m128i b) PUNPCKLDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vunpacklo(Vector128<int> x, Vector128<int> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m128i _mm_unpacklo_epi32 (__m128i a, __m128i b) PUNPCKLDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vunpacklo(Vector128<uint> x, Vector128<uint> y)
            => UnpackLow(x, y);

        /// <summary>
        ///  __m128i _mm_unpacklo_epi64 (__m128i a, __m128i b) PUNPCKLQDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vunpacklo(Vector128<long> x, Vector128<long> y)
            => UnpackLow(x, y);

        /// <summary>
        ///  __m128i _mm_unpacklo_epi64 (__m128i a, __m128i b) PUNPCKLQDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vunpacklo(Vector128<ulong> x, Vector128<ulong> y)
            => UnpackLow(x, y);

        /// <summary>
        ///  __m128i _mm_unpackhi_epi8 (__m128i a, __m128i b)PUNPCKHBW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vunpackhi(Vector128<sbyte> x, Vector128<sbyte> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m128i _mm_unpackhi_epi8 (__m128i a, __m128i b)PUNPCKHBW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vunpackhi(Vector128<byte> x, Vector128<byte> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m128i _mm_unpackhi_epi16 (__m128i a, __m128i b)PUNPCKHWD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vunpackhi(Vector128<short> x, Vector128<short> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m128i _mm_unpackhi_epi16 (__m128i a, __m128i b) PUNPCKHWD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vunpackhi(Vector128<ushort> x, Vector128<ushort> y)
            => UnpackHigh(x, y);

        /// <summary>
        ///  __m128i _mm_unpackhi_epi32 (__m128i a, __m128i b) PUNPCKHDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vunpackhi(Vector128<int> x, Vector128<int> y)
            => UnpackHigh(x, y);

        /// <summary>
        ///  __m128i _mm_unpackhi_epi32 (__m128i a, __m128i b) PUNPCKHDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vunpackhi(Vector128<uint> x, Vector128<uint> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m128i _mm_unpackhi_epi64 (__m128i a, __m128i b) PUNPCKHQDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vunpackhi(Vector128<long> x, Vector128<long> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m128i _mm_unpackhi_epi64 (__m128i a, __m128i b)PUNPCKHQDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vunpackhi(Vector128<ulong> x, Vector128<ulong> y)
            => UnpackHigh(x, y);
 
        /// <summary>
        /// __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256
        /// Forms the vector z := [vhi(x), vhi(y)]
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vunpacklo(Vector256<sbyte> x, Vector256<sbyte> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        /// <remarks>
        /// x := [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31]
        /// y := [32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63]
        /// z := [ 0, 32,  1, 33,  2, 34,  3, 35,  4, 36,  5, 37,  6, 38,  7, 39, 16, 48, 17, 49, 18, 50, 19, 51, 20, 52, 21, 53, 22, 54, 23, 55]
        /// </remarks>
        [MethodImpl(Inline)]
        public static Vector256<byte> vunpacklo(Vector256<byte> x, Vector256<byte> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        /// <remarks>
        /// x := [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31]
        /// y := [32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63]
        /// z := [ 8, 40,  9, 41, 10, 42, 11, 43, 12, 44, 13, 45, 14, 46, 15, 47, 24, 56, 25, 57, 26, 58, 27, 59, 28, 60, 29, 61, 30, 62, 31, 63]
        /// </remarks>
        [MethodImpl(Inline)]
        public static Vector256<byte> vunpackhi(Vector256<byte> x, Vector256<byte> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vunpacklo(Vector256<short> x, Vector256<short> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vunpacklo(Vector256<ushort> x, Vector256<ushort> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vunpacklo(Vector256<int> x, Vector256<int> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vunpacklo(Vector256<uint> x, Vector256<uint> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vunpacklo(Vector256<long> x, Vector256<long> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256
        /// [0, 1, 2, 3] [4, 5, 6, 7] -> [0, 4, 2, 6]
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vunpacklo(Vector256<ulong> x, Vector256<ulong> y)
            => UnpackLow(x,y);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256
        /// [0, 1, 2, 3] [4, 5, 6, 7] -> [1, 5, 3, 7]
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vunpackhi(Vector256<ulong> x, Vector256<ulong> y)
            => UnpackHigh(x, y);
 
        /// <summary>
        /// __m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vunpackhi(Vector256<sbyte> x, Vector256<sbyte> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vunpackhi(Vector256<short> x, Vector256<short> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vunpackhi(Vector256<ushort> x, Vector256<ushort> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vunpackhi(Vector256<int> x, Vector256<int> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vunpackhi(Vector256<uint> x, Vector256<uint> y)
            => UnpackHigh(x, y);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vunpackhi(Vector256<long> x, Vector256<long> y)
            => UnpackHigh(x, y);
 
   }
}