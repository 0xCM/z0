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
        public static Vector128<short> vbsll(Vector128<short> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vbsll(Vector128<ushort> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vbsll(Vector128<int> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vbsll(Vector128<uint> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vbsll(Vector128<long> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vbsll(Vector128<ulong> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);
        
        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vbsll(Vector256<short> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vbsll(Vector256<ushort> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vbsll(Vector256<int> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vbsll(Vector256<uint> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vbsll(Vector256<long> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vbsll(Vector256<ulong> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);          
    }
}