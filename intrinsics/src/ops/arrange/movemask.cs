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
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// Constructs an integer from the most significant bit of each source vector component
        /// int _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// </summary>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector128<sbyte> src)
            => (uint)MoveMask(src);

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector128<byte> src)
            => (uint)MoveMask(src);

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector128<short> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector128<ushort> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector128<int> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector128<uint> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector128<long> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector128<ulong> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector256<sbyte> src)
            => (uint)MoveMask(src);

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector256<byte> src)
            => (uint)MoveMask(src);

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector256<short> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector256<ushort> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector256<int> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector256<uint> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector256<long> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask(Vector256<ulong> src)
            => (uint)MoveMask(v8u(src));
    }
}