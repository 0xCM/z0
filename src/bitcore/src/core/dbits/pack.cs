//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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
        /// Packs 5 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline), Pack]
        public static uint pack(Bit32 b0, Bit32 b1, Bit32 b2, Bit32 b3, Bit32 b4)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            dst |= ((uint)b2 << 2);
            dst |= ((uint)b3 << 3);
            dst |= ((uint)b4 << 4);
            return dst;
        }

        /// <summary>
        /// Packs 8 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline), Pack]
        public static uint pack(Bit32 b0, Bit32 b1, Bit32 b2, Bit32 b3, Bit32 b4, Bit32 b5, Bit32 b6, Bit32 b7)
        {
            var dst = pack(b0, b1, b2, b3);
            dst |= (pack(b4, b5, b6, b7) << 4);
            return dst;
        }
    }
}