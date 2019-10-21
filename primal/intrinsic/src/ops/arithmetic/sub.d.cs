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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;

    partial class dinx
    {

        /// <summary>
        /// __m128i _mm_sub_epi8 (__m128i a, __m128i b) PSUBB xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vsub(Vector128<byte> x, Vector128<byte> y)
            => Subtract(x,y);

        /// <summary>
        ///  __m128i _mm_sub_epi8 (__m128i a, __m128i b) PSUBB xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vsub(Vector128<sbyte> x, Vector128<sbyte> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi16 (__m128i a, __m128i b) PSUBW xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vsub(Vector128<short> x, Vector128<short> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi16 (__m128i a, __m128i b) PSUBW xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsub(Vector128<ushort> x, Vector128<ushort> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi32 (__m128i a, __m128i b) PSUBD xmm, xmm/m12
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsub(Vector128<int> x, Vector128<int> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi32 (__m128i a, __m128i b) PSUBD xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsub(Vector128<uint> x, Vector128<uint> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi64 (__m128i a, __m128i b) PSUBQ xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsub(Vector128<long> x, Vector128<long> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi64 (__m128i a, __m128i b) PSUBQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsub(Vector128<ulong> x, Vector128<ulong> y)
            => Subtract(x,y);

        /// <summary>
        /// __m256i _mm256_sub_epi8 (__m256i a, __m256i b) VPSUBB ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vsub(Vector256<byte> x, Vector256<byte> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256i _mm256_sub_epi8 (__m256i a, __m256i b) VPSUBB ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsub(Vector256<sbyte> x, Vector256<sbyte> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256i _mm256_sub_epi16 (__m256i a, __m256i b) VPSUBW ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsub(Vector256<short> x, Vector256<short> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256i _mm256_sub_epi16 (__m256i a, __m256i b) VPSUBW ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsub(Vector256<ushort> x, Vector256<ushort> y)
            => Subtract(x, y);

        /// <summary>
        ///  __m256i _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsub(Vector256<int> x, Vector256<int> y)
            => Subtract(x, y);

        /// <summary>
        ///  __m256i _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsub(Vector256<uint> x, Vector256<uint> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256i _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsub(Vector256<long> x, Vector256<long> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256i _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsub(Vector256<ulong> x, Vector256<ulong> y)
            => Subtract(x, y);

    }
}