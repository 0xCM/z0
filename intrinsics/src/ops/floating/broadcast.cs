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
        /// <param name="n">The bitsize selector</param>
        /// <param name="dst">The value to broadcast</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<float> vbroadcast(N256 n, float src)
            => BroadcastScalarToVector256(refptr(ref asRef(in src)));

        /// <summary>
        /// __m256d _mm256_broadcast_sd (double const * mem_addr) VBROADCASTSD ymm, m64
        /// </summary>
        /// <param name="n">The bitsize selector</param>
        /// <param name="dst">The value to broadcast</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<double> vbroadcast(N256 n, double src)
            => BroadcastScalarToVector256(refptr(ref asRef(in src)));

        /// <summary>
        /// __m128 _mm_broadcast_ss (float const * mem_addr) VBROADCASTSS xmm, m32
        /// </summary>
        /// <param name="n">The bitsize selector</param>
        /// <param name="dst">The value to broadcast</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<float> vbroadcast(N128 n128, float src)
            => BroadcastScalarToVector128(refptr(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static unsafe Vector128<double> vbroadcast(N128 n128, double src)
            => Vector128.Create(src);        
    }
}