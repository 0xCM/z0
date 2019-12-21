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

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static As;

    partial class dinx
    {         
        /// <summary>
        /// Defines the unfortunately missing _mm_slri_epi8 that shifts each vector component
        /// leftward by a common number of bits
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">The number of bits to shift left</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vsrl(Vector128<byte> src, byte shift)
        {
            var y = v8u(dinx.vsrl(v64u(src), shift));
            var m = VMask.lsb<byte>(n128, n8, (byte)(8 - shift));
            return dinx.vand(y,m);
        }

        /// <summary>
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vsrl(Vector128<sbyte> src, byte shift)
            => vsrl(src.AsByte(), shift).AsSByte();

        /// <summary>
        /// __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vsrl(Vector128<short> src, byte shift)
            => ShiftRightLogical(src, shift);


        /// <summary>
        /// __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsrl(Vector128<ushort> src, byte shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsrl(Vector128<int> src, byte shift)
            => ShiftRightLogical(src, shift);


        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsrl(Vector128<uint> src, byte shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsrl(Vector128<long> src, byte shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrl(Vector128<ulong> src, byte shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsrl(Vector256<sbyte> src, byte shift)
            => vsrl(src.AsByte(), shift).AsSByte();

        /// <summary>
        /// Defines the unfortunately missing _mm256_slri_epi16 that shifts each vector component
        /// rightward by a common number of bits
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">The number of bits to shift left</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vsrl(Vector256<byte> src, byte shift)
        {
            var y = v8u(dinx.vsrl(v64u(src), shift));
            var m = VMask.lsb<byte>(n256, n8, (byte)(8 - shift));
            return dinx.vand(y,m);
        } 

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsrl(Vector256<short> src, byte shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsrl(Vector256<ushort> src, byte shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsrl(Vector256<int> src, byte shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsrl(Vector256<uint> src, byte shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsrl(Vector256<long> src, byte shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrl(Vector256<ulong> src, byte shift)
            => ShiftRightLogical(src, shift); 

    }

}