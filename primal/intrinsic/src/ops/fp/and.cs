//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    

    partial class dfp
    {

        /// <summary>
        /// __m128 _mm_and_ps (__m128 a, __m128 b)ANDPS xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> vand(in Vec128<float> lhs, in Vec128<float> rhs)
            => And(lhs.xmm, rhs.xmm);
        
        /// <summary>
        /// __m128d _mm_and_pd (__m128d a, __m128d b)ANDPD xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vand(in Vec128<double> lhs, in Vec128<double> rhs)
            => And(lhs.xmm, rhs.xmm);

        /// <summary>
        /// __m128 _mm_and_ps (__m128 a, __m128 b)ANDPS xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vand(in Vec256<float> lhs, in Vec256<float> rhs)
            => And(lhs.ymm, rhs.ymm);
        
        /// <summary>
        /// __m128d _mm_and_pd (__m128d a, __m128d b)ANDPD xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vand(in Vec256<double> lhs, in Vec256<double> rhs)
            => And(lhs.ymm, rhs.ymm);
    }

}