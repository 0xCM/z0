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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    
    using static As;
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// void _mm_maskstore_ps (float * mem_addr, __m128i mask, __m128 a) VMASKMOVPS m128, xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void maskstore(in Vec128<float> src, in Vec128<float> mask, ref float dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm_maskstore_pd (double * mem_addr, __m128i mask, __m128d a) VMASKMOVPD m128, xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void maskstore(in Vec128<double> src, in Vec128<double> mask, ref double dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_ps (float * mem_addr, __m256i mask, __m256 a) VMASKMOVPS m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void maskstore(in Vec256<float> src, in Vec256<float> mask, ref float dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_pd (double * mem_addr, __m256i mask, __m256d a) VMASKMOVPD m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void maskstore(in Vec256<double> src, in Vec256<double> mask, ref double dst)
            => MaskStore(refptr(ref dst), src,mask);



    }

}