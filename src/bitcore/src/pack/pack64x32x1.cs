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
        /// Packs the least significant bit from 64 32-bit unsigned integers to a 64-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref ulong pack64x32x1(in uint src, ref ulong dst)
        {
            var v0 = vload(n256, skip(src, 0*8));
            var v1 = vload(n256, skip(src, 1*8));
            var x = vcompact16u(v0, v1, n256, z16);

            v0 = vload(n256, skip(src,2*8));
            v1 = vload(n256, skip(src,3*8));
            var y = vcompact16u(v0, v1, n256, z16);

            var packed = (ulong)vpacklsb(vcompact8u(x,y,n256,z8));

            v0 = vload(n256, skip(src,4*8));
            v1 = vload(n256, skip(src,5*8));
            x = vcompact16u(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,6*8));
            v1 = vload(n256, skip(src,7*8));
            y = vcompact16u(v0,v1,n256,z16);

            packed |= (ulong)vpacklsb(vcompact8u(x,y,n256,z8)) << 32;

            dst = packed;
            return ref dst;
        }
    }
}