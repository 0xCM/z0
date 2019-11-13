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
        ///<summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        ///</summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vpermhi4x16(Vector128<short> src, Perm4 spec)
            => ShuffleHigh(src, (byte)spec);

        /// <summary>
        /// __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8)VPSHUFHW ymm, ymm/m256,imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vpermhi4x16(Vector256<short> src, Perm4 spec)
            => ShuffleHigh(src, (byte)spec);

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        /// Shuffles the upper half of a vector as specified by a permutation while leaving the lower half unchanged
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vpermhi4x16(Vector128<ushort> src, Perm4 spec)
            => ShuffleHigh(src, (byte)spec);

        /// <summary>
        /// __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8) VPSHUFHW ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vpermhi4x16(Vector256<ushort> src, Perm4 spec)
            => ShuffleHigh(src, (byte)spec);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// Shuffles the lower half of a vector as specified by a permutation while leaving the upper half unchanged
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vpermlo4x16(Vector128<short> src, Perm4 spec)
            => ShuffleLow(src, (byte)spec);

        /// <summary>
        /// __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8) VPSHUFLW ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vpermlo4x16(Vector256<short> src, Perm4 spec)
            => ShuffleLow(src, (byte)spec);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// Shuffles the lower half of a vector as specified by a permutation while leaving the upper half unchanged
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vpermlo4x16(Vector128<ushort> src, Perm4 spec)
            => ShuffleLow(src, (byte)spec);        

        /// <summary>
        /// __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8)VPSHUFLW ymm, ymm/m256,imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vpermlo4x16(Vector256<ushort> src, Perm4 spec)
            => ShuffleLow(src, (byte)spec);        

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo spec</param>
        /// <param name="hi">The hi spec</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vperm4x16(Vector128<short> src, Perm4 lo, Perm4 hi)        
            => vpermhi4x16(vpermlo4x16(src,lo),hi);                   

        [MethodImpl(Inline)]
        public static Vector256<short> vperm4x16(Vector256<short> src, Perm4 lo, Perm4 hi)        
            => vpermhi4x16(vpermlo4x16(src,lo),hi);                   

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vperm4x16(Vector128<ushort> src, Perm4 lo, Perm4 hi)        
            => vpermhi4x16(vpermlo4x16(src,lo),hi);                   

        [MethodImpl(Inline)]
        public static Vector256<ushort> vperm4x16(Vector256<ushort> src, Perm4 lo, Perm4 hi)        
            => vpermhi4x16(vpermlo4x16(src,lo),hi);                   
    }
}