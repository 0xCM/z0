//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse;    
    using static System.Runtime.Intrinsics.X86.Sse2;    
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    
    using static Memories;    

    public partial class dvec
    {
        /// <summary>
        /// __m128i _mm_min_epu8 (__m128i a, __m128i b) PMINUB xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector128<byte> vmin(Vector128<byte> x, Vector128<byte> y)
            => Min(x, y);

        /// <summary>
        /// __m128i _mm_min_epi8 (__m128i a, __m128i b) PMINSB xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector128<sbyte> vmin(Vector128<sbyte> x, Vector128<sbyte> y)
            => Min(x, y);

        /// <summary>
        /// __m128i _mm_min_epi16 (__m128i a, __m128i b) PMINSW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector128<short> vmin(Vector128<short> x, Vector128<short> y)
            => Min(x, y);

        /// <summary>
        /// __m128i _mm_min_epu16 (__m128i a, __m128i b) PMINUW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector128<ushort> vmin(Vector128<ushort> x, Vector128<ushort> y)
            => Min(x, y);

        /// <summary>
        /// __m128i _mm_min_epu32 (__m128i a, __m128i b) PMINUD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector128<int> vmin(Vector128<int> x, Vector128<int> y)
            => Min(x, y);

        /// <summary>
        /// __m128i _mm_min_epu32 (__m128i a, __m128i b) PMINUD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector128<uint> vmin(Vector128<uint> x, Vector128<uint> y)
            => Min(x, y);

        /// <summary>
        /// Computes the maximum values of corresponding components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector128<long> vmin(Vector128<long> x, Vector128<long> y)
        {
            var xL = V0d.vinsert(x,default, BitState.Off);
            var yL = V0d.vinsert(y,default, BitState.Off);
            return V0d.vlo(vmin(xL,yL));
        }

        /// <summary>
        /// Computes the maximum values of corresponding components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vmin(Vector128<ulong> x, Vector128<ulong> y)
            => V0d.vselect(vlt(x,y),x,y);

        /// <summary>
        /// __m256i _mm256_min_epu8 (__m256i a, __m256i b) VPMINUB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Min]
        public static Vector256<byte> vmin(Vector256<byte> x, Vector256<byte> y)
            => Min(x, y);

        /// <summary>
        /// __m256i _mm256_min_epi8 (__m256i a, __m256i b)VPMINSB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Min]
        public static Vector256<sbyte> vmin(Vector256<sbyte> x, Vector256<sbyte> y)
            => Min(x, y);

        /// <summary>
        /// __m256i _mm256_min_epi16 (__m256i a, __m256i b)VPMINSW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector256<short> vmin(Vector256<short> x, Vector256<short> y)
            => Min(x, y);

        /// <summary>
        /// __m256i _mm256_min_epu16 (__m256i a, __m256i b) VPMINUW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector256<ushort> vmin(Vector256<ushort> x, Vector256<ushort> y)
            => Min(x, y);

        /// <summary>
        /// __m256i _mm256_min_epi32 (__m256i a, __m256i b) VPMINSD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector256<int> vmin(Vector256<int> x, Vector256<int> y)
            => Min(x, y);

        /// <summary>
        /// __m256i _mm256_min_epu32 (__m256i a, __m256i b) VPMINUD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector256<uint> vmin(Vector256<uint> x, Vector256<uint> y)
            => Min(x, y);

        /// <summary>
        /// Computes the maximum values of corresponding components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector256<ulong> vmin(Vector256<ulong> x, Vector256<ulong> y)
            => V0d.vselect(vlt(x,y),x,y);

        /// <summary>
        /// Computes the maximum values of corresponding components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Min]
        public static Vector256<long> vmin(Vector256<long> x, Vector256<long> y)
            => vblend(y, x, v8u(vlt(x,y)));
    }
}