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
        /// __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<short> vconvert(in Vec128<sbyte> src, out Vec128<short> dst)
        {
            dst = ConvertToVector128Int16(src);
            return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<int> vconvert(in Vec128<sbyte> src, out Vec128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return ref dst;
        }


        /// <summary>
        /// __m128i _mm_cvtepi8_epi64 (__m128i a) PMOVSXBQ xmm, xmm/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<long> vconvert(in Vec128<sbyte> src, out Vec128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// Zero extends 8 packed 8-bit integers in the low 8 bytes of xmm2/m64 to 8 packed 16-bit integers in xmm1.
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<short> vconvert(in Vec128<byte> src, out Vec128<short> dst)
        {
            dst = ConvertToVector128Int16(src);
            return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        /// Zero extends 8 packed 8-bit integers in the low 8 bytes of xmm2/m64 to 8 packed 16-bit integers in xmm1.
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <remarks>
        /// src[i] -> dst[i], i = 0,.., 7
        /// See https://www.felixcloutier.com/x86/pmovzx
        /// </remarks>
        [MethodImpl(Inline)]
        public static ref Vec128<ushort> vconvert(in Vec128<byte> src, out Vec128<ushort> dst)
        {
            dst = ConvertToVector128Int16(src).AsUInt16();
            return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<int> vconvert(in Vec128<byte> src, out Vec128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<uint> vconvert(in Vec128<byte> src, out Vec128<uint> dst)
        {
            dst = ConvertToVector128Int32(src).AsUInt32();
            return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi32_epi64 (__m128i a) PMOVSXDQ xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<long> vconvert(in Vec128<byte> src, out Vec128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<ulong> vconvert(in Vec128<byte> src, out Vec128<ulong> dst)
        {
            dst = ConvertToVector128Int64(src).AsUInt64();
            return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<int> vconvert(in  Vec128<short> src, out Vec128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return ref dst;
        }


        /// <summary>
        /// __m128i _mm_cvtepi16_epi64 (__m128i a) PMOVSXWQ xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<long> vconvert(in Vec128<short> src, out Vec128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu16_epi32 (__m128i a) PMOVZXWD xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<int> vconvert(in Vec128<ushort> src, out Vec128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<uint> vconvert(in Vec128<ushort> src, out Vec128<uint> dst)
        {
            dst = ConvertToVector128Int32(src).AsUInt32();
            return ref dst;
        }

        /// <summary>
        ///  __m128i _mm_cvtepu16_epi64 (__m128i a) PMOVZXWQ xmm, xmm/m32
        /// Zero extends 2 packed 16-bit integers in the low 4 bytes of xmm2/m32 to 2 packed 64-bit integers in xmm1.
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<long> vconvert(in Vec128<ushort> src, out Vec128<long> dst)
        {
           dst = ConvertToVector128Int64(src);
           return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<ulong> vconvert(in Vec128<ushort> src, out Vec128<ulong> dst)
        {
           dst = ConvertToVector128Int64(src).AsUInt64();
           return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi32_epi64 (__m128i a) PMOVSXDQ xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec128<long> vconvert(in Vec128<int> src, out Vec128<long> dst)
        {
           dst = ConvertToVector128Int64(src);
           return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// Zero extends 2 packed 32-bit integers in the low 8 bytes of xmm2/m64 to 2 packed 64-bit integers in xmm1.
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <remarks>
        /// src[0] -> dst[0]
        /// src[1] -> dst[1]
        /// </remarks>
        [MethodImpl(Inline)]
        public static ref Vec128<long> vconvert(in Vec128<uint> src, out Vec128<long> dst)
        {
           dst = ConvertToVector128Int64(src);
           return ref dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        /// Zero extend 2 packed 32-bit integers in the low 8 bytes of xmm2/m64 to 2 packed 64-bit integers in xmm1.
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <remarks>
        /// src[0] -> dst[0]
        /// src[1] -> dst[1]
        /// </remarks>
        [MethodImpl(Inline)]
        public static ref Vec128<ulong> vconvert(in Vec128<uint> src, out Vec128<ulong> dst)
        {
           dst = ConvertToVector128Int64(src).AsUInt64();
           return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<short> vconvert(in Vec128<sbyte> src, out Vec256<short> dst)
        {
            dst = ConvertToVector256Int16(src);
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi32 (__m128i a) VPMOVSXBD ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<int> vconvert(in Vec128<sbyte> src, out Vec256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi64 (__m128i a) VPMOVSXBQ ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<long> vconvert(in Vec128<sbyte> src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return ref dst;
        }
        
        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) vpmovzxbw ymm, xmm
        /// Zero extends 16 packed 8-bit integers in xmm2/m128 to 16 packed 16-bit integers in ymm1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<short> vconvert(in Vec128<byte> src, out Vec256<short> dst)
        {
            dst = ConvertToVector256Int16(src);
            return ref dst;
        }

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// Zero extends 16 packed 8-bit integers in xmm2/m128 to 16 packed 16-bit integers in ymm1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<ushort> vconvert(in Vec128<byte> src, out Vec256<ushort> dst)
        {
            dst = ConvertToVector256Int16(src.xmm).AsUInt16();
            return ref dst;
        }

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extend 8 packed 8-bit integers in the low 8 bytes of xmm2/m64 to 8 packed 32-bit integers in ymm1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<int> vconvert(in Vec128<byte> src, out Vec256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return ref dst;
        }

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// Zero extend 8 packed 8-bit integers in the low 8 bytes of xmm2/m64 to 8 packed 32-bit integers in ymm1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<uint> vconvert(in Vec128<byte> src, out Vec256<uint> dst)
        {
            dst = ConvertToVector256Int32(src).AsUInt32();
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi64 (__m128i a) VPMOVZXBQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<long> vconvert(in Vec128<byte> src, out Vec256<long> dst)
        {
            dst =ConvertToVector256Int64(src);
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi64 (__m128i a) VPMOVZXBQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<ulong> vconvert(in Vec128<byte> src, out Vec256<ulong> dst)
        {
            dst = ConvertToVector256Int64(src).AsUInt64();
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<int> vconvert(in Vec128<short> src, out Vec256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<long> vconvert(in Vec128<int> src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<long> vconvert(in Vec128<short> src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<int> vconvert(in Vec128<ushort> src, out Vec256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref Vec256<uint> vconvert(in Vec128<ushort> src, out Vec256<uint> dst)
        {
            dst = ConvertToVector256Int32(src).AsUInt32();
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi64 (__m128i a) VPMOVZXWQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<long> vconvert(in Vec128<ushort> src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec256<ulong> vconvert(in Vec128<ushort> src, out Vec256<ulong> dst)
        {
            dst = ConvertToVector256Int64(src).AsUInt64();
            return ref dst;
        }

        /// <summary>
        ///  __m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<long> vconvert(in Vec128<uint> src, out Vec256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return ref dst;
        }

        /// <summary>
        /// _m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<ulong> vconvert(in Vec128<uint> src, out Vec256<ulong> dst)
        {
            dst = ConvertToVector256Int64(src).AsUInt64();
            return ref dst;
        }
    }
}