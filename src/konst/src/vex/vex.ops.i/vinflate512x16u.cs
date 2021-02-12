//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Part;
    using static memory;

    partial struct cpu
    {
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate512x16u(in byte src)
        {
           var lo = vinflate256x16u(vload(w128, src));
           var hi = vinflate256x16u(vload(w128, add(src, 16)));
           return gcpu.vconcat(lo,hi);
        }

        /// <summary>
        /// 32x8u -> (16x16u, 16x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate512x16u(Vector256<byte> src)
             => (vmaplo256x16u(src), vmaphi256x16u(src));
    }
}