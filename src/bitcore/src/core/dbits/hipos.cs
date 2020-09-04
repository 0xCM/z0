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
        /// Computes the position of the highest enabled source bit, a number between 0 and 7
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), HiPos]
        public static byte hipos(byte src)
            => (byte)(bitsize<byte>() - 1 - nlz(src));

        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 15
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), HiPos]
        public static byte hipos(ushort src)
            => (byte)(bitsize<ushort>() - 1 - nlz(src));

        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 31
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), HiPos]
        public static byte hipos(uint src)
            => (byte)(bitsize<uint>() - 1 - nlz(src));

        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 63
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), HiPos]
        public static byte hipos(ulong src)
            => (byte)(bitsize<ulong>() - 1 - nlz(src));
    }
}