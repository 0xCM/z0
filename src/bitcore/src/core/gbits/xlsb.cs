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

    partial class gbits
    {
        /// <summary>
        /// Extracts the least set source bit and is logically equivalent to the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T xlsb<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(BitMasks.xlsb(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(BitMasks.xlsb(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(BitMasks.xlsb(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(BitMasks.xlsb(uint64(src)));
            else
                throw no<T>();
        }
    }
}