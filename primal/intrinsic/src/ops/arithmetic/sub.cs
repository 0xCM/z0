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
        public static Vec128<byte> vsub(in Vec128<byte> x, in Vec128<byte> y)
            => Subtract(x,y);

        /// <summary>
        ///  __m128i _mm_sub_epi8 (__m128i a, __m128i b) PSUBB xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vsub(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi16 (__m128i a, __m128i b) PSUBW xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vsub(in Vec128<short> x, in Vec128<short> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi16 (__m128i a, __m128i b) PSUBW xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vsub(in Vec128<ushort> x, in Vec128<ushort> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi32 (__m128i a, __m128i b) PSUBD xmm, xmm/m12
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vsub(in Vec128<int> x, in Vec128<int> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi32 (__m128i a, __m128i b) PSUBD xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vsub(in Vec128<uint> x, in Vec128<uint> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi64 (__m128i a, __m128i b) PSUBQ xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vsub(in Vec128<long> x, in Vec128<long> y)
            => Subtract(x,y);

        /// <summary>
        /// __m128i _mm_sub_epi64 (__m128i a, __m128i b) PSUBQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vsub(in Vec128<ulong> x, in Vec128<ulong> y)
            => Subtract(x,y);

        /// <summary>
        /// __m256i _mm256_sub_epi8 (__m256i a, __m256i b) VPSUBB ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vsub(in Vec256<byte> x, in Vec256<byte> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256i _mm256_sub_epi8 (__m256i a, __m256i b) VPSUBB ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vsub(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256i _mm256_sub_epi16 (__m256i a, __m256i b) VPSUBW ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vsub(in Vec256<short> x, in Vec256<short> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256i _mm256_sub_epi16 (__m256i a, __m256i b) VPSUBW ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vsub(in Vec256<ushort> x, in Vec256<ushort> y)
            => Subtract(x, y);

        /// <summary>
        ///  __m256i _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vsub(in Vec256<int> x, in Vec256<int> y)
            => Subtract(x, y);

        /// <summary>
        ///  __m256i _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vsub(in Vec256<uint> x, in Vec256<uint> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256i _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vsub(in Vec256<long> x, in Vec256<long> y)
            => Subtract(x, y);

        /// <summary>
        /// __m256i _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vsub(in Vec256<ulong> x, in Vec256<ulong> y)
            => Subtract(x, y);

    }
}