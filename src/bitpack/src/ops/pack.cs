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
        /// Packs the leading 8 source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static byte pack(Span<Bit32> src, N8 count)
        {
            var v0 = cpu.vload(n256, first(convert(src, 0, bitwidth<byte>(w8))));
            return (byte)gcpu.vpacklsb(vcompact8u(v0, w128));
        }

        /// <summary>
        /// Packs the 16 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static ushort pack(Span<Bit32> src, N16 count)
        {
            ref readonly var unpacked = ref first(convert(src, 0, bitwidth<ushort>(w8)));
            var buffer = z16;
            return Bits.pack16x32x1(unpacked, ref buffer);
        }

        /// <summary>
        /// Packs the 32 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static uint pack(Span<Bit32> src, N32 count)
        {
            ref readonly var unpacked = ref first(convert(src, 0, bitwidth<uint>(w8)));
            var buffer = z32;
            return Bits.pack32x32x1(unpacked, ref buffer);
        }

        /// <summary>
        /// Packs the 64 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static ulong pack(Span<Bit32> src, N64 count)
        {
            ref readonly var unpacked = ref first(convert(src, 0, bitwidth<ulong>(w8)));
            var buffer = z64;
            return Bits.pack64x32x1(unpacked, ref buffer);
        }

        [MethodImpl(Inline)]
        static Span<uint> convert(Span<Bit32> src, int offset, int count)
           => src.Slice(offset, count).Recover<Bit32,uint>();
    }
}