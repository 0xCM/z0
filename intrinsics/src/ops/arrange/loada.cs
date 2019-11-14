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
        public static unsafe Vector128<byte> vloada(N128 n, in byte src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> vloada(N128 n, in sbyte src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vloada(N128 n, in short src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vloada(N128 n, in ushort src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vloada(N128 n, in int src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vloada(N128 n, in uint src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vloada(N128 n, in long src)
            => LoadAlignedVector128(constptr(in src));
 
        /// <summary>
        /// Loads a 128-bit cpu vector from an aligned memory location
        /// __m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vloada(N128 n, in ulong src)
            => LoadAlignedVector128(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vloada(N256 n, in byte src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<sbyte> vloada(N256 n, in sbyte src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<short> vloada(N256 n, in short src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vloada(N256 n, in ushort src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vloada(N256 n, in int src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vloada(N256 n, in uint src)
            => LoadAlignedVector256(constptr(in src));

        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vloada(N256 n, in long src)
            => LoadAlignedVector256(constptr(in src));
 
        /// <summary>
        /// Loads a 256-bit cpu vector from an aligned memory location
        ///  __m256i _mm256_load_si256 (__m256i const * mem_addr)VMOVDQA ymm, m256
        /// </summary>
        /// <param name="src">A readonly memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vloada(N256 n, in ulong src)
            => LoadAlignedVector256(constptr(in src));
 
    }

}