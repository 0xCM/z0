//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Bits
    {
        /// <summary>
        /// Packs the least significant bit from 32 32-bit unsigned integers to a 32-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref uint pack32x32x1(in uint src, ref uint dst)
        {
            var v0 = cpu.vload(w256, skip(src,0*8));
            var v1 = cpu.vload(w256, skip(src,1*8));
            var x = vcompact16u(v0, v1, w256);

            v0 = cpu.vload(w256, skip(src,2*8));
            v1 = cpu.vload(w256, skip(src,3*8));
            var y = vcompact16u(v0,v1, w256);

            dst = gcpu.vpacklsb(vcompact8u(x, y, w256));
            return ref dst;
        }
    }
}