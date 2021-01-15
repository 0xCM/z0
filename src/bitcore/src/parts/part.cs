//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;
    using static BitMasks.Literals;


    partial struct BitParts
    {
        /// <summary>
        /// Partitions the first 63 bits of a 64 bit source value into 21 8-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline), Op]
        public static ref byte part(ulong src, N63 count, N3 wSrc, N8 wDst, ref byte dst)
        {
            var x = BitMasks.lo(n63) & src;
            seek64(dst, 0) = Bits.scatter(x, Lsb64x8x3);
            seek64(dst, 1) = Bits.scatter(x >> 24, Lsb64x8x3);
            seek64(dst, 2) = Bits.scatter(x >> 48, Lsb64x8x3);
            return ref dst;
        }

        /// <summary>
        /// Partitions a 16-bit source value into 2 segments of width 8 and is equivalent to <see cref='part8x2(byte, ref byte)'/>
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The partition target</param>
        [MethodImpl(Inline), Op]
        public static ref byte part(ushort src, N2 n2, N8 n8, ref byte dst)
            => ref part8x2(src,ref dst);
    }
}