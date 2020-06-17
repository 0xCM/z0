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
        /// Reverses the bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <remarks>BAD</remarks>
        [MethodImpl(Inline)]
        public static T reverse<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.reverse(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.reverse(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.reverse(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.reverse(uint64(src)));
            else            
                throw Unsupported.define<T>();
        }
    }
}