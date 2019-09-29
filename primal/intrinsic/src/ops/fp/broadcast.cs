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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    
    using static As;
    using static zfunc;    

    partial class dfp
    {

        /// <summary>
        /// __m256 _mm256_broadcast_ss (float const * mem_addr) VBROADCASTSS ymm, m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<float> vbroadcast(in float src, out Vec256<float> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }

        /// <summary>
        /// __m256d _mm256_broadcast_sd (double const * mem_addr) VBROADCASTSD ymm, m64
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<double> vbroadcast(in double src, out Vec256<double> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }
 
        /// <summary>
        /// __m128 _mm_broadcast_ss (float const * mem_addr) VBROADCASTSS xmm, m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<float> vbroadcast(in float src, out Vec128<float> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec128<double> vbroadcast(in double src, out Vec128<double> dst)
        {
            dst = Vec128.FromParts(src,src);
            return ref dst;
        }



    }

}