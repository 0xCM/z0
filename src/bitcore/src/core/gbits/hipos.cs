//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class gbits
    {
        /// <summary>
        /// Computes the position of the highest enabled source bit, a number in the inclusive range [0 , bitsize[T] - 1]
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), HiPos, Closures(UnsignedInts)]
        public static int hipos<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.hipos(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.hipos(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.hipos(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.hipos(uint64(src));
            else            
                throw Unsupported.define<T>();
        }           
    }
}