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

    using L = BitMasks.Literals;

    partial class Bits
    {
        /// <summary>
        /// Sends each source bit to to last bit of each 8-bit segment in the target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack8x1(byte src, ref ulong dst)
            => dst = scatter(src, (ulong)L.Lsb64x8x1);

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack8x1(byte src, Span<byte> dst)
            => unpack8x1(src, ref first64(dst));
    }
}