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
        /// Packs the least significant bit from 8 32-bit unsigned integers to an 8-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static byte pack8x32x1(in uint src)
        {
            var buffer = z8;
            return pack8x32x1(src, ref buffer);
        }

        /// <summary>
        /// Packs the least significant bit from 8 32-bit unsigned integers to an 8-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref byte pack8x32x1(in uint src, ref byte dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            dst = (byte)vpacklsb(vcompact(v0, n128, z8));
            return ref dst;
        }
    }
}