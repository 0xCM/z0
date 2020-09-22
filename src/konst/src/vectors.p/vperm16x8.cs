//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
        
    using static Konst; 

    partial struct z
    {        
        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vperm16x8(Vector128<byte> src, Vector128<byte> spec)
            => Shuffle(src, spec);

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vperm16x8(Vector128<sbyte> src, Vector128<byte> spec)
            => Shuffle(src, v8i(spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vperm16x8(Vector128<short> src, Vector128<byte> spec)
            => v16i(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vperm16x8(Vector128<ushort> src, Vector128<byte> spec)
            => v16u(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vperm16x8(Vector128<int> src, Vector128<byte> spec)
            => v32i(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vperm16x8(Vector128<uint> src, Vector128<byte> spec)
            => v32u(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vperm16x8(Vector128<long> src, Vector128<byte> spec)
            => v64i(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vperm16x8(Vector128<ulong> src, Vector128<byte> spec)
            => v64u(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vperm16x8(Vector256<byte> src, Vector256<byte> spec)
            => Shuffle(src, spec);

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vperm16x8(Vector256<sbyte> src, Vector256<byte> spec)
            => Shuffle(src, v8i(spec));

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vperm16x8(Vector256<short> src, Vector256<byte> spec)
            => v16i(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vperm16x8(Vector256<ushort> src, Vector256<byte> spec)
            => v16u(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vperm16x8(Vector256<int> src, Vector256<byte> spec)
            => v32i(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vperm16x8(Vector256<uint> src, Vector256<byte> spec)
            => v32u(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vperm16x8(Vector256<long> src, Vector256<byte> spec)
            => v64i(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vperm16x8(Vector256<ulong> src, Vector256<byte> spec)
            => v64u(Shuffle(v8u(src), spec));
    }
}