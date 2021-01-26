//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class gbits
    {
        /// <summary>
        /// Calculates the number of bits set up to and including the current bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline), Rank, Closures(Closure)]
        public static uint rank<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.rank(uint8(src), pos);
            else if(typeof(T) == typeof(ushort))
                return Bits.rank(uint16(src), pos);
            else if(typeof(T) == typeof(uint))
                return Bits.rank(uint32(src), pos);
            else if(typeof(T) == typeof(ulong))
                return Bits.rank(uint64(src), pos);
            else
                throw no<T>();
        }
    }
}