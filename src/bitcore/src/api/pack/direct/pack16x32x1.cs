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

    partial struct BitPack
    {
        /// <summary>
        /// Packs the least significant bit from 16 32-bit unsigned integers to a 16-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref ushort pack16x32x1(in uint src, ref ushort dst)
        {
            var v0 = cpu.vload(w256, skip(src, 0*8));
            var v1 = cpu.vload(w256, skip(src, 1*8));
            dst = gcpu.vpacklsb(cpu.vpack128x8u(v0, v1, w128));
            return ref dst;
        }

        /// <summary>
        /// Packs the least significant bit from 16 32-bit unsigned integers to a 16-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ushort pack16x32x1(in uint src)
        {
            var buffer = z16;
            return pack16x32x1(src, ref buffer);
        }

        /// <summary>
        /// Packs the least significant bit from <see cref='n16'/>  source values of bit-width <see cref='w32'/> to a <see cref='w16'/> bit target
        /// </summary>
        /// <param name="src">The intput sequence</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ushort pack16x32x1(NatSpan<N16,uint> src, ref ushort dst)
        {
            dst = pack16x32x1(src.First);
            return ref dst;
        }

        /// <summary>
        /// Packs the least significant bit from <see cref='n16'/>  source values of bit-width <see cref='w32'/> to a <see cref='w16'/> bit target
        /// </summary>
        /// <param name="src">The intput sequence</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ushort pack16x32x1(ReadOnlySpan<uint> src, ref ushort dst, uint offset)
        {
            dst = pack16x32x1(skip(src, offset));
            return ref dst;
        }

    }
}