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

    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// _m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> vload(in byte src, out Vector128<byte> dst)
            => dst = LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> vload(in sbyte src, out Vector128<sbyte> dst)
            => dst = LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vload(in short src, out Vector128<short> dst)
            => dst = LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vload(in ushort src, out Vector128<ushort> dst)
            => dst = LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vload(in int src, out Vector128<int> dst)
            => dst = LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vload(in uint src, out Vector128<uint> dst)
            => dst = LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vload(in long src, out Vector128<long> dst)
            => dst = LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vload(in ulong src, out Vector128<ulong> dst)
            => dst = LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vload(in byte src, out Vector256<byte> dst)
            => dst = LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<sbyte> vload(in sbyte src, out Vector256<sbyte> dst)
            => dst = LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<short> vload(in short src, out Vector256<short> dst)
            => dst = LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vload(in ushort src, out Vector256<ushort> dst)
            => dst = LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vload(in int src, out Vector256<int> dst)
            => dst = LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vload(in uint src, out Vector256<uint> dst)
            => dst = LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vload(in long src, out Vector256<long> dst)
            => dst = LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vload(in ulong src, out Vector256<ulong> dst)
            => dst = LoadDquVector256(constptr(in src));
   }
}