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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static Konst;
    using static Memories;

    partial class VStoreD
    {
        /// <summary>
        /// _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector128<sbyte> src, ref sbyte dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector128<byte> src, ref byte dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector128<short> src, ref short dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector128<ushort> src, ref ushort dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector128<int> src, ref int dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector128<uint> src, ref uint dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector128<long> src, ref long dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector128<ulong> src, ref ulong dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm_stream_ps (float* mem_addr, __m128 a) MOVNTPS m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector128<float> src, ref float dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm_stream_pd (double* mem_addr, __m128d a) MOVNTPD m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector128<double> src, ref double dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector256<sbyte> src, ref sbyte dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector256<byte> src, ref byte dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector256<short> src, ref short dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector256<ushort> src, ref ushort dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector256<int> src, ref int dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector256<uint> src, ref uint dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector256<long> src, ref long dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector256<ulong> src, ref ulong dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);                        
 
        /// <summary>
        /// void _mm256_stream_ps (float * mem_addr, __m256 a) MOVNTPS m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector256<float> src, ref float dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src);            

        /// <summary>
        /// void _mm256_stream_pd (double * mem_addr, __m256d a) MOVNTPD m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vstream(Vector256<double> src, ref double dst)
            => StoreAlignedNonTemporal(ptr(ref dst), src); 
    }
}