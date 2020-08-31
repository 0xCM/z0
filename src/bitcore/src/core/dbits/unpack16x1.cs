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
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack16x1(ushort src, Span<byte> dst)
            => unpack16x1(src, ref first64(dst));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack16x1(ushort src, in SpanBlock128<byte> dst)
            => unpack16x1(src, dst.Data);

        [MethodImpl(Inline), Unpack]
        static void unpack16x1(ushort src, ref ulong dst)
        {
            const ulong M = (ulong)BitMasks.Lsb64x8x1;

            seek(dst, 0) = scatter(src, M);
            seek(dst, 1) = scatter(uint16(src >> 8), M);
        }
    }
}