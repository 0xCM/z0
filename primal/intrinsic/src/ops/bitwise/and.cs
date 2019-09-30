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
    
    using static As;
    using static zfunc;

    partial class dinx
    {

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vand(in Vec128<byte> x, in Vec128<byte> y)
            => And(x, y.xmm);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vand(in Vec128<short> x, in Vec128<short> y)
            => And(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vand(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => And(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vand(in Vec128<ushort> x, in Vec128<ushort> y)
            => And(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vand(in Vec128<int> x, in Vec128<int> y)
            => And(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vand(in Vec128<uint> x, in Vec128<uint> y)
            => And(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vand(in Vec128<long> x, in Vec128<long> y)
            => And(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_and_si128 (__m128i a, __m128i b) PAND xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vand(in Vec128<ulong> x, in Vec128<ulong> y)
            => And(x.xmm, y.xmm);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vand(in Vec256<byte> x, in Vec256<byte> y)
            => And(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vand(in Vec256<short> x, in Vec256<short> y)
            => And(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vand(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => And(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vand(in Vec256<ushort> x, in Vec256<ushort> y)
            => And(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vand(in Vec256<int> x, in Vec256<int> y)
            => And(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vand(in Vec256<uint> x, in Vec256<uint> y)
            => And(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vand(in Vec256<long> x, in Vec256<long> y)
            => And(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vand(in Vec256<ulong> x, in Vec256<ulong> y)
            => And(x.ymm, y.ymm);

     }
}