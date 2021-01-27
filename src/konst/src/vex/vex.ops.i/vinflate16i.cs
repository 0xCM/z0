//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial struct cpu
    {
        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate16i(Vector128<byte> src, W256 w)
            => vinflate16i(src, w);

        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate16i(Vector128<byte> src, W256 w, short t = 0)
            => vconvert16i(src, w);

        /// <summary>
        /// 16x8i -> 16x16i
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate16i(Vector128<sbyte> src, W256 w, short t = 0)
            => vconcat(vmaplo16i(src, w128), vmaphi16i(src, w128));

        /// <summary>
        /// 32x8i -> 32x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vinflate16i(Vector256<sbyte> src, W512 w)
            => vconvert16i(src, w);

        /// <summary>
        /// 32x8w -> 32x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vinflate16i(Vector256<byte> src, N512 w)
            => vconvert16i(src, w);
    }
}