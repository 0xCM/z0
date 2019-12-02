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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
     
    using static As;
    using static zfunc;

    partial class dinx
    {                
        /// <summary>
        /// __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vconvert(Vector128<sbyte> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vconvert(Vector128<sbyte> src, out Vector128<short> dst)
        {
            dst = ConvertToVector128Int16(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi8_epi64 (__m128i a) PMOVSXBQ xmm, xmm/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vconvert(Vector128<sbyte> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// Zero extends 8 packed 8-bit integers the low 8 bytes of xmm2/m64 to 8 packed 16-bit integers xmm1.
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vconvert(Vector128<byte> src, out Vector128<short> dst)
        {
            dst = ConvertToVector128Int16(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// src[i] -> dst[i], i = 0,.., 7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/pmovzx
        /// </remarks>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vconvert(Vector128<byte> src, out Vector128<ushort> dst)
        {
            dst = v16u(ConvertToVector128Int16(src));
            return dst;
        }

        [MethodImpl(Inline)]
        public static void vconvert(Vector128<byte> src, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {
            vconvert(src, out lo);
            vconvert(src, out hi);            
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vconvert(Vector128<byte> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vconvert(Vector128<byte> src, out Vector128<uint> dst)
        {
            dst = v32u(ConvertToVector128Int32(src));
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi32_epi64 (__m128i a) PMOVSXDQ xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vconvert(Vector128<byte> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi64 (__m128i a) PMOVZXBQ xmm, xmm/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vconvert(Vector128<byte> src, out Vector128<ulong> dst)
        {
            dst = v64u(ConvertToVector128Int64(src));
            return  dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vconvert(Vector128<short> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi16_epi64 (__m128i a) PMOVSXWQ xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vconvert(Vector128<short> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu16_epi32 (__m128i a) PMOVZXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vconvert(Vector128<ushort> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu16_epi32 (__m128i a)PMOVZXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vconvert(Vector128<ushort> src, out Vector128<uint> dst)
        {
            dst = v32u(ConvertToVector128Int32(src));
            return dst;
        }

        /// <summary>
        ///  __m128i _mm_cvtepu16_epi64 (__m128i a) PMOVZXWQ xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vconvert(Vector128<ushort> src, out Vector128<long> dst)
        {
           dst = ConvertToVector128Int64(src);
           return dst;
        }

        /// <summary>
        ///  __m128i _mm_cvtepu16_epi64 (__m128i a) PMOVZXWQ xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vconvert(Vector128<ushort> src, out Vector128<ulong> dst)
        {
           dst = v64u(ConvertToVector128Int64(src));
           return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi32_epi64 (__m128i a) PMOVSXDQ xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vconvert(Vector128<int> src, out Vector128<long> dst)
        {
           dst = ConvertToVector128Int64(src);
           return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vconvert(Vector128<uint> src, out Vector128<long> dst)
        {
           dst = ConvertToVector128Int64(src);
           return dst;
        }


        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// src[i] -> dst[i], i = 0, 2
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vconvert(Vector128<uint> src, out Vector128<ulong> dst)
        {
           dst = v64u(ConvertToVector128Int64(src));
           return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vconvert(Vector128<sbyte> src, out Vector256<short> dst)
        {
            dst = ConvertToVector256Int16(src);
            return dst;
        }


        /// <summary>
        /// __m256i _mm256_cvtepi8_epi32 (__m128i a) VPMOVSXBD ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vconvert(Vector128<sbyte> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi64 (__m128i a) VPMOVSXBQ ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vconvert(Vector128<sbyte> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) vpmovzxbw ymm, xmm
        /// Zero extends 16 packed 8-bit integers xmm2/m128 to 16 packed 16-bit integers ymm1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vconvert(Vector128<byte> src, out Vector256<short> dst)
        {
            dst = ConvertToVector256Int16(src);
            return dst;
        }

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// src[i] -> dst[i], i = 0,...,15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vconvert(Vector128<byte> src, out Vector256<ushort> dst)
        {
            dst = v16u(ConvertToVector256Int16(src));
            return dst;
        }


        /// <summary>
        /// Zero extends each of the 16 8-bit integers in the lo half of the source to the lo target
        /// and each of the 16 8-bit integers in the hi half of the source to the hi target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector256<byte> src, out Vector256<ushort> lo, out Vector256<ushort> hi)
        {
            lo = v16u(ConvertToVector256Int16(vlo(src)));
            hi = v16u(ConvertToVector256Int16(vhi(src)));
        }

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extend 8 packed 8-bit integers the low 8 bytes of xmm2/m64 to 8 packed 32-bit integers ymm1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vconvert(Vector128<byte> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return dst;
        }


        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extend 8 packed 8-bit integers the low 8 bytes of xmm2/m64 to 8 packed 32-bit integers ymm1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vconvert(Vector128<byte> src, out Vector256<uint> dst)
        {
            dst = v32u(ConvertToVector256Int32(src));
            return dst;
        }        

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi64 (__m128i a) VPMOVZXBQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vconvert(Vector128<byte> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi64 (__m128i a) VPMOVZXBQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vconvert(Vector128<byte> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(src));
            return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vconvert(Vector128<short> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return dst;
        }


        [MethodImpl(Inline)]
        public static Vector256<uint> vconvert(Vector128<short> src, out Vector256<uint> dst)
        {
            dst = v32u(ConvertToVector256Int32(src));
            return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vconvert(Vector128<short> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return dst;
        }


        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vconvert(Vector128<ushort> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return dst;
        }

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vconvert(ref ushort src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(ptr(ref src));
            return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vconvert(Vector128<ushort> src, out Vector256<uint> dst)
        {
            dst = v32u(ConvertToVector256Int32(src));
            return dst;
        }

        [MethodImpl(Inline)]
        public static void vconvert(Vector256<ushort> src, out Vector256<uint> lo, out Vector256<uint> hi)
        {
            lo = v32u(ConvertToVector256Int32(vlo(src)));
            hi = v32u(ConvertToVector256Int32(vhi(src)));            
        }

        [MethodImpl(Inline)]
        public static void vconvert(Vector256<short> src, out Vector256<int> lo, out Vector256<int> hi)
        {
            lo = ConvertToVector256Int32(vlo(src));
            hi = ConvertToVector256Int32(vhi(src));            
        }

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a) VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vconvert(Vector128<ushort> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a)VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vconvert(Vector128<ushort> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(src));
            return dst;
        }

        [MethodImpl(Inline)]
        public static void vconvert(Vector256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            lo = v64u(ConvertToVector256Int64(vlo(src)));
            hi = v64u(ConvertToVector256Int64(vhi(src)));
        }
        
        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vconvert(Vector128<int> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return dst;
        }

        /// <summary>
        ///  __m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vconvert(Vector128<uint> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return dst;
        }

        /// <summary>
        /// _m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vconvert(Vector128<uint> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(src));
            return dst;
        }

        [MethodImpl(Inline)]
        public static void vconvert(Vector256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            lo = v64u(ConvertToVector256Int64(vlo(src)));
            hi = v64u(ConvertToVector256Int64(vhi(src)));
        }
    }
}