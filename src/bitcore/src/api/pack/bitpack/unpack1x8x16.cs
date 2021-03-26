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
    using static BitMasks.Literals;

    partial struct BitPack
    {
        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8x16(ushort src, ref ulong dst)
        {
            const ulong M = (ulong)Lsb64x8x1;
            seek(dst, 0) = scatter(src, M);
            seek(dst, 1) = scatter((ushort)(src >> 8), M);
            return ref dst;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly SpanBlock128<byte> unpack1x8x16(ushort src, in SpanBlock128<byte> dst, int block)
        {
            unpack(src, dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 16 corresponding target bytes
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref byte unpack1x8x16(ushort src, ref byte dst)
        {
            var m = lsb<ulong>(n8, n1);
            seek64(dst, 0) = scatter((ulong)(byte)src, m);
            seek64(dst, 1) = scatter((ulong)((byte)(src >> 8)), m);
            return ref dst;
        }

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x8x16(ushort src, Span<byte> dst)
            => unpack1x8x16(src, ref first64u(dst));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x8x16(ushort src, in SpanBlock128<byte> dst)
            => unpack1x8x16(src, dst.Storage);
    }
}