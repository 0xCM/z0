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
        /// Creates a 128-bit Vectortor where the lower 64 bits are taken from the
        /// lower 64 bits of the first source Vectortor and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> unpacklo(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m128i _mm_unpacklo_epi8 (__m128i a, __m128i b) PUNPCKLBW xmm, xmm/m128
        /// Creates a 128-bit Vectortor where the lower 64 bits are taken from the
        /// lower 64 bits of the first source Vectortor and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> unpacklo(Vector128<byte> lhs, Vector128<byte> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m128i _mm_unpacklo_epi16 (__m128i a, __m128i b) PUNPCKLWD xmm, xmm/m128
        /// Creates a 128-bit Vectortor where the lower 64 bits are taken from the
        /// lower 64 bits of the first source Vectortor and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector128<short> unpacklo(Vector128<short> lhs, Vector128<short> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m128i _mm_unpacklo_epi16 (__m128i a, __m128i b) PUNPCKLWD xmm, xmm/m128
        /// Creates a 128-bit Vectortor where the lower 64 bits are taken from the
        /// lower 64 bits of the first source Vectortor and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> unpacklo(Vector128<ushort> lhs, Vector128<ushort> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m128i _mm_unpacklo_epi32 (__m128i a, __m128i b) PUNPCKLDQ xmm, xmm/m128
        /// Creates a 128-bit Vectortor where the lower 64 bits are taken from the
        /// lower 64 bits of the first source Vectortor and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector128<int> unpacklo(Vector128<int> lhs, Vector128<int> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m128i _mm_unpacklo_epi32 (__m128i a, __m128i b) PUNPCKLDQ xmm, xmm/m128
        /// Creates a 128-bit Vectortor where the lower 64 bits are taken from the
        /// lower 64 bits of the first source Vectortor and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> unpacklo(Vector128<uint> lhs, Vector128<uint> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        ///  __m128i _mm_unpacklo_epi64 (__m128i a, __m128i b) PUNPCKLQDQ xmm, xmm/m128
        /// Creates a 128-bit Vectortor where the lower 64 bits are taken from the
        /// lower 64 bits of the first source Vectortor and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector128<long> unpacklo(Vector128<long> lhs, Vector128<long> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        ///  __m128i _mm_unpacklo_epi64 (__m128i a, __m128i b) PUNPCKLQDQ xmm, xmm/m128
        /// Creates a 128-bit Vectortor where the lower 64 bits are taken from the
        /// lower 64 bits of the first source Vectortor and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> unpacklo(Vector128<ulong> lhs, Vector128<ulong> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256
        /// Creates a 256-bit Vectortor where the lower 128 bits are taken from the
        /// lower 128 bits of the first source Vectortor and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> unpacklo(Vector256<byte> lhs, Vector256<byte> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256
        /// Creates a 256-bit Vectortor where the lower 128 bits are taken from the
        /// lower 128 bits of the first source Vectortor and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> unpacklo(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256
        /// Creates a 256-bit Vectortor where the lower 128 bits are taken from the
        /// lower 128 bits of the first source Vectortor and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector256<short> unpacklo(Vector256<short> lhs, Vector256<short> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256
        /// Creates a 256-bit Vectortor where the lower 128 bits are taken from the
        /// lower 128 bits of the first source Vectortor and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> unpacklo(Vector256<ushort> lhs, Vector256<ushort> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit Vectortor where the lower 128 bits are taken from the
        /// lower 128 bits of the first source Vectortor and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector256<int> unpacklo(Vector256<int> lhs, Vector256<int> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit Vectortor where the lower 128 bits are taken from the
        /// lower 128 bits of the first source Vectortor and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> unpacklo(Vector256<uint> lhs, Vector256<uint> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit Vectortor where the lower 128 bits are taken from the
        /// lower 128 bits of the first source Vectortor and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector256<long> unpacklo(Vector256<long> lhs, Vector256<long> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256
        /// </summary>
        /// Creates a 256-bit Vectortor where the lower 128 bits are taken from the
        /// lower 128 bits of the first source Vectortor and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source Vectortor
        /// </summary>
        /// <param name="lhs">The left source Vectortor</param>
        /// <param name="rhs">The right source Vectortor</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> unpacklo(Vector256<ulong> lhs, Vector256<ulong> rhs)
            => UnpackLow(lhs,rhs);
   }

}