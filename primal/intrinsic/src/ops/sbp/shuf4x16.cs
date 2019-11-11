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
        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vshufhi4x16(Vector128<short> src, Arrange4 spec)
            => ShuffleHigh(src, (byte)spec);

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int control) PSHUFHW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshufhi4x16(Vector128<ushort> src, Arrange4 spec)
            => ShuffleHigh(src, (byte)spec);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vshuflo4x16(Vector128<short> src, Arrange4 spec)
            => ShuffleLow(src, (byte)spec);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshuflo4x16(Vector128<ushort> src, Arrange4 spec)
            => ShuffleLow(src, (byte)spec);

        /// <summary>
        /// Shuffles the first four elements of the content vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vshuf4x16(Vector128<short> src, Arrange4 lo, Arrange4 hi)        
            => vshufhi4x16(vshuflo4x16(src,lo),hi);                   

        /// <summary>
        /// Shuffles the first four elements of the content vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshuf4x16(Vector128<ushort> src, Arrange4 lo, Arrange4 hi)        
            => vshufhi4x16(vshuflo4x16(src,lo),hi);                   

        /// <summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshufhi4x16(Vector128<ushort> src, byte spec)
            => ShuffleHigh(src, spec);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vshuflo4x16(Vector128<ushort> src, byte spec)
            => ShuffleLow(src, spec);


    }

}