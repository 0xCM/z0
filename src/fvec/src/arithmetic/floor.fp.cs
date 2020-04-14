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

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static Seed;

    partial class dinxfp
    {
        /// <summary>
        /// __m128 _mm_floor_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(9)
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vfloor(Vector128<float> x)
            => Floor(x);

        /// <summary>
        /// __m128 _mm_floor_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(9)
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vfloor(Vector128<double> x)
            => Floor(x);
        
        /// <summary>
        /// __m256 _mm256_floor_ps (__m256 a) VROUNDPS ymm, ymm/m256, imm8(9)
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vfloor(Vector256<float> x)
            => Floor(x);

        /// <summary>
        ///  __m256d _mm256_floor_pd (__m256d a) VROUNDPS ymm, ymm/m256, imm8(9)
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vfloor(Vector256<double> x)
            => Floor(x);
    }
}