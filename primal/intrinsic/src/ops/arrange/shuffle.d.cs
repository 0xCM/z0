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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vector128<short> vshufflehi(Vector128<short> src, Arrange4 spec)
            => ShuffleHigh(src, (byte)spec);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vshufflehi(Vector128<ushort> src, Arrange4 spec)
            => ShuffleHigh(src, (byte)spec);

        [MethodImpl(Inline)]
        public static Vector128<short> vshufflelo(Vector128<short> src, Arrange4 spec)
            => ShuffleLow(src, (byte)spec);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vshufflelo(Vector128<ushort> src, Arrange4 spec)
            => ShuffleLow(src, (byte)spec);

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vshuffle(Vector128<short> src, Arrange4 lo, Arrange4 hi)        
            => vshufflehi(vshufflelo(src,lo),hi);                   

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshuffle(Vector128<ushort> src, Arrange4 lo, Arrange4 hi)        
            => vshufflehi(vshufflelo(src,lo),hi);                   

        [MethodImpl(Inline)]
        public static Vector128<uint> vshuffle(Vector128<uint> src, Arrange4 spec)
            => Shuffle(src, (byte)spec);

        ///<summary>
        /// __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        /// shuffles 32-bit integers in the source vector within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vshuffle(Vector256<int> src, Arrange4 control)
            => Shuffle(src, (byte)control);

        ///<summary>
        /// __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        /// shuffles 32-bit integers in the source vector within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vshuffle(Vector256<uint> src, Arrange4 control)
            => Shuffle(src, (byte)control);

        ///<summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        ///</summary>
        [MethodImpl(Inline)]
        public static Vector128<short> vshufflehi(Vector128<short> src, Perm4 control)
            => ShuffleHigh(src, (byte)control);

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        /// Shuffles the upper half of a vector as specified by a permutation while leaving the lower half unchanged
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshufflehi(Vector128<ushort> src, Perm4 spec)
            => ShuffleHigh(src, (byte)spec);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// Shuffles the lower half of a vector as specified by a permutation while leaving the upper half unchanged
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vshufflelo(Vector128<short> src, Perm4 control)
            => ShuffleLow(src, (byte)control);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// Shuffles the lower half of a vector as specified by a permutation while leaving the upper half unchanged
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshufflelo(Vector128<ushort> src, Perm4 control)
            => ShuffleLow(src, (byte)control);        

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vshuffle(Vector128<short> src, Perm4 lo, Perm4 hi)        
            => vshufflehi(vshufflelo(src,lo),hi);                   

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshuffle(Vector128<ushort> src, Perm4 lo, Perm4 hi)        
            => vshufflehi(vshufflelo(src,lo),hi);                   

        /// <summary>
        /// __m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="spec"></param>
        [MethodImpl(Inline)]
        public static Vector128<int> vshuffle(Vector128<int> src, Perm4 spec)
            => Shuffle(src, (byte)spec);

        /// <summary>
        /// __m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vshuffle(Vector128<uint> src, Perm4 spec)
            => Shuffle(src, (byte)spec);

        ///<summary>
        /// __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        /// shuffles signed 32-bit integers in the source vector within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vshuffle(Vector256<int> src, Perm4 spec)
            => Shuffle(src, (byte)spec);

        ///<summary>
        /// __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        /// Shuffles unsigned 32-bit integers in the source vector within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vshuffle(Vector256<uint> src, Perm4 spec)
            => Shuffle(src, (byte)spec);

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="control"></param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshufflehi(Vector128<ushort> src, byte control)
            => ShuffleHigh(src, control);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshufflelo(Vector128<ushort> src, byte control)
            => ShuffleLow(src, control);

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The vector containing the content to rearrange</param>
        /// <param name="control">The rearrangment specification</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vshuffle(Vector128<byte> src, Vector128<byte> spec)
            => Shuffle(src, spec);

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vshuffle(Vector128<sbyte> src, Vector128<sbyte> spec)
            => Shuffle(src, spec);

        ///<summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// Shuffles unsigned 8-bit integers in the source vector within 128-bit lanes 
        /// as specified by the corresponding element in the shuffle control mask
        ///</summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vshuffle(Vector256<byte> src, Vector256<byte> spec)
            => Shuffle(src, spec);

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// Shuffles signed 8-bit integers in the source vector within 128-bit lanes 
        /// as specified by the corresponding element in the shuffle control mask
        /// </summary>
        /// <param name="src">The vector containing the content to rearrange</param>
        /// <param name="spec">The rearrangment specification</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vshuffle(Vector256<sbyte> src, Vector256<sbyte> spec)
            => Shuffle(src, spec);
    }
}