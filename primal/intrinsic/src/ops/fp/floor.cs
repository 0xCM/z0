//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    
    using static As;
    using static AsIn;

    partial class dfp
    {

        /// <summary>
        /// __m128 _mm_floor_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(9)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> vfloor(in Vec128<float> src)
            => Floor(src.xmm);

        /// <summary>
        /// __m128 _mm_floor_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(9)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vfloor(in Vec128<double> src)
            => Floor(src.xmm);
        
        /// <summary>
        /// __m256 _mm256_floor_ps (__m256 a) VROUNDPS ymm, ymm/m256, imm8(9)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vfloor(in Vec256<float> src)
            => Floor(src.ymm);

        /// <summary>
        ///  __m256d _mm256_floor_pd (__m256d a) VROUNDPS ymm, ymm/m256, imm8(9)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vfloor(in Vec256<double> src)
            => Floor(src.ymm);
 


    }

}