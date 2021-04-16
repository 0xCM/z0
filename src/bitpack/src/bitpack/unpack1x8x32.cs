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
        /// Distributes each packed source bit to the least significant bit of 32 corresponding target bytes
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref byte unpack1x8x32(uint src, ref byte dst)
        {
            var m = lsb<ulong>(n8,n1);
            seek64(dst, 0) = scatter((ulong)(byte)src, m);
            seek64(dst, 1) = scatter((ulong)((byte)(src >> 8)), m);
            seek64(dst, 2) = scatter((ulong)((byte)(src >> 16)), m);
            seek64(dst, 3) = scatter((ulong)((byte)(src >> 24)), m);
            return ref dst;
        }

        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8x32(uint src, ref ulong dst)
        {
            unpack1x8x16((ushort)src, ref dst);
            unpack1x8x16((ushort)(src >> 16), ref seek8(dst, 16));
            return ref dst;
        }

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x8x32(uint src, Span<byte> dst)
            => unpack1x8x32(src, ref first64u(dst));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x8x32(uint src, in SpanBlock256<byte> dst)
            => unpack1x8x32(src, dst.Storage);

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly SpanBlock256<byte> unpack1x8x32(uint src, in SpanBlock256<byte> dst, int block)
        {
            unpack1x8x32(src, dst.CellBlock(block));
            return ref dst;
        }
    }
}