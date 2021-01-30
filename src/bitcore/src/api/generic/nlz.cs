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
        /// Counts the number of leading zero bits the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Nlz, Closures(Closure)]
        public static int nlz<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return Bits.nlz(uint8(src));
            else if(typeof(T) == typeof(ushort))
                 return Bits.nlz(uint16(src));
            else if(typeof(T) == typeof(uint))
                 return Bits.nlz(uint32(src));
            else if(typeof(T) == typeof(ulong))
                 return Bits.nlz(uint64(src));
            else
                throw no<T>();
        }
    }
}