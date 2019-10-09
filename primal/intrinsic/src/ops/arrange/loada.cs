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

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> loada128(in byte src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> loada128(in sbyte src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<short> loada128(in short src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> loada128(in ushort src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<int> loada128(in int src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> loada128(in uint src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> loada128(in long src)
            => LoadAlignedVector128(constptr(in src));
 
        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> loada128(in ulong src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> loada256(in byte src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> loada256(in sbyte src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<short> loada256(in short src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> loada256(in ushort src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<int> loada256(in int src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> loada256(in uint src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<long> loada256(in long src)
            => LoadAlignedVector256(constptr(in src));
 
        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> loada256(in ulong src)
            => LoadAlignedVector256(constptr(in src));
 
    }

}