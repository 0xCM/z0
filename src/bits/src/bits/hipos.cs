//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class Bits
    {
        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 7
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), HiPos]
        public static byte hipos(byte src)
            => (byte)(width<byte>(w8) - 1 - nlz(src));

        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 15
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), HiPos]
        public static byte hipos(ushort src)
            => (byte)(width<ushort>(w8) - 1 - nlz(src));

        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 31
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), HiPos]
        public static byte hipos(uint src)
            => (byte)(width<uint>(w8) - 1 - nlz(src));

        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 63
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), HiPos]
        public static byte hipos(ulong src)
            => (byte)(width<ulong>(w8) - 1 - nlz(src));
    }
}