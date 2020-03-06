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

    using static Root;    

    partial class dinx
    {         
        /// <summary>
        /// __m128i _mm_srai_epi16 (__m128i a, int immediate) PSRAW xmm, imm8
        /// Applies a rightward arithmetic shift to the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to shift rightwards</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vsra(Vector128<short> src, [Shift] byte count)
            => ShiftRightArithmetic(src, count);

        /// <summary>
        /// __m128i _mm_srai_epi32 (__m128i a, int immediate) PSRAD xmm, imm8
        /// Applies a rightward arithmetic shift to the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to shift rightwards</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vsra(Vector128<int> src, [Shift] byte count)
            => ShiftRightArithmetic(src, count);

        /// <summary>
        /// __m256i _mm256_srai_epi16 (__m256i a, int imm8) VPSRAW ymm, ymm, imm8
        /// Applies a rightward arithmetic shift to the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to shift rightwards</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vsra(Vector256<short> src, [Shift] byte count)
            => ShiftRightArithmetic(src, count);

        /// <summary>
        /// __m256i _mm256_srai_epi32 (__m256i a, int imm8) VPSRAD ymm, ymm, imm8
        /// Applies a rightward arithmetic shift to the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to shift rightwards</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vsra(Vector256<int> src, [Shift] byte count)
            => ShiftRightArithmetic(src, count);
    }
}