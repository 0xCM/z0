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
        public static void unpack32x1(uint src, Span<byte> dst)
            => unpack32x1(src, ref first64(dst));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack32x1(uint src, in SpanBlock256<byte> dst)
            => unpack32x1(src, dst.Data);


        [MethodImpl(Inline), Unpack]
        static void unpack32x1(uint src, ref ulong dst)
        {
            unpack16x1((ushort)src, ref dst);
            unpack16x1((ushort)(src >> 16), ref seek8g(dst, 16));
        }
    }
}