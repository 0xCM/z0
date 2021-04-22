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
    using static BitMasks;

    partial struct BitPack
    {
        /// <summary>
        /// Unpacks 8 source bits to 8 32-bit targets
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x8(byte src, ref uint dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            unpack1x8(src, ref tmp);
            cpu.vinflate8x256x32u(tmp).StoreTo(ref dst);
        }

        /// <summary>
        /// Unpacks 8 source bits over 8 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x8(byte src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            unpack1x8(src, ref tmp);
            vinflate8x256x32u(tmp).StoreTo(ref lead);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x8(byte src, Span<byte> dst)
            => seek64(first(dst), 0) = BitMasks.scatter((ulong)(byte)src, lsb<ulong>(n8,n1));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 32 corresponding target bytes
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref byte unpack1x8x32(uint src, ref byte dst)
        {
            var m = lsb<ulong>(n8,n1);
            seek64(dst, 0) = BitMasks.scatter((ulong)(byte)src, m);
            seek64(dst, 1) = BitMasks.scatter((ulong)((byte)(src >> 8)), m);
            seek64(dst, 2) = BitMasks.scatter((ulong)((byte)(src >> 16)), m);
            seek64(dst, 3) = BitMasks.scatter((ulong)((byte)(src >> 24)), m);
            return ref dst;
        }

        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8x32(uint src, ref ulong dst)
        {
            unpack1x8x16((ushort)src, ref dst);
            unpack1x16((ushort)(src >> 16), ref seek8(dst, 16));
            return ref dst;
        }

        /// <summary>
        /// Sends each source bit to to least bit of each 8-bit segment in the target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8(byte src, ref ulong dst)
        {
            dst = BitMasks.scatter(src, lsb<ulong>(n8,n1));
            return ref dst;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 8 corresponding target bytes
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">A reference to the target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref byte unpack1x8(byte src, ref byte dst)
        {
            seek64(dst, 0) = BitMasks.scatter(src, lsb<ulong>(n8,n1));
            return ref dst;
        }

        /// <summary>
        /// Distributes 8 packed source bits to 8 corresponding target bits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x8(byte src, Span<bit> dst)
            => unpack1x8(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static void unpack1x8(byte src, in SpanBlock64<byte> dst, int block)
            => unpack1x8(src, dst.CellBlock(block));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8(byte src, Span<byte> dst, uint offset)
            => ref unpack1x8(src, ref seek64(dst, offset));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x8(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var count = src.Length;
            var offset = 0u;
            for(var i=0; i<count; i++, offset +=8)
                unpack1x8(skip(src,i), dst, offset);
        }
    }
}