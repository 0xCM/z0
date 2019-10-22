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
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> vbroadcast(N128 n, sbyte src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> vbroadcast(N128 n, byte src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vbroadcast(N128 n, short src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vbroadcast(N128 n, ushort src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vbroadcast(N128 n, int src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vbroadcast(N128 n, uint src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vbroadcast(N128 n, long src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));
        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vbroadcast(N128 n, ulong src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<sbyte> vbroadcast(N256 n, sbyte src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        /// __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vbroadcast(N256 n,byte src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));
                        
        /// <summary>
        ///  __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<short> vbroadcast(N256 n, short src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        ///  __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vbroadcast(N256 n, ushort src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        /// __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vbroadcast(N256 n, int src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        /// __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vbroadcast(N256 n, uint src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        /// __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vbroadcast(N256 n, long src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        ///  __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vbroadcast(N256 n, ulong src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));
 
    }
}