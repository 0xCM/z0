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

    partial class BitPack
    {
        /// <summary>
        /// Packs the least significant bit from 16 32-bit unsigned integers to a 16-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref ushort pack16(in uint src, ref ushort dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            dst = vpacklsb(vcompact(v0, v1, n128, z8));
            return ref dst;
        }
    }
}