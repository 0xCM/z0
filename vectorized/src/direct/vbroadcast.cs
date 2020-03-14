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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse41.X64;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Root;
    using static Nats;

    static partial class vdirect
    {
        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vbroadcast(N256 w, byte lo, byte hi)
            => vconcat(vbroadcast(n128, lo),vbroadcast(n128, hi));            

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vbroadcast(N256 w, ushort lo, ushort hi)
            => vconcat(vbroadcast(n128, lo),vbroadcast(n128, hi));            

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vbroadcast(N256 w, uint lo, uint hi)
            => vconcat(vbroadcast(n128, lo),vbroadcast(n128, hi));            

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vbroadcast(N256 w, ulong lo, ulong hi)
            => vconcat(vbroadcast(n128, lo),vbroadcast(n128, hi));            

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<sbyte> vbroadcast(N128 n, sbyte src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<byte> vbroadcast(N128 n, byte src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vbroadcast(N128 n, short src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ushort> vbroadcast(N128 n, ushort src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vbroadcast(N128 n, int src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vbroadcast(N128 n, uint src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vbroadcast(N128 n, long src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vbroadcast(N128 n, ulong src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<sbyte> vbroadcast(N256 n, sbyte src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<byte> vbroadcast(N256 n,byte src)
            => BroadcastScalarToVector256(&src);
                        
        /// <summary>
        ///  __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<short> vbroadcast(N256 n, short src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        ///  __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ushort> vbroadcast(N256 n, ushort src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<int> vbroadcast(N256 n, int src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vbroadcast(N256 n, uint src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vbroadcast(N256 n, long src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        ///  __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vbroadcast(N256 n, ulong src)
            => BroadcastScalarToVector256(&src);            

        /// <summary>
        /// __m256 _mm256_broadcast_ss (float const * mem_addr) VBROADCASTSS ymm, m32
        /// </summary>
        /// <param name="n">The bitsize selector</param>
        /// <param name="dst">The value to broadcast</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<float> vbroadcast(N256 n, float src)
            => BroadcastScalarToVector256(ptr(ref edit(in src)));

        /// <summary>
        /// __m256d _mm256_broadcast_sd (double const * mem_addr) VBROADCASTSD ymm, m64
        /// </summary>
        /// <param name="n">The bitsize selector</param>
        /// <param name="dst">The value to broadcast</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<double> vbroadcast(N256 n, double src)
            => BroadcastScalarToVector256(ptr(ref edit(in src)));

        /// <summary>
        /// __m128 _mm_broadcast_ss (float const * mem_addr) VBROADCASTSS xmm, m32
        /// </summary>
        /// <param name="n">The bitsize selector</param>
        /// <param name="dst">The value to broadcast</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<float> vbroadcast(N128 n128, float src)
            => BroadcastScalarToVector128(ptr(ref edit(in src)));

        [MethodImpl(Inline), Op]
        public static unsafe Vector128<double> vbroadcast(N128 n128, double src)
            => Vector128.Create(src);             
    }
}