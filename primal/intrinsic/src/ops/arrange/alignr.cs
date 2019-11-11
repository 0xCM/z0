//-----------------------------------------------------------------------------
// Copyy   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx
    {        
        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 1-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N1 n)
            => AlignRight(x, y, 1);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a s-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N2 n)
            => AlignRight(x, y, 2);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 3-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N3 n)
            => AlignRight(x, y, 3);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 4-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N4 n)
            => AlignRight(x, y, 4);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 5-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N5 n)
            => AlignRight(x, y, 5);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 6-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N6 n)
            => AlignRight(x, y, 6);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 7-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N7 n)
            => AlignRight(x, y, 7);

        /// <summary>
        /// __m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count)PALIGNR xmm, xmm/m128, imm8
        /// Applies an 8-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N8 n)
            => AlignRight(x, y, 8);

        /// <summary>
        /// __m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count)PALIGNR xmm, xmm/m128, imm8
        /// Applies a 9-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N9 n)
            => AlignRight(x, y, 9);

        /// <summary>
        /// __m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count)PALIGNR xmm, xmm/m128, imm8
        /// Applies a 10-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N10 n)
            => AlignRight(x, y, 10);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count) VPALIGNR ymm,ymm, ymm/m256, imm8 
        /// </summary>
        /// <param name="x">The x source vector</param>
        /// <param name="y">The y source vector</param>
        /// <param name="offset">The number of *bytes* to shift ywards</param>
        /// <remarks>
        /// Intel's description:
        /// Performs an alignment operation by concatenating two blocks of 16-byte data 
        /// from the first and second source vectors into an intermediate 32-byte composite, 
        /// shifting the composite at byte granularity to the right by a constant immediate 
        /// specified by mask, and extracting the y-aligned 16-byte result into the 
        /// destination vector. The immediate value is considered unsigned.
        /// tmp1[255:0] := ((x[127:0] << 128) OR x[127:0]) >> (offset[7:0]*8)
        /// dst[127:0] := tmp1[127:0]
        /// tmp2[255:0] := ((x[255:128] << 128) OR x[255:128]) >> (offset[7:0]*8)
        /// dst[255:127] := tmp2[127:0]
        /// </remarks>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N0 n)
            => AlignRight(x, y, 0);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 1-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N1 n)
            => AlignRight(x, y, 1);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 2-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N2 n)
            => AlignRight(x, y, 2);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 3-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N3 n)
            => AlignRight(x, y, 3);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 4-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N4 n)
            => AlignRight(x, y, 4);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 5-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N5 n)
            => AlignRight(x, y, 5);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 6-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N6 n)
            => AlignRight(x, y, 6);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 7-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N7 n)
            => AlignRight(x, y, 7);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies an 8-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N8 n)
            => AlignRight(x, y, 8);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 9-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N9 n)
            => AlignRight(x, y, 9);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 10-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N10 n)
            => AlignRight(x, y, 10);
 
        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 10-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N11 n)
            => AlignRight(x, y, 11);
 
    }

}