//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// 8x8i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vmaphi(Vector128<sbyte> src, N128 w, short k)
            => ConvertToVector128Int16(vshi(src));

        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// 8x8i -> 8x16u
        /// dst[i] = src[i], i = 8, ..., 15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vmaphi(Vector128<sbyte> src, N128 w, ushort k)
            => v16u(ConvertToVector128Int16(vshi(src)));

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi32 (__m128i a) VPMOVSXBD ymm, xmm/m128
        /// 8x8i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vmaphi(Vector128<sbyte> src, N256 w, int k)
            => ConvertToVector256Int32(vshi(src));

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// 8x8u -> 8x16i
        /// src[i] -> dst[i], i = 8,.., 15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vmaphi(Vector128<byte> src, N128 w, short k)
            =>  ConvertToVector128Int16(vshi(src));

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// 8x8u -> 8x16u
        /// src[i] -> dst[i], i = 0,.., 7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vmaphi(Vector128<byte> src, N128 w, ushort k)
            => v16u(ConvertToVector128Int16(vshi(src)));

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extends 8 8-bit integers from the low 8 bytes of the source to 8 32-bit integers in the target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vmaphi(Vector128<byte> src, N256 w, uint k)
            => v32u(ConvertToVector256Int32(vshi(src)));

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extends 8 8-bit integers from the low 8 bytes of the source to 8 32-bit integers in the target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vmaphi(Vector128<byte> src, N256 w, int k)
            => ConvertToVector256Int32(vshi(src));

        /// <summary>
        /// __m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vmaphi(Vector128<short> src, N128 w, int k)
            => ConvertToVector128Int32(vshi(src));

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x16u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vmaphi(Vector128<short> src, N256 w, long k)
            => ConvertToVector256Int64(vshi(src));

        /// <summary>
        /// __m128i _mm_cvtepu16_epi32 (__m128i a) PMOVZXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vmaphi(Vector128<ushort> src, N128 w, uint k)
            => v32u(ConvertToVector128Int32(vshi(src)));

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a) VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vmaphi(Vector128<ushort> src, N256 w, long k)
            => ConvertToVector256Int64(vshi(src));

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a) VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vmaphi(Vector128<ushort> src, N256 w, ulong k)
            => v64u(ConvertToVector256Int64(vshi(src)));

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// 2x32u -> 2x64i
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vmaphi(Vector128<uint> src, N128 w, long k)
            => ConvertToVector128Int64(vshi(src));

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// 2x32u -> 2x64u
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vmaphi(Vector128<uint> src, N128 w, ulong k)
            => v64u(ConvertToVector128Int64(vshi(src)));

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vmaphi(Vector256<byte> src, N256 w, ushort k)
            => v16u(ConvertToVector256Int16(vhi(src)));

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vmaphi(Vector256<byte> src, N256 w, short k)
            => ConvertToVector256Int16(vhi(src));

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vmaphi(Vector256<short> src, N256 w, int k)
            => ConvertToVector256Int32(vhi(src));

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vmaphi(Vector256<ushort> src, N256 w, uint k)
            => v32u(ConvertToVector256Int32(vhi(src)));

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32i -> 4x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vmaphi(Vector256<int> src, N256 w, long k)
            => ConvertToVector256Int64(vhi(src));

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="k">The target cell kind selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vmaphi(Vector256<uint> src, N256 w, ulong k)
            => v64u(ConvertToVector256Int64(vhi(src)));
    }
}