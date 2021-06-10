//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial struct cpu
    {
        /// <summary>
        /// (16x16i,16x16i) -> 32x8i
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vpack256x8i(Vector256<short> a, Vector256<short> b)
            => vperm4x64(vpackss(a,b), Perm4L.ACBD);
    }
}