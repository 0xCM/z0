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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;
    
    partial class dinx
    {           
        /// <summary>
        /// Defines the unfortunately missing _mm_slli_epi8 that shifts each vector component leftward by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count left</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vsll(Vector128<byte> src, [Shift] byte count)
        {
            var y = v8u(dinx.vsll(v64u(src), count));
            var m = vmask.vmsb(n128, n8, (byte)(8 - count),z8);
            return dinx.vand(y,m);
        }

        /// <summary>
        /// Shifts each component in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count each component</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vsll(Vector128<sbyte> src, [Shift] byte count)
            => v8i(vsll(src.AsByte(), count));

        /// <summary>
        /// Shifts each component in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count each component</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vsll(Vector256<sbyte> src, [Shift] byte count)
            => vsll(src.AsByte(), count).AsSByte();

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vsll(Vector128<ushort> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vsll(Vector128<int> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vsll(Vector128<uint> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vsll(Vector128<long> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vsll(Vector128<ulong> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// Defines the unfortunately missing _mm256_slli_epi16 that shifts each vector component
        /// leftward by a common number of bits
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bits to count left</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vsll(Vector256<byte> src, [Shift] byte count)
        {
            var y = v8u(dinx.vsll(v64u(src), count));
            var m = vmask.vmsb(n256, n8, (byte)(8 - count),z8);
            return dinx.vand(y,m);
        }

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vsll(Vector128<short> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vsll(Vector256<short> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vsll(Vector256<ushort> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vsll(Vector256<int> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vsll(Vector256<uint> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vsll(Vector256<long> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vsll(Vector256<ulong> src, [Shift] byte count)
            => ShiftLeftLogical(src, (byte)count); 
    }
}