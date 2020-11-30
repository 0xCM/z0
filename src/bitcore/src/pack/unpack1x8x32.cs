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

    partial class Bits
    {
        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8x32(uint src, ref ulong dst)
        {
            unpack16x1((ushort)src, ref dst);
            unpack16x1((ushort)(src >> 16), ref seek8g(dst, 16));
            return ref dst;
        }

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x8x32(uint src, Span<byte> dst)
            => unpack1x8x32(src, ref first64(dst));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x8x32(uint src, in SpanBlock256<byte> dst)
            => unpack1x8x32(src, dst.Storage);
    }
}