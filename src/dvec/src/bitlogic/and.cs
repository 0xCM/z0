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
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector128<byte> vand(Vector128<byte> x, Vector128<byte> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector128<short> vand(Vector128<short> x, Vector128<short> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector128<sbyte> vand(Vector128<sbyte> x, Vector128<sbyte> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector128<ushort> vand(Vector128<ushort> x, Vector128<ushort> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector128<int> vand(Vector128<int> x, Vector128<int> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector128<uint> vand(Vector128<uint> x, Vector128<uint> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector128<long> vand(Vector128<long> x, Vector128<long> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector128<ulong> vand(Vector128<ulong> x, Vector128<ulong> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector256<byte> vand(Vector256<byte> x, Vector256<byte> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector256<short> vand(Vector256<short> x, Vector256<short> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector256<sbyte> vand(Vector256<sbyte> x, Vector256<sbyte> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector256<ushort> vand(Vector256<ushort> x, Vector256<ushort> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector256<int> vand(Vector256<int> x, Vector256<int> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector256<uint> vand(Vector256<uint> x, Vector256<uint> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector256<long> vand(Vector256<long> x, Vector256<long> y)
            => V0d.vand(x,y);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), And]
        public static Vector256<ulong> vand(Vector256<ulong> x, Vector256<ulong> y)
            => V0d.vand(x,y);

        [MethodImpl(Inline), And]
        public static Vector256<byte> vand8u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
            => V0d.vand8u(x,y);
     }
}