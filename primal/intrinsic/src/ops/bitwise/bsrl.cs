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
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vbsrl(in Vec128<short> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vbsrl(in Vec128<ushort> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vbsrl(in Vec128<int> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vbsrl(in Vec128<uint> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vbsrl(in Vec128<long> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);

        /// <summary>
        /// __m128i _mm_bsrli_si128 (__m128i a, int imm8) PSRLDQ xmm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vbsrl(in Vec128<ulong> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);
        
        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vbsrl(in Vec256<short> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vbsrl(in Vec256<ushort> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vbsrl(in Vec256<int> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vbsrl(in Vec256<uint> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vbsrl(in Vec256<long> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        /// Shifts the source vector rightwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vbsrl(in Vec256<ulong> src, byte bytes)
            => ShiftRightLogical128BitLane(src, bytes); 
    }
}