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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;

    partial class ginx
    {
        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each 8-bit segment of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vtakemask<T>(Vector128<T> src)
            where T : unmanaged
                => (uint)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit segment of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vtakemask<T>(Vector256<T> src)
            where T : unmanaged
                => (uint)MoveMask(v8u(src));
    }
}