//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Part;

    partial struct z
    {
        /// <summary>
        /// Computes the horizontal sum of the source vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector128<sbyte> vhadd(Vector128<sbyte> x, Vector128<sbyte> y)
        {
            var a = cpu.vinflate16i(x, n256, z16i);
            var b = cpu.vinflate16i(y, n256, z16i);
            return vcompact8i(vhadd(a,b), w128);
        }

        /// <summary>
        /// Computes the horizontal sum of the source vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector128<byte> vhadd(Vector128<byte> x, Vector128<byte> y)
        {
            var z0 = cpu.vinflate16i(x, n256, z16i);
            var z1 = cpu.vinflate16i(y, n256, z16i);
            return vcompact8u(vhadd(z0,z1), w128);
        }

        /// <summary>
        /// __m128i _mm_hadd_epi16 (__m128i a, __m128i b) PHADDW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector128<short> vhadd(Vector128<short> x, Vector128<short> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// __m128i _mm_hadd_epi32 (__m128i a, __m128i b) PHADDD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector128<int> vhadd(Vector128<int> x, Vector128<int> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// Computes the horizontal sum of the source vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector256<sbyte> vhadd(Vector256<sbyte> x, Vector256<sbyte> y)
        {
            (var x0, var x1) = cpu.vinflate16i(x,n512, z16i);
            (var y0, var y1) = cpu.vinflate16i(x,n512, z16i);
            return vcompact8i(vhadd(x0,y0),vhadd(x1,y1), w256);
        }

        /// <summary>
        /// __m256i _mm256_hadd_epi16 (__m256i a, __m256i b) VPHADDW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector256<short> vhadd(Vector256<short> x, Vector256<short> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// m256i _mm256_hadd_epi32 (__m256i a, __m256i b) VPHADDD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector256<int> vhadd(Vector256<int> x, Vector256<int> y)
            => HorizontalAdd(x, y);
   }
}