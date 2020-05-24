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
     
    using static Seed; 
    using static Memories;

    [ApiHost]
    public readonly struct VMaps : IApiHost<VMaps>
    {
        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// 8x8i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<short> vmap(Vector128<sbyte> src, N0 n, W16 w)
            => ConvertToVector128Int16(src);

        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// 8x8i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<short> vmap(Vector128<sbyte> src, N1 n, W16 w)
            => ConvertToVector128Int16(dvec.vhi(src));

        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// dst[i] = src[i], i = 1, ..., 7
        /// 8x8i -> 8x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<ushort> vmap(Vector128<sbyte> src, N0 n, W16 w, N1 i)
            => v16u(ConvertToVector128Int16(src));

        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// 8x8i -> 8x16u
        /// dst[i] = src[i], i = 8, ..., 15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<ushort> vmap(Vector128<sbyte> src, N1 n, W16 w, N1 i)
            => v16u(ConvertToVector128Int16(dvec.vhi(src)));

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi32 (__m128i a) VPMOVSXBD ymm, xmm/m128
        /// 8x8i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<int> vmap(Vector128<sbyte> src, N0 n, W32 w)
            => ConvertToVector256Int32(src);

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi32 (__m128i a) VPMOVSXBD ymm, xmm/m128
        /// 8x8i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<int> vmap(Vector128<sbyte> src, N1 n, W32 w)
            => ConvertToVector256Int32(dvec.vhi(src));

        // ~ 128x8u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// 8x8u -> 8x16u
        /// src[i] -> dst[i], i = 0,.., 7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<short> vmap(Vector128<byte> src, N0 n, W16 w, N1 i)
            => ConvertToVector128Int16(src);

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// 8x8u -> 8x16i
        /// src[i] -> dst[i], i = 8,.., 15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<short> vmap(Vector128<byte> src, N1 n, W16 w, N1 i)
            =>  ConvertToVector128Int16(dvec.vhi(src));

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// 8x8u -> 8x16u
        /// src[i] -> dst[i], i = 0,.., 7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<ushort> vmap(Vector128<byte> src, N0 n, W16 w)
            => v16u(ConvertToVector128Int16(src));

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// 8x8u -> 8x16u
        /// src[i] -> dst[i], i = 0,.., 7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<ushort> vmap(Vector128<byte> src, N1 n, W16 w)
            => v16u(ConvertToVector128Int16(dvec.vhi(src)));

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extends 8 8-bit integers from the low 8 bytes of the source to 8 32-bit integers in the target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<uint> vmap(Vector128<byte> src, N0 n, W32 w)
            => v32u(ConvertToVector256Int32(src));

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extends 8 8-bit integers from the low 8 bytes of the source to 8 32-bit integers in the target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<uint> vmap(Vector128<byte> src, N1 n, W32 w)
            => v32u(ConvertToVector256Int32(dvec.vhi(src)));

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extends 8 8-bit integers from the low 8 bytes of the source to 8 32-bit integers in the target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<int> vmap(Vector128<byte> src, N0 n, W32 w, N1 i)
            => ConvertToVector256Int32(src);

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extends 8 8-bit integers from the low 8 bytes of the source to 8 32-bit integers in the target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<int> vmap(Vector128<byte> src, N1 n, W32 w, N1 i)
            => ConvertToVector256Int32(dvec.vhi(src));

        // ~ 128x16i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<int> vmap(Vector128<short> src, N0 n, N32 w)
            => ConvertToVector128Int32(src);

        /// <summary>
        /// __m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<int> vmap(Vector128<short> src, N1 n, N32 w)
            => ConvertToVector128Int32(dvec.vhi(src));

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x16u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<long> vmap(Vector128<short> src, N0 n, W64 w)
            => ConvertToVector256Int64(src);

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x16u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<long> vmap(Vector128<short> src, N1 n, W64 w)
            => ConvertToVector256Int64(dvec.vhi(src));

        // ~ 128x16u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m128i _mm_cvtepu16_epi32 (__m128i a)PMOVZXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<uint> vmap(Vector128<ushort> src, N0 n, W32 w)
            => v32u(ConvertToVector128Int32(src));

        /// <summary>
        /// __m128i _mm_cvtepu16_epi32 (__m128i a)PMOVZXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<uint> vmap(Vector128<ushort> src, N1 n, W32 w)
            => v32u(ConvertToVector128Int32(dvec.vhi(src)));

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a) VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<long> vmap(Vector128<ushort> src, N0 n, W64 w, N1 i)
            => ConvertToVector256Int64(src);

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a) VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<long> vmap(Vector128<ushort> src, N1 n, W64 w, N1 i)
            => ConvertToVector256Int64(dvec.vhi(src));

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a) VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<ulong> vmap(Vector128<ushort> src, N0 n, W64 w)
            => v64u(ConvertToVector256Int64(src));

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a) VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<ulong> vmap(Vector128<ushort> src, N1 n, W64 w)
            => v64u(ConvertToVector256Int64(dvec.vhi(src)));

        // ~ 128x32u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// 2x32u -> 2x64i
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<long> vmap(Vector128<uint> src, N0 n, W64 w, N1 i)
            => ConvertToVector128Int64(src);

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// 2x32u -> 2x64i
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<long> vmap(Vector128<uint> src, N1 n, W64 w, N1 i)
            => ConvertToVector128Int64(dvec.vhi(src));

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// 2x32u -> 2x64u
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<ulong> vmap(Vector128<uint> src, N0 n, W64 w)
            => v64u(ConvertToVector128Int64(src));

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// 2x32u -> 2x64u
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector128<ulong> vmap(Vector128<uint> src, N1 n, W64 w)
            => v64u(ConvertToVector128Int64(dvec.vhi(src)));

        // ~ 256x8i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<short> vmap(Vector256<sbyte> src, N0 n, W16 w)
            => ConvertToVector256Int16(dvec.vlo(src));

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<short> vmap(Vector256<sbyte> src, N1 n, W16 w)
            => ConvertToVector256Int16(dvec.vhi(src));

        // ~ 256x8u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<ushort> vmap(Vector256<byte> src, N0 n, W16 w)
            => v16u(ConvertToVector256Int16(dvec.vlo(src)));

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<ushort> vmap(Vector256<byte> src, N1 n, W16 w)
            => v16u(ConvertToVector256Int16(dvec.vhi(src)));

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<short> vmap(Vector256<byte> src, N0 n, W16 w, N1 i)
            => ConvertToVector256Int16(dvec.vlo(src));

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Specifies a target sign extension</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<short> vmap(Vector256<byte> src, N1 n, W16 w, N1 i)
            => ConvertToVector256Int16(dvec.vhi(src));

        // ~ 256x16i -> X
        // ~ ------------------------------------------------------------------
        
        /// <summary>
        /// __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<int> vmap(Vector256<short> src, N0 n, W32 w)
            => ConvertToVector256Int32(dvec.vlo(src));

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<int> vmap(Vector256<short> src, N1 n, W32 w)
            => ConvertToVector256Int32(dvec.vhi(src));

        // ~ 256x16u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<uint> vmap(Vector256<ushort> src, N0 n, W32 w)
            => v32u(ConvertToVector256Int32(dvec.vlo(src)));

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<uint> vmap(Vector256<ushort> src, N1 n, W32 w)
            => v32u(ConvertToVector256Int32(dvec.vhi(src)));

        // ~ 256x32i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32i -> 4x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<long> vmap(Vector256<int> src, N0 n, W64 w)
            => ConvertToVector256Int64(dvec.vlo(src));

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32i -> 4x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<long> vmap(Vector256<int> src, N1 n, W64 w)
            => ConvertToVector256Int64(dvec.vhi(src));

        // ~ 256x32u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<ulong> vmap(Vector256<uint> src, N0 n, W64 w)
            => v64u(ConvertToVector256Int64(dvec.vlo(src)));

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The lane selector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static Vector256<ulong> vmap(Vector256<uint> src, N1 n, W64 w)
            => v64u(ConvertToVector256Int64(dvec.vhi(src)));    
    }
}