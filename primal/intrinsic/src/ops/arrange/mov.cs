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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> vmov128(in byte src)
            => LoadVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> vmov128(in sbyte src)
            => LoadVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<short> vmov128(in short src)
            => LoadVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> vmov128(in ushort src)
            => LoadVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<int> vmov128(in int src)
            => LoadVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> vmov128(in uint src)
            => LoadVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> vmov128(in long src)
            => LoadVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> vmov128(in ulong src)
            => LoadVector128(constptr(in src));

        /// <summary>
        /// __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, m256
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> vmov256(in sbyte src)
            => LoadVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, m256
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> vmov256(in byte src)
            => LoadVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, m256
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<short> vmov256(in short src)
            => LoadVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, m256
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> vmov256(in ushort src)
            => LoadVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, m256
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<int> vmov256(in int src)
            => LoadVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, m256
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> vmov256(in uint src)
            => LoadVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, m256
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<long> vmov256(in long src)
            => LoadVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, m256
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> vmov256(in ulong src)
            => LoadVector256(constptr(in src));
    }

}