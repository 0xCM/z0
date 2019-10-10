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
        /// _m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> vloadu128(in byte src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> vloadu128(in sbyte src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<short> vloadu128(in short src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> vloadu128(in ushort src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<int> vloadu128(in int src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> vloadu128(in uint src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> vloadu128(in long src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> vloadu128(in ulong src)
            => LoadDquVector128(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> vloadu256(in byte src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> vloadu256(in sbyte src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<short> vloadu256(in short src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> vloadu256(in ushort src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<int> vloadu256(in int src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> vloadu256(in uint src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<long> vloadu256(in long src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> vloadu256(in ulong src)
            => LoadDquVector256(constptr(in src));
   }
}