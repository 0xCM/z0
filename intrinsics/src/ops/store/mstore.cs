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
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector128<byte> src, Vector128<byte> mask, in Block128<byte> dst)
            =>  MaskMove(src, mask, ptr(dst));

        /// <summary>
        /// void _mm_maskstore_epi32 (int* mem_addr, __m128i mask, __m128i a) VPMASKMOVD m128, xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector128<uint> src, Vector128<uint> mask, in Block128<uint> dst)
            => MaskStore(ptr(dst), src,mask);

        /// <summary>
        /// void _mm_maskstore_epi64 (__int64* mem_addr, __m128i mask, __m128i a) VPMASKMOVQ m128, xmm, xmm
        /// Conditionally stores source vector components to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector128<ulong> src, Vector128<ulong> mask, in Block128<ulong> dst)
            => MaskStore(ptr(dst), src, mask);

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<byte> src, Vector256<byte> mask, in Block256<byte> dst)
        {
            vmstore(vlo(src), vlo(mask), ref dst.Head);
            vmstore(vhi(src), vhi(mask), ref seek(ref dst.Head, 16));
        }

        /// <summary>
        /// void _mm256_maskstore_epi32 (int* mem_addr, __m256i mask, __m256i a) VPMASKMOVD m256, ymm, ymm
        /// Conditionally stores source vector components to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<uint> src, Vector256<uint> mask, in Block256<uint> dst)
            => MaskStore(ptr(dst), src, mask);

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// Conditionally stores source vector components to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<ulong> src, Vector256<ulong> mask, in Block256<ulong> dst)
            => MaskStore(ptr(dst), src, mask);

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector128<sbyte> src, Vector128<byte> mask, Block128<byte> dst)
            => MaskMove(v8u(src), v8u(mask), ptr(dst));

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector128<short> src, Vector128<byte> mask, in Block128<byte> dst)
            => MaskMove(v8u(src), mask, ptr(dst));

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector128<ushort> src, Vector128<byte> mask, in Block128<byte> dst)
            =>  MaskMove(v8u(src), mask, ptr(dst));

        /// <summary>
        /// void _mm_maskstore_epi32 (int* mem_addr, __m128i mask, __m128i a) VPMASKMOVD m128, xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector128<int> src, Vector128<int> mask, in Block128<int> dst)
            => MaskStore(ptr(dst), src,mask);

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<sbyte> src, Vector256<byte> mask, in Block256<byte> dst)
        {
            vmstore(vlo(src), vlo(mask), ref dst.Head);
            vmstore(vhi(src), vhi(mask), ref seek(ref dst.Head, 16));
        }

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector128<int> src, Vector128<byte> mask, in Block128<byte> dst)
            =>  MaskMove(v8u(src), mask, ptr(dst));

        /// <summary>
        /// void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector128<uint> src, Vector128<byte> mask, in Block128<byte> dst)
            =>  MaskMove(v8u(src), mask, ptr(dst));

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
        public static unsafe void vmstore(Vector128<long> src, Vector128<byte> mask, in Block128<byte> dst)
            =>  MaskMove(v8u(src), mask, ptr(dst));

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
        public static unsafe void vmstore(Vector128<ulong> src, Vector128<byte> mask, in Block128<byte> dst)
            =>  MaskMove(v8u(src), mask, ptr(dst));

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<short> src, Vector256<byte> mask, in Block256<byte> dst)
        {
            vmstore(vlo(src), vlo(mask), ref dst.Head);
            vmstore(vhi(src), vhi(mask), ref seek(ref dst.Head, 16));
        }

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<ushort> src, Vector256<byte> mask, in Block256<byte> dst)
        {
            vmstore(vlo(src), vlo(mask), ref dst.Head);
            vmstore(vhi(src), vhi(mask), ref seek(ref dst.Head, 16));
        }

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<int> src, Vector256<byte> mask, in Block256<byte> dst)
        {
            vmstore(vlo(src), vlo(mask), ref dst.Head);
            vmstore(vhi(src), vhi(mask), ref seek(ref dst.Head, 16));
        }

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<uint> src, Vector256<byte> mask, in Block256<byte> dst)
        {
            vmstore(vlo(src), vlo(mask), ref dst.Head);
            vmstore(vhi(src), vhi(mask), ref seek(ref dst.Head, 16));
        }

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<long> src, Vector256<byte> mask, in Block256<byte> dst)
        {
            vmstore(vlo(src), vlo(mask), ref dst.Head);
            vmstore(vhi(src), vhi(mask), ref seek(ref dst.Head, 16));
        }

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<ulong> src, Vector256<byte> mask, in Block256<byte> dst)
        {
            vmstore(vlo(src), vlo(mask), ref dst.Head);
            vmstore(vhi(src), vhi(mask), ref seek(ref dst.Head, 16));
        }

        /// <summary>
        /// void _mm256_maskstore_epi32 (int* mem_addr, __m256i mask, __m256i a) VPMASKMOVD m256, ymm, ymm
        /// Conditionally stores source vector components to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<int> src, Vector256<int> mask, in Block256<int> dst)
            => MaskStore(ptr(dst), src, mask);

        /// <summary>
        /// Conditionally stores 32-bit source vector segments to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<byte> src, Vector256<uint> mask, in Block256<uint> dst)
            => vmstore(v32u(src), mask, dst);

        /// <summary>
        /// Conditionally stores 32-bit source vector segments to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<ushort> src, Vector256<uint> mask, in Block256<uint> dst)
            => vmstore(v32u(src), mask, dst);

        /// <summary>
        /// Conditionally stores 32-bit source vector segments to memory according to a vectorized mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<ulong> src, Vector256<uint> mask, in Block256<uint> dst)
            => vmstore(v32u(src), mask, dst);

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// Conditionally stores source vector components to memory according to a vectorized mask
        /// where the hi bit of each corresponding component determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<long> src, Vector256<long> mask, in Block256<long> dst)
            => MaskStore(ptr(dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// Conditionally stores 64-bit source vector segments to memory according to a vectorized mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<byte> src, Vector256<ulong> mask, in Block256<ulong> dst)
            => vmstore(v64u(src), mask, dst);

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// Conditionally stores 64-bit source vector segments to memory according to a vectorized mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<ushort> src, Vector256<ulong> mask, in Block256<ulong> dst)
            => vmstore(v64u(src), mask, dst);

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// Conditionally stores 64-bit source vector segments to memory according to a vectorized mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The target memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmstore(Vector256<uint> src, Vector256<ulong> mask, in Block256<ulong> dst)
            => vmstore(v64u(src), mask, dst);

        [MethodImpl(Inline)]
        static unsafe void vmstore(Vector128<byte> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(src, mask, ptr(ref dst));

        [MethodImpl(Inline)]
        static unsafe void vmstore(Vector128<sbyte> src, Vector128<byte> mask, ref byte dst)
            => MaskMove(v8u(src), v8u(mask), ptr(ref dst));

        [MethodImpl(Inline)]
        static unsafe void vmstore(Vector128<short> src, Vector128<byte> mask, ref byte dst)
            => MaskMove(v8u(src), mask, ptr(ref dst));

        [MethodImpl(Inline)]
        static unsafe void vmstore(Vector128<ushort> src, Vector128<byte> mask, ref byte dst)
            => MaskMove(v8u(src), mask, ptr(ref dst));

        [MethodImpl(Inline)]
        static unsafe void vmstore(Vector128<int> src, Vector128<byte> mask, ref byte dst)
            => MaskMove(v8u(src), mask, ptr(ref dst));

        [MethodImpl(Inline)]
        static unsafe void vmstore(Vector128<uint> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(v8u(src), mask, ptr(ref dst));

        [MethodImpl(Inline)]
        static unsafe void vmstore(Vector128<long> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(v8u(src), mask, ptr(ref dst));

        [MethodImpl(Inline)]
        static unsafe void vmstore(Vector128<ulong> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(v8u(src), mask, ptr(ref dst));

    }
}