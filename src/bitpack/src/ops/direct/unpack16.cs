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
        /// Distributes 16 packed source bits to 16 corresponding target bits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack16(ushort src, Span<bit> dst)
            => unpack16(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 16 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack16(ushort packed, ref byte unpacked)
        {
            var m = lsb<ulong>(n8, n1);
            seek64(unpacked, 0) = scatter((ulong)(byte)packed, m);
            seek64(unpacked, 1) = scatter((ulong)((byte)(packed >> 8)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly SpanBlock128<byte> unpack16(ushort src, in SpanBlock128<byte> dst, int block = 0)
        {
            unpack(src, dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Unpacks 16 source bits over 16 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack16(ushort src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);

            unpack8((byte)src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack8((byte)(src >> 8), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);
        }
    }
}