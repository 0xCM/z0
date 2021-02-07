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
        /// (4x32i,4x32i) -> 8x16i
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vpack128x16i(Vector128<int> x, Vector128<int> y, N128 w = default)
            => vpackss(x,y);

        /// <summary>
        /// 8x32i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vpack128x16i(Vector256<int> src, N128 w = default)
            => vpack128x16i(vlo(src), vhi(src),w);

        /// <summary>
        /// 8x32i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vpack128x16i(Vector256<int> src)
            => vpack128x16i(vlo(src), vhi(src), w128);
    }
}