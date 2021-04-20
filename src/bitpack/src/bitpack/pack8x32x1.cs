//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static cpu;

    partial struct BitPack
    {
        /// <summary>
        /// Packs the least significant bit from 8 32-bit unsigned integers to an 8-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref byte pack8x32x1(in uint src, ref byte dst)
        {
            var v0 = vload(w256, src);
            dst = (byte)cpu.vpacklsb(vpack128x8u(v0));
            return ref dst;
        }

        /// <summary>
        /// Packs the leading 8 source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static byte pack8x32x1(Span<uint> src)
        {
            var v0 = vload(w256, first(src));
            return (byte)cpu.vpacklsb(vpack128x8u(v0));
        }

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
        /// Packs the least significant bit from <see cref='n8'/> <see cref='w32'/> <see cref='uint'/> source values to a <see cref='w8'/> bit <see cref='byte'/> target
        /// </summary>
        /// <param name="src">The intput sequence</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref byte pack8x32x1(in NatSpan<N8,uint> src, ref byte dst)
        {
            dst = pack8x32x1(src.First);
            return ref dst;
        }
    }
}