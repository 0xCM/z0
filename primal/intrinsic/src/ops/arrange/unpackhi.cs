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
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vunpackhi(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => UnpackHigh(x.xmm, y.xmm);

        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vunpackhi(in Vec128<byte> x, in Vec128<byte> y)
            => UnpackHigh(x.xmm, y.xmm);

        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vunpackhi(in Vec128<short> x, in Vec128<short> y)
            => UnpackHigh(x.xmm, y.xmm);

        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vunpackhi(in Vec128<ushort> x, in Vec128<ushort> y)
            => UnpackHigh(x.xmm, y.xmm);

        /// <summary>
        ///  __m128i _mm_unpackhi_epi32 (__m128i a, __m128i b) PUNPCKHDQ xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vunpackhi(in Vec128<int> x, in Vec128<int> y)
            => UnpackHigh(x.xmm, y.xmm);

        /// <summary>
        ///  __m128i _mm_unpackhi_epi32 (__m128i a, __m128i b) PUNPCKHDQ xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vunpackhi(in Vec128<uint> x, in Vec128<uint> y)
            => UnpackHigh(x.xmm, y.xmm);

        /// <summary>
        /// __m128i _mm_unpackhi_epi64 (__m128i a, __m128i b) PUNPCKHQDQ xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vunpackhi(in Vec128<long> x, in Vec128<long> y)
            => UnpackHigh(x.xmm, y.xmm);

        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vunpackhi(in Vec128<ulong> x, in Vec128<ulong> y)
            => UnpackHigh(x.xmm, y.xmm);

        /// <summary>
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vunpackhi(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => UnpackHigh(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vunpackhi(in Vec256<byte> x, in Vec256<byte> y)
            => UnpackHigh(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vunpackhi(in Vec256<short> x, in Vec256<short> y)
            => UnpackHigh(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vunpackhi(in Vec256<ushort> x, in Vec256<ushort> y)
            => UnpackHigh(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vunpackhi(in Vec256<int> x, in Vec256<int> y)
            => UnpackHigh(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vunpackhi(in Vec256<uint> x, in Vec256<uint> y)
            => UnpackHigh(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vunpackhi(in Vec256<long> x, in Vec256<long> y)
            => UnpackHigh(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vunpackhi(in Vec256<ulong> x, in Vec256<ulong> y)
            => UnpackHigh(x.ymm, y.ymm);
   }
}