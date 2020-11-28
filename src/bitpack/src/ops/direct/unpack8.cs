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
        /// Distributes 8 packed source bits to 8 corresponding target bits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack8(byte src, Span<bit> dst)
            => unpack8(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 8 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">A reference to the target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack8(byte packed, ref byte unpacked)
            => seek64(unpacked, 0) = scatter((ulong)(byte)packed, lsb<ulong>(n8,n1));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly SpanBlock64<byte> unpack8(byte src, in SpanBlock64<byte> dst, int block = 0)
        {
            unpack(src, dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Unpacks 8 source bits over 8 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack8(byte src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            unpack8(src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
        }
    }
}