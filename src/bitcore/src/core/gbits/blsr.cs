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
        /// Disables the least set bit in the source and is logically equivalent to the composite operation (src - 1) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T blsr<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.blsr(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.blsr(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.blsr(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.blsr(uint64(src)));
            else            
                throw Unsupported.define<T>();
        }           
    }
}