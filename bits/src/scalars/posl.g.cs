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
        /// Returns the position of the least on bit in the source
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static uint posl<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.posl(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.posl(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.posl(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.posl(uint64(src));
            else            
                throw unsupported<T>();
        }           
    }
}