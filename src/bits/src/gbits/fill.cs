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

    partial class gbits
    {
        /// <summary>
        /// Enables a contiguous sequence of source bits starting at a specified index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin</param>
        /// <param name="count">The number of bits to fill</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T fill<T>(T src, byte index, byte count)
            where T : unmanaged
        {
            if(size<T>() == 1)
                return generic<T>(Bits.fill(uint8(src), index, count));
            else if (size<T>() == 2)
                return generic<T>(Bits.fill(uint16(src), index, count));
            else if (size<T>() == 4)
                return generic<T>(Bits.fill(uint32(src), index, count));
            else
                return generic<T>(Bits.fill(uint64(src), index, count));
        }
    }
}