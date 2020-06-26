//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
     using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;
     
    using static Typed;
    using static Konst;
    using static V0;

    partial struct V0d
    {
        // ~ Scalar conversions
        /// <summary>
        /// int _mm_cvtsi128_si32 (__m128i a)MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static int convert(Vector128<int> src, N32 w, int t = default)
            => ConvertToInt32(src);

        /// <summary>
        /// int _mm_cvtsi128_si32 (__m128i a)MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static uint convert(Vector128<uint> src, N32 w, uint t = default)
            => ConvertToUInt32(src);

        /// <summary>
        /// __int64 _mm_cvtsi128_si64 (__m128i a)MOVQ reg/m64, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static long convert(Vector128<long> src, N64 w, long t = default)
            => ConvertToInt64(src);

        /// <summary>
        /// __int64 _mm_cvtsi128_si64 (__m128i a)MOVQ reg/m64, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong convert(Vector128<ulong> src, N64 w, ulong t = default)
            => ConvertToUInt64(src);


        /// <summary>
        /// __m128i _mm256_cvtpd_epi32 (__m256d a) VCVTPD2DQ xmm, ymm/m256
        /// 4x64u -> 4x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vconvert(Vector256<ulong> src, N128 w, uint t = default)
            => v32u(ConvertToVector128Int32(v64f(src)));
    
        /// <summary>
        /// __m128i _mm256_cvtpd_epi32 (__m256d a) VCVTPD2DQ xmm, ymm/m256
        /// (2x64u,2x64u) -> 4x32u
        /// </summary>
        /// <param name="lo">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vconvert(Vector128<ulong> lo, Vector128<ulong> hi, N128 w, uint t = default)
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
        public static Vector256<ushort> vconvert(Vector128<sbyte> src, N256 w, ushort t = default)
            => v16u(ConvertToVector256Int16(src));        

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        /// 16x8i -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vconvert(Vector128<sbyte> src, N256 w, short t = default)
            => ConvertToVector256Int16(src);

        /// <summary>
        /// __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vconvert(Vector128<sbyte> src, N128 w, int t = default)
            => ConvertToVector128Int32(src);

        /// <summary>
        /// 16x8i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vconvert(Vector128<sbyte> src, N512 w, int t = default)
            => (vmaplo(src,n256,t), vmaphi(src,n256,t));

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
        public static Vector256<short> vconvert(Vector128<byte> src, N256 w, short t = default)
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
        public static Vector256<ushort> vconvert(Vector128<byte> src, N256 w, ushort t = default)
            => v16u(ConvertToVector256Int16(src));        

        /// <summary>
        /// 16x8u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vconvert(Vector128<byte> src, N512 w, uint t = default)        
            => (vmaplo(src, n256, t), vmaphi(src, n256, t));

        // ~ 128x16i -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vconvert(Vector128<short> src, N256 w, int t = default)
            => ConvertToVector256Int32(src);

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// 8x16i -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vconvert(Vector128<short> src, N256 w, uint t = default)
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
        public static Vector256<int> vconvert(Vector128<ushort> src, N256 w, int t = default)
            => ConvertToVector256Int32(src);

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vconvert(Vector128<ushort> src, N256 w, uint t = default)
            => v32u(ConvertToVector256Int32(src));

    }
}