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
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static void unpack1x8x8(byte src, in SpanBlock64<byte> dst, int block)
            => unpack(src, dst.Block(block));

        /// <summary>
        /// Sends each source bit to to least bit of each 8-bit segment in the target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8x8(byte src, ref ulong dst)
        {
            dst = scatter(src, lsb<ulong>(n8,n1));
            return ref dst;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 8 corresponding target bytes
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">A reference to the target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref byte unpack1x8x8(byte src, ref byte dst)
        {
            seek64(dst, 0) = scatter(src, lsb<ulong>(n8,n1));
            return ref dst;
        }

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8x8(byte src, Span<byte> dst)
            => ref unpack1x8x8(src, ref first64u(dst));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8x8(byte src, Span<byte> dst, uint offset)
            => ref unpack1x8x8(src, ref seek64(dst, offset));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x8x8(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var count = src.Length;
            var offset = 0u;
            for(var i=0; i<count; i++, offset +=8)
                unpack1x8x8(skip(src,i), dst, offset);
        }
    }
}