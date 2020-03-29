//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;
     
    using static Core;
    using static vgeneric;

    partial class dvec
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
            => vconvert(vdirect.vconcat(lo,hi), w,t);

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
            => (vmaplo(src,n256,t),vmaphi(src,n256,t));

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

        // ~ 128x32i -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32i -> 4x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vconvert(Vector128<int> src, N256 w, long t = default)
            => ConvertToVector256Int64(src);

        // ~ 128x32u -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        ///  __m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vconvert(Vector128<uint> src, N256 w, long t = default)
            => ConvertToVector256Int64(src);

        /// <summary>
        /// _m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vconvert(Vector128<uint> src, N256 w, ulong t = default)
            => v64u(ConvertToVector256Int64(src));
        
        // ~ 256
        // ~ ------------------------------------------------------------------     

        /// <summary>
        /// src[i] -> lo[i], i = 1,..,15
        /// src[i] -> hi[i], i = 16,..,31
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vconvert(Vector256<sbyte> src, N512 w, short t = default)
            => (vmaplo(src,n256,z16i),vmaphi(src,n256,z16i));

        /// <summary>
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<int> vconvert(Vector256<sbyte> src, N1024 w, int t = default)
        {
            (var lo, var hi) = vconvert(src, n512, z16i); 
            var x0 = vmaplo(lo,n256,z32i);
            var x1 = vmaphi(lo,n256,z32i);
            var x2 = vmaplo(hi,n256,z32i);
            var x3 = vmaphi(hi,n256,z32i);            
            return (x0,x1,x2,x3);
        }

        /// <summary>
        /// 32x8u -> (16x16u, 16x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vconvert(Vector256<byte> src, N512 w, ushort t = default)
             => (vmaplo(src, n256, z16), vmaphi(src, n256, z16));

        /// <summary>
        /// 32x8u -> (16x16i, 16x16i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vconvert(Vector256<byte> src, N512 w, short t = default)
            => (vmaplo(src, n256, z16i),vmaphi(src, n256, z16i));

        /// <summary>
        /// 32x8u -> (8x32u, 8x32u, 8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<uint> vconvert(Vector256<byte> src, N1024 w, uint t = default)
        {
            (var lo, var hi) = vconvert(src, n512, z16);            
            (var x0, var x1) = vconvert(lo, n512, t);
            (var x2, var x3) = vconvert(hi, n512, t);
            return (x0,x1,x2,x3);
        }

        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert(Vector128<short> src, N512 w, long t = default)
            => (vmaplo(src, n256, z64i), vmaphi(src, n256, z64i));
        
        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vconvert(Vector128<ushort> src, N512 w, ulong t = default)
            => (vmaplo(src, n256, z64),vmaphi(src, n256, z64));

        /// <summary>
        /// 16x16u -> 16x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<ulong> vconvert(Vector256<ushort> src, N1024 w, ulong t = default)
            => (vconvert(vlo(src), n512, t), vconvert(vhi(src), n512, t));

        /// <summary>
        /// 16x16i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vconvert(Vector256<short> src, N512 w, int t = default)
            => (vmaplo(src,n256,t), vmaphi(src,n256,t));

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vconvert(Vector256<ushort> src, N512 w, uint t = default)
            => (vmaplo(src,n256,t),vmaphi(src,n256,t));

        /// <summary>
        /// 8x32i -> (4x64i, 4x64i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert(Vector256<int> src, N512 w, long t = default)
            => (vmaplo(src, n256, t),vmaphi(src, n256, t));

        /// <summary>
        /// 8x32u -> (4x64u, 4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vconvert(Vector256<uint> src, N512 w, ulong t = default)
            => (vmaplo(src, n256, t),vmaphi(src, n256, t));

        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert(Vector256<short> src, N512 w, long t = default)
            => (ConvertToVector256Int64(vlo(src)), ConvertToVector256Int64(vhi(src)));
    }
}