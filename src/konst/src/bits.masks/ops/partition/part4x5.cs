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

    using L = BitMasks.Literals;

    partial class BitMasks
    {
        /// <summary>
        /// Partitions the first 20 bits of a 32-bit source value into 4 8-bit segments of width 5
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The partition target</param>
        [MethodImpl(Inline), Op]
        public static ref byte Part4x5(uint src, ref byte dst)
        {
            seek32(dst, 0) = scatter(src, L.Lsb32x8x5);
            return ref dst;
        }
    }
}