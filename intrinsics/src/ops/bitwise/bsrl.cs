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
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vbsrl(Vector128<sbyte> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vbsrl(Vector128<byte> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vbsrl(Vector128<short> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vbsrl(Vector128<ushort> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vbsrl(Vector128<int> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vbsrl(Vector128<uint> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vbsrl(Vector128<long> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vbsrl(Vector128<ulong> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vbsrl(Vector256<sbyte> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vbsrl(Vector256<byte> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vbsrl(Vector256<short> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vbsrl(Vector256<ushort> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vbsrl(Vector256<int> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vbsrl(Vector256<uint> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vbsrl(Vector256<long> x, byte count)
            => ShiftRightLogical128BitLane(x, count);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vbsrl(Vector256<ulong> x, byte count)
            => ShiftRightLogical128BitLane(x, count); 
    }
}