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
            var v0 = vload(n256, first(convert(src, 0, bitwidth<byte>(w8))));
            return (byte)packlsb(vcompact(v0,n128,z8), n8);
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
    }
}