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

    using static zfunc;
    using static As;

    partial class dinx
    {         
        /// <summary>
        /// __m256i _mm256_srai_epi16 (__m256i a, int imm8) VPSRAW ymm, ymm, imm8
        /// Applies a rightward arithmetic shift to the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsra(Vector256<short> src, byte shift)
            => ShiftRightArithmetic(src, shift);

        /// <summary>
        /// __m256i _mm256_srai_epi32 (__m256i a, int imm8) VPSRAD ymm, ymm, imm8
        /// Applies a rightward arithmetic shift to the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsra(Vector256<int> src, byte shift)
            => ShiftRightArithmetic(src, shift);

        /// <summary>
        /// _mm_srav_epi32, avx2, shift-right variable arithmetic:
        /// Applies a rightward arithmetic shift each source vector component as 
        /// specified by the amount the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsrav(Vector128<int> src, Vector128<uint> shift)
            => ShiftRightArithmeticVariable(src, shift);

        /// <summary>
        /// _mm256_srav_epi32, avx2, shift-right variable arithmetic:
        /// Applies a rightward arithmetic shift each source vector component as 
        /// specified by the amount the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsrav(Vector256<int> src, Vector256<uint> shift)
            => ShiftRightArithmeticVariable(src, shift);
    }
}