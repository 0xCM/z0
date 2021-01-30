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

    partial class Bits
    {
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

        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8x64(ulong src, ref ulong dst)
        {
            unpack1x8x32((uint)src, ref dst);
            unpack1x8x32((uint)(src >> 32), ref seek8(dst, 32));
            return ref dst;
        }

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x8x64(ulong src, Span<byte> dst)
            => unpack1x8x64(src, ref first64(dst));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly SpanBlock512<byte> unpack1x8x64(ulong src, in SpanBlock512<byte> dst, int block)
        {
            unpack1x8x64(src, dst.Block(block));
            return ref dst;
        }
    }
}