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
        /// _m128i _mm_lddqu_si128 (__m128i const* mem_addr)LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> loadu128(in byte src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> loadu128(in sbyte src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<short> loadu128(in short src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> loadu128(in ushort src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<int> loadu128(in int src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> loadu128(in uint src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> loadu128(in long src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> loadu128(in ulong src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> loadu256(in byte src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> loadu256(in sbyte src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<short> loadu256(in short src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> loadu256(in ushort src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<int> loadu256(in int src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> loadu256(in uint src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<long> loadu256(in long src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> loadu256(in ulong src)
            => LoadDquVector256(constptr(in src));

   }
}