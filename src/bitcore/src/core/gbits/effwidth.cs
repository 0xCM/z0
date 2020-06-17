//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class gbits
    {                
        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), EffWidth, Closures(UnsignedInts)]
        public static int effwidth<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.effwidth(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.effwidth(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.effwidth(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.effwidth(uint64(src));
            else            
                throw Unsupported.define<T>();
        }           
    }
}