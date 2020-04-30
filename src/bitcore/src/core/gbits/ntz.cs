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
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Ntz, Closures(UnsignedInts)]
        public static T ntz<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.ntz(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.ntz(uint16(src)));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.ntz(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(Bits.ntz(uint64(src)));
            else 
                throw Unsupported.define<T>();
        }
    }
}