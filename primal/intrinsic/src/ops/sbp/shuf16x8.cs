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
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vshuf16x8(Vector128<byte> src, Vector128<byte> spec)
            => Shuffle(src, spec);

        ///<summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// Shuffles source vector components within 128-bit lanes as specified by the corresponding component in the shuffle spec
        ///</summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vshuf16x8(Vector256<byte> src, Vector256<byte> spec)
            => Shuffle(src, spec);

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// Shuffles source vector components within 128-bit lanes as specified by the corresponding component in the shuffle spec
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vshuf16x8(Vector128<sbyte> src, Vector128<sbyte> spec)
            => Shuffle(src, spec);

        /// <summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// Shuffles source vector components within 128-bit lanes as specified by the corresponding component in the shuffle spec
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vshuf16x8(Vector256<sbyte> src, Vector256<sbyte> spec)
            => Shuffle(src, spec);
    }
}