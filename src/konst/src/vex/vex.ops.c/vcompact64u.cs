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
        /// 8x16u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact64u(Vector128<ushort> src, W64 wDst)
            => gcpu.vcell64(vcompact8u(src, default, w128), 0);

        /// <summary>
        /// 8x32u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact64u(Vector256<uint> src)
            => vcompact64u(vcompact16u(src, w128), w64);
    }
}