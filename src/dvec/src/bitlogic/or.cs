//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class dvec
    {
        /// <summary>
        ///  __m128i _mm_or_si128 (__m128i a, __m128i b)POR xmm, xmm/m128
        /// Computes the bitwise or between the source operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vor(Vector128<byte> x, Vector128<byte> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m128i _mm_or_si128 (__m128i a, __m128i b)POR xmm, xmm/m128
        /// Computes the bitwise or between the source operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vor(Vector128<short> x, Vector128<short> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m128i _mm_or_si128 (__m128i a, __m128i b)POR xmm, xmm/m128
        /// Computes the bitwise or between the source operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vor(Vector128<sbyte> x, Vector128<sbyte> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m128i _mm_or_si128 (__m128i a, __m128i b)POR xmm, xmm/m128
        /// Computes the bitwise or between the source operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vor(Vector128<ushort> x, Vector128<ushort> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m128i _mm_or_si128 (__m128i a, __m128i b)POR xmm, xmm/m128
        /// Computes the bitwise or between the source operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vor(Vector128<int> x, Vector128<int> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m128i _mm_or_si128 (__m128i a, __m128i b)POR xmm, xmm/m128
        /// Computes the bitwise or between the source operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vor(Vector128<uint> x, Vector128<uint> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m128i _mm_or_si128 (__m128i a, __m128i b)POR xmm, xmm/m128
        /// Computes the bitwise or between the source operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vor(Vector128<long> x, Vector128<long> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m128i _mm_or_si128 (__m128i a, __m128i b)POR xmm, xmm/m128
        /// Computes the bitwise or between the source operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vor(Vector128<ulong> x, Vector128<ulong> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m128i _mm_or_si128 (__m128i a, __m128i b)POR xmm, xmm/m128
        /// Computes the bitwise or between the source operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vor(Vector256<byte> x, Vector256<byte> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m256i _mm256_or_si256 (__m256i a, __m256i b)VPOR ymm, ymm, ymm/m25
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vor(Vector256<short> x, Vector256<short> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m256i _mm256_or_si256 (__m256i a, __m256i b)VPOR ymm, ymm, ymm/m25
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vor(Vector256<sbyte> x, Vector256<sbyte> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m256i _mm256_or_si256 (__m256i a, __m256i b)VPOR ymm, ymm, ymm/m25
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vor(Vector256<ushort> x, Vector256<ushort> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m256i _mm256_or_si256 (__m256i a, __m256i b)VPOR ymm, ymm, ymm/m25
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vor(Vector256<int> x, Vector256<int> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m256i _mm256_or_si256 (__m256i a, __m256i b)VPOR ymm, ymm, ymm/m25
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vor(Vector256<uint> x, Vector256<uint> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m256i _mm256_or_si256 (__m256i a, __m256i b)VPOR ymm, ymm, ymm/m25
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vor(Vector256<long> x, Vector256<long> y)
            => z.vor(x,y);

        /// <summary>
        ///  __m256i _mm256_or_si256 (__m256i a, __m256i b)VPOR ymm, ymm, ymm/m25
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vor(Vector256<ulong> x, Vector256<ulong> y)
            => z.vor(x,y);
    }
}