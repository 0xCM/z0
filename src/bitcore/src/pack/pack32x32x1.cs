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
    using static BitMasks.Literals;
    using static BitMasks;

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
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            var x = vcompact16u(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,2*8));
            v1 = vload(n256, skip(src,3*8));
            var y = vcompact16u(v0,v1,n256,z16);

            dst = vpacklsb(vcompact8u(x,y,n256,z8));
            return ref dst;
        }
    }
}