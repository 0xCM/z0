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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_unpacklo_epi8 (__m128i a, __m128i b) PUNPCKLBW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vunpacklo(Vector128<sbyte> x, Vector128<sbyte> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m128i _mm_unpacklo_epi8 (__m128i a, __m128i b) PUNPCKLBW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vunpacklo(Vector128<byte> x, Vector128<byte> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m128i _mm_unpacklo_epi16 (__m128i a, __m128i b) PUNPCKLWD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vunpacklo(Vector128<short> x, Vector128<short> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m128i _mm_unpacklo_epi16 (__m128i a, __m128i b) PUNPCKLWD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vunpacklo(Vector128<ushort> x, Vector128<ushort> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m128i _mm_unpacklo_epi32 (__m128i a, __m128i b) PUNPCKLDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vunpacklo(Vector128<int> x, Vector128<int> y)
            => UnpackLow(x, y);

        /// <summary>
        /// __m128i _mm_unpacklo_epi32 (__m128i a, __m128i b) PUNPCKLDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vunpacklo(Vector128<uint> x, Vector128<uint> y)
            => UnpackLow(x, y);

        /// <summary>
        ///  __m128i _mm_unpacklo_epi64 (__m128i a, __m128i b) PUNPCKLQDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vunpacklo(Vector128<long> x, Vector128<long> y)
            => UnpackLow(x, y);

        /// <summary>
        ///  __m128i _mm_unpacklo_epi64 (__m128i a, __m128i b) PUNPCKLQDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vunpacklo(Vector128<ulong> x, Vector128<ulong> y)
            => UnpackLow(x, y);

    }

}