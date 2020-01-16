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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vshufhi4x16(Vector128<ushort> src, [Imm] byte spec)
            => ShuffleHigh(src, spec);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vshuflo4x16(Vector128<ushort> src, [Imm] byte spec)
            => ShuffleLow(src, spec);

        /// <summary>
        /// __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8)VPSHUFHW ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vshufhi4x16(Vector256<ushort> src, [Imm] byte spec)
            => ShuffleHigh(src,spec);

        /// <summary>
        /// __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8)VPSHUFHW ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vshufhi4x16(Vector256<short> src, [Imm] byte spec)
            => ShuffleHigh(src,spec);

        /// <summary>
        /// __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8)VPSHUFLW ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vshuflo4x16(Vector256<short> src, [Imm] byte spec)
            => ShuffleLow(src,spec);

        /// <summary>
        /// __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8)VPSHUFLW ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vshuflo4x16(Vector256<ushort> src, [Imm] byte spec)
            => ShuffleLow(src,spec);    

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vshufhi4x16(Vector128<short> src, [Imm] byte spec)
            => ShuffleHigh(src, spec);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vshuflo4x16(Vector128<short> src, [Imm] byte spec)
            => ShuffleLow(src, spec);

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vshufhi4x16(Vector128<short> src, Arrange4L spec)
            => vshufhi4x16(src,(byte)spec);

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int control) PSHUFHW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshufhi4x16(Vector128<ushort> src, Arrange4L spec)
            => vshufhi4x16(src,(byte)spec);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vshuflo4x16(Vector128<short> src, Arrange4L spec)
            => vshuflo4x16(src,(byte)spec);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshuflo4x16(Vector128<ushort> src, Arrange4L spec)
            => vshuflo4x16(src, (byte)spec);

        /// <summary>
        /// Shuffles the first four elements of the content vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vshuf4x16(Vector128<short> src, Arrange4L lo, Arrange4L hi)        
            => vshufhi4x16(vshuflo4x16(src,lo),hi);                   

        /// <summary>
        /// Shuffles the first four elements of the content vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshuf4x16(Vector128<ushort> src, Arrange4L lo, Arrange4L hi)        
            => vshufhi4x16(vshuflo4x16(src,lo),hi);                   

        /// <summary>
        /// __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8)VPSHUFHW ymm, ymm/m256, imm8
        /// Shuffles the hi 64 bits of each 128-bit lane as determined by the shuffle spec and leaves
        /// the lo 64 bits of each 128-bit lane unchanged
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vshufhi4x16(Vector256<ushort> src, Arrange4L spec)
            => vshufhi4x16(src,(byte)spec);

        /// <summary>
        /// __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8)VPSHUFHW ymm, ymm/m256, imm8
        /// Shuffles the hi 64 bits of each 128-bit lane as determined by the shuffle spec and leaves
        /// the lo 64 bits of each 128-bit lane unchanged
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vshufhi4x16(Vector256<short> src, Arrange4L spec)
            => vshufhi4x16(src,(byte)spec);

        /// <summary>
        /// __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8)VPSHUFLW ymm, ymm/m256, imm8
        /// Shuffles the lo 64 bits of each 128-bit lane as determined by the shuffle spec and leaves
        /// the hi 64 bits of each 128-bit lane unchanged
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vshuflo4x16(Vector256<short> src, Arrange4L spec)
            => vshuflo4x16(src,(byte)spec);    

        /// <summary>
        /// __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8)VPSHUFLW ymm, ymm/m256, imm8
        /// Shuffles the lo 64 bits of each 128-bit lane as determined by the shuffle spec and leaves the hi 64 bits of each 128-bit lane unchanged
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vshuflo4x16(Vector256<ushort> src, Arrange4L spec)
            => vshuflo4x16(src,(byte)spec);    

        /// <summary>
        /// Shuffles lo/hi parts of each 128-bit lane as respectively determined by the shuffle specs
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vshuf4x16(Vector256<short> src, Arrange4L lo, Arrange4L hi)        
            => vshufhi4x16(vshuflo4x16(src,lo),hi);                   

        /// <summary>
        /// Shuffles lo/hi parts of each 128-bit lane as respectively determined by the shuffle specs
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vshuf4x16(Vector256<ushort> src, Arrange4L lo, Arrange4L hi)        
            => vshufhi4x16(vshuflo4x16(src,lo),hi);                   


    }
}