//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vbsll(in Vec128<short> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vbsll(in Vec128<ushort> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vbsll(in Vec128<int> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vbsll(in Vec128<uint> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vbsll(in Vec128<long> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vbsll(in Vec128<ulong> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);
        
        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vbsll(in Vec256<short> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vbsll(in Vec256<ushort> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vbsll(in Vec256<int> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vbsll(in Vec256<uint> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vbsll(in Vec256<long> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vbsll(in Vec256<ulong> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);          
    }
}