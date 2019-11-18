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
        public static unsafe void vcmove(Vector128<sbyte> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(v8u(src), v8u(mask), pbyte(ref dst));

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
        public static unsafe void vcmove(Vector128<byte> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(src, mask, pbyte(ref dst));

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
        public static unsafe void vcmove(Vector128<short> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(v8u(src), mask, pbyte(ref dst));

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
        public static unsafe void vcmove(Vector128<ushort> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(v8u(src), mask, pbyte(ref dst));

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
        public static unsafe void vcmove(Vector128<int> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(v8u(src), mask, pbyte(ref dst));

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
        public static unsafe void vcmove(Vector128<uint> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(v8u(src), mask, pbyte(ref dst));

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
        public static unsafe void vcmove(Vector128<long> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(v8u(src), mask, pbyte(ref dst));

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
        public static unsafe void vcmove(Vector128<ulong> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(v8u(src), mask, pbyte(ref dst));

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void vcmove(Vector256<sbyte> src, Vector256<byte> mask, ref byte dst)
        {
            vcmove(vlo(src), vlo(mask), ref dst);
            vcmove(vhi(src), vhi(mask), ref seek(ref dst, 16));
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
        public static unsafe void vcmove(Vector256<byte> src, Vector256<byte> mask, ref byte dst)
        {
            vcmove(vlo(src), vlo(mask), ref dst);
            vcmove(vhi(src), vhi(mask), ref seek(ref dst, 16));
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
        public static unsafe void vcmove(Vector256<short> src, Vector256<byte> mask, ref byte dst)
        {
            vcmove(vlo(src), vlo(mask), ref dst);
            vcmove(vhi(src), vhi(mask), ref seek(ref dst, 16));
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
        public static unsafe void vcmove(Vector256<ushort> src, Vector256<byte> mask, ref byte dst)
        {
            vcmove(vlo(src), vlo(mask), ref dst);
            vcmove(vhi(src), vhi(mask), ref seek(ref dst, 16));
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
        public static unsafe void vcmove(Vector256<int> src, Vector256<byte> mask, ref byte dst)
        {
            vcmove(vlo(src), vlo(mask), ref dst);
            vcmove(vhi(src), vhi(mask), ref seek(ref dst, 16));
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
        public static unsafe void vcmove(Vector256<uint> src, Vector256<byte> mask, ref byte dst)
        {
            vcmove(vlo(src), vlo(mask), ref dst);
            vcmove(vhi(src), vhi(mask), ref seek(ref dst, 16));
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
        public static unsafe void vcmove(Vector256<long> src, Vector256<byte> mask, ref byte dst)
        {
            vcmove(vlo(src), vlo(mask), ref dst);
            vcmove(vhi(src), vhi(mask), ref seek(ref dst, 16));
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
        public static unsafe void vcmove(Vector256<ulong> src, Vector256<byte> mask, ref byte dst)
        {
            vcmove(vlo(src), vlo(mask), ref dst);
            vcmove(vhi(src), vhi(mask), ref seek(ref dst, 16));
        }

    }
}