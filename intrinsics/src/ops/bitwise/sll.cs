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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;
    
    partial class dinx
    {   
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsll(Vector256<sbyte> src, Vector128<sbyte> offset)
            => vsll(src, (byte)offset.Item(0));

        [MethodImpl(Inline)]
        public static Vector256<byte> vsll(Vector256<byte> src, Vector128<byte> offset)
            => vsll(src, offset.Item(0));

        /// <summary>
        /// __m256i _mm256_sll_epi16 (__m256i a, __m128i count)VPSLLW ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<short> vsll(Vector256<short> src, Vector128<short> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_sll_epi16 (__m256i a, __m128i count) VPSLLW ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsll(Vector256<ushort> src, Vector128<ushort> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        ///  __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSLLD ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<int> vsll(Vector256<int> src, Vector128<int> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        ///  __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSLLD ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsll(Vector256<uint> src, Vector128<uint> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _m256i _mm256_sll_epi64 (__m256i a, __m128i count)VPSLLQ ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<long> vsll(Vector256<long> src, Vector128<long> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _m256i _mm256_sll_epi64 (__m256i a, __m128i count)VPSLLQ ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsll(Vector256<ulong> src, Vector128<ulong> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vsll(Vector128<byte> src, byte offset)
            => dinxc.vsll(src, offset);

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vsll(Vector128<sbyte> src, byte offset)
            => vsll(src.AsByte(), offset).AsSByte();

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsll(Vector256<sbyte> src, byte offset)
            => vsll(src.AsByte(), offset).AsSByte();

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsll(Vector128<ushort> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsll(Vector128<int> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsll(Vector128<uint> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsll(Vector128<long> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsll(Vector128<ulong> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vsll(Vector256<byte> src, byte offset)
            => dinxc.vsll(src,offset);

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vsll(Vector128<short> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsll(Vector256<short> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsll(Vector256<ushort> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsll(Vector256<int> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsll(Vector256<uint> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsll(Vector256<long> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsll(Vector256<ulong> src, byte offset)
            => ShiftLeftLogical(src, offset); 
    }
}