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
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vcompact8i(Vector128<short> x, Vector128<short> y, N128 w)
            => vpackss(x,y);

        /// <summary>
        /// (16x16i,16x16i) -> 32x8i
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vcompact8i(Vector256<short> x, Vector256<short> y, N256 w)
            => vperm4x64(vpackss(x,y), Perm4L.ACBD);

        /// <summary>
        /// 16x16i -> 16x8i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vcompact8i(Vector256<short> src, W8 w)
            => vpackss(vlo(src), vhi(src));

        /// <summary>
        /// 16x16i -> 16x8i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vcompact8i(Vector256<short> src, W128 w)
            => vpackss(vlo(src), vhi(src));
    }
}