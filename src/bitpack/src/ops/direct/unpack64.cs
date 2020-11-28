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
        /// Distributes 64 packed source bits to 64 corresponding target bits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack64(ulong src, Span<bit> dst)
            => unpack64(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 64 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack64(ulong packed, ref byte unpacked)
        {
            unpack32((uint)packed, ref unpacked);
            unpack32((uint)(packed >> 32), ref seek(unpacked, 32));
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly SpanBlock512<byte> unpack64(ulong src, in SpanBlock512<byte> dst, int block = 0)
        {
            unpack(src, dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Unpacks 64 source bits over 64 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack64(ulong src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            unpack8((byte)src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack8((byte)(src >> 8), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);
            unpack8((byte)(src >> 16), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 16);
            unpack8((byte)(src >> 24), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 24);
            unpack8((byte)(src >> 32), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 32);
            unpack8((byte)(src >> 40), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 40);
            unpack8((byte)(src >> 48), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 48);
            unpack8((byte)(src >> 56), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 56);
        }
    }
}