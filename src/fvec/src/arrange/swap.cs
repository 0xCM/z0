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

    partial class fcpu
    {
        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vswaphl(Vector256<float> x)
            => cpu.vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vswaphl(Vector256<double> x)
            => cpu.vperm2x128(x,x, Perm2x4.DA);
    }
}