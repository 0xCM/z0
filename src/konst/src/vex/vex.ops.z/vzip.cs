//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// (8x16i,8x16i) -> 16x8i
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VZip]
        public static Vector128<sbyte> vzip(Vector128<short> x, Vector128<short> y, W8 w)
            => vpackss(x,y);

        /// <summary>
        /// (8x16i,8x16i) -> 16x8u
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        /// <param name="z">Specifies a zero-extended target</param>
        [MethodImpl(Inline), VZip]
        public static Vector128<byte> vzip(Vector128<short> x, Vector128<short> y, W8 w, N0 n)
            => vpackus(x,y);

        /// <summary>
        /// (16x16i,16x16i) -> 32x8i
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VZip]
        public static Vector256<sbyte> vzip(Vector256<short> x, Vector256<short> y, W8 w)
            => vperm4x64(vpackss(x,y), Perm4L.ACBD);

        /// <summary>
        /// (8x16u,8x16u) -> 16x8u
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VZip]
        public static Vector128<byte> vzip(Vector128<ushort> x, Vector128<ushort> y, W8 w)
            => vpackus(x,y);

        /// <summary>
        /// (16x16u,16x16u) -> 32x8u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), VZip]
        public static Vector256<byte> vzip(Vector256<ushort> x, Vector256<ushort> y, W8 w)
            => vperm4x64(vpackus(x,y), Perm4L.ACBD);

        /// <summary>
        /// (4x32i,4x32i) -> 8x16i
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="w">The target vector width</param>
        [MethodImpl(Inline), VZip]
        public static Vector128<short> vzip(Vector128<int> x, Vector128<int> y, W16 w)
            => vpackss(x,y);

        /// <summary>
        /// (8x32i,8x32i) -> 16x16i
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VZip]
        public static Vector256<short> vzip(Vector256<int> x, Vector256<int> y, W16 w)
            => vperm4x64(vpackss(x,y), Perm4L.ACBD);

        /// <summary>
        /// (4x32u,4x32u) -> 8x16u
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VZip]
        public static Vector128<ushort> vzip(Vector128<uint> x, Vector128<uint> y, W16 w)
            => vpackus(x,y);

        /// <summary>
        ///__m128i _mm_packus_epi32 (__m128i a, __m128i b)PACKUSDW xmm, xmm/m128
        /// (4x32w,4x32w) -> 8x16w
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        /// <param name="w">Specifies a zero-extended target</param>
        [MethodImpl(Inline), VZip]
        public static Vector128<ushort> vzip(Vector128<int> x, Vector128<int> y, W16 w, N0 n)
            => vpackus(x,y);

        /// <summary>
        /// __m256i _mm256_packus_epi16 (__m256i a, __m256i b)VPACKUSWB ymm, ymm, ymm/m256
        /// (16x8w,16x8w) -> 32x8w
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        /// <param name="w">Specifies a zero-extended target</param>
        [MethodImpl(Inline), VZip]
        public static Vector256<byte> vzip(Vector256<short> x, Vector256<short> y, N8 w, N0 n)
            => vpackus(x,y);

        /// <summary>
        /// __m256i _mm256_packus_epi32 (__m256i a, __m256i b)VPACKUSDW ymm, ymm, ymm/m256
        /// (8x32w,8x32w) -> 16x16w
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        /// <param name="w">Specifies a zero-extended target</param>
        [MethodImpl(Inline), VZip]
        public static Vector256<ushort> vzip(Vector256<int> x, Vector256<int> y, N16 w, N0 n)
            => vpackus(x,y);

        /// <summary>
        /// (8x32w,8x32w) -> 16x16w
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        /// <remarks>The vpackus intrinsic emits a vector in the following form:
        /// [0, 1, 2, 3, 8, 9, 10, 11, 4, 5, 6, 7, 12, 13, 14, 15]
        /// To make use of the result, it must be permuted to a more reasonable order,
        /// [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]
        /// </remarks>
        [MethodImpl(Inline), VZip]
        public static Vector256<ushort> vzip(Vector256<uint> x, Vector256<uint> y, W16 w)
            => vperm4x64(vpackus(x,y), Perm4L.ACBD);

        /// <summary>
        /// (8x32u, 8x32u) -> 16x8u
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VZip]
        public static Vector128<byte> vzip(Vector256<uint> x, Vector256<uint> y, W8 w)
            => vpack128x8u(vpack256x16u(x, y, n256), w128);

        /// <summary>
        /// (2x64w,2x64w) -> 4x32w
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VZip]
        public static Vector128<uint> vzip(Vector128<ulong> x, Vector128<ulong> y, W32 w)
            => vparts(n128, (uint)vcell(x, 0),(uint)vcell(x, 1),(uint)vcell(y, 0),(uint)vcell(y, 1));

        /// <summary>
        /// (4x64w,4x64w) -> 8x32w
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VZip]
        public static Vector256<uint> vzip(Vector256<ulong> x, Vector256<ulong> y, W32 w)
            => vconcat(vpack128x32u(x, w128), vpack128x32u(y, w128));

        /// <summary>
        /// (4x32u,4x32u,4x32u,4x32u) -> 16x8u
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VZip]
        public static Vector128<byte> vzip(Vector128<uint> x0, Vector128<uint> x1, Vector128<uint> x2, Vector128<uint> x3, W8 w)
            => vpack128x8u(vpack128x16u(x0, x1, w128), vpack128x16u(x2, x3, w128), w128);

        /// <summary>
        /// (8x32u,8x32u,8x32u,8x32u) -> 32x8w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VZip]
        public static Vector256<byte> vzip(Vector256<uint> x0, Vector256<uint> x1, Vector256<uint> x2, Vector256<uint> x3, W8 w)
            => vpack256x8u(vpack256x16u(x0, x1, w256), vpack256x16u(x2, x3, w256), w256);
    }
}