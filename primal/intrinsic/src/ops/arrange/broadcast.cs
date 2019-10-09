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
        public static unsafe Vec128<sbyte> vbroadcast128(sbyte src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> vbroadcast128(byte src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<short> vbroadcast128(short src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> vbroadcast128(ushort src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<int> vbroadcast128(int src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> vbroadcast128(uint src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> vbroadcast128(long src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));
        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> vbroadcast128(ulong src)
            => BroadcastScalarToVector128(refptr(ref asRef(src)));

        /// <summary>
        /// __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> vbroadcast256(sbyte src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        /// __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> vbroadcast256(byte src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));
                        
        /// <summary>
        ///  __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<short> vbroadcast256(short src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        ///  __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> vbroadcast256(ushort src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        /// __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<int> vbroadcast256(int src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        /// __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> vbroadcast256(uint src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        /// __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<long> vbroadcast256(long src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));

        /// <summary>
        ///  __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> vbroadcast256(ulong src)
            => BroadcastScalarToVector256(refptr(ref asRef(src)));
 
    }
}