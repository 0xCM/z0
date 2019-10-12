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
        public static Vec128<short> arrangehi(in Vec128<short> src, Arrange4 spec)
            => ShuffleHigh(src.xmm, (byte)spec);

        [MethodImpl(Inline)]
        public static Vec128<ushort> arrangehi(in Vec128<ushort> src, Arrange4 spec)
            => ShuffleHigh(src.xmm, (byte)spec);

        [MethodImpl(Inline)]
        public static Vec128<short> arrangelo(in Vec128<short> src, Arrange4 spec)
            => ShuffleLow(src.xmm, (byte)spec);

        [MethodImpl(Inline)]
        public static Vec128<ushort> arrangelo(in Vec128<ushort> src, Arrange4 spec)
            => ShuffleLow(src.xmm, (byte)spec);

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vec128<short> arrange(in Vec128<short> src, Arrange4 lo, Arrange4 hi)        
            => arrangehi(arrangelo(src,lo),hi);                   

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> arrange(in Vec128<ushort> src, Arrange4 lo, Arrange4 hi)        
            => arrangehi(arrangelo(src,lo),hi);                   

        [MethodImpl(Inline)]
        public static Vec128<uint> arrange(in Vec128<uint> src, Arrange4 spec)
            => Shuffle(src.xmm, (byte)spec);

        ///<summary>
        /// __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        /// shuffles 32-bit integers in the source vector within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vec256<int> arrange(in Vec256<int> src, Arrange4 control)
            => Shuffle(src.ymm, (byte)control);

        ///<summary>
        /// __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        /// shuffles 32-bit integers in the source vector within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> arrange(in Vec256<uint> src, Arrange4 control)
            => Shuffle(src.ymm, (byte)control);
    }

}