//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Bits
    {
        /// <summary>
        /// Packs 2 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline), Pack]
        public static uint pack(bit b0, bit b1)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            return dst;
        }

        /// <summary>
        /// Packs 3 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline), Pack]
        public static uint pack(bit b0, bit b1, bit b2)
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
        public static uint pack(bit b0, bit b1, bit b2, bit b3)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            dst |= ((uint)b2 << 2);
            dst |= ((uint)b3 << 3);
            return dst;
        }


    }
}