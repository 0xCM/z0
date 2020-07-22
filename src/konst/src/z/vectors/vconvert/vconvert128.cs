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
    using static System.Runtime.Intrinsics.X86.Sse2;
     
    using static Konst;
    using static z;

    partial struct z
    {
        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32i -> 4x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vconvert(Vector128<int> src, N256 w, long t)
            => ConvertToVector256Int64(src);

        /// <summary>
        ///  __m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vconvert(Vector128<uint> src, N256 w, long t)
            => ConvertToVector256Int64(src);

        /// <summary>
        /// _m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vconvert(Vector128<uint> src, N256 w, ulong t)
            => v64u(ConvertToVector256Int64(src));

        /// <summary>
        /// __m128i _mm256_cvtpd_epi32 (__m256d a) VCVTPD2DQ xmm, ymm/m256
        /// (2x64u,2x64u) -> 4x32u
        /// </summary>
        /// <param name="lo">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vconvert(Vector128<ulong> lo, Vector128<ulong> hi, N128 w, uint t)
            => vconvert(vconcat(lo,hi), w,t);

        // ~ 128x8i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// 16x8i -> (8x16u, 8x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vconvert(Vector128<sbyte> src, N256 w, ushort t)
            => v16u(ConvertToVector256Int16(src));        

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        /// 16x8i -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vconvert(Vector128<sbyte> src, N256 w, short t)
            => ConvertToVector256Int16(src);

        /// <summary>
        /// __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vconvert(Vector128<sbyte> src, N128 w, int t)
            => ConvertToVector128Int32(src);

        // ~ 128x8u -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) vpmovzxbw ymm, xmm
        /// 16x8u -> 16x16i
        /// src[i] -> dst[i], i = 0,...,15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vconvert(Vector128<byte> src, N256 w, short t)
            => ConvertToVector256Int16(src);

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16u
        /// src[i] -> dst[i], i = 0,...,15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vconvert(Vector128<byte> src, N256 w, ushort t)
            => v16u(ConvertToVector256Int16(src));        

        // ~ 128x16i -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vconvert(Vector128<short> src, N256 w, int t)
            => ConvertToVector256Int32(src);

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// 8x16i -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vconvert(Vector128<short> src, N256 w, uint t)
            => v32u(ConvertToVector256Int32(src));

        // ~ 128x16u -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// 8x16u -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vconvert(Vector128<ushort> src, N256 w, int t)
            => ConvertToVector256Int32(src);

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vconvert(Vector128<ushort> src, N256 w, uint t)
            => v32u(ConvertToVector256Int32(src));            

        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert(Vector128<short> src, N512 w, long t)
            => (vmaplo(src, n256, z64i), vmaphi(src, n256, z64i));
        
        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vconvert(Vector128<ushort> src, N512 w, ulong t)
            => (vmaplo(src, n256, z64), vmaphi(src, n256, z64));

        /// <summary>
        /// 16x8i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vconvert(Vector128<sbyte> src, N512 w, int t)
            => (vmaplo(src,n256,t), vmaphi(src,n256,t));

        /// <summary>
        /// 16x8u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vconvert(Vector128<byte> src, N512 w, uint t)        
            => (vmaplo(src, n256, t), vmaphi(src, n256, t));
    }
}