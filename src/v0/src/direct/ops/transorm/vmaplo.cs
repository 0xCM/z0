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

    partial struct V0d
    {
        // ~ 128x8i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// 8x8i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vmaplo(Vector128<sbyte> src, N128 w, short t = default)
            => z.vmaplo(src, w, t);

        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// dst[i] = src[i], i = 1, ..., 7
        /// 8x8i -> 8x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vmaplo(Vector128<sbyte> src, N128 w, ushort t =  default)
            => z.vmaplo(src, w, t);

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi32 (__m128i a) VPMOVSXBD ymm, xmm/m128
        /// 8x8i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vmaplo(Vector128<sbyte> src, N256 w, int t = default)
            => z.vmaplo(src, w, t);

        // ~ 128x8u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// 8x8u -> 8x16u
        /// src[i] -> dst[i], i = 0,.., 7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vmaplo(Vector128<byte> src, N128 w, short t = default)
            => z.vmaplo(src, w, t);

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// 8x8u -> 8x16u
        /// src[i] -> dst[i], i = 0,.., 7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vmaplo(Vector128<byte> src, N128 w, ushort t = default)
            => z.vmaplo(src, w, t);

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extends 8 8-bit integers from the low 8 bytes of the source to 8 32-bit integers in the target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vmaplo(Vector128<byte> src, N256 w, uint t = default)
            => z.vmaplo(src, w, t);

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extends 8 8-bit integers from the low 8 bytes of the source to 8 32-bit integers in the target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vmaplo(Vector128<byte> src, N256 w, int t = default)
            => z.vmaplo(src, w, t);

        // ~ 128x16i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vmaplo(Vector128<short> src, N128 w, int t = default)
            => z.vmaplo(src, w, t);

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x16u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vmaplo(Vector128<short> src, N256 w, long t = default)
            => z.vmaplo(src, w, t);

        // ~ 128x16u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m128i _mm_cvtepu16_epi32 (__m128i a)PMOVZXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vmaplo(Vector128<ushort> src, N128 w, uint t = default)
            => z.vmaplo(src, w, t);

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a) VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vmaplo(Vector128<ushort> src, N256 w, long t = default)
            => z.vmaplo(src, w, t);

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a) VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vmaplo(Vector128<ushort> src, N256 w, ulong t = default)
            => z.vmaplo(src, w, t);

        // ~ 128x32u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// 2x32u -> 2x64i
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vmaplo(Vector128<uint> src, N128 w, long t = default)
            => z.vmaplo(src, w, t);

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// 2x32u -> 2x64u
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vmaplo(Vector128<uint> src, N128 w, ulong t = default)
            => z.vmaplo(src, w, t);

        // ~ 256x8i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vmaplo(Vector256<sbyte> src, N256 w, short t = default)
            => z.vmaplo(src, w, t);

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vmaphi(Vector256<sbyte> src, N256 w, short t = default)
            => z.vmaplo(src, w, t);

        // ~ 256x8u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vmaplo(Vector256<byte> src, N256 w, ushort t = default)
            => z.vmaplo(src, w, t);

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vmaplo(Vector256<byte> src, N256 w, short t = default)
            => z.vmaplo(src, w, t);

        // ~ 256x16i -> X
        // ~ ------------------------------------------------------------------
        
        /// <summary>
        /// __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vmaplo(Vector256<short> src, N256 w, int t = default)
            => z.vmaplo(src, w, t);

        // ~ 256x16u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vmaplo(Vector256<ushort> src, N256 w, uint t = default)
            => z.vmaplo(src, w, t);

        // ~ 256x32i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32i -> 4x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vmaplo(Vector256<int> src, N256 w, long t = default)
            => z.vmaplo(src, w, t);

        // ~ 256x32u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vmaplo(Vector256<uint> src, N256 w, ulong t = default)
            => z.vmaplo(src, w, t);
    }
}