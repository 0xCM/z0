//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Konst;
    using static z;

    partial struct cpu
    {
        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector128<sbyte> vbroadcast(W128 w, sbyte src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector128<byte> vbroadcast(W128 w, byte src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector128<short> vbroadcast(W128 w, short src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector128<ushort> vbroadcast(W128 w, ushort src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector128<int> vbroadcast(W128 w, int src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector128<uint> vbroadcast(W128 w, uint src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector128<long> vbroadcast(W128 w, long src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector128<ulong> vbroadcast(W128 w, ulong src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector256<sbyte> vbroadcast(W256 w, sbyte src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector256<byte> vbroadcast(W256 w, byte src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        ///  __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector256<short> vbroadcast(W256 w, short src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        ///  __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector256<ushort> vbroadcast(W256 w, ushort src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector256<int> vbroadcast(W256 w, int src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector256<uint> vbroadcast(W256 w, uint src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector256<long> vbroadcast(W256 w, long src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        ///  __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector256<ulong> vbroadcast(W256 w, ulong src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256 _mm256_broadcast_ss (float const * mem_addr) VBROADCASTSS ymm, m32
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector256<float> vbroadcast(W256 w, float src)
            => BroadcastScalarToVector256(gptr(src));

        /// <summary>
        /// __m256d _mm256_broadcast_sd (double const * mem_addr) VBROADCASTSD ymm, m64
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector256<double> vbroadcast(W256 w, double src)
            => BroadcastScalarToVector256(gptr(src));

        /// <summary>
        /// __m128 _mm_broadcast_ss (float const * mem_addr) VBROADCASTSS xmm, m32
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector128<float> vbroadcast(W128 w, float src)
            => BroadcastScalarToVector128(gptr(src));

        /// <summary>
        /// Broadcasts a 64-bit floating point value to the upper and lower cells of a 128-bit floating-point vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The value to broadcast</param>
        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector128<double> vbroadcast(W128 w, double src)
            => Vector128.Create(src);

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline), Broadcast]
        public static Vector256<byte> vbroadcast(W256 w, byte lo, byte hi)
            => cpu.vconcat(vbroadcast(w128, lo), vbroadcast(w128, hi));

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline), Broadcast]
        public static Vector256<ushort> vbroadcast(W256 w, ushort lo, ushort hi)
            => cpu.vconcat(vbroadcast(w128, lo), vbroadcast(w128, hi));

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline), Broadcast]
        public static Vector256<uint> vbroadcast(W256 w, uint lo, uint hi)
            => cpu.vconcat(vbroadcast(w128, lo), vbroadcast(w128, hi));

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline), Broadcast]
        public static Vector256<ulong> vbroadcast(W256 w, ulong lo, ulong hi)
            => cpu.vconcat(vbroadcast(w128, lo), vbroadcast(w128, hi));

        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector512<byte> vbroadcast(W512 w, byte src)
            => (BroadcastScalarToVector256(&src), BroadcastScalarToVector256(&src));

        [MethodImpl(Inline), Broadcast]
        public static unsafe Vector512<ushort> vbroadcast(W512 w, ushort src)
            => (BroadcastScalarToVector256(&src), BroadcastScalarToVector256(&src));
    }
}