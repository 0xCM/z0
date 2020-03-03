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

    static class VDirect
    {
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vscalar(N128 n, sbyte a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vscalar(N128 n, byte a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vscalar(N128 n, short a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vscalar(N128 n, ushort a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vscalar(N128 n, int a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vscalar(N128 n, uint a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vscalar(N128 n, long a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vscalar(N128 n, ulong a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vscalar(N128 n, float a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vscalar(N128 n, double a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vscalar(N256 n, sbyte a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vscalar(N256 n, byte a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vscalar(N256 n, short a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vscalar(N256 n, ushort a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vscalar(N256 n, int a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vscalar(N256 n, uint a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vscalar(N256 n, long a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vscalar(N256 n, ulong a)
            => Vector256.CreateScalarUnsafe(a);
 
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vscalar(N256 n, float a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vscalar(N256 n, double a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Creates a 256-bit vector by concatenating two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The lower 128-bits of the target vector</param>
        /// <param name="hi">The upper 128-bits of the target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vconcat(Vector128<byte> lo, Vector128<byte> hi)        
            => InsertVector128(InsertVector128(default, lo, 0), hi, 1);

        /// <summary>
        /// Creates a 256-bit vector by concatenating two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The lower 128-bits of the target vector</param>
        /// <param name="hi">The upper 128-bits of the target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vconcat(Vector128<sbyte> lo, Vector128<sbyte> hi)        
            => InsertVector128(InsertVector128(default, lo, 0), hi, 1);

        /// <summary>
        /// Creates a 256-bit vector by concatenating two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The lower 128-bits of the target vector</param>
        /// <param name="hi">The upper 128-bits of the target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vconcat(Vector128<short> lo, Vector128<short> hi)        
            => InsertVector128(InsertVector128(default, lo, 0), hi, 1);

        /// <summary>
        /// Creates a 256-bit vector by concatenating two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The lower 128-bits of the target vector</param>
        /// <param name="hi">The upper 128-bits of the target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vconcat(Vector128<ushort> lo, Vector128<ushort> hi)        
            => InsertVector128(InsertVector128(default, lo, 0), hi, 1);

        /// <summary>
        /// Creates a 256-bit vector by concatenating two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The lower 128-bits of the target vector</param>
        /// <param name="hi">The upper 128-bits of the target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vconcat(Vector128<int> lo, Vector128<int> hi)        
            => InsertVector128(InsertVector128(default, lo, 0), hi, 1);

        /// <summary>
        /// Creates a 256-bit vector by concatenating two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The lower 128-bits of the target vector</param>
        /// <param name="hi">The upper 128-bits of the target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vconcat(Vector128<uint> lo, Vector128<uint> hi)        
            => InsertVector128(InsertVector128(default, lo, 0), hi, 1);

        /// <summary>
        /// Creates a 256-bit vector by concatenating two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The lower 128-bits of the target vector</param>
        /// <param name="hi">The upper 128-bits of the target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vconcat(Vector128<long> lo, Vector128<long> hi)        
            => InsertVector128(InsertVector128(default, lo, 0), hi, 1);

        /// <summary>
        /// Creates a 256-bit vector by concatenating two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The lower 128-bits of the target vector</param>
        /// <param name="hi">The upper 128-bits of the target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vconcat(Vector128<ulong> lo, Vector128<ulong> hi)        
            => InsertVector128(InsertVector128(default, lo, 0), hi, 1);

        /// <summary>
        /// Creates a 256-bit vector by concatenating two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The lower 128-bits of the target vector</param>
        /// <param name="hi">The upper 128-bits of the target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vconcat(Vector128<float> lo, Vector128<float> hi)        
            => InsertVector128(InsertVector128(default, lo, 0), hi, 1);

        /// <summary>
        /// Creates a 256-bit vector by concatenating two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The lower 128-bits of the target vector</param>
        /// <param name="hi">The upper 128-bits of the target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vconcat(Vector128<double> lo, Vector128<double> hi)        
            => InsertVector128(InsertVector128(default, lo, 0), hi, 1);
 
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
            => BroadcastScalarToVector256(ptr(ref mutable(in src)));

        /// <summary>
        /// __m256d _mm256_broadcast_sd (double const * mem_addr) VBROADCASTSD ymm, m64
        /// </summary>
        /// <param name="n">The bitsize selector</param>
        /// <param name="dst">The value to broadcast</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<double> vbroadcast(N256 n, double src)
            => BroadcastScalarToVector256(ptr(ref mutable(in src)));

        /// <summary>
        /// __m128 _mm_broadcast_ss (float const * mem_addr) VBROADCASTSS xmm, m32
        /// </summary>
        /// <param name="n">The bitsize selector</param>
        /// <param name="dst">The value to broadcast</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<float> vbroadcast(N128 n128, float src)
            => BroadcastScalarToVector128(ptr(ref mutable(in src)));

        [MethodImpl(Inline), Op]
        public static unsafe Vector128<double> vbroadcast(N128 n128, double src)
            => Vector128.Create(src);             
    }
}