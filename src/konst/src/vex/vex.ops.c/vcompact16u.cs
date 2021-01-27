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
        /// 8x32u -> 8x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcompact16u(Vector256<uint> src, W128 w)
            => vcompact16u(vlo(src), cpu.vhi(src), w);

        /// <summary>
        /// (4x32u,4x32u) -> 8x16u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcompact16u(Vector128<uint> x, Vector128<uint> y, N128 w)
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
        public static Vector256<ushort> vcompact16u(Vector256<uint> x, Vector256<uint> y, N256 w)
            => vperm4x64(vpackus(x,y), Perm4L.ACBD);
    }
}