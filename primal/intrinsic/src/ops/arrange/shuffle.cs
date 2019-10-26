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
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The vector containing the content to rearrange</param>
        /// <param name="control">The rearrangment specification</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vshuffle(in Vec128<byte> src, in Vec128<byte> spec)
            => Shuffle(src.xmm, spec);



        ///<summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// Shuffles unsigned 8-bit integers in the source vector within 128-bit lanes 
        /// as specified by the corresponding element in the shuffle control mask
        ///</summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vshuffle(in Vec256<byte> src, in Vec256<byte> spec)
            => Shuffle(src.ymm, spec);
    }
}