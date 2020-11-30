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
    using static BitMasks;

    partial class BitPack
    {
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

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 64 corresponding target bytes
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref byte unpack1x8x64(ulong src, ref byte dst)
        {
            unpack1x8x32((uint)src, ref dst);
            unpack1x8x32((uint)(src >> 32), ref seek(dst, 32));
            return ref dst;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x8x32(uint src, Span<byte> dst)
        {
            var mask = lsb<ulong>(n8,n1);
            ref var lead = ref first(dst);
            seek64(lead, 0) = scatter((ulong)(byte)src, mask);
            seek64(lead, 1) = scatter((ulong)((byte)(src >> 8)), mask);
            seek64(lead, 2) = scatter((ulong)((byte)(src >> 16)), mask);
            seek64(lead, 3) = scatter((ulong)((byte)(src >> 24)), mask);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x8x64(ulong src, Span<byte> dst)
        {
            unpack1x8x32((uint)src, slice(dst, 0, 32));
            unpack1x8x32((uint)(src >> 32), slice(dst, 32, 32));
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly SpanBlock64<byte> unpack1x8x8(byte src, in SpanBlock64<byte> dst, int block = 0)
        {
            unpack(src, dst.Block(block));
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
        public static ref readonly SpanBlock128<byte> unpack1x8x16(ushort src, in SpanBlock128<byte> dst, int block = 0)
        {
            unpack(src, dst.Block(block));
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
        public static ref readonly SpanBlock256<byte> unpack1x8x32(uint src, in SpanBlock256<byte> dst, int block = 0)
        {
            unpack1x8x32(src, dst.Block(block));
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
        public static ref readonly SpanBlock512<byte> unpack1x8x64(ulong src, in SpanBlock512<byte> dst, int block = 0)
        {
            unpack1x8x64(src, dst.Block(block));
            return ref dst;
        }
    }
}