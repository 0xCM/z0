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

    partial class dinx
    {
        /// <summary>
        /// _m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> vload(in ConstBlock128<byte> src)
            => LoadDquVector128(constptr(src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> vload(in ConstBlock128<sbyte> src)
            => LoadDquVector128(constptr(src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vload(in ConstBlock128<short> src)
            => LoadDquVector128(constptr(src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vload(in ConstBlock128<ushort> src)
            => LoadDquVector128(constptr(src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vload(in ConstBlock128<int> src)
            => LoadDquVector128(constptr(src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vload(in ConstBlock128<uint> src)
            => LoadDquVector128(constptr(src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vload(in ConstBlock128<long> src)
            => LoadDquVector128(constptr(src));

        /// <summary>
        /// __m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128
        /// Loads a 128-bit cpu vector from an unaligned memory location
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vload(in ConstBlock128<ulong> src)
            => LoadDquVector128(constptr(src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vload(in ConstBlock256<byte> src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<sbyte> vload(in ConstBlock256<sbyte> src)
            => LoadDquVector256(constptr(src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<short> vload(in ConstBlock256<short> src)
            => LoadDquVector256(constptr(src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vload(in ConstBlock256<ushort> src)
            => LoadDquVector256(constptr(src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vload(in ConstBlock256<int> src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vload(in ConstBlock256<uint> src)
            => LoadDquVector256(constptr(src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vload(in ConstBlock256<long> src)
            => LoadDquVector256(constptr(src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, m256
        /// Loads a 256-bit cpu vector from the leading block of a blocked container
        /// </summary>
        /// <param name="src">A readonly blocked storage container</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vload(in ConstBlock256<ulong> src)
            => LoadDquVector256(constptr(src));


    }
}