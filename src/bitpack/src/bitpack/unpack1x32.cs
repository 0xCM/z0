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
        /// Distributes 32 packed source bits to 32 corresponding target bits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32(uint src, Span<bit> dst)
            => unpack1x8x32(src, ref u8(first(dst)));

        /// <summary>
        /// Unpacks 32 source bits over 32 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32(uint src, Span<uint> dst)
        {
            var buffer = z64;
            var w = w256;
            var n = n64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            unpack1x8((byte)src, ref tmp);
            vinflate8x256x32u(tmp).StoreTo(ref lead);
            unpack1x8((byte)(src >> 8), ref tmp);
            vinflate8x256x32u(tmp).StoreTo(ref lead, 8);
            unpack1x8((byte)(src >> 16), ref tmp);
            vinflate8x256x32u(tmp).StoreTo(ref lead, 16);
            unpack1x8((byte)(src >> 24), ref tmp);
            vinflate8x256x32u(tmp).StoreTo(ref lead, 24);
        }

        [MethodImpl(Inline), Op]
        public static Span<uint> unpack1x32(uint src)
        {
            var buffer = MemBlocks.block(n32);
            ref var tmp = ref MemBlocks.first<byte>(ref buffer);

            var storage = MemBlocks.block(n128);
            ref var target = ref MemBlocks.first<uint>(ref storage);

            unpack1x8x32(src, ref tmp);
            cpu.vinflate8x256x32u(tmp, 0, ref target);
            cpu.vinflate8x256x32u(tmp, 1, ref target);
            cpu.vinflate8x256x32u(tmp, 2, ref target);
            cpu.vinflate8x256x32u(tmp, 3, ref target);
            return MemBlocks.span<uint>(ref storage);
        }

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x32(uint src, in SpanBlock256<byte> dst)
            => unpack1x32(src, dst.Storage);

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x32(uint src, Span<byte> dst)
            => unpack1x8x32(src, ref first64u(dst));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly SpanBlock256<byte> unpack1x32(uint src, in SpanBlock256<byte> dst, int block)
        {
            unpack1x32(src, dst.CellBlock(block));
            return ref dst;
        }
    }
}