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
        /// Packs 2 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline), Pack]
        public static uint pack(Bit32 b0, Bit32 b1)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            return dst;
        }

        /// <summary>
        /// Packs 3 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline), Pack]
        public static uint pack(Bit32 b0, Bit32 b1, Bit32 b2)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            dst |= ((uint)b2 << 2);
            return dst;
        }

        /// <summary>
        /// Packs 4 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline), Pack]
        public static uint pack(Bit32 b0, Bit32 b1, Bit32 b2, Bit32 b3)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            dst |= ((uint)b2 << 2);
            dst |= ((uint)b3 << 3);
            return dst;
        }

        /// <summary>
        /// Packs the least significant bit from 64 32-bit unsigned integers to a 64-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static ulong pack64x32x1(in uint src, N64 n, W64 w)
        {
            var buffer = z64;
            return pack64x32x1(src, ref buffer);
        }
    }
}