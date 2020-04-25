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
        /// Computes the minimal number of bits required to represent the source value, the effective width
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int ewidth<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.ewidth(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.ewidth(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.ewidth(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.ewidth(uint64(src));
            else            
                throw Unsupported.define<T>();
        }           
    }
}