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
        /// Packs the least significant bit from 8 32-bit unsigned integers to an 8-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static byte pack(in uint src, N8 count, W8 dst)
        {
            var buffer = z8;
            return pack8(src, ref buffer);
        }

        /// <summary>
        /// Packs the least significant bit from 16 32-bit unsigned integers to a 16-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ushort pack(in uint src, N16 count, W16 dst)
        {
            var buffer = z16;
            return pack16(src, ref buffer);
        }

        /// <summary>
        /// Packs the least significant bit from 32 32-bit unsigned integers to a 32-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint pack(in uint src, N32 count, W32 dst)
        {
            var buffer = z32;
            return pack32(src, ref buffer);
        }

        /// <summary>
        /// Packs the least significant bit from 64 32-bit unsigned integers to a 64-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static ulong pack(in uint src, N64 n, W64 w)
        {
            var buffer = z64;
            return pack64(src, ref buffer);
        }

        /// <summary>
        /// Packs the leading 8 source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static byte pack(Span<Bit32> src, N8 count)
        {
            var v0 = vload(n256, first(convert(src, 0, bitwidth<byte>(w8))));
            return (byte)z.vpacklsb(vcompact(v0, n128,z8));
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
            return pack(unpacked, count, w16);
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
            return pack(unpacked,count, w32);
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
            return pack(unpacked, count, w64);
        }

        [MethodImpl(Inline)]
        static Span<uint> convert(Span<Bit32> src, int offset, int count)
           => src.Slice(offset, count).Cast<Bit32,uint>();
    }
}