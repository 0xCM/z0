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
        /// <summary>
        /// Defines the unfortunately missing _mm_slli_epi8 that shifts each vector component
        /// leftward by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift left</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vsll(Vector128<byte> src, byte shift)
        {
            var y = v8u(dinx.vsll(v64u(src), shift));
            var m = CpuVector.msbmask(n128, n8, (byte)(8 - shift),z8);
            return dinx.vand(y,m);
        }

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vsll(Vector128<sbyte> src, byte shift)
            => vsll(src.AsByte(), shift).AsSByte();

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsll(Vector256<sbyte> src, byte shift)
            => vsll(src.AsByte(), shift).AsSByte();

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsll(Vector128<ushort> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsll(Vector128<int> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsll(Vector128<uint> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsll(Vector128<long> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsll(Vector128<ulong> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// Defines the unfortunately missing _mm256_slli_epi16 that shifts each vector component
        /// leftward by a common number of bits
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">The number of bits to shift left</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vsll(Vector256<byte> src, byte shift)
        {
            var y = v8u(dinx.vsll(v64u(src), shift));
            var m = CpuVector.msbmask(n256, n8, (byte)(8 - shift),z8);
            return dinx.vand(y,m);
        }

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vsll(Vector128<short> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsll(Vector256<short> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsll(Vector256<ushort> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsll(Vector256<int> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsll(Vector256<uint> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsll(Vector256<long> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsll(Vector256<ulong> src, byte shift)
            => ShiftLeftLogical(src, (byte)shift); 
    }
}