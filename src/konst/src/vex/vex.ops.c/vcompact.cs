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

    partial struct z
    {
        /// <summary>
        /// 16x16i -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<short> src, W8 w)
            => v8u(vpackss(vlo(src), vhi(src)));

        /// <summary>
        /// 8x16u -> 8x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector128<ushort> x, W8 w)
            => vcompact8u(x, default, w128, z8);

        /// <summary>
        /// 16x16u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<ushort> src, W8 w)
            => vpackus(vlo(src), vhi(src));

        /// <summary>
        /// 8x32u -> 8x8u (a scalar vector)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<uint> src, W8 w)
            => vcompact8u(vcompact16u(src, n128,z16),w128,z8);

        /// <summary>
        /// 16x32u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector tuple</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(in Vector512<uint> src, W8 w)
            => vcompact8u(src.Lo, src.Hi, w128, z8);

        /// <summary>
        /// 16x16i -> 16x8i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vcompact8i(Vector256<short> src, W8 w)
            => vpackss(vlo(src), vhi(src));

        /// <summary>
        /// 8x32u -> 8x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcompact16u(Vector256<uint> src, W16 w)
            => vcompact16u(vlo(src), vhi(src), w128, z16);

        /// <summary>
        /// 8x32i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vcompact16i(Vector256<int> src, W16 w)
            => vcompact16i(vlo(src), vhi(src), w128);

        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact32u(Vector256<ulong> src, W32 w)
            => vparts(w128, (uint)vcell(src, 0),(uint)vcell(src, 1),(uint)vcell(src, 2),(uint)vcell(src, 3));

        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vcompact32i(Vector256<long> src, W32 w)
            => vparts(w128i, (int)vcell(src, 0), (int)vcell(src, 1), (int)vcell(src, 2), (int)vcell(src, 3));

        /// <summary>
        /// 8x16u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact64u(Vector128<ushort> src, W64 w)
            => vcell64(vcompact8u(src, default, w128),0);

        /// <summary>
        /// 8x32u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact64u(Vector256<uint> src, W64 w)
            => vcompact64u(vcompact16u(src, w128), w64, z64);

        // ~ 16i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (8x16i,8x16i) -> 16x8i
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vcompact8i(Vector128<short> x, Vector128<short> y, N128 w)
            => vpackss(x,y);

        /// <summary>
        /// (8x16i,8x16i) -> 16x8u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector128<short> x, Vector128<short> y, N128 w)
            => vpackus(x,y);

        /// <summary>
        /// (16x16i,16x16i) -> 32x8i
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vcompact8i(Vector256<short> x, Vector256<short> y, N256 w, sbyte t = 0)
            => vperm4x64(vpackss(x,y), Perm4L.ACBD);

        /// <summary>
        /// (8x16u,8x16u) -> 16x8u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector128<ushort> x, Vector128<ushort> y, N128 w, byte t = 0)
            => vpackus(x,y);

        /// <summary>
        /// (16x16u,16x16u) -> 32x8u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcompact8u(Vector256<ushort> x, Vector256<ushort> y, N256 w, byte t = 0)
            => vperm4x64(vpackus(x,y), Perm4L.ACBD);

        /// <summary>
        /// (4x32i,4x32i) -> 8x16i
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vcompact16i(Vector128<int> x, Vector128<int> y, N128 w, short t = 0)
            => vpackss(x,y);

        /// <summary>
        /// (8x32i,8x32i) -> 16x16i
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vcompact16i(Vector256<int> x, Vector256<int> y, N256 w, short t = 0)
            => vperm4x64(vpackss(x,y), Perm4L.ACBD);

        /// <summary>
        /// (4x32u,4x32u) -> 8x16u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcompact16u(Vector128<uint> x, Vector128<uint> y, N128 w, ushort t = 0)
            => vpackus(x,y);

        /// <summary>
        /// (8x32w,8x32w) -> 16x16w
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <remarks>The vpackus intrinsic emits a vector in the following form:
        /// [0, 1, 2, 3, 8, 9, 10, 11, 4, 5, 6, 7, 12, 13, 14, 15]
        /// To make use of the result, it must be permuted to a more reasonable order,
        /// [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vcompact16u(Vector256<uint> x, Vector256<uint> y, N256 w, ushort t = 0)
            => vperm4x64(vpackus(x,y), Perm4L.ACBD);

        /// <summary>
        /// (8x32u, 8x32u) -> 16x8u
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<uint> x0, Vector256<uint> x1, N128 w, byte t = 0)
            => vcompact8u(vcompact16u(x0, x1, n256, Konst.z16), w);

        /// <summary>
        /// (2x64w,2x64w) -> 4x32w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact32u(Vector128<ulong> x0, Vector128<ulong> x1, N128 w, uint t = 0)
            => vparts(n128, (uint)vcell(x0, 0),(uint)vcell(x0, 1),(uint)vcell(x1, 0),(uint)vcell(x1, 1));

        /// <summary>
        /// (4x64w,4x64w) -> 8x32w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcompact32u(Vector256<ulong> x0, Vector256<ulong> x1, N256 w, uint t = 0)
            => cpu.vconcat(vcompact32u(x0, n128,t), vcompact32u(x1, n128,t));

        /// <summary>
        /// (4x32u,4x32u,4x32u,4x32u) -> 16x8u
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector128<uint> x0, Vector128<uint> x1, Vector128<uint> x2, Vector128<uint> x3, N128 w, byte t = 0)
            => vcompact8u(vcompact16u(x0, x1, n128, Konst.z8), vcompact16u(x2, x3, n128, Konst.z8),w,t);

        /// <summary>
        /// (8x32u,8x32u,8x32u,8x32u) -> 32x8w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcompact8u(Vector256<uint> x0, Vector256<uint> x1, Vector256<uint> x2, Vector256<uint> x3, N256 w, byte t = 0)
            => vcompact8u(vcompact16u(x0,x1,n256,Konst.z16), vcompact16u(x2,x3,n256,Konst.z16),w);

        /// <summary>
        /// 16x32u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector tuple</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(in Vector512<uint> src, W128 w)
            => vcompact8u(src.Lo, src.Hi, w);

        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact32u(Vector256<ulong> src, W128 w, uint t = 0)
            => vparts(n128, (uint)vcell(src, 0),(uint)vcell(src, 1),(uint)vcell(src, 2),(uint)vcell(src, 3));

        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vcompact32i(Vector256<long> src, W128 w, int t = 0)
            => vparts(w128i, (int)vcell(src, 0), (int)vcell(src, 1), (int)vcell(src, 2), (int)vcell(src, 3));

        /// <summary>
        /// 16x16i -> 16x8i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vcompact8i(Vector256<short> src, W128 w, sbyte t = 0)
            => vpackss(vlo(src), vhi(src));

        /// <summary>
        /// 16x16i -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<short> src, W128 w, byte t = 0)
            => v8u(vpackss(vlo(src), vhi(src)));

        /// <summary>
        /// 8x16u -> 8x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector128<ushort> x, W128 w, byte t = 0)
            => vcompact8u(x, default, w, t);

        /// <summary>
        /// 16x16u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<ushort> src, W128 w, byte t = 0)
            => vpackus(vlo(src), vhi(src));

        /// <summary>
        /// 8x16u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact64u(Vector128<ushort> src, W64 w, ulong t)
            => vcell64(vcompact8u(src, default, n128, Konst.z8),0);

        /// <summary>
        /// 8x32u -> 8x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcompact16u(Vector256<uint> src, W128 w, ushort t = 0)
            => vcompact16u(vlo(src), vhi(src),w,t);

        /// <summary>
        /// 8x32u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact64u(Vector256<uint> src, W64 w, ulong t = 0)
            => vcompact64u(vcompact16u(src, n128,Konst.z16),w,t);

        /// <summary>
        /// 8x32u -> 8x8u (a scalar vector)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<uint> src, W128 w, byte t = 0)
            => vcompact8u(vcompact16u(src, n128,Konst.z16),w,t);

        /// <summary>
        /// 8x32i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vcompact16i(Vector256<int> src, N128 w, short t = 0)
            => vcompact16i(vlo(src), vhi(src),w,t);
   }
}