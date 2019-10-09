//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;



    partial class gbits
    {
        /// <summary>
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the 
        /// lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static T blsmsk<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.blsmsk(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.blsmsk(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.blsmsk(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.blsmsk(uint64(src)));
            else            
                throw unsupported<T>();
        }           


    }
}