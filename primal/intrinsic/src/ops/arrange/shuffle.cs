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
        ///<summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        ///</summary>
        [MethodImpl(Inline)]
        public static Vec128<short> shufflehi(in Vec128<short> src, Perm4 control)
            => ShuffleHigh(src.xmm, (byte)control);

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8<
        /// </summary>
        /// <param name="src"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shufflehi(in Vec128<ushort> src, Perm4 control)
            => ShuffleHigh(src.xmm, (byte)control);

        ///<summary>__m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<short> shufflelo(in Vec128<short> src, Perm4 control)
            => ShuffleLow(src.xmm, (byte)control);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shufflelo(in Vec128<ushort> src, Perm4 control)
            => ShuffleLow(src.xmm, (byte)control);        

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four
        /// elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shuffle(in Vec128<ushort> src, Perm4 lo, Perm4 hi)        
            => shufflehi(shufflelo(src,lo),hi);                   

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four
        /// elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vec128<short> shuffle(in Vec128<short> src, Perm4 lo, Perm4 hi)        
            => shufflehi(shufflelo(src,lo),hi);                   

        /// <summary>
        /// __m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<int> shuffle(in Vec128<int> src, Perm4 control)
            => Shuffle(src.xmm, (byte)control);

        /// <summary>
        /// __m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="control"></param>
        [MethodImpl(Inline)]
        public static Vec128<uint> shuffle(in Vec128<uint> src, Perm4 control)
            => Shuffle(src.xmm, (byte)control);

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<short> shufflehi(in Vec128<short> src, byte control)
            => ShuffleHigh(src.xmm, control);

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="control"></param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shufflehi(in Vec128<ushort> src, byte control)
            => ShuffleHigh(src.xmm, control);

        ///<summary>__m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<short> shufflelo(in Vec128<short> src, byte control)
            => ShuffleLow(src.xmm, control);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shufflelo(in Vec128<ushort> src, byte control)
            => ShuffleLow(src.xmm, control);

        /// <summary>
        /// __m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="control"></param>
        [MethodImpl(Inline)]
        public static Vec128<int> shuffle(in Vec128<int> src, byte control)
            => Shuffle(src.xmm, control);

        /// <summary>
        /// __m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="control"></param>
        [MethodImpl(Inline)]
        public static Vec128<uint> shuffle(in Vec128<uint> src, byte control)
            => Shuffle(src.xmm, control);

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The vector containing the content to rearrange</param>
        /// <param name="control">The rearrangment specification</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> shuffle(in Vec128<byte> src, in Vec128<byte> mask)
            => Shuffle(src.xmm, mask);

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="mask"></param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> shuffle(in Vec128<sbyte> src, in Vec128<sbyte> mask)
            => Shuffle(src.xmm, mask);

        ///<summary>
        /// __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        /// shuffles 32-bit integers in the source vector within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vec256<int> shuffle(in Vec256<int> src, byte control)
            => Shuffle(src.ymm, control);
        
        ///<summary>
        /// __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        /// shuffles 32-bit integers in the source vector within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> shuffle(in Vec256<uint> src, byte control)
            => Shuffle(src.ymm, control);

        ///<summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// Shuffles unsigned 8-bit integers in the source vector within 128-bit lanes 
        /// as specified by the corresponding element in the shuffle control mask
        ///</summary>
        /// <param name="src">The vector containing the content to rearrange</param>
        /// <param name="control">The rearrangment specification</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> shuffle(in Vec256<byte> src, in Vec256<byte> control)
            => Shuffle(src.ymm, control);

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// Shuffles signed 8-bit integers in the source vector within 128-bit lanes 
        /// as specified by the corresponding element in the shuffle control mask
        /// </summary>
        /// <param name="src">The vector containing the content to rearrange</param>
        /// <param name="control">The rearrangment specification</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> shuffle(in Vec256<sbyte> src, in Vec256<sbyte> control)
            => Shuffle(src.ymm, control);
    }
}