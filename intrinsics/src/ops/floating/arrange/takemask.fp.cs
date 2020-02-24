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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class dinxfp
    {        
        /// <summary>
        /// int _mm_movemask_ps (__m128 a) MOVMSKPS reg, xmm<
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        [MethodImpl(Inline), Op]
        public static int takemask(Vector128<float> src)
            => MoveMask(src);

        /// <summary>
        /// int _mm_movemask_pd (__m128d a) MOVMSKPD reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        [MethodImpl(Inline), Op]
        public static int takemask(Vector128<double> src)
            => MoveMask(src);

        /// <summary>
        /// int _mm256_movemask_ps (__m256 a) VMOVMSKPS reg, ymm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static int takemask(Vector256<float> src)
            => MoveMask(src);

        /// <summary>
        /// int _mm256_movemask_pd (__m256d a) VMOVMSKPD reg, ymm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static int takemask(Vector256<double> src)
            => MoveMask(src);
    }

}