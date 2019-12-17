//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
        
    using static zfunc;

    partial class dinx    
    {        
        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vperm16x8(Vector128<byte> src, Vector128<byte> spec)
            => Shuffle(src, spec);

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vperm16x8(Vector128<sbyte> src, Vector128<byte> spec)
            => Shuffle(src, v8i(spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vperm16x8(Vector128<short> src, Vector128<byte> spec)
            => v16i(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vperm16x8(Vector128<ushort> src, Vector128<byte> spec)
            => v16u(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vperm16x8(Vector128<int> src, Vector128<byte> spec)
            => v32i(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vperm16x8(Vector128<uint> src, Vector128<byte> spec)
            => v32u(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vperm16x8(Vector128<long> src, Vector128<byte> spec)
            => v64i(Shuffle(v8u(src), spec));

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vperm16x8(Vector128<ulong> src, Vector128<byte> spec)
            => v64u(Shuffle(v8u(src), spec));

    }

}