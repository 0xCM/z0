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
    using static BitMasks;

    partial struct BitPack
    {
        /// <summary>
        /// Distributes 8 packed source bits to 8 corresponding target bits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(byte src, Span<bit> dst)
            => BitPack.unpack1x8x8(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes 16 packed source bits to 16 corresponding target bits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ushort src, Span<bit> dst)
            => BitPack.unpack1x8x16(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes 32 packed source bits to 32 corresponding target bits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(uint src, Span<bit> dst)
            => BitPack.unpack1x8x32(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes 64 packed source bits to 64 corresponding target bits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ulong src, Span<bit> dst)
            => BitPack.unpack1x8x64(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(byte src, Span<byte> dst)
            => seek64(first(dst), 0) = Bits.scatter((ulong)(byte)src, lsb<ulong>(n8,n1));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ushort src, Span<byte> dst)
        {
            var mask = lsb<ulong>(n8, n1);
            ref var lead = ref first(dst);
            seek64(lead, 0) = Bits.scatter((ulong)(byte)src, mask);
            seek64(lead, 1) = Bits.scatter((ulong)((byte)(src >> 8)), mask);
        }

        /// <summary>
        /// Unpacks a specified number source bytes to a corresponding count of 32-bit target values
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bytes to pack</param>
        /// <param name="dst">The target reference, of size at least 256*count bits</param>
        [MethodImpl(Inline), Op]
        public static void unpack(in byte src, int count, ref uint dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            for(var i=0; i<count; i++)
            {
                BitPack.unpack1x8x8(skip(src, i), ref tmp);
                cpu.vinflate8x256x32u(tmp).StoreTo(ref seek(dst, i*8));
            }
        }

        /// <summary>
        /// Unpacks a specified number source bytes to a corresponding count of 256-bit blocks comprising 32-bit target values
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="blocks">The number of bytes to pack</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(in byte src, int blocks, in SpanBlock256<uint> dst)
            => unpack(src, blocks, ref dst.First);
    }
}