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
        /// 16x16i -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<short> src)
            => v8u(vpackss(vlo(src), vhi(src)));

        /// <summary>
        /// 8x16u -> 8x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector128<ushort> x)
            => vcompact8u(x, default, w128);

        /// <summary>
        /// 16x16u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<ushort> src)
            => vpackus(vlo(src), vhi(src));

        /// <summary>
        /// 8x32u -> 8x8u (a scalar vector)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<uint> src)
            => vcompact8u(vcompact16u(src, w128), w128);

        /// <summary>
        /// 16x32u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(in Vector512<uint> src)
            => vcompact8u(src.Lo, src.Hi, w128);

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
        /// (8x16u,8x16u) -> 16x8u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector128<ushort> x, Vector128<ushort> y, N128 w)
            => vpackus(x,y);

        /// <summary>
        /// (16x16u,16x16u) -> 32x8u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcompact8u(Vector256<ushort> x, Vector256<ushort> y, N256 w)
            => vperm4x64(vpackus(x,y), Perm4L.ACBD);

        /// <summary>
        /// (8x32u, 8x32u) -> 16x8u
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<uint> x0, Vector256<uint> x1, N128 w)
            => vcompact8u(vcompact16u(x0, x1, n256), w);

        /// <summary>
        /// (4x32u,4x32u,4x32u,4x32u) -> 16x8u
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector128<uint> x0, Vector128<uint> x1, Vector128<uint> x2, Vector128<uint> x3, N128 w)
            => vcompact8u(vcompact16u(x0, x1, w128), vcompact16u(x2, x3, w128), w);

        /// <summary>
        /// (8x32u,8x32u,8x32u,8x32u) -> 32x8w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcompact8u(Vector256<uint> x0, Vector256<uint> x1, Vector256<uint> x2, Vector256<uint> x3, N256 w)
            => vcompact8u(vcompact16u(x0, x1, w256), vcompact16u(x2, x3, w256), w);

        /// <summary>
        /// 16x32u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector tuple</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(in Vector512<uint> src, W128 w)
            => vcompact8u(src.Lo, src.Hi, w);

        /// <summary>
        /// 16x16i -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<short> src, W128 w)
            => v8u(vpackss(vlo(src), vhi(src)));

        /// <summary>
        /// 8x16u -> 8x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector128<ushort> x, W128 w)
            => vcompact8u(x, default, w);

        /// <summary>
        /// 16x16u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<ushort> src, W128 w)
            => vpackus(vlo(src), vhi(src));

        /// <summary>
        /// 8x32u -> 8x8u (a scalar vector)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact8u(Vector256<uint> src, W128 w)
            => vcompact8u(vcompact16u(src, w128), w);
    }
}