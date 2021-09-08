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
    using static cpu;

    partial struct vpack
    {
        /// <summary>
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<int> vinflate1024x32i(Vector256<sbyte> src)
        {
            (var lo, var hi) = vinflate512x16i(src);
            var x0 = vpack.vlo256x32i(lo);
            var x1 = vpack.vhi256x32i(lo);
            var x2 = vpack.vlo256x32i(hi);
            var x3 = vpack.vhi256x32i(hi);
            return (x0,x1,x2,x3);
        }

        /// <summary>
        /// 32x8u -> (8x32u, 8x32u, 8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<uint> vinflate1024x32u(Vector256<byte> src)
        {
            (var lo, var hi) = vinflate512x16u(src);
            (var x0, var x1) = vinflate512x32u(lo);
            (var x2, var x3) = vinflate512x32u(hi);
            return (x0, x1, x2, x3);
        }
    }
}