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

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<sbyte> src, Vector128<byte> mask, ref sbyte dst)
            =>  MaskMove(src, v8i(mask), refptr(ref dst));                 

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void vmaskstore(Vector256<sbyte> src, Vector256<byte> mask, ref sbyte dst)
        {
            vmaskstore(vlo(src), vlo(mask), ref dst);
            vmaskstore(vhi(src), vhi(mask), ref seek(ref dst, 16));
        }

        /// <summary>
        /// _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<byte> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(src, mask, refptr(ref dst));                 

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void vmaskstore(Vector256<byte> src, Vector256<byte> mask, ref byte dst)
        {
            vmaskstore(vlo(src), vlo(mask), ref dst);
            vmaskstore(vhi(src), vhi(mask), ref seek(ref dst, 16));
        }

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<short> src, Vector128<byte> mask, ref short dst)
            => MaskMove(v8u(src), mask, refptr(ref Unsafe.As<short,byte>(ref dst)));

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void vmaskstore(Vector256<short> src, Vector256<byte> mask, ref short dst)
        {
            vmaskstore(vlo(src), vlo(mask), ref dst);
            vmaskstore(vhi(src), vhi(mask), ref seek(ref dst, 8));
        }

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<ushort> src, Vector128<byte> mask, ref ushort dst)
            => MaskMove(v8u(src), mask, refptr(ref Unsafe.As<ushort,byte>(ref dst)));

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void vmaskstore(Vector256<ushort> src, Vector256<byte> mask, ref ushort dst)
        {
            vmaskstore(vlo(src), vlo(mask), ref dst);
            vmaskstore(vhi(src), vhi(mask), ref seek(ref dst, 8));
        }

        /// <summary>
        /// void _mm_maskstore_epi32 (int* mem_addr, __m128i mask, __m128i a) VPMASKMOVD m128, xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<int> src, Vector128<int> mask, ref int dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<int> src, Vector128<byte> mask, ref int dst)
            => MaskMove(v8u(src), mask, refptr(ref Unsafe.As<int,byte>(ref dst)));

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void vmaskstore(Vector256<int> src, Vector256<byte> mask, ref int dst)
        {
            vmaskstore(vlo(src), vlo(mask), ref dst);
            vmaskstore(vhi(src), vhi(mask), ref seek(ref dst, 4));
        }

        /// <summary>
        /// void _mm256_maskstore_epi32 (int* mem_addr, __m256i mask, __m256i a) VPMASKMOVD m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<int> src, Vector256<int> mask, ref int dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_epi32 (int* mem_addr, __m256i mask, __m256i a) VPMASKMOVD m256, ymm, ymm
        /// Conditionally source vector components to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<uint> src, Vector256<uint> mask, ref uint dst)
            => MaskStore(refptr(ref dst), src, mask);

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<uint> src, Vector128<byte> mask, ref uint dst)
            =>  MaskMove(v8u(src), mask, refptr(ref Unsafe.As<uint,byte>(ref dst)));

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void vmaskstore(Vector256<uint> src, Vector256<byte> mask, ref uint dst)
        {
            vmaskstore(vlo(src), vlo(mask), ref dst);
            vmaskstore(vhi(src), vhi(mask), ref seek(ref dst, 4));
        }

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<long> src, Vector256<long> mask, ref long dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<long> src, Vector128<byte> mask, ref long dst)
            =>  MaskMove(v8u(src), mask, refptr(ref Unsafe.As<long,byte>(ref dst)));

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void vmaskstore(Vector256<long> src, Vector256<byte> mask, ref long dst)
        {
            vmaskstore(vlo(src), vlo(mask), ref dst);
            vmaskstore(vhi(src), vhi(mask), ref seek(ref dst, 2));
        }

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<ulong> src, Vector256<ulong> mask, ref ulong dst)
            => MaskStore(refptr(ref dst), src, mask);

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<ulong> src, Vector128<byte> mask, ref ulong dst)
            =>  MaskMove(v8u(src), mask, refptr(ref Unsafe.As<ulong,byte>(ref dst)));

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void vmaskstore(Vector256<ulong> src, Vector256<byte> mask, ref ulong dst)
        {
            vmaskstore(vlo(src), vlo(mask), ref dst);
            vmaskstore(vhi(src), vhi(mask), ref seek(ref dst, 2));
        }

    }

}